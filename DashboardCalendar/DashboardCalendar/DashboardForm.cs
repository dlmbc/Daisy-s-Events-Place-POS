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
    public partial class DashboardForm : Form
    {
        List<FlowLayoutPanel> listDay = new List<FlowLayoutPanel>();
        DateTime currentDate = DateTime.Today;

        public DashboardForm()
        {
            InitializeComponent();
            PrintCalendar();
            DisplayCurrentMonth();
        }

        public int firstDayOfMonth()
        {
            DateTime firstDay = new DateTime(currentDate.Year, currentDate.Month, 1);
            return (int)firstDay.DayOfWeek + 1;
        }

        public int totalDayOfMonth()
        {
            int currentMontFirstDay = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            return currentMontFirstDay;
        }

        private void DisplayCurrentMonth()
        {
            lblMonths.Text = currentDate.ToString("MMMM yyyy").ToUpper();
            addDayToFl(firstDayOfMonth(), totalDayOfMonth());
        }

        private void PreviousMonth()
        {
            currentDate = currentDate.AddMonths(-1);
            DisplayCurrentMonth();
        }

        private void NextMonth()
        {
            currentDate = currentDate.AddMonths(1);
            DisplayCurrentMonth();
        }

        public void PrintCalendar()
        {
            listDay.Clear();
            datePanel.Controls.Clear();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    FlowLayoutPanel fl = new FlowLayoutPanel();
                    fl.Size = new Size(145, 72);
                    fl.BorderStyle = BorderStyle.None;
                    fl.Location = new Point(0 + (j * 145), 0 + (i * 72));
                    fl.Margin = new Padding(9, 0, 2, 10);
                    datePanel.Controls.Add(fl);
                    listDay.Add(fl);
                }
            }
        }

        public void addDayToFl(int startDay, int endDate)
        {
            string hexColor = "#E6E6E6";
            string hexColor1 = "#808080";
            Color bColor = System.Drawing.ColorTranslator.FromHtml(hexColor);
            Color cColor = System.Drawing.ColorTranslator.FromHtml(hexColor1);

            foreach (FlowLayoutPanel fl in listDay)
            {
                fl.Controls.Clear();
                fl.BackColor = bColor;
            }

            for (int i = 1; i <= endDate; i++)
            {
                Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Size = new Size(145, 30);
                lbl.Text = i.ToString();
                lbl.Font = new Font("Montserrat", 14);
                listDay[(i - 1) + (startDay - 1)].Controls.Add(lbl);

                if (new DateTime(currentDate.Year, currentDate.Month, i) == DateTime.Today)
                {
                    listDay[(startDay - 1) + (i - 1)].BackColor = cColor;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PreviousMonth();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextMonth();
        }
    }
}
