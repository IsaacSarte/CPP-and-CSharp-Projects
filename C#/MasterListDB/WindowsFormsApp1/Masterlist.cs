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
    public partial class Masterlist : Form
    {
        List<RanchPC> ranchList = new List<RanchPC>();
        public Masterlist()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();

            this.Close(); // Masterlist Close Sign
        }

        private void Masterlist_Load(object sender, EventArgs e)
        {
            string connection = "Data Source = (localdb)\\MSSQLLocalDb;Initial Catalog=Customer_PC;Integrated Security = True";
            SqlConnection connect = new SqlConnection(connection);
            connect.Open();

            string query = "SELECT * FROM tblCustomers ORDER by Name";
            var command = new SqlCommand(query, connect);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["Name"].ToString();
                string orders = reader["Orders"].ToString();
                string date = reader["Date"].ToString();
                string serviceName = reader["ServiceName"].ToString();

                ListViewItem ranchListView = new ListViewItem(name);
                ranchListView.SubItems.Add(orders);
                ranchListView.SubItems.Add(date);
                ranchListView.SubItems.Add(serviceName);
                ClientList.Items.Add(ranchListView);

                RanchPC ranch = new RanchPC();
                ranch.Name = name;
                ranch.Orders = orders;
                ranch.Date = date;
                ranch.ServiceName = serviceName;
                ranchList.Add(ranch);
            }
            reader.Close();
            connect.Close();
        } // private void

        private void editDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            string name = ClientList.SelectedItems[0].SubItems[0].Text;
            string orders = ClientList.SelectedItems[0].SubItems[1].Text;
            string date = ClientList.SelectedItems[0].SubItems[2].Text;
            string serviceName = ClientList.SelectedItems[0].SubItems[3].Text;

            Edit form = new Edit();
            form.Name = name;
            form.Orders = orders;
            form.Date = date;
            form.ServiceName = serviceName;
            form.Show();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            string name = ClientList.SelectedItems[0].SubItems[0].Text;
            string orders = ClientList.SelectedItems[0].SubItems[1].Text;
            string date = ClientList.SelectedItems[0].SubItems[2].Text;
            string serviceName = ClientList.SelectedItems[0].SubItems[3].Text;

            Delete form = new Delete();
            form.Name = name;
            form.Orders = orders;
            form.Date = date;
            form.ServiceName = serviceName;
            form.Show();
        }
    } // public class
}
