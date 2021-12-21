using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCourseProject.Domain
{
    public class FreePlate
    {
        public int PlateId { get; set; }
        public string PlateValue { get; set; }
        public int DepartmentId { get; set; }
    }
}
