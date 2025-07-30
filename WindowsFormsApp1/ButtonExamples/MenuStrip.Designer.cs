namespace ButtonExamples
{
    partial class ToolStripMenuItem
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
            this.showToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.showToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem.SuspendLayout();
            this.ClearToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.showToolStripMenuItem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.showToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem1});
            this.showToolStripMenuItem.Location = new System.Drawing.Point(0, 33);
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(1924, 33);
            this.showToolStripMenuItem.TabIndex = 0;
            this.showToolStripMenuItem.Text = "menuStrip1";
            // 
            // showToolStripMenuItem1
            // 
            this.showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            this.showToolStripMenuItem1.Size = new System.Drawing.Size(72, 29);
            this.showToolStripMenuItem1.Text = "Show";
            this.showToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.ClearToolStripMenuItem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ClearToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1});
            this.ClearToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(1924, 33);
            this.ClearToolStripMenuItem.TabIndex = 1;
            this.ClearToolStripMenuItem.Text = "menuStrip1";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(67, 29);
            this.clearToolStripMenuItem1.Text = "Clear";
            // 
            // ToolStripMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.showToolStripMenuItem);
            this.Controls.Add(this.ClearToolStripMenuItem);
            this.MainMenuStrip = this.ClearToolStripMenuItem;
            this.Name = "ToolStripMenuItem";
            this.Text = "MenuStrip";
            this.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            this.showToolStripMenuItem.ResumeLayout(false);
            this.showToolStripMenuItem.PerformLayout();
            this.ClearToolStripMenuItem.ResumeLayout(false);
            this.ClearToolStripMenuItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
    }
}