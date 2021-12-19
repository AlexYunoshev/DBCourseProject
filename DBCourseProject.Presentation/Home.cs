using DBCourseProject.BusinessLogic;
using DBCourseProject.DataAccess;
using DBCourseProject.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCourseProject.Presentation
{
    public partial class Home : Form
    {
        private readonly IOService _IOService;
        private const string filePath = @"D:\DesktopFolders\ProjectsProgr\ASP NET Core\DBCourseProject\DBCourseProject.DataAccess\data.csv";

        public Home()
        {
            _IOService = (IOService)Program.ServiceProvider.GetService(typeof(IOService));
            InitializeComponent();

            //var data = _IOService.GetAllDepartments();
            //var data2 = _IOService.ReadDataFromFile(filePath);

            //List<Department> departments;
            //List<List<FreePlate>> freePlates;
            //List<List<PayablePlate>> payablePlates;

            //_IOService.SplitData(data2, out departments, out freePlates, out payablePlates);

            //_IOService.InitializePayablePlates(payablePlates);

            int count;

            //var dep = new Department()
            //{
            //    City = "city",
            //    DepartmentId = "123",
            //    DepartmentName = "Name"
            //};
            //count = _IOService.InsertDepartment(dep);

            var free = new FreePlate()
            {
                PlateValue = "ax0549cm",
                DepartmentId = 1

            };
            count = _IOService.InsertFreePlate(free);


            var payable = new PayablePlate()
            {
                PlateValue = "ax0549cc",
                DepartmentId = 1

            };
            count = _IOService.InsertPayablePlate(payable);
        }
    }
}
