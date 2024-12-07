namespace VacayFlow01
{
    partial class DashboardForm1
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
            this.statics = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statics
            // 
            this.statics.AutoSize = true;
            this.statics.Location = new System.Drawing.Point(316, 243);
            this.statics.Name = "statics";
            this.statics.Size = new System.Drawing.Size(47, 13);
            this.statics.TabIndex = 0;
            this.statics.Text = "statistics";
            this.statics.Click += new System.EventHandler(this.label1_Click);
            // 
            // dashboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 551);
            this.Controls.Add(this.statics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard1";
            this.Text = "t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statics;
    }
}