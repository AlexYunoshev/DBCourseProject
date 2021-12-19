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

        private List<Department> allDepartments = new List<Department>();

        public Home(DepartmentService departmentService)
        {
            _departmentService = departmentService;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadData();
            UpdateComboboxes();
        }

        //private void UpdateDepartments(Department department, List<FreePlate> freePlates, List<PayablePlate> payablePlates)
        //{
        //    int indexOfLastValue = dgvMainData.Rows.Count;
        //    dgvMainData[0, indexOfLastValue + 1].Value = department.DepartmentId;
        //    dgvMainData[1, indexOfLastValue + 1].Value = department.City;
        //    dgvMainData[2, indexOfLastValue + 1].Value = department.DepartmentName;
        //}

        private void LoadData()
        {
            allDepartments = _departmentService.GetAllDepartments();

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
                if (plates.Contains(", "))
                {
                    plates = plates.Remove(plates.Length - 2, 2);
                    dgvMainData[3, i].Value = plates;
                }
              

                plates = "";
                foreach (var plate in payablePlates)
                {
                    plates += plate.PlateValue + ", ";
                }
                if (plates.Contains(", "))
                {
                    plates = plates.Remove(plates.Length - 2, 2);
                    dgvMainData[4, i].Value = plates;
                }
            }
        }

        private void UpdateComboboxes()
        {
            if (allDepartments.Count < 0) { var allDepartments = _departmentService.GetAllDepartments(); }

            foreach (var department in allDepartments)
            {
                comboBoxAddFreePlateDepartmentId.Items.Add(department.DepartmentId);
                comboBoxAddPayablePlateDepartmentId.Items.Add(department.DepartmentId);

                comboBoxRemoveFreePlateDepartmentId.Items.Add(department.DepartmentId);
                comboBoxRemovePayablePlateDepartmentId.Items.Add(department.DepartmentId);
            }

            if (comboBoxAddFreePlateDepartmentId.Items.Count > 0)
            {
                comboBoxAddFreePlateDepartmentId.SelectedIndex = 0;
            }

            if (comboBoxAddPayablePlateDepartmentId.Items.Count > 0)
            {
                comboBoxAddPayablePlateDepartmentId.SelectedIndex = 0;
            }

            if (comboBoxRemoveFreePlateDepartmentId.Items.Count > 0)
            {
                comboBoxRemoveFreePlateDepartmentId.SelectedIndex = 0;
            }


            if (comboBoxRemovePayablePlateDepartmentId.Items.Count > 0)
            {
                comboBoxRemovePayablePlateDepartmentId.SelectedIndex = 0;
            }

            

        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            var departmentId = textBoxAddDepartmentId.Text;
            var departmentCity = textBoxAddDepartmentCity.Text;
            var departmentName = textBoxAddDepartmentName.Text;

            var department = new Department()
            {
                DepartmentId = departmentId,
                City = departmentCity,
                DepartmentName = departmentName
            };

            var insertItemsCount = _departmentService.InsertDepartment(department);
            if (insertItemsCount > 0) {
                MessageBox.Show("Done");
                LoadData();
                UpdateComboboxes();
            }
            else { MessageBox.Show("Something went wrong!"); }

        }

        private void buttonAddFreePlate_Click(object sender, EventArgs e)
        {
            var departmentIdComboBox = comboBoxAddFreePlateDepartmentId.SelectedItem.ToString();
            var departmentDB = _departmentService.GetDepartment(departmentIdComboBox);
            var plateValue = textBoxAddFreePlateValue.Text;
            var departmentId = departmentDB.Id;
            var plate = new FreePlate()
            {
                DepartmentId = departmentId,
                PlateValue = plateValue
            };
            var insertItemsCount = _departmentService.InsertFreePlate(plate);
            if (insertItemsCount > 0)
            {
                MessageBox.Show("Done");
                LoadData();
                UpdateComboboxes();
                textBoxAddFreePlateValue.Text = "";
            }
            else { MessageBox.Show("Something went wrong!"); }
        }

        private void buttonAddPayablePlate_Click(object sender, EventArgs e)
        {
            var departmentIdComboBox = comboBoxAddPayablePlateDepartmentId.SelectedItem.ToString();
            var departmentDB = _departmentService.GetDepartment(departmentIdComboBox);
            var plateValue = textBoxAddPayablePlateValue.Text;
            var departmentId = departmentDB.Id;
            var plate = new PayablePlate()
            {
                DepartmentId = departmentId,
                PlateValue = plateValue
            };
            var insertItemsCount = _departmentService.InsertPayablePlate(plate);
            if (insertItemsCount > 0)
            {
                MessageBox.Show("Done");
                LoadData();
                UpdateComboboxes();
                textBoxAddPayablePlateValue.Text = "";
            }
            else { MessageBox.Show("Something went wrong!"); }
        }

      

        private void comboBoxRemoveFreePlateDepartmentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRemoveFreePlateValue.Items.Clear();

            var departmentIdComboBox = comboBoxRemoveFreePlateDepartmentId.SelectedItem.ToString();
            var departmentDB = _departmentService.GetDepartment(departmentIdComboBox);
            var freePlates = _departmentService.GetAllFreePlatesByDepartment(departmentDB.Id);

            foreach (var plate in freePlates)
            {
                comboBoxRemoveFreePlateValue.Items.Add(plate.PlateValue);
            }

            if (comboBoxRemoveFreePlateValue.Items.Count > 0)
            {
                comboBoxRemoveFreePlateValue.SelectedIndex = 0;
            }

        }

        private void comboBoxRemovePayablePlateDepartmentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRemovePayablePlateValue.Items.Clear();

            var departmentIdComboBox = comboBoxRemovePayablePlateDepartmentId.SelectedItem.ToString();
            var departmentDB = _departmentService.GetDepartment(departmentIdComboBox);
            var payablePlates = _departmentService.GetAllPayablePlatesByDepartment(departmentDB.Id);

            foreach (var plate in payablePlates)
            {
                comboBoxRemovePayablePlateValue.Items.Add(plate.PlateValue);
            }

            if (comboBoxRemovePayablePlateValue.Items.Count > 0)
            {
                comboBoxRemovePayablePlateValue.SelectedIndex = 0;
            }

        }

        private void buttonRemoveFreePlate_Click(object sender, EventArgs e)
        {
            string valuePlate = comboBoxRemoveFreePlateValue.SelectedItem.ToString();
            var removedCount = _departmentService.RemoveFreePlateByPlateValue(valuePlate);
            if (removedCount > 0)
            {
                MessageBox.Show("Done");
                LoadData();
                UpdateComboboxes();
            }
            else { MessageBox.Show("Something went wrong!"); }
        }

        private void buttonRemovePayablePlate_Click(object sender, EventArgs e)
        {
            string valuePlate = comboBoxRemovePayablePlateValue.SelectedItem.ToString();
            var removedCount = _departmentService.RemovePayablePlateByPlateValue(valuePlate);
            if (removedCount > 0)
            {
                MessageBox.Show("Done");
                LoadData();
                UpdateComboboxes();
            }
            else { MessageBox.Show("Something went wrong!"); }
        }
    }
}
