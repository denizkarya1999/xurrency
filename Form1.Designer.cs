
namespace currency_convertor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.amount_label = new System.Windows.Forms.Label();
            this.amount_text = new System.Windows.Forms.TextBox();
            this.currency_box = new System.Windows.Forms.ComboBox();
            this.from_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currency_box_2 = new System.Windows.Forms.ComboBox();
            this.converted_value = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.convert_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Location = new System.Drawing.Point(8, 35);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(74, 13);
            this.amount_label.TabIndex = 0;
            this.amount_label.Text = "Enter Amount:";
            // 
            // amount_text
            // 
            this.amount_text.Location = new System.Drawing.Point(88, 32);
            this.amount_text.Name = "amount_text";
            this.amount_text.Size = new System.Drawing.Size(143, 20);
            this.amount_text.TabIndex = 1;
            this.amount_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currency_box
            // 
            this.currency_box.FormattingEnabled = true;
            this.currency_box.Items.AddRange(new object[] {
            "American Dollar (USD)",
            "Canadian Dollar (CAD)",
            "British Pound (GBP)",
            "Euro (EUR)",
            "Australian Dollar (AUD)",
            "Turkish Lira (TRY)"});
            this.currency_box.Location = new System.Drawing.Point(98, 68);
            this.currency_box.Name = "currency_box";
            this.currency_box.Size = new System.Drawing.Size(133, 21);
            this.currency_box.TabIndex = 2;
            // 
            // from_label
            // 
            this.from_label.AutoSize = true;
            this.from_label.Location = new System.Drawing.Point(8, 71);
            this.from_label.Name = "from_label";
            this.from_label.Size = new System.Drawing.Size(84, 13);
            this.from_label.TabIndex = 3;
            this.from_label.Text = "Converting from:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Converting to:";
            // 
            // currency_box_2
            // 
            this.currency_box_2.FormattingEnabled = true;
            this.currency_box_2.Items.AddRange(new object[] {
            "American Dollar (USD)",
            "Canadian Dollar (CAD)",
            "British Pound (GBP)",
            "Euro (EUR)",
            "Australian Dollar (AUD)",
            "Turkish Lira (TRY)"});
            this.currency_box_2.Location = new System.Drawing.Point(98, 101);
            this.currency_box_2.Name = "currency_box_2";
            this.currency_box_2.Size = new System.Drawing.Size(133, 21);
            this.currency_box_2.TabIndex = 5;
            // 
            // converted_value
            // 
            this.converted_value.BackColor = System.Drawing.SystemColors.ControlLight;
            this.converted_value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.converted_value.Location = new System.Drawing.Point(47, 157);
            this.converted_value.Name = "converted_value";
            this.converted_value.Size = new System.Drawing.Size(152, 23);
            this.converted_value.TabIndex = 6;
            this.converted_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.converted_value.Click += new System.EventHandler(this.converted_value_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Value";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // convert_button
            // 
            this.convert_button.Location = new System.Drawing.Point(22, 193);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(75, 23);
            this.convert_button.TabIndex = 8;
            this.convert_button.Text = "Convert";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(146, 193);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 9;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(243, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stocksToolStripMenuItem});
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.modesToolStripMenuItem.Text = "Modes";
            // 
            // stocksToolStripMenuItem
            // 
            this.stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stocksToolStripMenuItem.Text = "Markets";
            this.stocksToolStripMenuItem.Click += new System.EventHandler(this.stocksToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(243, 222);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.converted_value);
            this.Controls.Add(this.currency_box_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from_label);
            this.Controls.Add(this.currency_box);
            this.Controls.Add(this.amount_text);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Xurrency ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.TextBox amount_text;
        private System.Windows.Forms.ComboBox currency_box;
        private System.Windows.Forms.Label from_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox currency_box_2;
        private System.Windows.Forms.Label converted_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
    }
}

