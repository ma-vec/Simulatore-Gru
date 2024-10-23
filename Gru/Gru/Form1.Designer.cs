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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(183, 308);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(87, 38);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(698, 186);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 381);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 639);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(buttonApplica);
            Controls.Add(textBoxHMax);
            Controls.Add(textBoxHMin);
            Controls.Add(buttonReset);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
