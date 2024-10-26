namespace Gru
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonUp = new Button();
            buttonDown = new Button();
            buttonReset = new Button();
            textBoxHMin = new TextBox();
            textBoxHMax = new TextBox();
            buttonApplica = new Button();
            pictureBox2 = new PictureBox();
            cavo_img = new PictureBox();
            gancio_img = new PictureBox();
            labelH_fissa = new Label();
            label_Hgancio = new Label();
            pictureBoxEgg = new PictureBox();
            labelhmin_fissa = new Label();
            labelhmax_fissa = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cavo_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gancio_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEgg).BeginInit();
            SuspendLayout();
            // 
            // buttonUp
            // 
            buttonUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUp.Location = new Point(34, 257);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(127, 48);
            buttonUp.TabIndex = 0;
            buttonUp.Text = "ALZA";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDown.Location = new Point(34, 343);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(127, 48);
            buttonDown.TabIndex = 1;
            buttonDown.Text = "ABBASSA";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.ForeColor = Color.IndianRed;
            buttonReset.Location = new Point(183, 308);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(87, 38);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // textBoxHMin
            // 
            textBoxHMin.Location = new Point(34, 40);
            textBoxHMin.Name = "textBoxHMin";
            textBoxHMin.Size = new Size(127, 23);
            textBoxHMin.TabIndex = 3;
            // 
            // textBoxHMax
            // 
            textBoxHMax.Location = new Point(34, 86);
            textBoxHMax.Name = "textBoxHMax";
            textBoxHMax.Size = new Size(127, 23);
            textBoxHMax.TabIndex = 4;
            // 
            // buttonApplica
            // 
            buttonApplica.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonApplica.ForeColor = Color.ForestGreen;
            buttonApplica.Location = new Point(34, 125);
            buttonApplica.Name = "buttonApplica";
            buttonApplica.Size = new Size(127, 29);
            buttonApplica.TabIndex = 5;
            buttonApplica.Text = "Applica";
            buttonApplica.UseVisualStyleBackColor = true;
            buttonApplica.Click += buttonApplica_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(644, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(439, 561);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // cavo_img
            // 
            cavo_img.Image = (Image)resources.GetObject("cavo_img.Image");
            cavo_img.Location = new Point(716, 189);
            cavo_img.Name = "cavo_img";
            cavo_img.Size = new Size(123, 438);
            cavo_img.TabIndex = 8;
            cavo_img.TabStop = false;
            // 
            // gancio_img
            // 
            gancio_img.Image = (Image)resources.GetObject("gancio_img.Image");
            gancio_img.Location = new Point(694, 191);
            gancio_img.Name = "gancio_img";
            gancio_img.Size = new Size(100, 468);
            gancio_img.SizeMode = PictureBoxSizeMode.StretchImage;
            gancio_img.TabIndex = 10;
            gancio_img.TabStop = false;
            // 
            // labelH_fissa
            // 
            labelH_fissa.AutoSize = true;
            labelH_fissa.Location = new Point(34, 442);
            labelH_fissa.Name = "labelH_fissa";
            labelH_fissa.Size = new Size(109, 15);
            labelH_fissa.TabIndex = 11;
            labelH_fissa.Text = "Altezza Gancio (m):";
            // 
            // label_Hgancio
            // 
            label_Hgancio.AutoSize = true;
            label_Hgancio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Hgancio.Location = new Point(149, 442);
            label_Hgancio.Name = "label_Hgancio";
            label_Hgancio.Size = new Size(0, 15);
            label_Hgancio.TabIndex = 12;
            // 
            // pictureBoxEgg
            // 
            pictureBoxEgg.Image = (Image)resources.GetObject("pictureBoxEgg.Image");
            pictureBoxEgg.Location = new Point(694, 335);
            pictureBoxEgg.Name = "pictureBoxEgg";
            pictureBoxEgg.Size = new Size(100, 107);
            pictureBoxEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEgg.TabIndex = 13;
            pictureBoxEgg.TabStop = false;
            // 
            // labelhmin_fissa
            // 
            labelhmin_fissa.AutoSize = true;
            labelhmin_fissa.Location = new Point(173, 44);
            labelhmin_fissa.Name = "labelhmin_fissa";
            labelhmin_fissa.Size = new Size(204, 15);
            labelhmin_fissa.TabIndex = 14;
            labelhmin_fissa.Text = "Altezza min. piano di camapagna (m)";
            // 
            // labelhmax_fissa
            // 
            labelhmax_fissa.AutoSize = true;
            labelhmax_fissa.Location = new Point(173, 94);
            labelhmax_fissa.Name = "labelhmax_fissa";
            labelhmax_fissa.Size = new Size(92, 15);
            labelhmax_fissa.TabIndex = 15;
            labelhmax_fissa.Text = "Altezza max (m)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1085, 735);
            Controls.Add(labelhmax_fissa);
            Controls.Add(labelhmin_fissa);
            Controls.Add(pictureBoxEgg);
            Controls.Add(label_Hgancio);
            Controls.Add(labelH_fissa);
            Controls.Add(gancio_img);
            Controls.Add(cavo_img);
            Controls.Add(pictureBox2);
            Controls.Add(buttonApplica);
            Controls.Add(textBoxHMax);
            Controls.Add(textBoxHMin);
            Controls.Add(buttonReset);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Name = "Form1";
            Text = "Simulatore Gru";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cavo_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)gancio_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEgg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUp;
        private Button buttonDown;
        private Button buttonReset;
        private TextBox textBoxHMin;
        private TextBox textBoxHMax;
        private Button buttonApplica;
        private PictureBox pictureBox2;
        private PictureBox cavo_img;
        private PictureBox gancio_img;
        private Label labelH_fissa;
        private Label label_Hgancio;
        private PictureBox pictureBoxEgg;
        private Label labelhmin_fissa;
        private Label labelhmax_fissa;
    }
}
