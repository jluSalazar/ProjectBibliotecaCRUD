using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class Diseno : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse

      );
        
        public Diseno()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "Dashboard";
            this.pnlContent.Controls.Clear();
            FormDashboard FrmDashboard_Vrb = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }       
        
        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(31, 27, 48);
            Color btnColor = Color.FromArgb(26, 23, 40);
            btnDashboard.BackColor = btnColor;
            btnCustomers.BackColor = btnColor;
            btnEmployees.BackColor = btnColor;
            btnMenuList.BackColor = btnColor;
            btnAnalytics.BackColor = btnColor;
            btnRestaurants.BackColor = btnColor;
            btnSettings.BackColor = btnColor;
            button.BackColor = activeColor;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "Dashboard";
            this.pnlContent.Controls.Clear();
            FormDashboard FrmDashboard_Vrb = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnCustomers.Height;
            pnlNavIndicator.Top = btnCustomers.Top;
            pnlNavIndicator.Left = btnCustomers.Left;
            ButtonColorReset(btnCustomers);

            lblTabTitle.Text = "Customers";
            this.pnlContent.Controls.Clear();
            MetodosEstudiante FrmCustomer_Vrb = new MetodosEstudiante() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmCustomer_Vrb);
            FrmCustomer_Vrb.Show();
        }
        private void BtnRestaurants_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnRestaurants.Height;
            pnlNavIndicator.Top = btnRestaurants.Top;
            pnlNavIndicator.Left = btnRestaurants.Left;
            ButtonColorReset(btnRestaurants);

            lblTabTitle.Text = "Restaurants";
            this.pnlContent.Controls.Clear();
            FormRestaurants FrmCustomer_Vrb = new FormRestaurants() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmCustomer_Vrb);
            FrmCustomer_Vrb.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnEmployees.Height;
            pnlNavIndicator.Top = btnEmployees.Top;
            pnlNavIndicator.Left = btnEmployees.Left;
            ButtonColorReset(btnEmployees);

            lblTabTitle.Text = "Employes";
            this.pnlContent.Controls.Clear();
            FormCustomers FrmCustomer_Vrb = new FormCustomers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmCustomer_Vrb);
            FrmCustomer_Vrb.Show();
        }
    }
}
