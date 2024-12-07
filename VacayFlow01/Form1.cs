using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacayFlow01
{
    public partial class Main_form : Form
    {

        public Main_form()
        {
            InitializeComponent();

            // Attach events to each PictureBox
            dashBoard_img.MouseEnter += PictureBox_MouseEnter;
            dashBoard_img.MouseLeave += PictureBox_MouseLeave;

            Calandar_img.MouseEnter += PictureBox_MouseEnter;
            Calandar_img.MouseLeave += PictureBox_MouseLeave;

            rooms_img.MouseEnter += PictureBox_MouseEnter;
            rooms_img.MouseLeave += PictureBox_MouseLeave;

            Customer_img.MouseEnter += PictureBox_MouseEnter;
            Customer_img.MouseLeave += PictureBox_MouseLeave;

            booking_img.MouseEnter += PictureBox_MouseEnter;
            booking_img.MouseLeave += PictureBox_MouseLeave;

            exit_img.MouseEnter += PictureBox_MouseEnter;
            exit_img.MouseLeave += PictureBox_MouseLeave;

            // Load DashboardForm1 by default on startup
            DashboardForm1 dashboard = new DashboardForm1();
            OpenChildForm(dashboard);
        }
        //handlers to handle hover and un-hover states
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                pictureBox.BackColor = Color.LightGray; // Highlight color
            }
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                pictureBox.BackColor = Color.Transparent; // Reset to default color
            }
        }



        // Method to load and replace a child form in the panel
        private void OpenChildForm(Form childForm)
        {
            try
            {
                // Remove any existing controls in the panel
                if (mainPanel.Controls.Count > 0)
                {
                    mainPanel.Controls.RemoveAt(0);
                }

                // Set up the new child form
                childForm.TopLevel = false;
                childForm.Dock = DockStyle.Fill;
                childForm.FormBorderStyle = FormBorderStyle.None;

                // Add the child form to the panel
                mainPanel.Controls.Add(childForm);
                mainPanel.Tag = childForm;

                // Show the child form
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HighlightSelectedPictureBox(PictureBox selectedPictureBox)
        {
            // Loop through all controls in the form
            foreach (Control ctrl in this.Controls)
            {
                // Check if the control is a PictureBox
                if (ctrl is PictureBox pictureBox)
                {
                    // Reset the background color to default
                    pictureBox.BackColor = Color.Transparent;
                }
            }

            // Highlight the selected PictureBox
            selectedPictureBox.BackColor = Color.LightGray; // Use any color you like for highlighting
        }


        private void dashBoard_img_Click(object sender, EventArgs e)
        {
            HighlightSelectedPictureBox((PictureBox)sender);
            // Open DashboardForm1 in the main panel
            DashboardForm1 dashboard = new DashboardForm1();
            OpenChildForm(dashboard);
        }

        private void Calandar_img_Click(object sender, EventArgs e)
        {
            HighlightSelectedPictureBox((PictureBox)sender);
            CalandarForm calandarForm = new CalandarForm();
            OpenChildForm(calandarForm);
        }

        private void rooms_img_Click(object sender, EventArgs e)
        {
            HighlightSelectedPictureBox((PictureBox)sender);
            RoomsForm roomsForm = new RoomsForm(); 
            OpenChildForm(roomsForm);
        }
        private void Customer_img_Click(object sender, EventArgs e)
        {
            HighlightSelectedPictureBox((PictureBox)sender);
            // Open CustomerForm in the main panel
            CustomerForm customerForm = new CustomerForm();
            OpenChildForm(customerForm);
        }

        private void booking_img_Click(object sender, EventArgs e)
        {
            HighlightSelectedPictureBox((PictureBox)sender);
            BookingForm bookingForm = new BookingForm();
            OpenChildForm(bookingForm);
        }


        private void exit_img_Click(object sender, EventArgs e)
        {
            HighlightSelectedPictureBox((PictureBox)sender);
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dashboard_pop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void booked_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void booking_pop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void room_pop_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
