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
        private Button currentBtn;

        public Form1()
        {
            InitializeComponent();
            OpenForm(new DashboardForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w , h);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDay.Text = DateTime.Now.ToString("dd");
            lblMonth.Text = DateTime.Now.ToString("MMMM").ToUpper();
            lblYear.Text = DateTime.Now.ToString("yyyy");

            Time.Text = DateTime.Now.ToString("hh : mm tt");
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



        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    DisableButton();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.DimGray;
                    currentBtn.ForeColor = Color.Black;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control prevBtn in panel1.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(26, 26, 26);
                    prevBtn.ForeColor = Color.White;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new DashboardForm());
            ActivateButton(sender);
            btnDashboard.Image = global::DashboardCalendar.Properties.Resources.dashboard;
            btnSchedule.Image = global::DashboardCalendar.Properties.Resources.schedule;
            btnCustomer.Image = global::DashboardCalendar.Properties.Resources.customer;
            btnAddR.Image = global::DashboardCalendar.Properties.Resources.wform;
            btnLogOut.BackColor = Color.FromArgb(140, 198, 63);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenForm(new ScheduleForm());
            ActivateButton(sender);
            btnDashboard.Image = global::DashboardCalendar.Properties.Resources.wdashboard;
            btnSchedule.Image = global::DashboardCalendar.Properties.Resources.bschedule;
            btnCustomer.Image = global::DashboardCalendar.Properties.Resources.customer;
            btnAddR.Image = global::DashboardCalendar.Properties.Resources.wform;
            btnLogOut.BackColor = Color.FromArgb(140, 198, 63);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerForm());
            ActivateButton(sender);
            btnDashboard.Image = global::DashboardCalendar.Properties.Resources.wdashboard;
            btnSchedule.Image = global::DashboardCalendar.Properties.Resources.schedule;
            btnCustomer.Image = global::DashboardCalendar.Properties.Resources.bcustomer;
            btnAddR.Image = global::DashboardCalendar.Properties.Resources.wform;
            btnLogOut.BackColor = Color.FromArgb(140, 198, 63);
        }

        private void btnAddR_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnDashboard.Image = global::DashboardCalendar.Properties.Resources.wdashboard;
            btnSchedule.Image = global::DashboardCalendar.Properties.Resources.schedule;
            btnCustomer.Image = global::DashboardCalendar.Properties.Resources.customer;
            btnAddR.Image = global::DashboardCalendar.Properties.Resources.form;
            btnLogOut.BackColor = Color.FromArgb(140, 198, 63);

            ReservationForm rForm = new ReservationForm();
            rForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btnLogOut.BackColor = Color.FromArgb(140, 198, 63);
            btnLogOut.ForeColor = Color.White;
            btnDashboard.Image = global::DashboardCalendar.Properties.Resources.wdashboard;
            btnSchedule.Image = global::DashboardCalendar.Properties.Resources.schedule;
            btnCustomer.Image = global::DashboardCalendar.Properties.Resources.customer;
            btnAddR.Image = global::DashboardCalendar.Properties.Resources.wform;

            DialogResult dResult;
            dResult = MessageBox.Show("ARE YOU SURE TO LOG OUT?", "", MessageBoxButtons.YesNo);
            /*if (dResult == DialogResult.No) 
            {
                //Cancel
            }*/
        }
    }
}
