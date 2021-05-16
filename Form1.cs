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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void converted_value_Click(object sender, EventArgs e)
        {

        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            try
            {
                double entered_currency = double.Parse(amount_text.Text);
                double same_value = 1;
                double usd, cad, gbp, euro, aud, trky;
                double c_value;

                if (currency_box.SelectedItem == "American Dollar (USD)" && currency_box_2.SelectedItem == "American Dollar (USD)")
                {
                    c_value = entered_currency * same_value;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "American Dollar (USD)" && currency_box_2.SelectedItem == "Canadian Dollar (CAD)")
                {
                    cad = 1.26;
                    c_value = entered_currency * cad;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "American Dollar (USD)" && currency_box_2.SelectedItem == "British Pound (GBP)")
                {
                    gbp = 0.72;
                    c_value = entered_currency * gbp;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "American Dollar (USD)" && currency_box_2.SelectedItem == "Euro (EUR)")
                {
                    euro = 0.85;
                    c_value = entered_currency * euro;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "American Dollar (USD)" && currency_box_2.SelectedItem == "Australian Dollar (AUD)")
                {
                    aud = 1.31;
                    c_value = entered_currency * aud;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "American Dollar (USD)" && currency_box_2.SelectedItem == "Turkish Lira (TRY)")
                {
                    trky = 8.25;
                    c_value = entered_currency * trky;
                    converted_value.Text = c_value.ToString();
                }


                if (currency_box.SelectedItem == "Canadian Dollar (CAD)" && currency_box_2.SelectedItem == "Canadian Dollar (CAD)")
                {
                    c_value = entered_currency * same_value;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Canadian Dollar (CAD)" && currency_box_2.SelectedItem == "American Dollar (USD)")
                {
                    usd = 0.80;
                    c_value = entered_currency * usd;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Canadian Dollar (CAD)" && currency_box_2.SelectedItem == "British Pound (GBP)")
                {
                    gbp = 0.58;
                    c_value = entered_currency * gbp;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Canadian Dollar (CAD)" && currency_box_2.SelectedItem == "Euro (EUR)")
                {
                    euro = 0.68;
                    c_value = entered_currency * euro;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Canadian Dollar (CAD)" && currency_box_2.SelectedItem == "Australian Dollar (AUD)")
                {
                    aud = 1.05;
                    c_value = entered_currency * aud;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Canadian Dollar (CAD)" && currency_box_2.SelectedItem == "Turkish Lira (TRY)")
                {
                    trky = 6.57;
                    c_value = entered_currency * trky;
                    converted_value.Text = c_value.ToString();
                }


                if (currency_box.SelectedItem == "British Pound (GBP)" && currency_box_2.SelectedItem == "British Pound (GBP)")
                {
                    c_value = entered_currency * same_value;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "British Pound (GBP)" && currency_box_2.SelectedItem == "American Dollar (USD)")
                {
                    usd = 1.38;
                    c_value = entered_currency * usd;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "British Pound (GBP)" && currency_box_2.SelectedItem == "Euro (EUR)")
                {
                    euro = 1.18;
                    c_value = entered_currency * euro;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "British Pound (GBP)" && currency_box_2.SelectedItem == "Canadian Dollar (CAD)")
                {
                    cad = 1.74;
                    c_value = entered_currency * cad;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "British Pound (GBP)" && currency_box_2.SelectedItem == "Australian Dollar (AUD)")
                {
                    aud = 1.81;
                    c_value = entered_currency * aud;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "British Pound (GBP)" && currency_box_2.SelectedItem == "Turkish Lira (TRY)")
                {
                    trky = 11.46;
                    c_value = entered_currency * trky;
                    converted_value.Text = c_value.ToString();
                }

                if (currency_box.SelectedItem == "Euro (EUR)" && currency_box_2.SelectedItem == "Euro (EUR)")
                {
                    c_value = entered_currency * same_value;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Euro (EUR)" && currency_box_2.SelectedItem == "American Dollar (USD)")
                {
                    usd = 1.17;
                    c_value = entered_currency * usd;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Euro (EUR)" && currency_box_2.SelectedItem == "British Pound (GBP)")
                {
                    gbp = 0.85;
                    c_value = entered_currency * gbp;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Euro (EUR)" && currency_box_2.SelectedItem == "Canadian Dollar (CAD)")
                {
                    cad = 1.48;
                    c_value = entered_currency * cad;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Euro (EUR)" && currency_box_2.SelectedItem == "Australian Dollar (AUD)")
                {
                    aud = 1.54;
                    c_value = entered_currency * aud;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Euro (EUR)" && currency_box_2.SelectedItem == "Turkish Lira (TRY)")
                {
                    trky = 9.70;
                    c_value = entered_currency * trky;
                    converted_value.Text = c_value.ToString();
                }


                if (currency_box.SelectedItem == "Australian Dollar (AUD)" && currency_box_2.SelectedItem == "Australian Dollar (AUD)")
                {
                    c_value = entered_currency * same_value;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Australian Dollar (AUD)" && currency_box_2.SelectedItem == "American Dollar (USD)")
                {
                    usd = 0.76;
                    c_value = entered_currency * usd;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Australian Dollar (AUD)" && currency_box_2.SelectedItem == "British Pound (GBP)")
                {
                    gbp = 0.55;
                    c_value = entered_currency * gbp;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Australian Dollar (AUD)" && currency_box_2.SelectedItem == "Canadian Dollar (CAD)")
                {
                    cad = 0.96;
                    c_value = entered_currency * cad;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Australian Dollar (AUD)" && currency_box_2.SelectedItem == "Euro (EUR)")
                {
                    euro = 0.65;
                    c_value = entered_currency * euro;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Australian Dollar (AUD)" && currency_box_2.SelectedItem == "Turkish Lira (TRY)")
                {
                    trky = 6.28;
                    c_value = entered_currency * trky;
                    converted_value.Text = c_value.ToString();
                }


                if (currency_box.SelectedItem == "Turkish Lira (TRY)" && currency_box_2.SelectedItem == "Turkish Lira (TRY)")
                {
                    c_value = entered_currency * same_value;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Turkish Lira (TRY)" && currency_box_2.SelectedItem == "American Dollar (USD)")
                {
                    usd = 0.12;
                    c_value = entered_currency * usd;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Turkish Lira (TRY)" && currency_box_2.SelectedItem == "British Pound (GBP)")
                {
                    gbp = 0.088;
                    c_value = entered_currency * gbp;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Turkish Lira (TRY)" && currency_box_2.SelectedItem == "Canadian Dollar (CAD)")
                {
                    cad = 0.15;
                    c_value = entered_currency * cad;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Turkish Lira (TRY)" && currency_box_2.SelectedItem == "Euro (EUR)")
                {
                    euro = 0.10;
                    c_value = entered_currency * euro;
                    converted_value.Text = c_value.ToString();
                }
                else if (currency_box.SelectedItem == "Turkish Lira (TRY)" && currency_box_2.SelectedItem == "Australian Dollar (AUD)")
                {
                    aud = 0.16;
                    c_value = entered_currency * aud;
                    converted_value.Text = c_value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a number...", "Error");
            }

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            currency_box.ResetText();
            currency_box_2.ResetText();
            converted_value.Text = " ";
            amount_text.Text = " ";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2021 Deniz K Acikbas. All rights are reserved. ", "About");
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
