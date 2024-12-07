namespace VacayFlow01
{
    partial class RoomsForm
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
            System.Windows.Forms.Label Rooms_title;
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            Rooms_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(Rooms_title);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 59);
            this.panel1.TabIndex = 4;
            // 
            // Rooms_title
            // 
            Rooms_title.AutoSize = true;
            Rooms_title.Location = new System.Drawing.Point(330, 21);
            Rooms_title.Name = "Rooms_title";
            Rooms_title.Size = new System.Drawing.Size(40, 13);
            Rooms_title.TabIndex = 4;
            Rooms_title.Text = "Rooms";
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(34, 115);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.Size = new System.Drawing.Size(624, 295);
            this.dgvRooms.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(537, 88);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 6;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(583, 416);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStatus.TabIndex = 7;
            this.btnUpdateStatus.Text = "Update";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomsForm";
            this.Text = "RoomsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
    }
}