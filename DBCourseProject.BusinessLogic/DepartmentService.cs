using DBCourseProject.DataAccess;
using DBCourseProject.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCourseProject.BusinessLogic
{
    public class DepartmentService
    {
        string query = "";
        DataSet dataSet;

        public int InsertDepartment(Department department)
        {
            query = Commands.InsertDepartment(department);
            ConnectedData.SetCommand(query);
            int count = ConnectedData.UpdateData();
            return count;
        }

        public int UpdateDepartment(Department department)
        {
            query = Commands.UpdateDepartment(department);
            ConnectedData.SetCommand(query);
            int count = ConnectedData.UpdateData();
            return count;
        }

        public int InsertFreePlate(FreePlate plate)
        {
            query = Commands.InsertFreePlate(plate);
            ConnectedData.SetCommand(query);
            int count = ConnectedData.UpdateData();
            return count;
        }

        public int InsertPayablePlate(PayablePlate plate)
        {
            query = Commands.InsertPayablePlate(plate);
            ConnectedData.SetCommand(query);
            int count = ConnectedData.UpdateData();
            return count;
        }

        public Department GetDepartment(string departmentId)
        {
            query = Commands.SelectDepartment(departmentId);
            ConnectedData.SetCommand(query);
            int[] size = new int[2];
            size = ConnectedData.GetRowAndColumnCount();
            int row = size[0];
            int column = size[1];
            string[,] data = new string[row, column];
            data = ConnectedData.GetTableData();
            for (int i = 0; i < row; i++)
            {
                var department = new Department()
                {
                    Id = Convert.ToInt32(data[i, 0]),
                    DepartmentId = data[i, 3],
                    City = data[i, 1],
                    DepartmentName = data[i, 2]
                };
                return department;
            }
            return null;
        }

        public Department GetDepartment(int id)
        {
            query = Commands.SelectDepartment(id);
            ConnectedData.SetCommand(query);
            int[] size = new int[2];
            size = ConnectedData.GetRowAndColumnCount();
            int row = size[0];
            int column = size[1];
            string[,] data = new string[row, column];
            data = ConnectedData.GetTableData();
            for (int i = 0; i < row; i++)
            {
                var department = new Department()
                {
                    Id = Convert.ToInt32(data[i, 0]),
                    DepartmentId = data[i, 3],
                    City = data[i, 1],
                    DepartmentName = data[i, 2]
                };
                return department;
            }
            return null;
        }

        public int RemoveFreePlateByPlateValue(string plateValue)
        {
            query = Commands.RemoveFreePlate(plateValue);
            ConnectedData.SetCommand(query);
            return ConnectedData.UpdateData();
        }

        public int RemovePayablePlateByPlateValue(string plateValue)
        {
            query = Commands.RemovePayablePlate(plateValue);
            ConnectedData.SetCommand(query);
            return ConnectedData.UpdateData();
        }

        public int RemoveFreePlatesByDepartmentId(int Id)
        {
            query = Commands.RemoveFreePlatesByDepartmentId(Id);
            ConnectedData.SetCommand(query);
            return ConnectedData.UpdateData();
        }

        public int RemovepayablePlatesByDepartmentId(int Id)
        {
            query = Commands.RemovePayablePlatesByDepartmentId(Id);
            ConnectedData.SetCommand(query);
            return ConnectedData.UpdateData();
        }


        public int RemoveDepartmentById(string departmentId)
        {
            var departmentDB = GetDepartment(departmentId);
            RemoveFreePlatesByDepartmentId(departmentDB.Id);
            RemovepayablePlatesByDepartmentId(departmentDB.Id);
            query = Commands.RemoveDepartmentById(departmentDB.Id);
            ConnectedData.SetCommand(query);
            return ConnectedData.UpdateData();
        }

        public List<Department> GetAllDepartments(Sort sortType, string searchValue = null)
        {
            var departments = new List<Department>();
            query = Commands.SelectDepartments(sortType, searchValue);      
            ConnectedData.SetCommand(query);
            int[] size = new int[2];
            size = ConnectedData.GetRowAndColumnCount();
            int row = size[0];
            int column = size[1];

            string[,] data = new string[row, column];
            data = ConnectedData.GetTableData();

            for (int i = 0; i < row; i++)
            {
                var department = new Department()
                {
                    Id = Convert.ToInt32(data[i, 0]),
                    DepartmentId = data[i, 3],
                    City = data[i, 1],
                    DepartmentName = data[i, 2]
                };
                departments.Add(department);
            }

            return departments;
        }

        public List<int> GetDepartmentsIdInPlatesByValue(string plateValue)
        {
            var listOfId = new List<int>();
            query = Commands.SelectDepartmentsIdInPlatesByValue(plateValue);
            ConnectedData.SetCommand(query);
            int[] size = new int[2];
            size = ConnectedData.GetRowAndColumnCount();
            int row = size[0];
            int column = size[1];

            string[,] data = new string[row, column];
            data = ConnectedData.GetTableData();

            for (int i = 0; i < row; i++)
            {
                listOfId.Add(Convert.ToInt32(data[i, 0]));
            }

            return listOfId;
        }

        public List<FreePlate> GetAllFreePlatesByDepartment(int Id)
        {
            var plates = new List<FreePlate>();
            query = Commands.SelectFreePlatesByDepartment(Id);
            ConnectedData.SetCommand(query);
            int[] size = new int[2];
            size = ConnectedData.GetRowAndColumnCount();
            int row = size[0];
            int column = size[1];

            string[,] data = new string[row, column];
            data = ConnectedData.GetTableData();

            for (int i = 0; i < row; i++)
            {
                var plate = new FreePlate()
                {
                    PlateId = Convert.ToInt32(data[i, 0]),
                    DepartmentId = Convert.ToInt32(data[i, 1]),
                    PlateValue = data[i, 2]
                };
                plates.Add(plate);
            }

            return plates;
        }

        public List<FreePlate> GetAllPayablePlatesByDepartment(int Id)
        {
            var plates = new List<FreePlate>();
            query = Commands.SelectPayablePlatesByDepartment(Id);
            ConnectedData.SetCommand(query);
            int[] size = new int[2];
            size = ConnectedData.GetRowAndColumnCount();
            int row = size[0];
            int column = size[1];

            string[,] data = new string[row, column];
            data = ConnectedData.GetTableData();

            for (int i = 0; i < row; i++)
            {
                var plate = new FreePlate()
                {
                    PlateId = Convert.ToInt32(data[i, 0]),
                    DepartmentId = Convert.ToInt32(data[i, 1]),
                    PlateValue = data[i, 2]
                };
                plates.Add(plate);
            }

            return plates;
        }
    }
}
