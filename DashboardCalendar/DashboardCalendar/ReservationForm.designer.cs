/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 06/09/2021
 * Time: 1:20 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DashboardCalendar
{
	partial class ReservationForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.panel13 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.computebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.payDet = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.payMethod = new System.Windows.Forms.GroupBox();
            this.gcash = new System.Windows.Forms.RadioButton();
            this.bdo = new System.Windows.Forms.RadioButton();
            this.lblAdditional = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.GroupBox();
            this.deposit = new System.Windows.Forms.RadioButton();
            this.full = new System.Windows.Forms.RadioButton();
            this.balance = new System.Windows.Forms.Label();
            this.paid = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.paidDate = new System.Windows.Forms.DateTimePicker();
            this.total = new System.Windows.Forms.Label();
            this.additional = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reserveDet = new System.Windows.Forms.GroupBox();
            this.nupTime = new System.Windows.Forms.NumericUpDown();
            this.nupGuests = new System.Windows.Forms.NumericUpDown();
            this.addGuests = new System.Windows.Forms.Label();
            this.extra = new System.Windows.Forms.GroupBox();
            this.lightsSounds = new System.Windows.Forms.CheckBox();
            this.room = new System.Windows.Forms.CheckBox();
            this.type = new System.Windows.Forms.GroupBox();
            this.weddings = new System.Windows.Forms.RadioButton();
            this.smallMeets = new System.Windows.Forms.RadioButton();
            this.reserveDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.Label();
            this.timeExtension = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.CustomerInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.contactNo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.payDet.SuspendLayout();
            this.panel11.SuspendLayout();
            this.payMethod.SuspendLayout();
            this.payment.SuspendLayout();
            this.reserveDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGuests)).BeginInit();
            this.extra.SuspendLayout();
            this.type.SuspendLayout();
            this.CustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel13.Controls.Add(this.pictureBox1);
            this.panel13.Controls.Add(this.label2);
            resources.ApplyResources(this.panel13, "panel13");
            this.panel13.Name = "panel13";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::DashboardCalendar.Properties.Resources.logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.computebtn);
            this.panel1.Controls.Add(this.exitbtn);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.payDet);
            this.panel1.Controls.Add(this.reserveDet);
            this.panel1.Controls.Add(this.CustomerInfo);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // computebtn
            // 
            this.computebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.computebtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.computebtn, "computebtn");
            this.computebtn.Name = "computebtn";
            this.computebtn.UseVisualStyleBackColor = false;
            this.computebtn.Click += new System.EventHandler(this.computebtnClick);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.exitbtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.exitbtn, "exitbtn");
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.savebtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.savebtn, "savebtn");
            this.savebtn.Name = "savebtn";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtnClick);
            // 
            // payDet
            // 
            this.payDet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.payDet.Controls.Add(this.panel11);
            this.payDet.Controls.Add(this.lblSubtotal);
            this.payDet.Controls.Add(this.payMethod);
            this.payDet.Controls.Add(this.lblAdditional);
            this.payDet.Controls.Add(this.lblTotal);
            this.payDet.Controls.Add(this.lblBalance);
            this.payDet.Controls.Add(this.payment);
            this.payDet.Controls.Add(this.balance);
            this.payDet.Controls.Add(this.paid);
            this.payDet.Controls.Add(this.txtPaid);
            this.payDet.Controls.Add(this.paidDate);
            this.payDet.Controls.Add(this.total);
            this.payDet.Controls.Add(this.additional);
            this.payDet.Controls.Add(this.subTotal);
            this.payDet.Controls.Add(this.label1);
            resources.ApplyResources(this.payDet, "payDet");
            this.payDet.Name = "payDet";
            this.payDet.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.lblSubtotal, "lblSubtotal");
            this.lblSubtotal.Name = "lblSubtotal";
            // 
            // payMethod
            // 
            this.payMethod.Controls.Add(this.gcash);
            this.payMethod.Controls.Add(this.bdo);
            resources.ApplyResources(this.payMethod, "payMethod");
            this.payMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.payMethod.Name = "payMethod";
            this.payMethod.TabStop = false;
            // 
            // gcash
            // 
            resources.ApplyResources(this.gcash, "gcash");
            this.gcash.Name = "gcash";
            this.gcash.TabStop = true;
            this.gcash.UseVisualStyleBackColor = true;
            // 
            // bdo
            // 
            resources.ApplyResources(this.bdo, "bdo");
            this.bdo.Name = "bdo";
            this.bdo.TabStop = true;
            this.bdo.UseVisualStyleBackColor = true;
            // 
            // lblAdditional
            // 
            this.lblAdditional.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.lblAdditional, "lblAdditional");
            this.lblAdditional.Name = "lblAdditional";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.lblBalance, "lblBalance");
            this.lblBalance.Name = "lblBalance";
            // 
            // payment
            // 
            this.payment.Controls.Add(this.deposit);
            this.payment.Controls.Add(this.full);
            resources.ApplyResources(this.payment, "payment");
            this.payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.payment.Name = "payment";
            this.payment.TabStop = false;
            // 
            // deposit
            // 
            resources.ApplyResources(this.deposit, "deposit");
            this.deposit.Name = "deposit";
            this.deposit.TabStop = true;
            this.deposit.UseVisualStyleBackColor = true;
            // 
            // full
            // 
            resources.ApplyResources(this.full, "full");
            this.full.Name = "full";
            this.full.TabStop = true;
            this.full.UseVisualStyleBackColor = true;
            // 
            // balance
            // 
            resources.ApplyResources(this.balance, "balance");
            this.balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.balance.Name = "balance";
            // 
            // paid
            // 
            resources.ApplyResources(this.paid, "paid");
            this.paid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paid.Name = "paid";
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtPaid, "txtPaid");
            this.txtPaid.Name = "txtPaid";
            // 
            // paidDate
            // 
            resources.ApplyResources(this.paidDate, "paidDate");
            this.paidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.paidDate.Name = "paidDate";
            // 
            // total
            // 
            resources.ApplyResources(this.total, "total");
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.total.Name = "total";
            // 
            // additional
            // 
            resources.ApplyResources(this.additional, "additional");
            this.additional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.additional.Name = "additional";
            // 
            // subTotal
            // 
            resources.ApplyResources(this.subTotal, "subTotal");
            this.subTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subTotal.Name = "subTotal";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Name = "label1";
            // 
            // reserveDet
            // 
            this.reserveDet.Controls.Add(this.nupTime);
            this.reserveDet.Controls.Add(this.nupGuests);
            this.reserveDet.Controls.Add(this.addGuests);
            this.reserveDet.Controls.Add(this.extra);
            this.reserveDet.Controls.Add(this.type);
            this.reserveDet.Controls.Add(this.reserveDate);
            this.reserveDet.Controls.Add(this.comboBox);
            this.reserveDet.Controls.Add(this.time);
            this.reserveDet.Controls.Add(this.timeExtension);
            this.reserveDet.Controls.Add(this.date);
            resources.ApplyResources(this.reserveDet, "reserveDet");
            this.reserveDet.Name = "reserveDet";
            this.reserveDet.TabStop = false;
            // 
            // nupTime
            // 
            this.nupTime.BackColor = System.Drawing.Color.Gainsboro;
            this.nupTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.nupTime, "nupTime");
            this.nupTime.Name = "nupTime";
            // 
            // nupGuests
            // 
            this.nupGuests.BackColor = System.Drawing.Color.Gainsboro;
            this.nupGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.nupGuests, "nupGuests");
            this.nupGuests.Name = "nupGuests";
            // 
            // addGuests
            // 
            resources.ApplyResources(this.addGuests, "addGuests");
            this.addGuests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addGuests.Name = "addGuests";
            // 
            // extra
            // 
            this.extra.Controls.Add(this.lightsSounds);
            this.extra.Controls.Add(this.room);
            resources.ApplyResources(this.extra, "extra");
            this.extra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.extra.Name = "extra";
            this.extra.TabStop = false;
            // 
            // lightsSounds
            // 
            resources.ApplyResources(this.lightsSounds, "lightsSounds");
            this.lightsSounds.Name = "lightsSounds";
            this.lightsSounds.UseVisualStyleBackColor = true;
            // 
            // room
            // 
            resources.ApplyResources(this.room, "room");
            this.room.Name = "room";
            this.room.UseVisualStyleBackColor = true;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            resources.ApplyResources(this.type, "type");
            this.type.Controls.Add(this.weddings);
            this.type.Controls.Add(this.smallMeets);
            this.type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.type.Name = "type";
            this.type.TabStop = false;
            // 
            // weddings
            // 
            resources.ApplyResources(this.weddings, "weddings");
            this.weddings.Name = "weddings";
            this.weddings.TabStop = true;
            this.weddings.UseVisualStyleBackColor = true;
            // 
            // smallMeets
            // 
            resources.ApplyResources(this.smallMeets, "smallMeets");
            this.smallMeets.Name = "smallMeets";
            this.smallMeets.TabStop = true;
            this.smallMeets.UseVisualStyleBackColor = true;
            // 
            // reserveDate
            // 
            this.reserveDate.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.reserveDate, "reserveDate");
            this.reserveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reserveDate.Name = "reserveDate";
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox, "comboBox");
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            resources.GetString("comboBox.Items"),
            resources.GetString("comboBox.Items1"),
            resources.GetString("comboBox.Items2")});
            this.comboBox.Name = "comboBox";
            this.comboBox.UseWaitCursor = true;
            // 
            // time
            // 
            resources.ApplyResources(this.time, "time");
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.time.Name = "time";
            // 
            // timeExtension
            // 
            resources.ApplyResources(this.timeExtension, "timeExtension");
            this.timeExtension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeExtension.Name = "timeExtension";
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.date.Name = "date";
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.Controls.Add(this.label3);
            this.CustomerInfo.Controls.Add(this.searchbtn);
            this.CustomerInfo.Controls.Add(this.txtAddress);
            this.CustomerInfo.Controls.Add(this.txtEmail);
            this.CustomerInfo.Controls.Add(this.address);
            this.CustomerInfo.Controls.Add(this.email);
            this.CustomerInfo.Controls.Add(this.txtContactNo);
            this.CustomerInfo.Controls.Add(this.contactNo);
            this.CustomerInfo.Controls.Add(this.txtName);
            resources.ApplyResources(this.CustomerInfo, "CustomerInfo");
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Name = "label3";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchbtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.searchbtn, "searchbtn");
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Name = "txtAddress";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Name = "txtEmail";
            // 
            // address
            // 
            resources.ApplyResources(this.address, "address");
            this.address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.address.Name = "address";
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.Name = "email";
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtContactNo, "txtContactNo");
            this.txtContactNo.ForeColor = System.Drawing.Color.Black;
            this.txtContactNo.Name = "txtContactNo";
            // 
            // contactNo
            // 
            resources.ApplyResources(this.contactNo, "contactNo");
            this.contactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contactNo.Name = "contactNo";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HideSelection = false;
            this.txtName.Name = "txtName";
            // 
            // ReservationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.payDet.ResumeLayout(false);
            this.payDet.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.payMethod.ResumeLayout(false);
            this.payment.ResumeLayout(false);
            this.reserveDet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGuests)).EndInit();
            this.extra.ResumeLayout(false);
            this.type.ResumeLayout(false);
            this.CustomerInfo.ResumeLayout(false);
            this.CustomerInfo.PerformLayout();
            this.ResumeLayout(false);

		}
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button computebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.GroupBox payDet;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.GroupBox payMethod;
        private System.Windows.Forms.RadioButton gcash;
        private System.Windows.Forms.RadioButton bdo;
        private System.Windows.Forms.Label lblAdditional;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox payment;
        private System.Windows.Forms.RadioButton deposit;
        private System.Windows.Forms.RadioButton full;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label paid;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.DateTimePicker paidDate;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label additional;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox reserveDet;
        private System.Windows.Forms.NumericUpDown nupTime;
        private System.Windows.Forms.NumericUpDown nupGuests;
        private System.Windows.Forms.Label addGuests;
        private System.Windows.Forms.GroupBox extra;
        private System.Windows.Forms.CheckBox lightsSounds;
        private System.Windows.Forms.CheckBox room;
        private System.Windows.Forms.GroupBox type;
        private System.Windows.Forms.RadioButton weddings;
        private System.Windows.Forms.RadioButton smallMeets;
        private System.Windows.Forms.DateTimePicker reserveDate;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label timeExtension;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.GroupBox CustomerInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label contactNo;
        private System.Windows.Forms.TextBox txtName;
    }
}
