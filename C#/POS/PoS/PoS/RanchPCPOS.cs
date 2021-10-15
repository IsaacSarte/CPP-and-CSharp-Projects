using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoS
{
    public partial class RanchPCPOS : Form
    {
        public RanchPCPOS()
        {
            InitializeComponent();
        }

        // INTEL PROCESSORS
        private void item1_Click(object sender, EventArgs e) // i3-9100F
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label1.Text + "\t\tP" + (qtyInt * double.Parse(price1.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label1.Text + "\tP" + (qtyInt * double.Parse(price1.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price1.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item1_1_Click(object sender, EventArgs e) // i3-9100
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label1_1.Text + "\t\tP" + (qtyInt * double.Parse(price1_1.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label1_1.Text + "\tP" + (qtyInt * double.Parse(price1_1.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price1.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item1_2_Click(object sender, EventArgs e) // i3-10100
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label1_2.Text + "\t\tP" + (qtyInt * double.Parse(price1_2.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label1_2.Text + "\tP" + (qtyInt * double.Parse(price1_2.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price1_2.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item2_Click(object sender, EventArgs e) // i5-9400F
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label2.Text + "\t\tP" + (qtyInt * double.Parse(price2.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label2.Text + "\tP" + (qtyInt * double.Parse(price2.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price2.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item2_1_Click(object sender, EventArgs e) // i5-9400
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label2_1.Text + "\t\tP" + (qtyInt * double.Parse(price2_1.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label2_1.Text + "\tP" + (qtyInt * double.Parse(price2_1.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price2_1.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item3_Click(object sender, EventArgs e) // i5-10400
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label3.Text + "\t\tP" + (qtyInt * double.Parse(price3.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label3.Text + "\tP" + (qtyInt * double.Parse(price3.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price3.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item3_1_Click(object sender, EventArgs e) // i5-10500
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label3_1.Text + "\t\tP" + (qtyInt * double.Parse(price3_1.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label3_1.Text + "\tP" + (qtyInt * double.Parse(price3_1.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price3_1.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item3_2_Click(object sender, EventArgs e) // i5-10600
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label3_2.Text + "\t\tP" + (qtyInt * double.Parse(price3_2.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label3_2.Text + "\tP" + (qtyInt * double.Parse(price3_2.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price3_2.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item3_3_Click(object sender, EventArgs e) // i5-10600K
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label3_3.Text + "\t\tP" + (qtyInt * double.Parse(price3_3.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label3_3.Text + "\tP" + (qtyInt * double.Parse(price3_3.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price3_3.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item4_Click(object sender, EventArgs e) // i7-9700F
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label4.Text + "\t\tP" + (qtyInt * double.Parse(price4.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label4.Text + "\tP" + (qtyInt * double.Parse(price4.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price4.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item4_1_Click(object sender, EventArgs e) // i7-9700
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label4_1.Text + "\t\tP" + (qtyInt * double.Parse(price4_1.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label4_1.Text + "\tP" + (qtyInt * double.Parse(price4_1.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price4_1.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item4_2_Click_1(object sender, EventArgs e) // i7-9700K
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label4_2.Text + "\t\tP" + (qtyInt * double.Parse(price4_2.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label4_2.Text + "\tP" + (qtyInt * double.Parse(price4_2.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price4_2.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item4_3_Click(object sender, EventArgs e) // i7-10700
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label4_3.Text + "\t\tP" + (qtyInt * double.Parse(price4_3.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label4_3.Text + "\tP" + (qtyInt * double.Parse(price4_3.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price4_3.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item4_4_Click(object sender, EventArgs e) // i7-10700K
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label4_4.Text + "\t\tP" + (qtyInt * double.Parse(price4_4.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label4_4.Text + "\tP" + (qtyInt * double.Parse(price4_4.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price4_4.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item5_Click(object sender, EventArgs e) // i9-9900K
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label5.Text + "\t\tP" + (qtyInt * double.Parse(price5.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label5.Text + "\tP" + (qtyInt * double.Parse(price5.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price5.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item5_1_Click(object sender, EventArgs e) // i9-10900
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label5_1.Text + "\t\tP" + (qtyInt * double.Parse(price5_1.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label5_1.Text + "\tP" + (qtyInt * double.Parse(price5_1.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price5_1.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void item5_2_Click(object sender, EventArgs e) // i9-10900K
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label5_2.Text + "\t\tP" + (qtyInt * double.Parse(price5_2.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + label5_2.Text + "\tP" + (qtyInt * double.Parse(price5_2.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(price5_2.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }


        // AMD RYZEN PROCESSORS
        private void itemRyzen_Click(object sender, EventArgs e) // R3-3100G
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelRyzen.Text + "\t\tP" + (qtyInt * double.Parse(priceRyzen.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelRyzen.Text + "\tP" + (qtyInt * double.Parse(priceRyzen.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceRyzen.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR1_Click(object sender, EventArgs e) // R3-3200G
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR1.Text + "\t\tP" + (qtyInt * double.Parse(priceR1.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR1.Text + "\tP" + (qtyInt * double.Parse(priceR1.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR1.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR1_1_Click(object sender, EventArgs e) // R3-3300X
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR1_1.Text + "\t\tP" + (qtyInt * double.Parse(priceR1_1.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR1_1.Text + "\tP" + (qtyInt * double.Parse(priceR1_1.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR1_1.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR2_Click(object sender, EventArgs e) // R5-2600
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2.Text + "\t\tP" + (qtyInt * double.Parse(priceR2.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2.Text + "\tP" + (qtyInt * double.Parse(priceR2.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR2.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR2_1_Click(object sender, EventArgs e) // R5-3400G
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_1.Text + "\t\tP" + (qtyInt * double.Parse(priceR2_1.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_1.Text + "\tP" + (qtyInt * double.Parse(priceR2_1.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR2_1.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR2_2_Click(object sender, EventArgs e) // R5-3500
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_2.Text + "\t\tP" + (qtyInt * double.Parse(priceR2_2.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_2.Text + "\tP" + (qtyInt * double.Parse(priceR2_2.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR2_2.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR2_3_Click(object sender, EventArgs e) // R5-3500X
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_3.Text + "\t\tP" + (qtyInt * double.Parse(priceR2_3.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_3.Text + "\tP" + (qtyInt * double.Parse(priceR2_3.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR2_3.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR2_4_Click(object sender, EventArgs e) // R5-3600
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_4.Text + "\t\tP" + (qtyInt * double.Parse(priceR2_4.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_4.Text + "\tP" + (qtyInt * double.Parse(priceR2_4.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR2_4.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR2_5_Click(object sender, EventArgs e) // R5-3600X
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_5.Text + "\t\tP" + (qtyInt * double.Parse(priceR2_5.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_5.Text + "\tP" + (qtyInt * double.Parse(priceR2_5.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR2_5.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR2_6_Click(object sender, EventArgs e) // R5-3500XT
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_6.Text + "\t\tP" + (qtyInt * double.Parse(priceR2_6.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR2_6.Text + "\tP" + (qtyInt * double.Parse(priceR2_6.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR2_6.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR3_Click(object sender, EventArgs e) // R7-3700X
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR3.Text + "\t\tP" + (qtyInt * double.Parse(priceR3.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR3.Text + "\tP" + (qtyInt * double.Parse(priceR3.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR3.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR3_1_Click(object sender, EventArgs e) // R7-3800X
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR3_1.Text + "\t\tP" + (qtyInt * double.Parse(priceR3_1.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR3_1.Text + "\tP" + (qtyInt * double.Parse(priceR3_1.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR3_1.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR3_2_Click(object sender, EventArgs e) // R7-3800XT
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR3_2.Text + "\t\tP" + (qtyInt * double.Parse(priceR3_2.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR3_2.Text + "\tP" + (qtyInt * double.Parse(priceR3_2.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR3_2.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR4_Click(object sender, EventArgs e) // R9-3900X
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR4.Text + "\t\tP" + (qtyInt * double.Parse(priceR4.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR4.Text + "\tP" + (qtyInt * double.Parse(priceR4.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR4.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR4_1_Click(object sender, EventArgs e) // R9-3900XT
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR4_1.Text + "\t\tP" + (qtyInt * double.Parse(priceR4_1.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR4_1.Text + "\tP" + (qtyInt * double.Parse(priceR4_1.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR4_1.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }
        private void itemR4_2_Click(object sender, EventArgs e) // R9-3950X
        {
            string qtyStr = qty.Text;
            if (qty.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Please put the quantity.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    qty.Text = "1";
                }
                else if (result == DialogResult.Cancel)
                {
                    qty.Text = "1";
                }
            }
            else if (char.IsDigit(qtyStr[0]))
            {
                int qtyInt = int.Parse(qtyStr);
                if (qtyInt < 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR4_2.Text + "\t\tP" + (qtyInt * double.Parse(priceR4_2.Text.ToString())) + ".00");
                else if (qtyInt >= 10)
                    listBox1.Items.Add("(" + qtyStr + ") " + labelR4_2.Text + "\tP" + (qtyInt * double.Parse(priceR4_2.Text.ToString())) + ".00");

                int multiplier = int.Parse(Convert.ToString(qty.Text));
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                int newNoItem = currentItem + multiplier;
                noItemsIntBox.Text = newNoItem.ToString();
                noItemsBox.Text = newNoItem.ToString();

                double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                double addPrice = double.Parse(priceR4_2.Text.ToString());
                double newPrice = currentPrice + (addPrice * qtyInt);
                hiddenPrice.Text = newPrice.ToString();
                priceBox.Text = "P " + newPrice.ToString() + ".00";
            }
        }



        // DIMM DDR4 RAM
        // SOLID STATE DRIVE
        // HARD DISK DRIVE 


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int k = listBox1.SelectedIndex;
                string pangalanString = listBox1.Items[k].ToString();
                int currentItem = int.Parse(Convert.ToString(noItemsIntBox.Text));
                string sub = listBox1.Items[k].ToString();
                listBox1.Items.RemoveAt(k);

                string subString = Convert.ToString(sub[1]);
                int parenthesis = sub.IndexOf(')');

                bool tryParse = int.TryParse(Convert.ToString(sub[2]), out int subString2);

                if (tryParse == false)
                {
                    int subtrahend = int.Parse(subString);
                    int newNoItem = currentItem - subtrahend;
                    noItemsIntBox.Text = newNoItem.ToString();
                    noItemsBox.Text = newNoItem.ToString();
                    if (noItemsIntBox.Text == "0") noItemsBox.Text = null;

                    double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                    double subtrahend2 = 0;
                    double newPrice = currentPrice - (subtrahend2 * subtrahend);
                    hiddenPrice.Text = newPrice.ToString();
                    priceBox.Text = "P " + newPrice.ToString() + ".00";
                    if (hiddenPrice.Text == "0") priceBox.Text = null;
                }
                else if (tryParse == true)
                {
                    int parenthesisOpen = sub.IndexOf('(');
                    int parenthesisClose = sub.IndexOf(')');
                    subString = sub.Substring(1, parenthesisClose - 1); //(index, length)

                    int subtrahend = int.Parse(subString);
                    int newNoItem = currentItem - subtrahend;
                    noItemsIntBox.Text = newNoItem.ToString();
                    noItemsBox.Text = newNoItem.ToString();
                    if (noItemsIntBox.Text == "0") noItemsBox.Text = null;

                    double currentPrice = double.Parse(hiddenPrice.Text.ToString());
                    double subtrahend2 = 0;
                    double newPrice = currentPrice - (subtrahend2 * subtrahend);
                    hiddenPrice.Text = newPrice.ToString();
                    priceBox.Text = "P " + newPrice.ToString() + ".00";
                    if (hiddenPrice.Text == "0") priceBox.Text = null;
                }
            }
        }
        private void tenderBox_TextChanged(object sender, EventArgs e)
        {
            if (hiddenPrice.Text != "" && tenderBox.Text != "")
            {
                bool tryParse = int.TryParse(tenderBox.Text.ToString(), out int tenderInt);
                if (tryParse == true)
                {
                    double tender = double.Parse(tenderBox.Text.ToString());
                    double totalPrice = double.Parse(hiddenPrice.Text.ToString());
                    double changeInt = tender - totalPrice;
                    changeBox.Text = "P " + changeInt.ToString() + ".00";
                    if(changeInt < 0)
                    {
                        nextButton.Enabled = false;

                    }
                    else if(changeInt >= 0)
                    {
                        nextButton.Enabled = true;
                    }
                }
                else if (tryParse == false)
                {
                    nextButton.Enabled = false;
                    DialogResult result;
                    result = MessageBox.Show("Error! Numbers only", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        tenderBox.Text = null;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        tenderBox.Text = null;
                    }
                }
            }
            if (hiddenPrice.Text == "" || tenderBox.Text == "")
            {
                changeBox.Text = null;
                nextButton.Enabled = false;
            }
        }
        private void hiddenPrice_TextChanged(object sender, EventArgs e)
        {
            if (hiddenPrice.Text != "" && tenderBox.Text != "")
            {
                bool tryParse = int.TryParse(tenderBox.Text.ToString(), out int tenderInt); ;
                if (tryParse == true)
                {
                    double tender = double.Parse(tenderBox.Text.ToString());
                    double totalPrice = double.Parse(hiddenPrice.Text.ToString());
                    double changeInt = tender - totalPrice;
                    changeBox.Text = "P " + changeInt.ToString() + ".00";
                    if (changeInt < 0)
                    {
                        nextButton.Enabled = false;

                    }
                    else if (changeInt >= 0)
                    {
                        nextButton.Enabled = true;
                    }
                }
                else if (tryParse == false)
                {
                    DialogResult result;
                    result = MessageBox.Show("Error! Numbers only", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        tenderBox.Text = null;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        tenderBox.Text = null;
                    }
                }
            }
            if (hiddenPrice.Text == "" || tenderBox.Text == "")
            {
                changeBox.Text = null;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) // Printing the Document
        {
            int y = listBox1.Items.Count;
            string[] items = new string[y];
            for (int i = 0; i < y; i++)
            {
                items[i] = listBox1.Items[i].ToString();
            }
            float z = 3.0f;
            foreach (string item in items)
            {
                e.Graphics.DrawString(item, new Font("Microsoft San Serif", 8), Brushes.Gray, 5, z);
                z += 15.0f;
            }
            z += 30.0f;
            e.Graphics.DrawString("==============================================================", new Font("Microsoft San Serif", 8), Brushes.Gray, 5, z);
            z += 30.0f;
            e.Graphics.DrawString("No. of Items: " + noItemsBox.Text, new Font("Microsoft San Serif", 8), Brushes.Gray, 5, z);
            z += 15.0f;
            e.Graphics.DrawString("Total Price: " + priceBox.Text, new Font("Microsoft San Serif", 8), Brushes.Gray, 5, z);
            z += 15.0f;
            e.Graphics.DrawString("Cash: " + tenderBox.Text, new Font("Microsoft San Serif", 8), Brushes.Gray, 5, z);
            z += 15.0f;
            e.Graphics.DrawString("Change: " + changeBox.Text, new Font("Microsoft San Serif", 8), Brushes.Gray, 5, z);
            z += 15.0f;
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            listBox1.Items.Clear();
            noItemsIntBox.Text = "0";
            noItemsBox.Text = null;
            hiddenPrice.Text = "0.00";
            priceBox.Text = null;
            tenderBox.Text = null;
            changeBox.Text = null;
            qty.Text = "1";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            noItemsIntBox.Text = "0";
            noItemsBox.Text = null;
            hiddenPrice.Text = "0.00";
            priceBox.Text = null;
            tenderBox.Text = null;
            changeBox.Text = null;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void qty_TextChanged(object sender, EventArgs e)
        {
            int length = qty.Text.Length;
            string str = qty.Text;
            for (int i = 0; i < length; i++)
            {
                char Char = str[i];
                if (char.IsLetter(Char) || Char == ' ')
                {
                    DialogResult result;
                    result = MessageBox.Show("Error! Numbers only", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        qty.Text = "1";
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        qty.Text = "1";
                    }
                }
            }
        }
    }
}