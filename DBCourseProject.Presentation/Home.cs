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
        private readonly DepartmentService _departmentService;

        public Home(DepartmentService departmentService)
        {

            _departmentService = departmentService;
            InitializeComponent();
            

        }

        private void Home_Load(object sender, EventArgs e)
        {
            //BindingSource bindingSource = new BindingSource();
            //bindingSource.DataSource = _DepartmentSerivce.GetAllDepartments();
            //dgvMainData.DataSource = bindingSource;

            var allDepartments = _departmentService.GetAllDepartments();
           

            dgvMainData.RowCount = allDepartments.Count; 
            for (int i = 0; i < allDepartments.Count; i++)
            {
                dgvMainData[0, i].Value = allDepartments[i].DepartmentId; 
                dgvMainData[1, i].Value = allDepartments[i].City; 
                dgvMainData[2, i].Value = allDepartments[i].DepartmentName;

                var freePlates = _departmentService.GetAllFreePlatesByDepartment(allDepartments[i].Id);
                var payablePlates = _departmentService.GetAllPayablePlatesByDepartment(allDepartments[i].Id);

                string plates = "";
                foreach (var plate in freePlates)
                {
                    plates += plate.PlateValue + ", ";
                }
                plates = plates.Remove(plates.Length - 2, 2);
                dgvMainData[3, i].Value = plates;

                plates = "";
                foreach (var plate in payablePlates)
                {
                    plates += plate.PlateValue + ", ";
                }
                plates = plates.Remove(plates.Length - 2, 2);
                dgvMainData[4, i].Value = plates;
            }
        }
    }
}
