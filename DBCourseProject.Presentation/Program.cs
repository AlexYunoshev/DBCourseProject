using DBCourseProject.BusinessLogic;
using DBCourseProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using DBCourseProject.Domain;

namespace DBCourseProject.Presentation
{
    static class Program
    {
        private const string filePath = @"D:\DesktopFolders\ProjectsProgr\ASP NET Core\DBCourseProject\DBCourseProject.DataAccess\File.csv";

        private static readonly DepartmentService _departmentService = new DepartmentService();
        private static readonly IOService _IOService = new IOService();

        public static void InitializeDatabase()
        {
            var data = _IOService.ReadDataFromFile(filePath);

            List<Department> departments;
            List<List<FreePlate>> freePlates;
            List<List<PayablePlate>> payablePlates;

            _IOService.SplitData(data, out departments, out freePlates, out payablePlates);

      
            for (int i = 0; i < departments.Count; i++)
            {
                _departmentService.InsertDepartment(departments[i]);
                var departmentDB = _departmentService.GetDepartment(departments[i].DepartmentId);
                foreach (var plate in freePlates[i])
                {
                    plate.DepartmentId = departmentDB.Id;
                    _departmentService.InsertFreePlate(plate);
                }

                foreach (var plate in payablePlates[i])
                {
                    plate.DepartmentId = departmentDB.Id;
                    _departmentService.InsertPayablePlate(plate);
                }
            }

            //count = 0;
            //foreach (var plates in freePlates)
            //{
            //    foreach (var plate in plates)
            //    {
            //        count += _DepartmentService.InsertFreePlate(plate);
            //    }  
            //}

            //count = 0;
            //foreach (var plates in payablePlates)
            //{
            //    foreach (var plate in plates)
            //    {
            //        count += _DepartmentService.InsertPayablePlate(plate);
            //    }
            //}


            //var dep = new Department()
            //{
            //    City = "city",
            //    DepartmentId = "123",
            //    DepartmentName = "Name"
            //};
            //count = _IOService.InsertDepartment(dep);

            //var free = new FreePlate()
            //{
            //    PlateValue = "ax0550cm",
            //    DepartmentId = 1
            //};
            //count = _DepartmentSerivce.InsertFreePlate(free);


            //var payable = new PayablePlate()
            //{
            //    PlateValue = "ax0549cc",
            //    DepartmentId = 1

            //};
            //count = _IOService.InsertPayablePlate(payable);

            //var dep = _IOService.GetDepartment("123");
        }

        [STAThread]
        static void Main()
        {

            //InitializeDatabase();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(_departmentService));
        }
    }
}
