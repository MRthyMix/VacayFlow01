namespace VacayFlow01
{
    partial class CalandarForm
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
            System.Windows.Forms.Label Calandar_Title;
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lstBookings = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.btnAddBooking = new System.Windows.Forms.Button();
            Calandar_Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // Calandar_Title
            // 
            Calandar_Title.AutoSize = true;
            Calandar_Title.Location = new System.Drawing.Point(330, 21);
            Calandar_Title.Name = "Calandar_Title";
            Calandar_Title.Size = new System.Drawing.Size(49, 13);
            Calandar_Title.TabIndex = 4;
            Calandar_Title.Text = "Calandar";
            Calandar_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(74, 70);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lstBookings
            // 
            this.lstBookings.FormattingEnabled = true;
            this.lstBookings.HorizontalScrollbar = true;
            this.lstBookings.Location = new System.Drawing.Point(333, 85);
            this.lstBookings.Name = "lstBookings";
            this.lstBookings.Size = new System.Drawing.Size(308, 147);
            this.lstBookings.TabIndex = 1;
            this.lstBookings.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(Calandar_Title);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 59);
            this.panel1.TabIndex = 3;
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(12, 248);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.Size = new System.Drawing.Size(661, 293);
            this.dgvBookings.TabIndex = 4;
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInteractiveCalendar_CellContentClick);
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(431, 119);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 20);
            this.txtRoom.TabIndex = 5;
            this.txtRoom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Room#:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Guest Name:";
            // 
            // txtGuest
            // 
            this.txtGuest.Location = new System.Drawing.Point(431, 145);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.Size = new System.Drawing.Size(100, 20);
            this.txtGuest.TabIndex = 8;
            this.txtGuest.TextChanged += new System.EventHandler(this.txtGuest_TextChanged);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(431, 181);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(75, 23);
            this.btnAddBooking.TabIndex = 9;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // CalandarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 553);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.txtGuest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstBookings);
            this.Controls.Add(this.monthCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalandarForm";
            this.Text = "CalandarForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListBox lstBookings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuest;
        private System.Windows.Forms.Button btnAddBooking;
    }
}