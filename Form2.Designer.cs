
namespace currency_convertor
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foxBusinessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cNBCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cNBCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marketWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cNNMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foxBusinessToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToXurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(742, 504);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://money.cnn.com/data/markets/", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.resourcesToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.backToXurrencyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.forwardToolStripMenuItem1,
            this.backToolStripMenuItem1,
            this.refreshToolStripMenuItem1});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.homeToolStripMenuItem.Text = "Navigation";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // forwardToolStripMenuItem1
            // 
            this.forwardToolStripMenuItem1.Name = "forwardToolStripMenuItem1";
            this.forwardToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.forwardToolStripMenuItem1.Text = "Forward";
            this.forwardToolStripMenuItem1.Click += new System.EventHandler(this.forwardToolStripMenuItem1_Click);
            // 
            // backToolStripMenuItem1
            // 
            this.backToolStripMenuItem1.Name = "backToolStripMenuItem1";
            this.backToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.backToolStripMenuItem1.Text = "Back";
            this.backToolStripMenuItem1.Click += new System.EventHandler(this.backToolStripMenuItem1_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foxBusinessToolStripMenuItem,
            this.cNBCToolStripMenuItem,
            this.cNBCToolStripMenuItem1,
            this.marketWatchToolStripMenuItem,
            this.cNNMoneyToolStripMenuItem,
            this.foxBusinessToolStripMenuItem1});
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.resourcesToolStripMenuItem.Text = "Resources";
            // 
            // foxBusinessToolStripMenuItem
            // 
            this.foxBusinessToolStripMenuItem.Name = "foxBusinessToolStripMenuItem";
            this.foxBusinessToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.foxBusinessToolStripMenuItem.Text = "Wall Street Journal";
            this.foxBusinessToolStripMenuItem.Click += new System.EventHandler(this.foxBusinessToolStripMenuItem_Click);
            // 
            // cNBCToolStripMenuItem
            // 
            this.cNBCToolStripMenuItem.Name = "cNBCToolStripMenuItem";
            this.cNBCToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cNBCToolStripMenuItem.Text = "Bloomberg";
            this.cNBCToolStripMenuItem.Click += new System.EventHandler(this.cNBCToolStripMenuItem_Click);
            // 
            // cNBCToolStripMenuItem1
            // 
            this.cNBCToolStripMenuItem1.Name = "cNBCToolStripMenuItem1";
            this.cNBCToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.cNBCToolStripMenuItem1.Text = "CNBC";
            this.cNBCToolStripMenuItem1.Click += new System.EventHandler(this.cNBCToolStripMenuItem1_Click);
            // 
            // marketWatchToolStripMenuItem
            // 
            this.marketWatchToolStripMenuItem.Name = "marketWatchToolStripMenuItem";
            this.marketWatchToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.marketWatchToolStripMenuItem.Text = "MarketWatch";
            this.marketWatchToolStripMenuItem.Click += new System.EventHandler(this.marketWatchToolStripMenuItem_Click);
            // 
            // cNNMoneyToolStripMenuItem
            // 
            this.cNNMoneyToolStripMenuItem.Name = "cNNMoneyToolStripMenuItem";
            this.cNNMoneyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cNNMoneyToolStripMenuItem.Text = "CNN Money";
            this.cNNMoneyToolStripMenuItem.Click += new System.EventHandler(this.cNNMoneyToolStripMenuItem_Click);
            // 
            // foxBusinessToolStripMenuItem1
            // 
            this.foxBusinessToolStripMenuItem1.Name = "foxBusinessToolStripMenuItem1";
            this.foxBusinessToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.foxBusinessToolStripMenuItem1.Text = "Fox Business";
            this.foxBusinessToolStripMenuItem1.Click += new System.EventHandler(this.foxBusinessToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // backToXurrencyToolStripMenuItem
            // 
            this.backToXurrencyToolStripMenuItem.Name = "backToXurrencyToolStripMenuItem";
            this.backToXurrencyToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.backToXurrencyToolStripMenuItem.Text = "Back to Xurrency";
            this.backToXurrencyToolStripMenuItem.Click += new System.EventHandler(this.backToXurrencyToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 528);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Markets";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToXurrencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foxBusinessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cNBCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cNBCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marketWatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foxBusinessToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cNNMoneyToolStripMenuItem;
    }
}