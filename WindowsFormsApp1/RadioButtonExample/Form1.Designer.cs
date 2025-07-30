namespace RadioButtonExample
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
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.rbBeige = new System.Windows.Forms.RadioButton();
            this.rbLightGreen = new System.Windows.Forms.RadioButton();
            this.rbLightYellow = new System.Windows.Forms.RadioButton();
            this.rbBisque = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackgroundColor.Location = new System.Drawing.Point(268, 63);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(202, 18);
            this.lblBackgroundColor.TabIndex = 0;
            this.lblBackgroundColor.Text = "Select Background Color:";
            // 
            // rbBeige
            // 
            this.rbBeige.AutoSize = true;
            this.rbBeige.Location = new System.Drawing.Point(271, 95);
            this.rbBeige.Name = "rbBeige";
            this.rbBeige.Size = new System.Drawing.Size(52, 17);
            this.rbBeige.TabIndex = 1;
            this.rbBeige.TabStop = true;
            this.rbBeige.Text = "Beige";
            this.rbBeige.UseVisualStyleBackColor = true;
            this.rbBeige.CheckedChanged += new System.EventHandler(this.rbBeige_CheckedChanged);
            // 
            // rbLightGreen
            // 
            this.rbLightGreen.AutoSize = true;
            this.rbLightGreen.Location = new System.Drawing.Point(271, 136);
            this.rbLightGreen.Name = "rbLightGreen";
            this.rbLightGreen.Size = new System.Drawing.Size(80, 17);
            this.rbLightGreen.TabIndex = 2;
            this.rbLightGreen.TabStop = true;
            this.rbLightGreen.Text = "Light Green";
            this.rbLightGreen.UseVisualStyleBackColor = true;
            this.rbLightGreen.CheckedChanged += new System.EventHandler(this.rbLightGreen_CheckedChanged);
            // 
            // rbLightYellow
            // 
            this.rbLightYellow.AutoSize = true;
            this.rbLightYellow.Location = new System.Drawing.Point(271, 177);
            this.rbLightYellow.Name = "rbLightYellow";
            this.rbLightYellow.Size = new System.Drawing.Size(80, 17);
            this.rbLightYellow.TabIndex = 3;
            this.rbLightYellow.TabStop = true;
            this.rbLightYellow.Text = "Light yellow";
            this.rbLightYellow.UseVisualStyleBackColor = true;
            this.rbLightYellow.CheckedChanged += new System.EventHandler(this.rbLightYellow_CheckedChanged);
            // 
            // rbBisque
            // 
            this.rbBisque.AutoSize = true;
            this.rbBisque.Location = new System.Drawing.Point(271, 222);
            this.rbBisque.Name = "rbBisque";
            this.rbBisque.Size = new System.Drawing.Size(57, 17);
            this.rbBisque.TabIndex = 4;
            this.rbBisque.TabStop = true;
            this.rbBisque.Text = "Bisque";
            this.rbBisque.UseVisualStyleBackColor = true;
            this.rbBisque.CheckedChanged += new System.EventHandler(this.rbBisque_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbBisque);
            this.Controls.Add(this.rbLightYellow);
            this.Controls.Add(this.rbLightGreen);
            this.Controls.Add(this.rbBeige);
            this.Controls.Add(this.lblBackgroundColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.RadioButton rbBeige;
        private System.Windows.Forms.RadioButton rbLightGreen;
        private System.Windows.Forms.RadioButton rbLightYellow;
        private System.Windows.Forms.RadioButton rbBisque;
    }
}

