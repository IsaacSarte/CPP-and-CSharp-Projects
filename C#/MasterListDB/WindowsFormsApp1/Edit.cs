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
using System.Linq.Expressions;

namespace WindowsFormsApp1
{
    public partial class Edit : Form
    {
        public string Name { get; set; }
        public string Orders { get; set; }
        public string Date { get; set; }
        public string ServiceName { get; set; }
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            string connection = "Data Source = (localdb)\\MSSQLLocalDb;Initial Catalog=Customer_PC;Integrated Security = True";
            SqlConnection connect = new SqlConnection(connection);
            connect.Open();

            string query = "SELECT ServiceName FROM tblService;";
            var command = new SqlCommand(query, connect);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string serviceName = reader["ServiceName"].ToString();
                comboBox1.Items.Add(serviceName);
            }
            reader.Close();
            connect.Close();

            comboBox1.Text = ServiceName;
            textBox1.Text = Name;
            textBox2.Text = Orders;
            textBox3.Text = Date;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Add to Edit
            string connectionString = "Data Source = (localdb)\\MSSQLLocalDb;Initial Catalog=Customer_PC;Integrated Security = True";
            string countString = "SELECT COUNT(*) FROM tblCustomers WHERE tblCustomers.Name = @NameForChecking";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            if (comboBox1.Text == String.Empty || textBox1.Text == String.Empty || textBox2.Text == String.Empty || dateTimePicker1.Text == String.Empty)
            {
                MessageBox.Show("Invalid Details", "Please Input ALL Informations", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string queryString = "UPDATE tblCustomers SET ServiceName = @ServiceName, Orders = @Orders, Date = @Date WHERE Name = @Name;";
                try
                {
                    SqlParameter par1 = new SqlParameter("@Name", textBox1.Text);
                    SqlParameter par2 = new SqlParameter("@Orders", textBox2.Text);
                    SqlParameter par3 = new SqlParameter("@Date", textBox3.Text);
                    SqlParameter par4 = new SqlParameter("@ServiceName", comboBox1.Text);

                    var com = new SqlCommand(queryString, connection);
                    com.Parameters.Add(par1);
                    com.Parameters.Add(par2);
                    com.Parameters.Add(par3);
                    com.Parameters.Add(par4);

                    com.ExecuteNonQuery();
                    MessageBox.Show(textBox1.Text + " Customer ", " Edited ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {

                }
                connection.Close(); // Closing the Database

                this.Close();
                Masterlist form = new Masterlist();
                form.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Masterlist form = new Masterlist();
            form.Show();

            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();

            this.Close();
        }
    }
}
