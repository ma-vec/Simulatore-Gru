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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cavo_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gancio_img).BeginInit();
            SuspendLayout();
            // 
            // buttonUp
            // 
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
            buttonApplica.Location = new Point(34, 125);
            buttonApplica.Name = "buttonApplica";
            buttonApplica.Size = new Size(127, 23);
            buttonApplica.TabIndex = 5;
            buttonApplica.Text = "Applica";
            buttonApplica.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1085, 639);
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
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cavo_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)gancio_img).EndInit();
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
    }
}
