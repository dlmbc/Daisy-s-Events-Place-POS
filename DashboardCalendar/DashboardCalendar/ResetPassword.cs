/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 12/09/2021
 * Time: 2:06 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.ComponentModel;

namespace DashboardCalendar
{
	public partial class ResetPassword : Form
	{
		OleDbConnection connection = new OleDbConnection();
		
		public ResetPassword()
		{
			InitializeComponent();
			connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\database.accdb;Persist Security Info=False;";
		}
		
		void BtnLoginClick(object sender, EventArgs e)
		{
			this.Hide();
			LoginForm log = new LoginForm();
			log.Show();
		}
		void ConfirmBtnClick(object sender, EventArgs e)
		{
			if (userTxt.Text != "" && newPassText.Text != "" && confirmPassTxt.Text != "")
            {
				if (newPassText.Text == confirmPassTxt.Text)
                {
					try
                    {
						connection.Open();
						OleDbCommand comm = new OleDbCommand();
						comm.Connection = connection;
						comm.CommandText = "select * from loginTbl where Username='" + userTxt.Text + "'";
			
						OleDbDataReader reader = comm.ExecuteReader();
						int count = 0;
						while (reader.Read())
                        {
							count += 1;
					    }
						
					    reader.Close();
						
						if (count == 1)
                        {
							OleDbCommand command = new OleDbCommand();
							command.Connection = connection;
							command.CommandText = "UPDATE loginTbl SET [Password] = '" + confirmPassTxt.Text + "' WHERE [Username]='" + userTxt.Text + "'";
							command.ExecuteNonQuery();
							
							MessageBox.Show("Password reset successfully");
							
							userTxt.Clear();
							newPassText.Clear();
							confirmPassTxt.Clear();
							
							userTxt.Focus();
							
						}
                        else if (count > 1)
                        {
							MessageBox.Show("");
						}
                        else
                        {
							MessageBox.Show("Not Found");
							userTxt.Focus();
						}
				
					}
                    catch (Exception ex)
                    {
						MessageBox.Show("Failed due to " + ex.Message);
				
					} finally
                    {
						connection.Close();
					}
				}
                else
                {
					MessageBox.Show("Password Not Match");
					confirmPassTxt.Clear();
					confirmPassTxt.Focus();
				}
			}
            else
            {
				MessageBox.Show("Fill the form");
				if (userTxt.Text == "")
                {
					userTxt.Focus();
				}
                else if (newPassText.Text == "")
                {
					newPassText.Focus();
				}
                else if (confirmPassTxt.Text == "")
                {
					confirmPassTxt.Focus();
				}
			}
		}
	}
}
