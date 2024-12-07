using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacayFlow01
{
    public class MaintenanceTask
    {

        //Attributes
        private int TaskID { get; set; }
        private string Property { get; set; }
        private string Description { get; set; }
        private string ScheduledDate { get; set; }
        private string Status { get; set; }
        private string AssignedTo { get; set; }
    }


}
