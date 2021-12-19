using DBCourseProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCourseProject.DataAccess
{
    public static class Commands
    {
        public static string SelectDepartments()
        {
            string cmd = @"select * from dbo.Departments;";
            return cmd;
        }


        public static string InsertDepartments(Department department)
        {
            string cmd = @"insert into 
            dbo.Departments(City, DepartmentName, DepartmentId)
            values('" + department.City + "', '" + department.DepartmentName + "', '"  + department.DepartmentId + "')";
            return cmd;
        }

        public static string InsertFreePlates(FreePlate plate)
        {
            string cmd = @"insert into 
            dbo.FreePlates(DepartmentId, PlateValue)
            values(" + plate.DepartmentId + ", '" + plate.PlateValue + "')";
            return cmd;
        }
    }
}
