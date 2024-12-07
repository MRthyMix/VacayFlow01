using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VacayFlow01
{
    public partial class CalandarForm : Form
    {
        // Dictionary to simulate booking data
        private Dictionary<DateTime, List<string>> bookings;

        public CalandarForm()
        {
            InitializeComponent();
            InitializeBookings();
            monthCalendar.DateSelected += MonthCalendar_DateSelected; // Event for date selection
            btnAddBooking.Click += btnAddBooking_Click; // Event for adding bookings
        }

        private void InitializeBookings()
        {
            // Example booking data
            bookings = new Dictionary<DateTime, List<string>>
            {
                { DateTime.Today, new List<string> { "Room 101: John Doe", "Room 202: Jane Smith" } },
                { DateTime.Today.AddDays(1), new List<string> { "Room 303: Mike Ross" } },
                { DateTime.Today.AddDays(2), new List<string> { "Room 101: Alex Brown" } }
            };

            // Load today's bookings into the ListBox
            UpdateBookingList(DateTime.Today);
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Get the selected date
            DateTime selectedDate = monthCalendar.SelectionStart;

            // Update the ListBox with bookings for the selected date
            UpdateBookingList(selectedDate);
        }

        private void UpdateBookingList(DateTime date)
        {
            // Create a DataTable to hold the bookings
            DataTable table = new DataTable();
            table.Columns.Add("Room", typeof(string));
            table.Columns.Add("Guest", typeof(string));

            if (bookings.ContainsKey(date))
            {
                // Add each booking to the table
                foreach (var booking in bookings[date])
                {
                    var parts = booking.Split(':'); // Assume "Room 101: John Doe" format
                    table.Rows.Add(parts[0].Trim(), parts[1].Trim());
                }
            }
            else
            {
                // Add a default row if no bookings are available
                table.Rows.Add("No bookings", "");
            }

            // Bind the DataTable to the DataGridView
            dgvBookings.DataSource = table;
        }

        private void LoadUpcomingBookings()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Booking", typeof(string));

            foreach (var date in bookings.Keys)
            {
                foreach (var booking in bookings[date])
                {
                    table.Rows.Add(date, booking);
                }
            }

            dgvBookings.DataSource = table; // dgvBookings is a DataGridView
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            // Get the selected date
            DateTime selectedDate = monthCalendar.SelectionStart;

            // Get room and guest data from text boxes
            string room = txtRoom.Text.Trim();
            string guest = txtGuest.Text.Trim();

             //Validate inputs
            if (string.IsNullOrEmpty(room) || string.IsNullOrEmpty(guest))
            {
                MessageBox.Show("Please enter both Room and Guest details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add booking to the dictionary
            string bookingEntry = $"Room {room}: {guest}";
            if (!bookings.ContainsKey(selectedDate))
            {
                bookings[selectedDate] = new List<string>();
            }
            bookings[selectedDate].Add(bookingEntry);

            // Refresh the DataGridView
            UpdateBookingList(selectedDate);

            // Clear the input fields
            txtRoom.Clear();
            txtGuest.Clear();

            MessageBox.Show("Booking added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvInteractiveCalendar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGuest_TextChanged(object sender, EventArgs e)
        {

        }

       
    } 
    
}
