using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace fractals
{
    public partial class Form1 : Form
    {
        Rectangle zoomRect;
        bool zooming;
        int zoomOriginX, zoomOriginY;
        /*int oldX;
        int oldY;           //variabili per movimento immagine
        bool isMoving;*/   

        // Inizializzazione

        public Form1()
        {
            InitializeComponent();
            btnZoomReset_Click(null, null);   // Reset zoom
        }

        // Event handlers

        private void btnRender_Click(object sender, EventArgs e)
        {
            Render();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Immagine Bitmap|*.bmp|Immagine JPG|*.jpg";
            dialog.Title = "Salva Immagine";
            dialog.ShowDialog();

            if (dialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile();

                switch (dialog.FilterIndex)
                {
                    case 1: // Note: 1-based
                        pbOutput.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 2:
                        pbOutput.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg); 
                        break;
                }

                fs.Close();
            }
        }

        // funzioni per zoom

        private void btnZoomReset_Click(object sender, EventArgs e)
        {
            txtXMin.Text = XMINLIMIT.ToString();
            txtYMin.Text = YMINLIMIT.ToString();
            txtXMax.Text = XMAXLIMIT.ToString();
            txtYMax.Text = YMAXLIMIT.ToString();

            Render();
        }

        private void pbOutput_MouseDown(object sender, MouseEventArgs e)
        {
            if (pbOutput.Image != null)
            {
                pbOutput.Refresh();

                zoomOriginX = e.X;
                zoomRect.X = e.X;
                zoomRect.Height = 0;

                zoomOriginY = e.Y;
                zoomRect.Y = e.Y;
                zoomRect.Width = 0;

                zooming = true;
            }
            /*if (pbOutput.Image != null && e.Button == MouseButtons.Right) //movimento immagine
            {
                isMoving = true;
                oldX = e.X;
                oldY = e.Y;
            }*/
        }

        private void SetZoomingRectangle (int moveToX, int moveToY)
        {
            // Account for user cropping outside of image dimensions
            moveToX = Math.Max(0, Math.Min(moveToX, pbOutput.Image.Width));
            moveToY = Math.Max(0, Math.Min(moveToY, pbOutput.Image.Height));

            if (moveToX == 0) moveToX = 1;
            if (moveToX >= pbOutput.Image.Width)
                moveToX -= 1;
            if (moveToY == 0) moveToY = 1;
            if (moveToY >= pbOutput.Image.Height)
                moveToY -= 1;

            if (moveToX >= zoomRect.X)    // moving right
                zoomRect.Width = moveToX - zoomOriginX;
            else                          // moving left
            {
                zoomRect.X = moveToX;
                zoomRect.Width = zoomOriginX - moveToX;
            }

            if (moveToY >= zoomRect.Y)    // moving down
                zoomRect.Height = moveToY - zoomOriginY;
            else                          // moving up
            {
                zoomRect.Y = moveToY;
                zoomRect.Height = zoomOriginY - moveToY;
            }

            if (chkKeepAspectRatio.Checked)
            {
                double ratio = (double)imageWidth / (double)imageHeight;

                if (zoomRect.Height > zoomRect.Width) 
                    zoomRect.Width = (int)(ratio * zoomRect.Height);
                else
                    zoomRect.Height = (int)(zoomRect.Width/ratio);
            }
        }

        private void pbOutput_MouseMove(object sender, MouseEventArgs e)
        {
            if (zooming)
            {
                pbOutput.Refresh();

                SetZoomingRectangle(e.X, e.Y);
                pbOutput.Invalidate();
            }
            /*if (isMoving) //movimento immagine
            {
                {
                    pbOutput.Location = new Point(pbOutput.Location.X + (e.X - oldX), pbOutput.Location.Y + (e.Y - oldY));
                }
            }*/
        }

        private void pbOutput_MouseUp(object sender, MouseEventArgs e)
        {
            zooming = false;
            //isMoving = false;
            btnZoom.Enabled = true;
        }

        private void pbOutput_Paint(object sender, PaintEventArgs e)
        {
            if (pbOutput.Image != null && zoomRect.Width > 0 && zoomRect.Height > 0)
            {
                Pen pen = new Pen(Color.WhiteSmoke, 2);
                SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(50, 240, 240, 240));
                Graphics g = e.Graphics;
                g.DrawRectangle(pen, zoomRect);
                g.FillRectangle(semiTransBrush, zoomRect);
            }
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (pbOutput.Image != null && zoomRect.Width > 0 && zoomRect.Height > 0)
            {
                // calcola nuovi limiti
                float frac = (float)zoomRect.X / (float)imageWidth;
                float newXMin = float.Parse(txtXMin.Text) + (frac * (float.Parse(txtXMax.Text) - float.Parse(txtXMin.Text)));
                frac = (float)(zoomRect.X + zoomRect.Width) / (float)imageWidth;
                float newXMax = float.Parse(txtXMin.Text) + (frac * (float.Parse(txtXMax.Text) - float.Parse(txtXMin.Text)));

                frac = (float)zoomRect.Y / (float)imageHeight;
                float newYMin = float.Parse(txtYMin.Text) + (frac * (float.Parse(txtYMax.Text) - float.Parse(txtYMin.Text)));
                frac = (float)(zoomRect.Y + zoomRect.Height) / (float)imageHeight;
                float newYMax = float.Parse(txtYMin.Text) + (frac * (float.Parse(txtYMax.Text) - float.Parse(txtYMin.Text)));

                txtXMin.Text = newXMin.ToString();
                txtXMax.Text = newXMax.ToString();

                txtYMin.Text = newYMin.ToString();
                txtYMax.Text = newYMax.ToString();

                // Reset rettangolo di zoom
                zoomRect.X = zoomRect.Y = zoomRect.Width = zoomRect.Height = 0;
            }

            Render();
        }
    }
}
