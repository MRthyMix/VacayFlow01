using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VacayFlow01
{
    public enum PropertyStatus
    {
        Available,
        Occupied,
        UnderMaintenance
    }
    public class Property
    {
        // Properties (Attributes)
        public int PropertyID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }        
        public string Description { get; set; }
        public List<string> Amenities { get; set; }
        public PropertyStatus Status { get; set; }

        // Constructor
        public Property(int propertyID, string name, string address, string description)
        {
            PropertyID = propertyID;
            Name = name;
            Address = address;
            Description = description;
            Amenities = new List<string>();
            Status = PropertyStatus.Available;
        }

        // Methods

        /// <summary>
        /// Updates the property details.
        /// </summary>
        public void UpdateDetails(string name, string address, string description)
        {
            Name = name;
            Address = address;
            Description = description;
        }

        /// <summary>
        /// Checks if the property is available between the given dates.
        /// </summary>
        public bool CheckAvailability(DateTime startDate, DateTime endDate)
        {
            // Implement logic to check reservations for this property
            // For this example, we'll assume it's always available if status is 'Available'
            return Status == PropertyStatus.Available;
        }

        /// <summary>
        /// Schedules a maintenance task for the property.
        /// </summary>
        public void ScheduleMaintenance(MaintenanceTask task)
        {
            // Add the maintenance task to the property's maintenance schedule
            // For this example, we'll just change the status
            Status = PropertyStatus.UnderMaintenance;

            // Add task to a maintenance task list or database (not implemented here)
        }

        /// <summary>
        /// Adds an amenity to the property's amenity list.
        /// </summary>
        public void AddAmenity(string amenity)
        {
            if (!Amenities.Contains(amenity))
            {
                Amenities.Add(amenity);
            }
        }

        /// <summary>
        /// Removes an amenity from the property's amenity list.
        /// </summary>
        public void RemoveAmenity(string amenity)
        {
            if (Amenities.Contains(amenity))
            {
                Amenities.Remove(amenity);
            }
        }

        /// <summary>
        /// Returns a string representation of the property.
        /// </summary>
        public override string ToString()
        {
            return $"Property ID: {PropertyID}, Name: {Name}, Address: {Address}, Status: {Status}";
        }
    }

    
}
