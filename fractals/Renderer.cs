using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace fractals
{
    public partial class Form1 : Form
    {
        const double XMINLIMIT = -2.5;
        const double XMAXLIMIT = 1.5;
        const double YMINLIMIT = -1.5;
        const double YMAXLIMIT = 1.5;

        int imageWidth, imageHeight;

        public void Render()
        {
            frameControls.Enabled = false;

            double xMin, xMax, yMin, yMax;
            int iterations;

            try
            {
                xMin = double.Parse(txtXMin.Text);
                xMax = double.Parse(txtXMax.Text);
                yMin = double.Parse(txtYMin.Text);
                yMax = double.Parse(txtYMax.Text);
                imageWidth = int.Parse(txtImageWidth.Text);
                imageHeight = int.Parse(txtImageHeight.Text);
                iterations = int.Parse(txtRounds.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("C'è stato un problema con i parametri; ricontrollali e riprova.\n\nErrore:" + e.ToString(), "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HDRImage image = new HDRImage(imageWidth, imageHeight);

            double xInc = (xMax - xMin) / imageWidth;
            double yInc = (yMax - yMin) / imageHeight;
            int colsDone = 0;

            double x = xMin;        // parte Reale

            for (int screenX = 0; screenX < imageWidth; screenX++)
            {
                double y = yMin;    // parte Immaginaria

                for (int screenY = 0; screenY < imageHeight; screenY++)
                {
                    double x1 = 0, y1 = 0;

                    int iter = 0;
                    while (iter < iterations && Math.Sqrt((x1 * x1) + (y1 * y1)) < 2)
                    {
                        iter++;
                        double xx = (x1 * x1) - (y1 * y1) + x;
                        y1 = 2 * x1 * y1 + y;
                        x1 = xx;
                    }

                    image.SetPixel(screenX, screenY, iter);
                    y += yInc;
                }

                colsDone++;

                double percent = ((double)colsDone / (double)imageWidth) * 100.0;
                progressBar.Value = (int)percent;
                x += xInc;
            }

            if (pbOutput.Image != null) pbOutput.Image.Dispose();
            pbOutput.Image = image.ToBitmap();
            pbOutput.Width = imageWidth;
            pbOutput.Height = imageHeight;

            frameControls.Enabled = true;
            btnSave.Enabled = true;
            btnZoom.Enabled = false;
            progressBar.Value = 0;
        }
    }
}