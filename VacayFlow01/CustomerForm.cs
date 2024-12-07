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
    public partial class CustomerForm : Form
    {
        // List to store customer data
        private List<Customer> customers;

        public CustomerForm()
        {
            InitializeComponent();
            InitializeCustomers();
            LoadCustomerData();
        }

        private void InitializeCustomers()
        {
            // Example customer data
            customers = new List<Customer>
            {
                new Customer { CustomerID = 1, Name = "John Doe", Email = "john.doe@example.com", Phone = "123-456-7890" },
                new Customer { CustomerID = 2, Name = "Jane Smith", Email = "jane.smith@example.com", Phone = "987-654-3210" }
            };
        }

        private void LoadCustomerData()
        {
            // Create a DataTable to hold customer data
            DataTable table = new DataTable();
            table.Columns.Add("CustomerID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Phone", typeof(string));

            foreach (var customer in customers)
            {
                table.Rows.Add(customer.CustomerID, customer.Name, customer.Email, customer.Phone);
            }

            // Bind the DataTable to the DataGridView
            dgvCustomers.DataSource = table;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtCustomerEmail.Text) || string.IsNullOrEmpty(txtCustomerPhone.Text))
            {
                MessageBox.Show("Please fill in all customer details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new customer
            int newID = customers.Count > 0 ? customers[customers.Count - 1].CustomerID + 1 : 1;
            var newCustomer = new Customer
            {
                CustomerID = newID,
                Name = txtCustomerName.Text.Trim(),
                Email = txtCustomerEmail.Text.Trim(),
                Phone = txtCustomerPhone.Text.Trim()
            };

            // Add to the customer list and refresh the DataGridView
            customers.Add(newCustomer);
            LoadCustomerData();

            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            txtCustomerName.Clear();
            txtCustomerEmail.Clear();
            txtCustomerPhone.Clear();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            // Ensure a customer is selected
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected customer
            int selectedID = (int)dgvCustomers.SelectedRows[0].Cells[0].Value;

            // Find the customer in the list
            var customer = customers.Find(c => c.CustomerID == selectedID);
            if (customer != null)
            {
                // Update customer details
                customer.Name = txtCustomerName.Text.Trim();
                customer.Email = txtCustomerEmail.Text.Trim();
                customer.Phone = txtCustomerPhone.Text.Trim();

                // Refresh the DataGridView
                LoadCustomerData();

                MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Ensure a customer is selected
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected customer ID
            int selectedID = (int)dgvCustomers.SelectedRows[0].Cells[0].Value;

            // Remove the customer from the list
            customers.RemoveAll(c => c.CustomerID == selectedID);

            // Refresh the DataGridView
            LoadCustomerData();

            MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    // Customer class to store customer data
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}