using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1 
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void LogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            SqlConnection LoginRanch = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aizak\OneDrive\Desktop\RanchPC\LoginRanch.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter LogRPC = new SqlDataAdapter("select count(*) from loginRanch where ID = '" + textBox1.Text + "' and Pass = '" + textBox2.Text + "'", LoginRanch);
            DataTable LPC = new DataTable();
            LogRPC.Fill(LPC);

            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Invalid Details", "Input ID Number and Password First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Visible = true; // ID Number Required Sign
                label2.Visible = true; // Password Required Sign
            }
            else if (LPC.Rows[0][0].ToString() == "1")
            {
                Dashboard form = new Dashboard();
                form.Show();


                textBox1.Text = "Ranch PC ID Number";
                textBox2.Text = "Password";
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("ID Number is Missing", "Input ID Number First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label1.Visible = true; // ID Number Required Sign
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Password is Missing", "Password is Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label2.Visible = true; // ID Number Required Sign
                }
                else if (LPC.Rows[0][0].ToString() != "1")
                {
                    MessageBox.Show("ID Number and Password Does Not Match", "Please Input the Correct Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } // private void
    } // public class
}
