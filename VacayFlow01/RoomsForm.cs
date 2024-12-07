using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacayFlow01
{
    public partial class RoomsForm : Form
    {
        // Dictionary to store room data (Room Number, Status)
        private Dictionary<string, string> rooms;

        public RoomsForm()
        {
            InitializeComponent();
            InitializeRooms();
            LoadRoomData();
        }

        private void InitializeRooms()
        {
            // Example room data
            rooms = new Dictionary<string, string>
            {
                { "Room 101", "Available" },
                { "Room 202", "Occupied" },
                { "Room 303", "Under Maintenance" },
                { "Room 404", "Available" }
            };
        }

        private void LoadRoomData()
        {
            // Create a DataTable to hold room data
            DataTable table = new DataTable();
            table.Columns.Add("Room", typeof(string));
            table.Columns.Add("Status", typeof(string));

            foreach (var room in rooms)
            {
                table.Rows.Add(room.Key, room.Value);
            }

            // Bind the DataTable to the DataGridView
            dgvRooms.DataSource = table;
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            // Get the selected row in the DataGridView
            if (dgvRooms.SelectedRows.Count > 0)
            {
                string selectedRoom = dgvRooms.SelectedRows[0].Cells[0].Value.ToString();
                string newStatus = cmbStatus.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(newStatus))
                {
                    // Update the room status in the dictionary
                    rooms[selectedRoom] = newStatus;

                    // Reload the DataGridView
                    LoadRoomData();

                    MessageBox.Show($"Status of {selectedRoom} updated to {newStatus}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a status to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a room to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}