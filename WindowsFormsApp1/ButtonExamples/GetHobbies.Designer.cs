namespace ButtonExamples
{
    partial class GetHobbies
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
            this.lblPleaseSelectHobbies = new System.Windows.Forms.Label();
            this.chkHockey = new System.Windows.Forms.CheckBox();
            this.chkCricket = new System.Windows.Forms.CheckBox();
            this.chkDriving = new System.Windows.Forms.CheckBox();
            this.chkDancing = new System.Windows.Forms.CheckBox();
            this.chkMovies = new System.Windows.Forms.CheckBox();
            this.btnGetHobbies = new System.Windows.Forms.Button();
            this.lblPopup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPleaseSelectHobbies
            // 
            this.lblPleaseSelectHobbies.AutoSize = true;
            this.lblPleaseSelectHobbies.Location = new System.Drawing.Point(489, 182);
            this.lblPleaseSelectHobbies.Name = "lblPleaseSelectHobbies";
            this.lblPleaseSelectHobbies.Size = new System.Drawing.Size(166, 20);
            this.lblPleaseSelectHobbies.TabIndex = 0;
            this.lblPleaseSelectHobbies.Text = "Please select Hobbies";
            // 
            // chkHockey
            // 
            this.chkHockey.AutoSize = true;
            this.chkHockey.Location = new System.Drawing.Point(547, 303);
            this.chkHockey.Name = "chkHockey";
            this.chkHockey.Size = new System.Drawing.Size(88, 24);
            this.chkHockey.TabIndex = 3;
            this.chkHockey.Text = "Hockey";
            this.chkHockey.UseVisualStyleBackColor = true;
            // 
            // chkCricket
            // 
            this.chkCricket.AutoSize = true;
            this.chkCricket.Location = new System.Drawing.Point(547, 352);
            this.chkCricket.Name = "chkCricket";
            this.chkCricket.Size = new System.Drawing.Size(84, 24);
            this.chkCricket.TabIndex = 4;
            this.chkCricket.Text = "Cricket";
            this.chkCricket.UseVisualStyleBackColor = true;
            // 
            // chkDriving
            // 
            this.chkDriving.AutoSize = true;
            this.chkDriving.Location = new System.Drawing.Point(547, 413);
            this.chkDriving.Name = "chkDriving";
            this.chkDriving.Size = new System.Drawing.Size(83, 24);
            this.chkDriving.TabIndex = 5;
            this.chkDriving.Text = "Driving";
            this.chkDriving.UseVisualStyleBackColor = true;
            // 
            // chkDancing
            // 
            this.chkDancing.AutoSize = true;
            this.chkDancing.Location = new System.Drawing.Point(547, 476);
            this.chkDancing.Name = "chkDancing";
            this.chkDancing.Size = new System.Drawing.Size(94, 24);
            this.chkDancing.TabIndex = 6;
            this.chkDancing.Text = "Dancing";
            this.chkDancing.UseVisualStyleBackColor = true;
            // 
            // chkMovies
            // 
            this.chkMovies.AutoSize = true;
            this.chkMovies.Location = new System.Drawing.Point(546, 534);
            this.chkMovies.Name = "chkMovies";
            this.chkMovies.Size = new System.Drawing.Size(84, 24);
            this.chkMovies.TabIndex = 7;
            this.chkMovies.Text = "Movies";
            this.chkMovies.UseVisualStyleBackColor = true;
            // 
            // btnGetHobbies
            // 
            this.btnGetHobbies.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGetHobbies.Location = new System.Drawing.Point(779, 577);
            this.btnGetHobbies.Name = "btnGetHobbies";
            this.btnGetHobbies.Size = new System.Drawing.Size(171, 68);
            this.btnGetHobbies.TabIndex = 8;
            this.btnGetHobbies.Text = "GetHobbies";
            this.btnGetHobbies.UseVisualStyleBackColor = false;
            this.btnGetHobbies.Click += new System.EventHandler(this.btnGetHobbies_Click);
            // 
            // lblPopup
            // 
            this.lblPopup.AutoSize = true;
            this.lblPopup.Location = new System.Drawing.Point(348, 628);
            this.lblPopup.Name = "lblPopup";
            this.lblPopup.Size = new System.Drawing.Size(55, 20);
            this.lblPopup.TabIndex = 9;
            this.lblPopup.Text = "Popup";
            // 
            // GetHobbies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2207, 1196);
            this.Controls.Add(this.lblPopup);
            this.Controls.Add(this.btnGetHobbies);
            this.Controls.Add(this.chkMovies);
            this.Controls.Add(this.chkDancing);
            this.Controls.Add(this.chkDriving);
            this.Controls.Add(this.chkCricket);
            this.Controls.Add(this.chkHockey);
            this.Controls.Add(this.lblPleaseSelectHobbies);
            this.Name = "GetHobbies";
            this.Text = "GetHobbies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPleaseSelectHobbies;
        private System.Windows.Forms.CheckBox chkHockey;
        private System.Windows.Forms.CheckBox chkCricket;
        private System.Windows.Forms.CheckBox chkDriving;
        private System.Windows.Forms.CheckBox chkDancing;
        private System.Windows.Forms.CheckBox chkMovies;
        private System.Windows.Forms.Button btnGetHobbies;
        private System.Windows.Forms.Label lblPopup;
    }
}