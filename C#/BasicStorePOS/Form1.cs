using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_Guzman_April
{
    public partial class Form1 : Form
    {
        double total = 0;
        double changeDouble = 0;
        double payment = 0;
        double itemPrice;

        Dictionary<string, double> gameItems = new Dictionary<string, double>();
        public Form1()
        {
            InitializeComponent();
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
       
            gameItems.Add("WARCRAFT", 120.75);
            gameItems.Add("CSGO", 89.50);
            gameItems.Add("VALORANT", 275.25);
            gameItems.Add("GTA", 300);
            comboBox1.DataSource = gameItems.ToList();
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Key";

            ProductLabel.Text = "----";
            ItemPriceLabel.Text = "0.0";

        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Clearing all texts

            comboBox1.Text = String.Empty; // Combobox Texts
            listBox1.Items.Clear(); // Listbox items
            textBox1.Text = String.Empty; // Payment textbox
            ChangeLabel.Text = "0.0";
            ItemsLabel.Text = "0";
            PriceLabel.Text = "0";
            ProductLabel.Text = "----";
            ItemPriceLabel.Text = "0.0";
            total = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text != String.Empty)
            {

                // Adding items in listbox

                string selectedGame = comboBox1.Text.ToString();
                listBox1.Items.Add(selectedGame);
                listBox1.Text = String.Format(selectedGame);
                ItemsLabel.Text = listBox1.Items.Count.ToString();

                itemPrice = Convert.ToDouble(gameItems[selectedGame]);
                ItemPriceLabel.Text = itemPrice.ToString();


                // Adding product name in the ProductLabel label

                ProductLabel.Text = comboBox1.Text;

                total += Convert.ToDouble(gameItems[selectedGame]);
                PriceLabel.Text = total.ToString();

                /*double price = Convert.ToDouble(PriceLabel.Text) + gameItems[selectedItem];
                PriceLabel.Text = String.Format("{0:0.00}", price);*/


            }
                
            else
                MessageBox.Show("Please add items.", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Removing items in listbox
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            

            //double price = Convert.ToDouble(PriceLabel.Text) - gameItems[price];
            //PriceLabel.Text = String.Format("{0:0.00}", price);

            string selectedGame = listBox1.SelectedItem.ToString();
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(selectedGame));
            ItemsLabel.Text = listBox1.Items.Count.ToString();

            
            total -= Convert.ToDouble(gameItems[selectedGame]);
            PriceLabel.Text = total.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Pay button function
            bool isError;
            if (textBox1.Text == String.Empty)
            {
                isError = true;
                errorProvider1.SetError(label6,"MUST NOT BE EMPTY");
            }
            else
            {
               string paymentString = textBox1.Text;
                payment = Convert.ToDouble(paymentString);
               if(payment < total)
                {
                    errorProvider1.SetError(label6, "Payment NOT Enough!");
                }
                else
                {
                    errorProvider1.Clear();

                    string changeString = ChangeLabel.Text;
                    changeDouble = Convert.ToDouble(changeString);
                    changeDouble = payment - total;
                    ChangeLabel.Text = changeDouble.ToString();
                }

            }

        }
    }
}
