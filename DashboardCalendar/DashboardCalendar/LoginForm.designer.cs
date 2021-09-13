/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 06/09/2021
 * Time: 8:53 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DashboardCalendar
{
    partial class LoginForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel logoContainer;
        private System.Windows.Forms.Panel loginContainer;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox userIDTxt;
        private System.Windows.Forms.Panel userLinePanel;
        private System.Windows.Forms.Panel passLinePanel;
        private System.Windows.Forms.PictureBox lockPicturebox;
        private System.Windows.Forms.PictureBox userPicturebox;
        private System.Windows.Forms.Label forgotPassLabel;
        private System.Windows.Forms.CheckBox rememberCheck;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.logoContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginContainer = new System.Windows.Forms.Panel();
            this.rememberCheck = new System.Windows.Forms.CheckBox();
            this.forgotPassLabel = new System.Windows.Forms.Label();
            this.lockPicturebox = new System.Windows.Forms.PictureBox();
            this.userPicturebox = new System.Windows.Forms.PictureBox();
            this.passLinePanel = new System.Windows.Forms.Panel();
            this.userLinePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.userIDTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.logoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicturebox)).BeginInit();
            this.userLinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoContainer
            // 
            this.logoContainer.Controls.Add(this.pictureBox1);
            this.logoContainer.Controls.Add(this.label1);
            this.logoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoContainer.Location = new System.Drawing.Point(0, 0);
            this.logoContainer.Name = "logoContainer";
            this.logoContainer.Size = new System.Drawing.Size(420, 100);
            this.logoContainer.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daisy\'s Events Place";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.FrmLoginClick);
            // 
            // loginContainer
            // 
            this.loginContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginContainer.Controls.Add(this.rememberCheck);
            this.loginContainer.Controls.Add(this.forgotPassLabel);
            this.loginContainer.Controls.Add(this.lockPicturebox);
            this.loginContainer.Controls.Add(this.userPicturebox);
            this.loginContainer.Controls.Add(this.passLinePanel);
            this.loginContainer.Controls.Add(this.userLinePanel);
            this.loginContainer.Controls.Add(this.passwordTxt);
            this.loginContainer.Controls.Add(this.userIDTxt);
            this.loginContainer.Controls.Add(this.loginBtn);
            this.loginContainer.Location = new System.Drawing.Point(57, 119);
            this.loginContainer.Name = "loginContainer";
            this.loginContainer.Size = new System.Drawing.Size(307, 291);
            this.loginContainer.TabIndex = 1;
            this.loginContainer.Click += new System.EventHandler(this.FrmLoginClick);
            // 
            // rememberCheck
            // 
            this.rememberCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rememberCheck.Location = new System.Drawing.Point(29, 173);
            this.rememberCheck.Name = "rememberCheck";
            this.rememberCheck.Size = new System.Drawing.Size(104, 24);
            this.rememberCheck.TabIndex = 8;
            this.rememberCheck.Text = "Remember Me";
            this.rememberCheck.UseVisualStyleBackColor = true;
            // 
            // forgotPassLabel
            // 
            this.forgotPassLabel.AutoSize = true;
            this.forgotPassLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.forgotPassLabel.Location = new System.Drawing.Point(185, 178);
            this.forgotPassLabel.Name = "forgotPassLabel";
            this.forgotPassLabel.Size = new System.Drawing.Size(92, 13);
            this.forgotPassLabel.TabIndex = 6;
            this.forgotPassLabel.Text = "Forgot Password?";
            this.forgotPassLabel.Click += new System.EventHandler(this.ForgotPassLabelClick);
            // 
            // lockPicturebox
            // 
            this.lockPicturebox.BackColor = System.Drawing.Color.Transparent;
            this.lockPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("lockPicturebox.Image")));
            this.lockPicturebox.Location = new System.Drawing.Point(29, 115);
            this.lockPicturebox.Name = "lockPicturebox";
            this.lockPicturebox.Size = new System.Drawing.Size(30, 30);
            this.lockPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockPicturebox.TabIndex = 5;
            this.lockPicturebox.TabStop = false;
            // 
            // userPicturebox
            // 
            this.userPicturebox.BackColor = System.Drawing.Color.Transparent;
            this.userPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("userPicturebox.Image")));
            this.userPicturebox.Location = new System.Drawing.Point(29, 44);
            this.userPicturebox.Name = "userPicturebox";
            this.userPicturebox.Size = new System.Drawing.Size(30, 30);
            this.userPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicturebox.TabIndex = 2;
            this.userPicturebox.TabStop = false;
            // 
            // passLinePanel
            // 
            this.passLinePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passLinePanel.Location = new System.Drawing.Point(28, 151);
            this.passLinePanel.Name = "passLinePanel";
            this.passLinePanel.Size = new System.Drawing.Size(248, 1);
            this.passLinePanel.TabIndex = 4;
            // 
            // userLinePanel
            // 
            this.userLinePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.userLinePanel.Controls.Add(this.panel1);
            this.userLinePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userLinePanel.Location = new System.Drawing.Point(28, 80);
            this.userLinePanel.Name = "userLinePanel";
            this.userLinePanel.Size = new System.Drawing.Size(248, 1);
            this.userLinePanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 1);
            this.panel1.TabIndex = 9;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.Silver;
            this.passwordTxt.Location = new System.Drawing.Point(70, 120);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(207, 20);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.Text = "Password";
            this.passwordTxt.Click += new System.EventHandler(this.PasswordTxtClick);
            this.passwordTxt.Enter += new System.EventHandler(this.PasswordTxtClick);
            this.passwordTxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PasswordTxtPreviewKeyDown);
            // 
            // userIDTxt
            // 
            this.userIDTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.userIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTxt.ForeColor = System.Drawing.Color.Silver;
            this.userIDTxt.Location = new System.Drawing.Point(70, 49);
            this.userIDTxt.Name = "userIDTxt";
            this.userIDTxt.Size = new System.Drawing.Size(207, 20);
            this.userIDTxt.TabIndex = 1;
            this.userIDTxt.Text = "User ID";
            this.userIDTxt.Click += new System.EventHandler(this.UserIDTxtClick);
            this.userIDTxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.UserIDTxtPreviewKeyDown);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.loginBtn.Location = new System.Drawing.Point(28, 221);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(248, 28);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "LOG IN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtnClick);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(173, 425);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 30);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(420, 470);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginContainer);
            this.Controls.Add(this.logoContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(7, 46);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.Click += new System.EventHandler(this.FrmLoginClick);
            this.logoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginContainer.ResumeLayout(false);
            this.loginContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicturebox)).EndInit();
            this.userLinePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
