/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 06/09/2021
 * Time: 8:53 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.ComponentModel;

namespace DashboardCalendar
{
	public partial class LoginForm : Form
	{
		private string imagePath = @".\img";
		
		private string user = @"\user.png";
		private string userBlue = @"\userblue.png";
		private string padlock = @"\padlock.png";
		private string padlockBlue = @"\padlockblue.png";
		
		OleDbConnection connection = new OleDbConnection();

		public LoginForm()
		{
			InitializeComponent();
			connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\database.accdb;Persist Security Info=False;";
			
			try {
				connection.Open();
				OleDbCommand cmd = new OleDbCommand();
				cmd.Connection = connection;
				cmd.CommandText = "select * from rememberTbl";
				
				OleDbDataReader rd = cmd.ExecuteReader();
				
				if (rd.HasRows) {
					
					while (rd.Read())
                    {
						userIDTxt.Text = rd.GetString(1);
						passwordTxt.Text = rd.GetString(2);
					}
					
					
				}
                else
                {
					userIDTxt.Text = "User ID";
					passwordTxt.Text = "Password";
				}
				rd.Close();
			} catch (Exception ex)
            {
				MessageBox.Show("Failed Due To: " + ex.Message);
			}
            finally
            {
				connection.Close();
			}
		}
		
		void userOriginal()
		{
			userPicturebox.Image = Image.FromFile(imagePath + user);
			userIDTxt.ForeColor = Color.Silver;
			userLinePanel.BackColor = Color.Silver;
		}
		
		void userColorChange()
		{
			userPicturebox.Image = Image.FromFile(imagePath + userBlue);
			userIDTxt.ForeColor = Color.FromArgb(78, 184, 206);
			userLinePanel.BackColor = Color.FromArgb(78, 184, 206);
		}
		
		void passwordOriginal()
		{
			lockPicturebox.Image = Image.FromFile(imagePath + padlock);
			passwordTxt.ForeColor = Color.Silver;
			passLinePanel.BackColor = Color.Silver;
		}
		
		void passwordColorChange()
		{
			lockPicturebox.Image = Image.FromFile(imagePath + padlockBlue);
			passwordTxt.ForeColor = Color.FromArgb(78, 184, 206);
			passLinePanel.BackColor = Color.FromArgb(78, 184, 206);
		}
		
		void UserIDTxtClick(object sender, EventArgs e)
		{
			if (userIDTxt.Text == "User ID") {
				userIDTxt.Clear();
			}
			
			if (passwordTxt.Text == "") {
				passwordTxt.Text = "Password";
			}
			
			userColorChange();
			passwordOriginal();
		}
		
		void PasswordTxtClick(object sender, EventArgs e)
		{
			if (passwordTxt.Text == "Password") {
				passwordTxt.Clear();
			}
			
			if (userIDTxt.Text == "") {
				userIDTxt.Text = "User ID";
			}
			
			passwordColorChange();
			userOriginal();
		}
		
		void ExitBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void FrmLoginClick(object sender, EventArgs e)
		{
			userOriginal();
			passwordOriginal();
		}
		
		void LoginBtnClick(object sender, EventArgs e)
		{
			connection.Open();
			OleDbCommand comm = new OleDbCommand();
			comm.Connection = connection;
			comm.CommandText = "select * from loginTbl where Username='" + userIDTxt.Text + "' and Password = '" + passwordTxt.Text + "'";
			
			OleDbDataReader reader = comm.ExecuteReader();
			int count = 0;
			while (reader.Read()) {
				count += 1;
			}
			
			reader.Close();
			
			if (count == 1) {
				if (rememberCheck.Checked) {
					try {
						OleDbCommand cmd = new OleDbCommand();
						cmd.Connection = connection;
						cmd.CommandText = "select * from rememberTbl where Username='" + userIDTxt.Text + "' and Password = '" + passwordTxt.Text + "'";
						OleDbDataReader rd = cmd.ExecuteReader();
						
						int i = 0;
						
						while (rd.Read()) {
							i += 1;
						}
						
						rd.Close();
						
						if (i == 0) {
							cmd.CommandText = "insert into rememberTbl (Username, [Password]) values (@Username, @Password)";
							cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = userIDTxt.Text;
							cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = passwordTxt.Text;
							cmd.ExecuteNonQuery();
						} else {
							cmd.CommandText = "UPDATE rememberTbl SET [Username] = '" + userIDTxt.Text + "' and [Password]='" + passwordTxt.Text + "'";
							cmd.ExecuteNonQuery();
						}
						
					} catch (Exception ex) {
						MessageBox.Show("Failed due to " + ex.Message);
					} finally {
						connection.Close();
					}
				} else {
					userIDTxt.Text = "User ID";
					passwordTxt.Text = "Password";
				}
				MessageBox.Show("Login Successfully");
				this.Hide();
                Form form = new Form();
                form.Show();
			}
            else if (count > 1)
            {
				MessageBox.Show("Duplicate Username and Password");
			}
            else
            {
				MessageBox.Show("Username or Password is not Correct");
			}
			
			
			connection.Close();
		}

		void UserIDTxtPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyData == Keys.Tab)
            {
				if (userIDTxt.Text == "")
                {
					userIDTxt.Text = "User ID";
				}
				
				userOriginal();
			}
		}
		
		void PasswordTxtPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyData == Keys.Tab)
            {
				if (passwordTxt.Text == "")
                {
					passwordTxt.Text = "Password";
				}
				passwordOriginal();
			}
		}
		void ForgotPassLabelClick(object sender, EventArgs e)
		{
			this.Hide();
			ResetPassword reset = new ResetPassword();
			reset.Show();
		}
	}
}
