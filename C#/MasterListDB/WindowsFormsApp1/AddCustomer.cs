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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e) 
        {
            string connection = "Data Source = (localdb)\\MSSQLLocalDb;Initial Catalog=Customer_PC;Integrated Security = True";
            SqlConnection connect = new SqlConnection(connection);
            connect.Open();

            string queryString = "SELECT ServiceName FROM tblService;";
            var command = new SqlCommand(queryString, connect);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string part = reader["ServiceName"].ToString();
                comboBox1.Items.Add(part);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == String.Empty || textBox1.Text == String.Empty || textBox2.Text == String.Empty || dateTimePicker1.Text == String.Empty)
            {
                MessageBox.Show("Invalid Details","Please Input ALL Informations",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                bool lastNameChecker = false;

                string connectionString = "Data Source = (localdb)\\MSSQLLocalDb;Initial Catalog=Customer_PC;Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string insertString = "INSERT INTO tblCustomers(ServiceName,Name,Orders) VALUES(@ServiceName,@Name,@Orders)";
                string countString = "SELECT COUNT(*) FROM tblCustomers WHERE tblCustomers.Name = @NameForChecking";

                SqlParameter par = new SqlParameter("@NameForChecking", textBox1.Text);
                var command = new SqlCommand(countString, connection);
                command.Parameters.Add(par);
                int lastNameValueInt = Convert.ToInt16(command.ExecuteScalar());
                if (lastNameValueInt == 0) lastNameChecker = true;
                if (lastNameValueInt != 0)
                {
                    MessageBox.Show("There is already with the same Name", "Try changing the first name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (lastNameChecker)
                {
                    
                        SqlParameter par1 = new SqlParameter("@ServiceName", comboBox1.Text);
                        SqlParameter par2 = new SqlParameter("@Name", textBox1.Text);
                        SqlParameter par3 = new SqlParameter("@Orders", textBox2.Text);
                        SqlParameter par4 = new SqlParameter("@Date", textBox3.Text);


                        var com = new SqlCommand(insertString, connection);
                        com.Parameters.Add(par1);
                        com.Parameters.Add(par2);
                        com.Parameters.Add(par3);
                        com.Parameters.Add(par4);



                        com.ExecuteNonQuery();
                        MessageBox.Show(textBox1.Text + " Customer ", " Registered ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        comboBox1.Text = String.Empty;
                        textBox1.Text = String.Empty;
                        textBox2.Text = String.Empty;


                        connection.Close(); // Closing the Database
                }                                     
            }              
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();

            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // private void
} // public class
