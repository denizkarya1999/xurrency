using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_convertor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void backToXurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://money.cnn.com/data/markets/");
        }


        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://money.cnn.com/data/markets/");
        }

        private void forwardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void foxBusinessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.wsj.com/news/markets/stocks");
        }

        private void cNBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.bloomberg.com/markets/stocks");
        }

        private void cNBCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.cnbc.com/");
        }

        private void marketWatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.marketwatch.com/markets?mod=top_nav");
        }

        private void foxBusinessToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.foxbusiness.com/markets");
        }

        private void cNNMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://money.cnn.com/data/markets/");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2021 Deniz K Acikbas. All rights are reserved. ", "About");
        }
    }
}
