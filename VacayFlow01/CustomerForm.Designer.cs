namespace VacayFlow01
{
    partial class CustomerForm
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
            System.Windows.Forms.Label Guest_title;
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.guest_add_panel = new System.Windows.Forms.Panel();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            Guest_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.guest_add_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guest_title
            // 
            Guest_title.AutoSize = true;
            Guest_title.Location = new System.Drawing.Point(330, 21);
            Guest_title.Name = "Guest_title";
            Guest_title.Size = new System.Drawing.Size(40, 13);
            Guest_title.TabIndex = 4;
            Guest_title.Text = "Guests";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(Guest_title);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 59);
            this.panel1.TabIndex = 5;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 217);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(665, 205);
            this.dgvCustomers.TabIndex = 6;
            // 
            // guest_add_panel
            // 
            this.guest_add_panel.BackColor = System.Drawing.Color.White;
            this.guest_add_panel.Controls.Add(this.label4);
            this.guest_add_panel.Controls.Add(this.label3);
            this.guest_add_panel.Controls.Add(this.label2);
            this.guest_add_panel.Controls.Add(this.label1);
            this.guest_add_panel.Controls.Add(this.btnDeleteCustomer);
            this.guest_add_panel.Controls.Add(this.btnEditCustomer);
            this.guest_add_panel.Controls.Add(this.btnAddCustomer);
            this.guest_add_panel.Controls.Add(this.txtCustomerPhone);
            this.guest_add_panel.Controls.Add(this.txtCustomerEmail);
            this.guest_add_panel.Controls.Add(this.txtCustomerName);
            this.guest_add_panel.Controls.Add(this.txtCustomerID);
            this.guest_add_panel.Location = new System.Drawing.Point(373, 66);
            this.guest_add_panel.Name = "guest_add_panel";
            this.guest_add_panel.Size = new System.Drawing.Size(290, 145);
            this.guest_add_panel.TabIndex = 7;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(190, 110);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(87, 23);
            this.btnDeleteCustomer.TabIndex = 6;
            this.btnDeleteCustomer.Text = "Delete Guest";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(109, 110);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnEditCustomer.TabIndex = 5;
            this.btnEditCustomer.Text = "Edit Guest";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(28, 110);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add Guest";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(125, 86);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerPhone.TabIndex = 3;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(125, 60);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerEmail.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(125, 34);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(125, 8);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Guest ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Guest Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Guest Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Guest Phone #:";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.guest_add_panel);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.guest_add_panel.ResumeLayout(false);
            this.guest_add_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel guest_add_panel;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}