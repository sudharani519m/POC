﻿namespace ButtonExamples
{
    partial class ButtonImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnClearBackgroundImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Background Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearBackgroundImage
            // 
            this.btnClearBackgroundImage.Location = new System.Drawing.Point(304, 187);
            this.btnClearBackgroundImage.Name = "btnClearBackgroundImage";
            this.btnClearBackgroundImage.Size = new System.Drawing.Size(265, 42);
            this.btnClearBackgroundImage.TabIndex = 1;
            this.btnClearBackgroundImage.Text = "Clear Background image";
            this.btnClearBackgroundImage.UseVisualStyleBackColor = true;
            this.btnClearBackgroundImage.Click += new System.EventHandler(this.btnClearBackgroundImage_Click);
            // 
            // ButtonImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearBackgroundImage);
            this.Controls.Add(this.button1);
            this.Name = "ButtonImage";
            this.Text = "ButtonImage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClearBackgroundImage;
    }
}