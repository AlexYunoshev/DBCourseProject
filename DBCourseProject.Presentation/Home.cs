using DBCourseProject.BusinessLogic;
using DBCourseProject.DataAccess;
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
        private readonly CourseProjectContext  _context;
        private readonly IOService _IOService;
        private const string filePath = @"D:\DesktopFolders\ProjectsProgr\ASP NET Core\DBCourseProject\DBCourseProject.DataAccess\data.csv";

        public Home()
        {
            _IOService = (IOService)Program.ServiceProvider.GetService(typeof(IOService));
            var data = _IOService.GetAllDepartments();
            var data2 = _IOService.ReadDataFromFile(filePath);
            InitializeComponent();
        }
    }
}
