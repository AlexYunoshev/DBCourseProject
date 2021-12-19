using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCourseProject.Domain
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentId { get; set; }
        public string City { get; set; }
        public string DepartmentName { get; set; }
        public List<FreePlate> FreePlates { get; set; } = new List<FreePlate>();
        public List<PayablePlate> PayablePlates { get; set; } = new List<PayablePlate>();
    }
}
