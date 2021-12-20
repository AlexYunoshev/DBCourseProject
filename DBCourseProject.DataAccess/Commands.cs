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
        public static string SelectDepartments(Sort sortType, string searchValue = null)
        {
            string cmd = "";
            cmd = @"select * from dbo.Departments ";

            if (searchValue != null)
            {
                cmd += "where City like N'%" + searchValue + "%' " +
                    "or DepartmentName like N'%" + searchValue + "%' " +
                    "or DepartmentId like N'" + searchValue + "%' ";
            }

            switch (sortType)
            {
                case Sort.IdAsc:
                    cmd += "order by DepartmentId asc ";
                    break;
                case Sort.IdDesc:
                    cmd += "order by DepartmentId desc ";
                    break;
                case Sort.CityAsc:
                    cmd += "order by City asc ";
                    break;
                case Sort.CityDesc:
                    cmd += "order by City desc ";
                    break;
                case Sort.DepartmentAsc:
                    cmd += "order by DepartmentName asc ";
                    break;
                case Sort.DepartmentDesc:
                    cmd += "order by DepartmentName desc ";
                    break;
            }

            cmd += ";";
            return cmd;
        }
     

        public static string SelectDepartmentsIdInPlatesByValue(string searchValue)
        {
            string cmd = @"select DepartmentId from dbo.FreePlates where PlateValue like N'%" + searchValue + "%' " +
                "UNION select DepartmentId from dbo.PayablePlates where PlateValue like N'%" + searchValue + "%' ";
            return cmd;
        }

        public static string SelectDepartment(string departmentId)
        {
            string cmd = @"select * from dbo.Departments where DepartmentID = '" + departmentId + "';";
            return cmd;
        }

        public static string SelectDepartment(int id)
        {
            string cmd = @"select * from dbo.Departments where Id = '" + id + "';";
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
            City = N'" + department.City + "', " +
            "DepartmentName = N'" + department.DepartmentName + "', " +
            "DepartmentId = N'" + department.DepartmentId + "' " +
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
