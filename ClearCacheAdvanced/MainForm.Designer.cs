namespace ClearCacheAdvanced
{
    partial class MainForm : Form
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

            //menuStrip1 = new MenuStrip();
            //mainToolStripMenuItem = new ToolStripMenuItem();
            //menuStrip1.SuspendLayout();
            //SuspendLayout();
            // 
            // menuStrip1
            // 
            //menuStrip1.Items.AddRange(new ToolStripItem[] { mainToolStripMenuItem });
            //menuStrip1.Location = new Point(0, 0);
            //menuStrip1.Name = "menuStrip1";
            //menuStrip1.Size = new Size(800, 24);
            //menuStrip1.TabIndex = 0;
            //menuStrip1.Text = "menuStrip1";
            //// 
            //// mainToolStripMenuItem
            //// 
            //mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            //mainToolStripMenuItem.Size = new Size(46, 20);
            //mainToolStripMenuItem.Text = "Main";

            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUP2Ak © ClearCache Advanced";
            this.ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainToolStripMenuItem;
    }
}