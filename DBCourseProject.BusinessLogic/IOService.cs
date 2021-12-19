using DBCourseProject.DataAccess;
using DBCourseProject.Domain;
using Microsoft.EntityFrameworkCore;
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

        public void SplitData(List<string[]> data,
            out List<Department> departmentsOut, 
            out List<List<FreePlate>> freePlatesOut,
            out List<List<PayablePlate>> payablePlatesOut)
        {
            departmentsOut = new List<Department>();
            freePlatesOut = new List<List<FreePlate>>();
            payablePlatesOut = new List<List<PayablePlate>>();

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

                departmentsOut.Add(department);

                var freePlates = new List<FreePlate>();
                foreach (var number in freeSplit)
                {
                    var freePlate = new FreePlate() 
                    { 
                        PlateValue = number,
                        Department = department
                    };
                    freePlates.Add(freePlate);    
                }
                freePlatesOut.Add(freePlates);


                var paymentPlates = new List<PayablePlate>();
                foreach (var number in payableSplit)
                {
                    var payablePlate = new PayablePlate()
                    {
                        PlateValue = number,
                        Department = department
                    };
                    paymentPlates.Add(payablePlate);
                }
                payablePlatesOut.Add(paymentPlates);
            }            
        }


        public void InitializeDepartments(List<Department> departments)
        {
            using (CourseProjectContext db = new CourseProjectContext())
            {
                foreach (var department in departments)
                {
                    db.Departments.Add(department);
                }
                db.SaveChanges();
            }    
        }

        public void InitializeFreePlates(List<List<FreePlate>> freePlates)
        {
            using (CourseProjectContext db = new CourseProjectContext())
            {
               
                foreach (var plates in freePlates)
                {
                    var plateDepartmentId = plates[0].Department.DepartmentId;
                    var department = db.Departments
                        .Where(d => d.DepartmentId == plateDepartmentId)
                        .Include(d => d.FreePlates)
                        .FirstOrDefault();
                    department.FreePlates = new List<FreePlate>(plates);
                    db.SaveChanges();
                }


            }
               
        }

        public void InitializePayablePlates(List<List<PayablePlate>> payablePlates)
        {
            using (CourseProjectContext db = new CourseProjectContext())
            {
                foreach (var plates in payablePlates)
                {
                    db.PayablePlates.AddRange(plates);
                }
                db.SaveChanges();
            }
             
        }


        //public void InitializeDepartments(List<Department> departments)
        //{
        //    foreach (var department in departments)
        //    {
        //        _context.Departments.Add(department);
        //    }
        //    _context.SaveChanges();
        //}

        //public void InitializeFreePlates(List<List<FreePlate>> freePlates)
        //{
        //    foreach (var plates in freePlates)
        //    {
        //        _context.FreePlates.AddRange(plates);
        //    }

        //    _context.SaveChanges();
        //}

        //public void InitializePayablePlates(List<List<PayablePlate>> payablePlates)
        //{
        //    foreach (var plates in payablePlates)
        //    {
        //        _context.PayablePlates.AddRange(plates);
        //    }
        //    _context.SaveChanges();
        //}

        public List<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }

    }
}
