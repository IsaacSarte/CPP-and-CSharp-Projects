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
    public partial class Delete : Form
    {
        public string Name { get; set; }
        public string Orders { get; set; }
        public string Date { get; set; }
        public string ServiceName { get; set; }
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
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
            // Add to Delete
            DialogResult result = MessageBox.Show("You are deleting a customer from the list", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                string connectionString = "Data Source = (localdb)\\MSSQLLocalDb;Initial Catalog=Customer_PC;Integrated Security = True";
                string countString = "SELECT COUNT(*) FROM tblCustomers WHERE tblCustomers.Name = @NameForChecking";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string queryString = "DELETE FROM tblCustomers WHERE Name = @Name";
                SqlParameter param1 = new SqlParameter("@Name", textBox1.Text);
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add(param1);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Customer Removed", "Customer Removed from list", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Add.Enabled = false;

            }
            else
            {
                MessageBox.Show("Extermination procedure suspended", "Action suspended", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            this.Close();

            Masterlist form = new Masterlist();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();

            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Masterlist form = new Masterlist();
            form.Show();

            this.Close();
        }
    }
}
