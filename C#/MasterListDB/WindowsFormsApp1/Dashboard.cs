using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addCustomersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.Show();

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masterlist form = new Masterlist();
            form.Show();

            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
