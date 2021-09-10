using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardCalendar
{
    public partial class Form1 : Form
    {
        private Form currentForm;

        public Form1()
        {
            InitializeComponent();

            OpenForm(new DashboardForm());
            /*PanelForm1.Controls.Clear();
            DashboardForm dashboardForm_Vrb = new DashboardForm();
            dashboardForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            PanelForm1.Controls.Add(dashboardForm_Vrb);
            dashboardForm_Vrb.Show();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void OpenForm(Form childForm)
        {
            PanelForm1.Controls.Clear();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            PanelForm1.Controls.Add(childForm);
            childForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDay.Text = DateTime.Now.ToString("dd");
            lblMonth.Text = DateTime.Now.ToString("MMMM").ToUpper();
            lblYear.Text = DateTime.Now.ToString("yyyy");

            Time.Text = DateTime.Now.ToString("HH : mm");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new DashboardForm());
            /*PanelForm1.Controls.Clear();
            DashboardForm dashboardForm_Vrb = new DashboardForm();
            dashboardForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            PanelForm1.Controls.Add(dashboardForm_Vrb);
            dashboardForm_Vrb.Show();*/
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenForm(new ScheduleForm());
            /*PanelForm1.Controls.Clear();
            ScheduleForm scheduleForm_Vrb = new ScheduleForm();
            scheduleForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            PanelForm1.Controls.Add(scheduleForm_Vrb);
            scheduleForm_Vrb.Show();*/
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerForm());
            /*PanelForm1.Controls.Clear();
            CustomerForm customerForm_Vrb = new CustomerForm();
            customerForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            PanelForm1.Controls.Add(customerForm_Vrb);
            customerForm_Vrb.Show();*/
        }
    }
}
