/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 06/09/2021
 * Time: 1:20 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace DashboardCalendar
{
    /// <summary>
    /// Description of ReservationForm.
    /// </summary>
    public partial class ReservationForm : Form
	{
		public ReservationForm()
		{
			InitializeComponent();

		}
		
		void computebtnClick(object sender, EventArgs e)
		{
			double stotal = 0;
			double price = 0;
			int num = int.Parse(nupTime.Text);
			int num1 = int.Parse(nupGuests.Text);
			
			//If no chosen Event Type or Time
			if (!smallMeets.Checked && !weddings.Checked || comboBox.Text == "")
			{
				MessageBox.Show("INCOMPLETE RESERVATION DETAILS");
			}
			else
			{
				//Subtotal
				if (smallMeets.Checked && comboBox.Text == "DAYTIME")
				{
					stotal += 8500.00;
				}
				else if (smallMeets.Checked && comboBox.Text == "OVERNIGHT")
				{
					stotal += 12000.00;
				}
				else if (smallMeets.Checked && comboBox.Text == "WHOLE DAY")
				{
					stotal += 20000.00;
				}
				else if (weddings.Checked && comboBox.Text == "DAYTIME")
				{
					stotal += 12000.00;
				}
				else if (weddings.Checked && comboBox.Text == "OVERNIGHT")
				{
					stotal += 16000.00;
				}
				else if (weddings.Checked && comboBox.Text == "WhHOLE DAY")
				{
					stotal += 25000.00;
				}
				
				//Additional - Extra
				if (room.Checked && !lightsSounds.Checked)
				{
					price += 2500;
				}
				else if (lightsSounds.Checked && !room.Checked)
				{
					price += 1000;
				}
				else if (room.Checked && lightsSounds.Checked)
				{
					price += 3500;
				}
				
				//Aditional - Time
				if (smallMeets.Checked)
				{
					price += num * 1000;
				}
				else if (weddings.Checked)
				{
					price += num * 1500;
				}
				
				//Additional - Guests
				if (num1 >= 1 && num1 <= 10) 
				{
					price += 2000;
				}
				else if (num1 >= 11 && num1 <= 20) 
				{
					price += 4000;
				}
				else if (num1 >= 21 && num1 <= 30) 
				{
					price += 6000;
				}
				else if (num1 >= 31 && num1 <= 40) 
				{
					price += 8000;
				}
				else if (num1 >= 41 && num1 <= 50) 
				{
					price += 10000;
				}
				else if (num1 >= 51 && num1 <= 60) 
				{
					price += 12000;
				}
				else if (num1 >= 61 && num1 <= 70) 
				{
					price += 14000;
				}
				else if (num1 >= 71 && num1 <= 80) 
				{
					price += 16000;
				}
				else if (num1 >= 81 && num1 <= 90) 
				{
					price += 18000;
				}
				else if (num1 >= 91 && num1 <= 100) 
				{
					price += 20000;
				}
				
				//Subtotal
				lblSubtotal.Text = stotal.ToString("C");
				
				//Additional
				lblAdditional.Text = price.ToString("C");
				
				//Total 
				double tot = stotal + price;
				lblTotal.Text = tot.ToString("C");
				
				//Balance
				double x,y;
				if(double.TryParse (txtPaid.Text, out x) && x > 0)
				{
					y = x;
					double bal = tot - x;
					lblBalance.Text = bal.ToString("C");
				}
			}
		}
		
		//To only accept a number in Contact Number
		void TxtContactNoKeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}
		
		//To only accept a number in Paid
		void TxtPaidKeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}
		
		void savebtnClick(object sender, EventArgs e)
		{	
			//If provided incomplete details			
			if (txtName.Text == "" || txtContactNo.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || 
			    lblBalance.Text == "" || (!full.Checked && !deposit.Checked) || (!bdo.Checked && !gcash.Checked))
			{
				MessageBox.Show("INCOMPLTER DETAILS");
			}
			else
			{
				txtName.Clear();
				txtContactNo.Clear();
				txtAddress.Clear();
				txtEmail.Clear();
				txtPaid.Clear();
				lblSubtotal.Text = "";
				lblAdditional.Text = "";
				lblTotal.Text = "";
				lblBalance.Text = "";
				smallMeets.Checked = false;
				weddings.Checked = false;
				full.Checked = false;
				deposit.Checked = false;
				bdo.Checked = false;
				gcash.Checked = false;
				room.Checked = false;
				lightsSounds.Checked = false;
				comboBox.Text = string.Empty;
				nupTime.Value = 0;
				nupGuests.Value = 0;
			}
		}

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.btnDashboard.Image = global::DashboardCalendar.Properties.Resources.wdashboard;
            form.btnSchedule.Image = global::DashboardCalendar.Properties.Resources.schedule;
            form.btnCustomer.Image = global::DashboardCalendar.Properties.Resources.customer;
            form.btnAddR.Image = global::DashboardCalendar.Properties.Resources.wform;
            form.btnAddR.BackColor = Color.FromArgb(26, 26, 26);
        }

    }
}
