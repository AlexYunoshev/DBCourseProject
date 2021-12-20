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
        public static string SelectDepartments(Sort sortType)
        {
            string cmd = "";
            cmd = @"select * from dbo.Departments ";

            if (sortType == Sort.IdAsc) { cmd += "order by DepartmentId asc"; }
            else if (sortType == Sort.IdDesc) { cmd += "order by DepartmentId desc"; }
            else if (sortType == Sort.IdDesc) { cmd += "order by City asc"; }
            else if (sortType == Sort.IdDesc) { cmd += "order by City desc"; }
            else if (sortType == Sort.IdDesc) { cmd += "order by DepartmentName asc"; }
            else if (sortType == Sort.IdDesc) { cmd += "order by DepartmentName desc"; }
      
            cmd += ";";
            return cmd;
        }
     


        public static string SelectDepartment(string departmentId)
        {
            string cmd = @"select * from dbo.Departments where DepartmentID = '" + departmentId + "';";
            return cmd;
        }

        public static string SelectFreePlatesByDepartment(int Id)
        {
            string cmd = @"select * from dbo.FreePlates where DepartmentID = " + Id + ";";
            return cmd;
        }

        public static string SelectPayablePlatesByDepartment(int Id)
        {
            string cmd = @"select * from dbo.PayablePlates where DepartmentID = " + Id + ";";
            return cmd;
        }

        public static string InsertDepartment(Department department)
        {

            department.City = department.City.Replace("'", "\"");
            string cmd = @"insert into 
            dbo.Departments(City, DepartmentName, DepartmentId)
            values(N'" + department.City + "', N'" + department.DepartmentName + "', N'"  + department.DepartmentId + "')";
            return cmd;
        }
        public static string UpdateDepartment(Department department)
        {
            department.City = department.City.Replace("'", "\"");
            string cmd = @"update dbo.Departments set
            City = '" + department.City + "', " +
            "DepartmentName = '" + department.DepartmentName + "', " +
            "DepartmentId = '" + department.DepartmentId + "', " +
            "where Id = " + department.Id + ";";
            return cmd;
        }

        public static string InsertFreePlate(FreePlate plate)
        {
            string cmd = @"insert into 
            dbo.FreePlates(DepartmentId, PlateValue)
            values(" + plate.DepartmentId + ", N'" + plate.PlateValue + "')";
            return cmd;
        }

        public static string RemoveFreePlate(string plateValue)
        {
            string cmd = @"delete from 
            dbo.FreePlates where PlateValue = N'" + plateValue + "'";
            return cmd;
        }

        public static string InsertPayablePlate(PayablePlate plate)
        {
            string cmd = @"insert into 
            dbo.PayablePlates(DepartmentId, PlateValue)
            values(" + plate.DepartmentId + ", N'" + plate.PlateValue + "')";
            return cmd;
        }

        public static string RemovePayablePlate(string plateValue)
        {
            string cmd = @"delete from 
            dbo.PayablePlates where PlateValue = N'" + plateValue + "'";
            return cmd;
        }

        public static string RemoveFreePlatesByDepartmentId(int Id)
        {
            string cmd = @"delete from 
            dbo.FreePlates where DepartmentId = " + Id;
            return cmd;
        }

        public static string RemovePayablePlatesByDepartmentId(int Id)
        {
            string cmd = @"delete from 
            dbo.PayablePlates where DepartmentId = " + Id;
            return cmd;
        }


        public static string RemoveDepartmentById(int Id)
        {
            string cmd = @"delete from 
            dbo.Departments where Id = " + Id;
            return cmd;
        }

        
    }
}
