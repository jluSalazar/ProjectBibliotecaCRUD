
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Restaurant_Management
{
    public partial class FormDashboard : Form
    {
       
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            UpdateForm update =new UpdateForm();
            update.Validate();
            update.Show();


        }
    }
}
