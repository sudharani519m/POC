namespace GroupBoxExample
{
    partial class Form1
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
            this.txtMyTextBox = new System.Windows.Forms.TextBox();
            this.grpBackgroundColor = new System.Windows.Forms.GroupBox();
            this.grpForegroundColor = new System.Windows.Forms.GroupBox();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbOrange = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtMyTextBox
            // 
            this.txtMyTextBox.Location = new System.Drawing.Point(230, 80);
            this.txtMyTextBox.Name = "txtMyTextBox";
            this.txtMyTextBox.Size = new System.Drawing.Size(392, 20);
            this.txtMyTextBox.TabIndex = 0;
            // 
            // grpBackgroundColor
            // 
            this.grpBackgroundColor.Location = new System.Drawing.Point(145, 157);
            this.grpBackgroundColor.Name = "grpBackgroundColor";
            this.grpBackgroundColor.Size = new System.Drawing.Size(177, 28);
            this.grpBackgroundColor.TabIndex = 1;
            this.grpBackgroundColor.TabStop = false;
            this.grpBackgroundColor.Text = "TextBox Background Color:";
            // 
            // grpForegroundColor
            // 
            this.grpForegroundColor.Location = new System.Drawing.Point(444, 157);
            this.grpForegroundColor.Name = "grpForegroundColor";
            this.grpForegroundColor.Size = new System.Drawing.Size(215, 28);
            this.grpForegroundColor.TabIndex = 2;
            this.grpForegroundColor.TabStop = false;
            this.grpForegroundColor.Text = "TextBox Foreground Color:";
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Location = new System.Drawing.Point(145, 209);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(50, 17);
            this.rbWhite.TabIndex = 3;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "white";
            this.rbWhite.UseVisualStyleBackColor = true;
            this.rbWhite.CheckedChanged += new System.EventHandler(this.rbWhite_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(145, 266);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(45, 17);
            this.rbRed.TabIndex = 4;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbYellow
            // 
            this.rbYellow.AutoSize = true;
            this.rbYellow.Location = new System.Drawing.Point(145, 336);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(56, 17);
            this.rbYellow.TabIndex = 5;
            this.rbYellow.TabStop = true;
            this.rbYellow.Text = "Yellow";
            this.rbYellow.UseVisualStyleBackColor = true;
            this.rbYellow.CheckedChanged += new System.EventHandler(this.rbYellow_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(444, 209);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(46, 17);
            this.rbBlue.TabIndex = 6;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(444, 266);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(54, 17);
            this.rbGreen.TabIndex = 7;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Location = new System.Drawing.Point(444, 326);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(60, 17);
            this.rbOrange.TabIndex = 8;
            this.rbOrange.TabStop = true;
            this.rbOrange.Text = "Orange";
            this.rbOrange.UseVisualStyleBackColor = true;
            this.rbOrange.CheckedChanged += new System.EventHandler(this.rbOrange_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbOrange);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbYellow);
            this.Controls.Add(this.rbRed);
            this.Controls.Add(this.rbWhite);
            this.Controls.Add(this.grpForegroundColor);
            this.Controls.Add(this.grpBackgroundColor);
            this.Controls.Add(this.txtMyTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMyTextBox;
        private System.Windows.Forms.GroupBox grpBackgroundColor;
        private System.Windows.Forms.GroupBox grpForegroundColor;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbOrange;
    }
}

