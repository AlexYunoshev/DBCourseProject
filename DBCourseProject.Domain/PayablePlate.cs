using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCourseProject.Domain
{
    public class PayablePlate
    {
        public int PlateId { get; set; }
        public string PlateValue { get; set; }
        public int DepartmentId { get; set; }
    }
}
