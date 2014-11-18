namespace fractals
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.frameControls = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnZoomReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRender = new System.Windows.Forms.Button();
            this.txtRounds = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImageWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImageHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtXMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkKeepAspectRatio = new System.Windows.Forms.CheckBox();
            this.frameOutput = new System.Windows.Forms.GroupBox();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.frameControls.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.frameOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // frameControls
            // 
            this.frameControls.Controls.Add(this.groupBox4);
            this.frameControls.Controls.Add(this.groupBox3);
            this.frameControls.Controls.Add(this.groupBox2);
            this.frameControls.Controls.Add(this.groupBox1);
            this.frameControls.Controls.Add(this.chkKeepAspectRatio);
            this.frameControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.frameControls.Location = new System.Drawing.Point(0, 625);
            this.frameControls.Name = "frameControls";
            this.frameControls.Size = new System.Drawing.Size(1030, 93);
            this.frameControls.TabIndex = 1;
            this.frameControls.TabStop = false;
            this.frameControls.Text = "Impostazioni";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnZoomReset);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnZoom);
            this.groupBox4.Location = new System.Drawing.Point(737, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 71);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controlli";
            // 
            // btnZoomReset
            // 
            this.btnZoomReset.Location = new System.Drawing.Point(135, 22);
            this.btnZoomReset.Name = "btnZoomReset";
            this.btnZoomReset.Size = new System.Drawing.Size(43, 34);
            this.btnZoomReset.TabIndex = 20;
            this.btnZoomReset.Text = "Reset";
            this.btnZoomReset.UseVisualStyleBackColor = true;
            this.btnZoomReset.Click += new System.EventHandler(this.btnZoomReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(22, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 21);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Salva";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Enabled = false;
            this.btnZoom.Location = new System.Drawing.Point(22, 17);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(89, 21);
            this.btnZoom.TabIndex = 18;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRender);
            this.groupBox3.Controls.Add(this.txtRounds);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(517, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 71);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precisione";
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(56, 18);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(89, 21);
            this.btnRender.TabIndex = 16;
            this.btnRender.Text = "Ricalcola";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // txtRounds
            // 
            this.txtRounds.Location = new System.Drawing.Point(105, 43);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(49, 20);
            this.txtRounds.TabIndex = 8;
            this.txtRounds.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Iterazioni";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtImageWidth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtImageHeight);
            this.groupBox2.Location = new System.Drawing.Point(299, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 71);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Larghezza Immagine";
            // 
            // txtImageWidth
            // 
            this.txtImageWidth.Location = new System.Drawing.Point(134, 19);
            this.txtImageWidth.Name = "txtImageWidth";
            this.txtImageWidth.Size = new System.Drawing.Size(49, 20);
            this.txtImageWidth.TabIndex = 10;
            this.txtImageWidth.Text = "1024";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Altezza Immagine";
            // 
            // txtImageHeight
            // 
            this.txtImageHeight.Location = new System.Drawing.Point(134, 43);
            this.txtImageHeight.Name = "txtImageHeight";
            this.txtImageHeight.Size = new System.Drawing.Size(49, 20);
            this.txtImageHeight.TabIndex = 22;
            this.txtImageHeight.Text = "768";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtXMin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtYMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtXMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtYMax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(81, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 71);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinate";
            // 
            // txtXMin
            // 
            this.txtXMin.Location = new System.Drawing.Point(32, 19);
            this.txtXMin.Name = "txtXMin";
            this.txtXMin.Size = new System.Drawing.Size(66, 20);
            this.txtXMin.TabIndex = 0;
            this.txtXMin.Text = "2.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // txtYMin
            // 
            this.txtYMin.Location = new System.Drawing.Point(32, 43);
            this.txtYMin.Name = "txtYMin";
            this.txtYMin.Size = new System.Drawing.Size(66, 20);
            this.txtYMin.TabIndex = 2;
            this.txtYMin.Text = "2.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // txtXMax
            // 
            this.txtXMax.Location = new System.Drawing.Point(120, 19);
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.Size = new System.Drawing.Size(66, 20);
            this.txtXMax.TabIndex = 4;
            this.txtXMax.Text = "4.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "->";
            // 
            // txtYMax
            // 
            this.txtYMax.Location = new System.Drawing.Point(120, 43);
            this.txtYMax.Name = "txtYMax";
            this.txtYMax.Size = new System.Drawing.Size(66, 20);
            this.txtYMax.TabIndex = 6;
            this.txtYMax.Text = "4.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "->";
            // 
            // chkKeepAspectRatio
            // 
            this.chkKeepAspectRatio.AutoSize = true;
            this.chkKeepAspectRatio.Checked = true;
            this.chkKeepAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepAspectRatio.Enabled = false;
            this.chkKeepAspectRatio.Location = new System.Drawing.Point(12, 37);
            this.chkKeepAspectRatio.Name = "chkKeepAspectRatio";
            this.chkKeepAspectRatio.Size = new System.Drawing.Size(29, 17);
            this.chkKeepAspectRatio.TabIndex = 21;
            this.chkKeepAspectRatio.Text = ".";
            this.chkKeepAspectRatio.UseVisualStyleBackColor = true;
            this.chkKeepAspectRatio.Visible = false;
            // 
            // frameOutput
            // 
            this.frameOutput.Controls.Add(this.pbOutput);
            this.frameOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameOutput.Location = new System.Drawing.Point(0, 70);
            this.frameOutput.Name = "frameOutput";
            this.frameOutput.Size = new System.Drawing.Size(1030, 671);
            this.frameOutput.TabIndex = 2;
            this.frameOutput.TabStop = false;
            this.frameOutput.Text = "Output";
            // 
            // pbOutput
            // 
            this.pbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOutput.Location = new System.Drawing.Point(3, 16);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(1024, 652);
            this.pbOutput.TabIndex = 1;
            this.pbOutput.TabStop = false;
            this.pbOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.pbOutput_Paint);
            this.pbOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbOutput_MouseDown);
            this.pbOutput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOutput_MouseMove);
            this.pbOutput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbOutput_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 70);
            this.panel1.TabIndex = 4;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 718);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1030, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 741);
            this.Controls.Add(this.frameControls);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.frameOutput);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mandelbrot";
            this.frameControls.ResumeLayout(false);
            this.frameControls.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.frameOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox frameControls;
        private System.Windows.Forms.GroupBox frameOutput;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.TextBox txtXMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRounds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImageWidth;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnZoomReset;
        private System.Windows.Forms.CheckBox chkKeepAspectRatio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImageHeight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}
