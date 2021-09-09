namespace DashboardCalendar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMonths = new System.Windows.Forms.Label();
            this.pnlSun = new System.Windows.Forms.Panel();
            this.lblSun = new System.Windows.Forms.Label();
            this.pnlMon = new System.Windows.Forms.Panel();
            this.lblMon = new System.Windows.Forms.Label();
            this.pnlTues = new System.Windows.Forms.Panel();
            this.lblTues = new System.Windows.Forms.Label();
            this.pnlWed = new System.Windows.Forms.Panel();
            this.lblWed = new System.Windows.Forms.Label();
            this.pnlThurs = new System.Windows.Forms.Panel();
            this.lblThurs = new System.Windows.Forms.Label();
            this.pnlFri = new System.Windows.Forms.Panel();
            this.lblFri = new System.Windows.Forms.Label();
            this.pnlSat = new System.Windows.Forms.Panel();
            this.lblSat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSun.SuspendLayout();
            this.pnlMon.SuspendLayout();
            this.pnlTues.SuspendLayout();
            this.pnlWed.SuspendLayout();
            this.pnlThurs.SuspendLayout();
            this.pnlFri.SuspendLayout();
            this.pnlSat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 770);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(256, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(506, 114);
            this.panel4.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::DashboardCalendar.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(0, 730);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(234, 40);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "   Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::DashboardCalendar.Properties.Resources.customer;
            this.btnCustomer.Location = new System.Drawing.Point(0, 216);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(234, 40);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "    Customer";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Image = global::DashboardCalendar.Properties.Resources.schedule;
            this.btnSchedule.Location = new System.Drawing.Point(0, 176);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(234, 40);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "   Schedule";
            this.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchedule.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Silver;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnDashboard.Image = global::DashboardCalendar.Properties.Resources.dashboard;
            this.btnDashboard.Location = new System.Drawing.Point(0, 136);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(234, 40);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 22);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 2);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::DashboardCalendar.Properties.Resources.logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Berlin Sans FB Demi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(248, 42);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(65, 43);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "00";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.panel5.Location = new System.Drawing.Point(314, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 66);
            this.panel5.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMonth.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(333, 32);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(169, 33);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "SEPTEMBER";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblYear.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(333, 65);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(67, 33);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "2021";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Time.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(1252, 50);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(87, 33);
            this.Time.TabIndex = 5;
            this.Time.Text = "12 : 00";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1330, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMonths
            // 
            this.lblMonths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMonths.Font = new System.Drawing.Font("Montserrat Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonths.Location = new System.Drawing.Point(413, 130);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(769, 58);
            this.lblMonths.TabIndex = 7;
            this.lblMonths.Text = "SEPTEMBER";
            this.lblMonths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSun
            // 
            this.pnlSun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlSun.Controls.Add(this.lblSun);
            this.pnlSun.Location = new System.Drawing.Point(256, 200);
            this.pnlSun.Name = "pnlSun";
            this.pnlSun.Size = new System.Drawing.Size(145, 35);
            this.pnlSun.TabIndex = 8;
            // 
            // lblSun
            // 
            this.lblSun.AutoSize = true;
            this.lblSun.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSun.ForeColor = System.Drawing.Color.White;
            this.lblSun.Location = new System.Drawing.Point(27, 6);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(92, 23);
            this.lblSun.TabIndex = 0;
            this.lblSun.Text = "SUNDAY";
            this.lblSun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMon
            // 
            this.pnlMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlMon.Controls.Add(this.lblMon);
            this.pnlMon.Location = new System.Drawing.Point(413, 200);
            this.pnlMon.Name = "pnlMon";
            this.pnlMon.Size = new System.Drawing.Size(145, 35);
            this.pnlMon.TabIndex = 9;
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMon.ForeColor = System.Drawing.Color.White;
            this.lblMon.Location = new System.Drawing.Point(25, 6);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(98, 23);
            this.lblMon.TabIndex = 0;
            this.lblMon.Text = "MONDAY";
            this.lblMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTues
            // 
            this.pnlTues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlTues.Controls.Add(this.lblTues);
            this.pnlTues.Location = new System.Drawing.Point(569, 200);
            this.pnlTues.Name = "pnlTues";
            this.pnlTues.Size = new System.Drawing.Size(145, 35);
            this.pnlTues.TabIndex = 9;
            // 
            // lblTues
            // 
            this.lblTues.AutoSize = true;
            this.lblTues.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTues.ForeColor = System.Drawing.Color.White;
            this.lblTues.Location = new System.Drawing.Point(25, 6);
            this.lblTues.Name = "lblTues";
            this.lblTues.Size = new System.Drawing.Size(100, 23);
            this.lblTues.TabIndex = 0;
            this.lblTues.Text = "TUESDAY";
            this.lblTues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWed
            // 
            this.pnlWed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlWed.Controls.Add(this.lblWed);
            this.pnlWed.Location = new System.Drawing.Point(725, 200);
            this.pnlWed.Name = "pnlWed";
            this.pnlWed.Size = new System.Drawing.Size(145, 35);
            this.pnlWed.TabIndex = 9;
            // 
            // lblWed
            // 
            this.lblWed.AutoSize = true;
            this.lblWed.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWed.ForeColor = System.Drawing.Color.White;
            this.lblWed.Location = new System.Drawing.Point(5, 6);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(136, 23);
            this.lblWed.TabIndex = 0;
            this.lblWed.Text = "WEDNESDAY";
            this.lblWed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlThurs
            // 
            this.pnlThurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlThurs.Controls.Add(this.lblThurs);
            this.pnlThurs.Location = new System.Drawing.Point(881, 200);
            this.pnlThurs.Name = "pnlThurs";
            this.pnlThurs.Size = new System.Drawing.Size(145, 35);
            this.pnlThurs.TabIndex = 9;
            // 
            // lblThurs
            // 
            this.lblThurs.AutoSize = true;
            this.lblThurs.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThurs.ForeColor = System.Drawing.Color.White;
            this.lblThurs.Location = new System.Drawing.Point(14, 6);
            this.lblThurs.Name = "lblThurs";
            this.lblThurs.Size = new System.Drawing.Size(117, 23);
            this.lblThurs.TabIndex = 0;
            this.lblThurs.Text = "THURSDAY";
            this.lblThurs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFri
            // 
            this.pnlFri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlFri.Controls.Add(this.lblFri);
            this.pnlFri.Location = new System.Drawing.Point(1037, 200);
            this.pnlFri.Name = "pnlFri";
            this.pnlFri.Size = new System.Drawing.Size(145, 35);
            this.pnlFri.TabIndex = 9;
            // 
            // lblFri
            // 
            this.lblFri.AutoSize = true;
            this.lblFri.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFri.ForeColor = System.Drawing.Color.White;
            this.lblFri.Location = new System.Drawing.Point(34, 6);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(81, 23);
            this.lblFri.TabIndex = 0;
            this.lblFri.Text = "FRIDAY";
            this.lblFri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSat
            // 
            this.pnlSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlSat.Controls.Add(this.lblSat);
            this.pnlSat.Location = new System.Drawing.Point(1194, 200);
            this.pnlSat.Name = "pnlSat";
            this.pnlSat.Size = new System.Drawing.Size(145, 35);
            this.pnlSat.TabIndex = 9;
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.ForeColor = System.Drawing.Color.White;
            this.lblSat.Location = new System.Drawing.Point(17, 6);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(115, 23);
            this.lblSat.TabIndex = 0;
            this.lblSat.Text = "SATURDAY";
            this.lblSat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // datePanel
            // 
            this.datePanel.Location = new System.Drawing.Point(248, 244);
            this.datePanel.Margin = new System.Windows.Forms.Padding(0);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(1107, 517);
            this.datePanel.TabIndex = 45;
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::DashboardCalendar.Properties.Resources.Next;
            this.btnNext.Location = new System.Drawing.Point(1194, 124);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 58);
            this.btnNext.TabIndex = 47;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = global::DashboardCalendar.Properties.Resources.Prev;
            this.btnPrevious.Location = new System.Drawing.Point(339, 130);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(62, 58);
            this.btnPrevious.TabIndex = 46;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 770);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.datePanel);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.pnlSat);
            this.Controls.Add(this.pnlFri);
            this.Controls.Add(this.pnlThurs);
            this.Controls.Add(this.pnlWed);
            this.Controls.Add(this.pnlTues);
            this.Controls.Add(this.pnlMon);
            this.Controls.Add(this.pnlSun);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSun.ResumeLayout(false);
            this.pnlSun.PerformLayout();
            this.pnlMon.ResumeLayout(false);
            this.pnlMon.PerformLayout();
            this.pnlTues.ResumeLayout(false);
            this.pnlTues.PerformLayout();
            this.pnlWed.ResumeLayout(false);
            this.pnlWed.PerformLayout();
            this.pnlThurs.ResumeLayout(false);
            this.pnlThurs.PerformLayout();
            this.pnlFri.ResumeLayout(false);
            this.pnlFri.PerformLayout();
            this.pnlSat.ResumeLayout(false);
            this.pnlSat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        protected internal System.Windows.Forms.Button btnDashboard;
        protected internal System.Windows.Forms.Button btnSchedule;
        protected internal System.Windows.Forms.Button btnCustomer;
        protected internal System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.Panel pnlSun;
        private System.Windows.Forms.Label lblSun;
        private System.Windows.Forms.Panel pnlMon;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Panel pnlTues;
        private System.Windows.Forms.Label lblTues;
        private System.Windows.Forms.Panel pnlWed;
        private System.Windows.Forms.Label lblWed;
        private System.Windows.Forms.Panel pnlThurs;
        private System.Windows.Forms.Label lblThurs;
        private System.Windows.Forms.Panel pnlFri;
        private System.Windows.Forms.Label lblFri;
        private System.Windows.Forms.Panel pnlSat;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel datePanel;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}

