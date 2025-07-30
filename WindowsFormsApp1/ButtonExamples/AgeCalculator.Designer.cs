namespace ButtonExamples
{
    partial class AgeCalculator
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
            this.lblPleaseSelectDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnGetMyAge = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPleaseSelectDOB
            // 
            this.lblPleaseSelectDOB.AutoSize = true;
            this.lblPleaseSelectDOB.Location = new System.Drawing.Point(427, 183);
            this.lblPleaseSelectDOB.Name = "lblPleaseSelectDOB";
            this.lblPleaseSelectDOB.Size = new System.Drawing.Size(218, 30);
            this.lblPleaseSelectDOB.TabIndex = 0;
            this.lblPleaseSelectDOB.Text = "Please Select DOB";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(684, 178);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(352, 26);
            this.dtpDOB.TabIndex = 1;
            // 
            // btnGetMyAge
            // 
            this.btnGetMyAge.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGetMyAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetMyAge.ForeColor = System.Drawing.Color.Black;
            this.btnGetMyAge.Location = new System.Drawing.Point(540, 342);
            this.btnGetMyAge.Name = "btnGetMyAge";
            this.btnGetMyAge.Size = new System.Drawing.Size(167, 71);
            this.btnGetMyAge.TabIndex = 2;
            this.btnGetMyAge.Text = "GetMyAge";
            this.btnGetMyAge.UseVisualStyleBackColor = false;
            this.btnGetMyAge.Click += new System.EventHandler(this.btnGetMyAge_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(817, 369);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 30);
            this.lblResult.TabIndex = 3;
            // 
            // lblAgeCaluculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2208, 897);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGetMyAge);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblPleaseSelectDOB);
            this.Name = "lblAgeCaluculator";
            this.Text = "AgeCalculator:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPleaseSelectDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnGetMyAge;
        private System.Windows.Forms.Label lblResult;
    }
}