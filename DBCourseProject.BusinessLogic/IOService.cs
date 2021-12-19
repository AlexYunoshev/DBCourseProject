using DBCourseProject.DataAccess;
using DBCourseProject.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCourseProject.BusinessLogic
{
    public class IOService
    {
        private readonly CourseProjectContext _context;

        public IOService(CourseProjectContext context)
        {
            _context = context;
        }

        public List<string[]> ReadDataFromFile(string filePath)
        {
            List<string[]> dataOutput = new List<string[]>();
            var separators = new string[] { ",\"", ",[" };
            using (var streamReader = new StreamReader(filePath, Encoding.GetEncoding(1251)))
            {
                bool skipHeaderLine = false;
                while(!streamReader.EndOfStream)
                {
                    var readLine = streamReader.ReadLine();
                    if (!skipHeaderLine)
                    {
                        skipHeaderLine = true;
                        continue;
                    }
                    var valuesLine = readLine.Split(separators, StringSplitOptions.None);
                    dataOutput.Add(valuesLine);
                }
            }
            return dataOutput;
        }

        public List<Department> SplitData(List<string[]> data)
        {
            var departments = new List<Department>();
            for (int i = 0; i < data.Count; i++)
            {
                var departmentId = data[i][0];
                departmentId = departmentId.Replace("\"", "");

                var city = data[i][1];
                city = city.Replace("\"", "");

                var dep = data[i][2];
                dep = dep.Replace("\"", "");

                var free = data[i][4];
                free = free.Replace("]", "");
                var freeSplit = free.Split(',');

                var payable = data[i][5];
                payable = payable.Replace("]\"", "");
                var payableSplit = payable.Split(',');

                var department = new Department()
                {
                    DepartmentId = departmentId,
                    City = city,
                    DepartmentName = dep      
                };

                _context.Departments.Add(department);
                //_context.SaveChanges();

                //var freePlates = new List<FreePlate>();
                foreach (var number in freeSplit)
                {
                    var freePlate = new FreePlate() 
                    { 
                        PlateValue = number,
                    };
                    department.FreePlates.Add(freePlate);
                }
                _context.SaveChanges();

                //var paymentPlates = new List<PayablePlate>();
                //foreach (var number in payableSplit)
                //{
                //    var payablePlate = new PayablePlate()
                //    {
                //        PlateValue = number,
                //        Department = department
                //        //DepartmentId = department.Id
                //    };
                //    _context.PayablePlates.Add(payablePlate);
                //    //paymentPlates.Add(payablePlate);
                //}

                //department.FreePlates = freePlates;
                //department.PayablePlates = paymentPlates;
                //_context.SaveChanges();

                //_context.FreePlates.AddRange(freePlates);
                //_context.PayablePlates.AddRange(paymentPlates);




                //department.FreePlates = freePlates;
                //department.PayablePlates = paymentPlates;

                //departments.Add(department);
            }
            _context.SaveChanges();
            return departments;
        }

        //public void InitializeDatabase(List<Department> departments)
        //{
        //    foreach (var department in departments)
        //    {
        //        _context.Departments.Add(department);
        //    }
        //    _context.SaveChanges();
        //}

        public List<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }

    }
}
