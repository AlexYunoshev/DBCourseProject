
namespace DBCourseProject.Presentation
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMainData = new System.Windows.Forms.DataGridView();
            this.DepId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepPayable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDepartmentBox = new System.Windows.Forms.GroupBox();
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.textBoxAddDepartmentName = new System.Windows.Forms.TextBox();
            this.labelDepartmentName = new System.Windows.Forms.Label();
            this.textBoxAddDepartmentCity = new System.Windows.Forms.TextBox();
            this.labelDepartmentCity = new System.Windows.Forms.Label();
            this.textBoxAddDepartmentId = new System.Windows.Forms.TextBox();
            this.labelDepartmentId = new System.Windows.Forms.Label();
            this.addFreePlateBox = new System.Windows.Forms.GroupBox();
            this.comboBoxAddFreePlateDepartmentId = new System.Windows.Forms.ComboBox();
            this.buttonAddFreePlate = new System.Windows.Forms.Button();
            this.textBoxAddFreePlateValue = new System.Windows.Forms.TextBox();
            this.labelFreePlateValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addPayeblePlateBox = new System.Windows.Forms.GroupBox();
            this.comboBoxAddPayablePlateDepartmentId = new System.Windows.Forms.ComboBox();
            this.buttonAddPayablePlate = new System.Windows.Forms.Button();
            this.textBoxAddPayablePlateValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeFreePlateBox = new System.Windows.Forms.GroupBox();
            this.comboBoxRemoveFreePlateValue = new System.Windows.Forms.ComboBox();
            this.comboBoxRemoveFreePlateDepartmentId = new System.Windows.Forms.ComboBox();
            this.buttonRemoveFreePlate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.removePayablePlateBox = new System.Windows.Forms.GroupBox();
            this.comboBoxRemovePayablePlateValue = new System.Windows.Forms.ComboBox();
            this.comboBoxRemovePayablePlateDepartmentId = new System.Windows.Forms.ComboBox();
            this.buttonRemovePayablePlate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.removeDepartmentBox = new System.Windows.Forms.GroupBox();
            this.buttonRemoveDepartment = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxRemoveDepartmentId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainData)).BeginInit();
            this.addDepartmentBox.SuspendLayout();
            this.addFreePlateBox.SuspendLayout();
            this.addPayeblePlateBox.SuspendLayout();
            this.removeFreePlateBox.SuspendLayout();
            this.removePayablePlateBox.SuspendLayout();
            this.removeDepartmentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMainData
            // 
            this.dgvMainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepId,
            this.DepCity,
            this.Dep,
            this.DepFree,
            this.DepPayable});
            this.dgvMainData.Location = new System.Drawing.Point(12, 12);
            this.dgvMainData.Name = "dgvMainData";
            this.dgvMainData.RowTemplate.Height = 25;
            this.dgvMainData.Size = new System.Drawing.Size(1240, 298);
            this.dgvMainData.TabIndex = 0;
            // 
            // DepId
            // 
            this.DepId.HeaderText = "Id";
            this.DepId.Name = "DepId";
            this.DepId.ReadOnly = true;
            // 
            // DepCity
            // 
            this.DepCity.HeaderText = "City";
            this.DepCity.Name = "DepCity";
            this.DepCity.ReadOnly = true;
            this.DepCity.Width = 300;
            // 
            // Dep
            // 
            this.Dep.HeaderText = "Dep";
            this.Dep.Name = "Dep";
            this.Dep.ReadOnly = true;
            this.Dep.Width = 300;
            // 
            // DepFree
            // 
            this.DepFree.HeaderText = "Free plates";
            this.DepFree.Name = "DepFree";
            this.DepFree.ReadOnly = true;
            this.DepFree.Width = 250;
            // 
            // DepPayable
            // 
            this.DepPayable.HeaderText = "Payable plates";
            this.DepPayable.Name = "DepPayable";
            this.DepPayable.ReadOnly = true;
            this.DepPayable.Width = 250;
            // 
            // addDepartmentBox
            // 
            this.addDepartmentBox.Controls.Add(this.buttonAddDepartment);
            this.addDepartmentBox.Controls.Add(this.textBoxAddDepartmentName);
            this.addDepartmentBox.Controls.Add(this.labelDepartmentName);
            this.addDepartmentBox.Controls.Add(this.textBoxAddDepartmentCity);
            this.addDepartmentBox.Controls.Add(this.labelDepartmentCity);
            this.addDepartmentBox.Controls.Add(this.textBoxAddDepartmentId);
            this.addDepartmentBox.Controls.Add(this.labelDepartmentId);
            this.addDepartmentBox.Location = new System.Drawing.Point(12, 329);
            this.addDepartmentBox.Name = "addDepartmentBox";
            this.addDepartmentBox.Size = new System.Drawing.Size(266, 162);
            this.addDepartmentBox.TabIndex = 1;
            this.addDepartmentBox.TabStop = false;
            this.addDepartmentBox.Text = "Add a department";
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.Location = new System.Drawing.Point(6, 128);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(248, 23);
            this.buttonAddDepartment.TabIndex = 8;
            this.buttonAddDepartment.Text = "Add";
            this.buttonAddDepartment.UseVisualStyleBackColor = true;
            this.buttonAddDepartment.Click += new System.EventHandler(this.buttonAddDepartment_Click);
            // 
            // textBoxAddDepartmentName
            // 
            this.textBoxAddDepartmentName.Location = new System.Drawing.Point(96, 94);
            this.textBoxAddDepartmentName.Name = "textBoxAddDepartmentName";
            this.textBoxAddDepartmentName.PlaceholderText = "ТСЦ 0542 РСЦ ГСЦ МВС";
            this.textBoxAddDepartmentName.Size = new System.Drawing.Size(158, 23);
            this.textBoxAddDepartmentName.TabIndex = 7;
            // 
            // labelDepartmentName
            // 
            this.labelDepartmentName.AutoSize = true;
            this.labelDepartmentName.Location = new System.Drawing.Point(6, 97);
            this.labelDepartmentName.Name = "labelDepartmentName";
            this.labelDepartmentName.Size = new System.Drawing.Size(39, 15);
            this.labelDepartmentName.TabIndex = 6;
            this.labelDepartmentName.Text = "Name";
            // 
            // textBoxAddDepartmentCity
            // 
            this.textBoxAddDepartmentCity.Location = new System.Drawing.Point(96, 59);
            this.textBoxAddDepartmentCity.Name = "textBoxAddDepartmentCity";
            this.textBoxAddDepartmentCity.PlaceholderText = "Київська обл., м.Київ";
            this.textBoxAddDepartmentCity.Size = new System.Drawing.Size(158, 23);
            this.textBoxAddDepartmentCity.TabIndex = 5;
            // 
            // labelDepartmentCity
            // 
            this.labelDepartmentCity.AutoSize = true;
            this.labelDepartmentCity.Location = new System.Drawing.Point(6, 62);
            this.labelDepartmentCity.Name = "labelDepartmentCity";
            this.labelDepartmentCity.Size = new System.Drawing.Size(28, 15);
            this.labelDepartmentCity.TabIndex = 4;
            this.labelDepartmentCity.Text = "City";
            // 
            // textBoxAddDepartmentId
            // 
            this.textBoxAddDepartmentId.Location = new System.Drawing.Point(96, 26);
            this.textBoxAddDepartmentId.Name = "textBoxAddDepartmentId";
            this.textBoxAddDepartmentId.PlaceholderText = "12300";
            this.textBoxAddDepartmentId.Size = new System.Drawing.Size(158, 23);
            this.textBoxAddDepartmentId.TabIndex = 3;
            // 
            // labelDepartmentId
            // 
            this.labelDepartmentId.AutoSize = true;
            this.labelDepartmentId.Location = new System.Drawing.Point(6, 29);
            this.labelDepartmentId.Name = "labelDepartmentId";
            this.labelDepartmentId.Size = new System.Drawing.Size(84, 15);
            this.labelDepartmentId.TabIndex = 2;
            this.labelDepartmentId.Text = "Department ID";
            // 
            // addFreePlateBox
            // 
            this.addFreePlateBox.Controls.Add(this.comboBoxAddFreePlateDepartmentId);
            this.addFreePlateBox.Controls.Add(this.buttonAddFreePlate);
            this.addFreePlateBox.Controls.Add(this.textBoxAddFreePlateValue);
            this.addFreePlateBox.Controls.Add(this.labelFreePlateValue);
            this.addFreePlateBox.Controls.Add(this.label3);
            this.addFreePlateBox.Location = new System.Drawing.Point(316, 329);
            this.addFreePlateBox.Name = "addFreePlateBox";
            this.addFreePlateBox.Size = new System.Drawing.Size(266, 117);
            this.addFreePlateBox.TabIndex = 2;
            this.addFreePlateBox.TabStop = false;
            this.addFreePlateBox.Text = "Add free plate to department";
            // 
            // comboBoxAddFreePlateDepartmentId
            // 
            this.comboBoxAddFreePlateDepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddFreePlateDepartmentId.FormattingEnabled = true;
            this.comboBoxAddFreePlateDepartmentId.Location = new System.Drawing.Point(96, 26);
            this.comboBoxAddFreePlateDepartmentId.Name = "comboBoxAddFreePlateDepartmentId";
            this.comboBoxAddFreePlateDepartmentId.Size = new System.Drawing.Size(158, 23);
            this.comboBoxAddFreePlateDepartmentId.TabIndex = 9;
            // 
            // buttonAddFreePlate
            // 
            this.buttonAddFreePlate.Location = new System.Drawing.Point(6, 89);
            this.buttonAddFreePlate.Name = "buttonAddFreePlate";
            this.buttonAddFreePlate.Size = new System.Drawing.Size(248, 23);
            this.buttonAddFreePlate.TabIndex = 8;
            this.buttonAddFreePlate.Text = "Add";
            this.buttonAddFreePlate.UseVisualStyleBackColor = true;
            this.buttonAddFreePlate.Click += new System.EventHandler(this.buttonAddFreePlate_Click);
            // 
            // textBoxAddFreePlateValue
            // 
            this.textBoxAddFreePlateValue.Location = new System.Drawing.Point(96, 59);
            this.textBoxAddFreePlateValue.Name = "textBoxAddFreePlateValue";
            this.textBoxAddFreePlateValue.PlaceholderText = "АХ0440ВМ";
            this.textBoxAddFreePlateValue.Size = new System.Drawing.Size(158, 23);
            this.textBoxAddFreePlateValue.TabIndex = 5;
            // 
            // labelFreePlateValue
            // 
            this.labelFreePlateValue.AutoSize = true;
            this.labelFreePlateValue.Location = new System.Drawing.Point(6, 62);
            this.labelFreePlateValue.Name = "labelFreePlateValue";
            this.labelFreePlateValue.Size = new System.Drawing.Size(64, 15);
            this.labelFreePlateValue.TabIndex = 4;
            this.labelFreePlateValue.Text = "Plate value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department ID";
            // 
            // addPayeblePlateBox
            // 
            this.addPayeblePlateBox.Controls.Add(this.comboBoxAddPayablePlateDepartmentId);
            this.addPayeblePlateBox.Controls.Add(this.buttonAddPayablePlate);
            this.addPayeblePlateBox.Controls.Add(this.textBoxAddPayablePlateValue);
            this.addPayeblePlateBox.Controls.Add(this.label1);
            this.addPayeblePlateBox.Controls.Add(this.label2);
            this.addPayeblePlateBox.Location = new System.Drawing.Point(623, 329);
            this.addPayeblePlateBox.Name = "addPayeblePlateBox";
            this.addPayeblePlateBox.Size = new System.Drawing.Size(266, 117);
            this.addPayeblePlateBox.TabIndex = 3;
            this.addPayeblePlateBox.TabStop = false;
            this.addPayeblePlateBox.Text = "Add payable plate to department";
            // 
            // comboBoxAddPayablePlateDepartmentId
            // 
            this.comboBoxAddPayablePlateDepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddPayablePlateDepartmentId.FormattingEnabled = true;
            this.comboBoxAddPayablePlateDepartmentId.Location = new System.Drawing.Point(96, 26);
            this.comboBoxAddPayablePlateDepartmentId.Name = "comboBoxAddPayablePlateDepartmentId";
            this.comboBoxAddPayablePlateDepartmentId.Size = new System.Drawing.Size(158, 23);
            this.comboBoxAddPayablePlateDepartmentId.TabIndex = 9;
            // 
            // buttonAddPayablePlate
            // 
            this.buttonAddPayablePlate.Location = new System.Drawing.Point(6, 89);
            this.buttonAddPayablePlate.Name = "buttonAddPayablePlate";
            this.buttonAddPayablePlate.Size = new System.Drawing.Size(248, 23);
            this.buttonAddPayablePlate.TabIndex = 8;
            this.buttonAddPayablePlate.Text = "Add";
            this.buttonAddPayablePlate.UseVisualStyleBackColor = true;
            this.buttonAddPayablePlate.Click += new System.EventHandler(this.buttonAddPayablePlate_Click);
            // 
            // textBoxAddPayablePlateValue
            // 
            this.textBoxAddPayablePlateValue.Location = new System.Drawing.Point(96, 59);
            this.textBoxAddPayablePlateValue.Name = "textBoxAddPayablePlateValue";
            this.textBoxAddPayablePlateValue.PlaceholderText = "АХ0440ВМ";
            this.textBoxAddPayablePlateValue.Size = new System.Drawing.Size(158, 23);
            this.textBoxAddPayablePlateValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plate value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department ID";
            // 
            // removeFreePlateBox
            // 
            this.removeFreePlateBox.Controls.Add(this.comboBoxRemoveFreePlateValue);
            this.removeFreePlateBox.Controls.Add(this.comboBoxRemoveFreePlateDepartmentId);
            this.removeFreePlateBox.Controls.Add(this.buttonRemoveFreePlate);
            this.removeFreePlateBox.Controls.Add(this.label4);
            this.removeFreePlateBox.Controls.Add(this.label5);
            this.removeFreePlateBox.Location = new System.Drawing.Point(316, 474);
            this.removeFreePlateBox.Name = "removeFreePlateBox";
            this.removeFreePlateBox.Size = new System.Drawing.Size(266, 117);
            this.removeFreePlateBox.TabIndex = 4;
            this.removeFreePlateBox.TabStop = false;
            this.removeFreePlateBox.Text = "Remove free plate from department";
            // 
            // comboBoxRemoveFreePlateValue
            // 
            this.comboBoxRemoveFreePlateValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemoveFreePlateValue.FormattingEnabled = true;
            this.comboBoxRemoveFreePlateValue.Location = new System.Drawing.Point(96, 59);
            this.comboBoxRemoveFreePlateValue.Name = "comboBoxRemoveFreePlateValue";
            this.comboBoxRemoveFreePlateValue.Size = new System.Drawing.Size(158, 23);
            this.comboBoxRemoveFreePlateValue.TabIndex = 10;
            // 
            // comboBoxRemoveFreePlateDepartmentId
            // 
            this.comboBoxRemoveFreePlateDepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemoveFreePlateDepartmentId.FormattingEnabled = true;
            this.comboBoxRemoveFreePlateDepartmentId.Location = new System.Drawing.Point(96, 26);
            this.comboBoxRemoveFreePlateDepartmentId.Name = "comboBoxRemoveFreePlateDepartmentId";
            this.comboBoxRemoveFreePlateDepartmentId.Size = new System.Drawing.Size(158, 23);
            this.comboBoxRemoveFreePlateDepartmentId.TabIndex = 9;
            this.comboBoxRemoveFreePlateDepartmentId.SelectedIndexChanged += new System.EventHandler(this.comboBoxRemoveFreePlateDepartmentId_SelectedIndexChanged);
            // 
            // buttonRemoveFreePlate
            // 
            this.buttonRemoveFreePlate.Location = new System.Drawing.Point(6, 89);
            this.buttonRemoveFreePlate.Name = "buttonRemoveFreePlate";
            this.buttonRemoveFreePlate.Size = new System.Drawing.Size(248, 23);
            this.buttonRemoveFreePlate.TabIndex = 8;
            this.buttonRemoveFreePlate.Text = "Remove";
            this.buttonRemoveFreePlate.UseVisualStyleBackColor = true;
            this.buttonRemoveFreePlate.Click += new System.EventHandler(this.buttonRemoveFreePlate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plate value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Department ID";
            // 
            // removePayablePlateBox
            // 
            this.removePayablePlateBox.Controls.Add(this.comboBoxRemovePayablePlateValue);
            this.removePayablePlateBox.Controls.Add(this.comboBoxRemovePayablePlateDepartmentId);
            this.removePayablePlateBox.Controls.Add(this.buttonRemovePayablePlate);
            this.removePayablePlateBox.Controls.Add(this.label6);
            this.removePayablePlateBox.Controls.Add(this.label7);
            this.removePayablePlateBox.Location = new System.Drawing.Point(623, 474);
            this.removePayablePlateBox.Name = "removePayablePlateBox";
            this.removePayablePlateBox.Size = new System.Drawing.Size(266, 117);
            this.removePayablePlateBox.TabIndex = 5;
            this.removePayablePlateBox.TabStop = false;
            this.removePayablePlateBox.Text = "Remove payable plate from department";
            // 
            // comboBoxRemovePayablePlateValue
            // 
            this.comboBoxRemovePayablePlateValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemovePayablePlateValue.FormattingEnabled = true;
            this.comboBoxRemovePayablePlateValue.Location = new System.Drawing.Point(96, 59);
            this.comboBoxRemovePayablePlateValue.Name = "comboBoxRemovePayablePlateValue";
            this.comboBoxRemovePayablePlateValue.Size = new System.Drawing.Size(158, 23);
            this.comboBoxRemovePayablePlateValue.TabIndex = 10;
            // 
            // comboBoxRemovePayablePlateDepartmentId
            // 
            this.comboBoxRemovePayablePlateDepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemovePayablePlateDepartmentId.FormattingEnabled = true;
            this.comboBoxRemovePayablePlateDepartmentId.Location = new System.Drawing.Point(96, 26);
            this.comboBoxRemovePayablePlateDepartmentId.Name = "comboBoxRemovePayablePlateDepartmentId";
            this.comboBoxRemovePayablePlateDepartmentId.Size = new System.Drawing.Size(158, 23);
            this.comboBoxRemovePayablePlateDepartmentId.TabIndex = 9;
            this.comboBoxRemovePayablePlateDepartmentId.SelectedIndexChanged += new System.EventHandler(this.comboBoxRemovePayablePlateDepartmentId_SelectedIndexChanged);
            // 
            // buttonRemovePayablePlate
            // 
            this.buttonRemovePayablePlate.Location = new System.Drawing.Point(6, 89);
            this.buttonRemovePayablePlate.Name = "buttonRemovePayablePlate";
            this.buttonRemovePayablePlate.Size = new System.Drawing.Size(248, 23);
            this.buttonRemovePayablePlate.TabIndex = 8;
            this.buttonRemovePayablePlate.Text = "Remove";
            this.buttonRemovePayablePlate.UseVisualStyleBackColor = true;
            this.buttonRemovePayablePlate.Click += new System.EventHandler(this.buttonRemovePayablePlate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Plate value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Department ID";
            // 
            // removeDepartmentBox
            // 
            this.removeDepartmentBox.Controls.Add(this.comboBoxRemoveDepartmentId);
            this.removeDepartmentBox.Controls.Add(this.buttonRemoveDepartment);
            this.removeDepartmentBox.Controls.Add(this.label10);
            this.removeDepartmentBox.Location = new System.Drawing.Point(12, 507);
            this.removeDepartmentBox.Name = "removeDepartmentBox";
            this.removeDepartmentBox.Size = new System.Drawing.Size(266, 84);
            this.removeDepartmentBox.TabIndex = 6;
            this.removeDepartmentBox.TabStop = false;
            this.removeDepartmentBox.Text = "Remove a department";
            // 
            // buttonRemoveDepartment
            // 
            this.buttonRemoveDepartment.Location = new System.Drawing.Point(6, 55);
            this.buttonRemoveDepartment.Name = "buttonRemoveDepartment";
            this.buttonRemoveDepartment.Size = new System.Drawing.Size(248, 23);
            this.buttonRemoveDepartment.TabIndex = 8;
            this.buttonRemoveDepartment.Text = "Remove";
            this.buttonRemoveDepartment.UseVisualStyleBackColor = true;
            this.buttonRemoveDepartment.Click += new System.EventHandler(this.buttonRemoveDepartment_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Department ID";
            // 
            // comboBoxRemoveDepartmentId
            // 
            this.comboBoxRemoveDepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemoveDepartmentId.FormattingEnabled = true;
            this.comboBoxRemoveDepartmentId.Location = new System.Drawing.Point(96, 21);
            this.comboBoxRemoveDepartmentId.Name = "comboBoxRemoveDepartmentId";
            this.comboBoxRemoveDepartmentId.Size = new System.Drawing.Size(158, 23);
            this.comboBoxRemoveDepartmentId.TabIndex = 10;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.removeDepartmentBox);
            this.Controls.Add(this.removePayablePlateBox);
            this.Controls.Add(this.removeFreePlateBox);
            this.Controls.Add(this.addPayeblePlateBox);
            this.Controls.Add(this.addFreePlateBox);
            this.Controls.Add(this.addDepartmentBox);
            this.Controls.Add(this.dgvMainData);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home page";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainData)).EndInit();
            this.addDepartmentBox.ResumeLayout(false);
            this.addDepartmentBox.PerformLayout();
            this.addFreePlateBox.ResumeLayout(false);
            this.addFreePlateBox.PerformLayout();
            this.addPayeblePlateBox.ResumeLayout(false);
            this.addPayeblePlateBox.PerformLayout();
            this.removeFreePlateBox.ResumeLayout(false);
            this.removeFreePlateBox.PerformLayout();
            this.removePayablePlateBox.ResumeLayout(false);
            this.removePayablePlateBox.PerformLayout();
            this.removeDepartmentBox.ResumeLayout(false);
            this.removeDepartmentBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMainData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepFree;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepPayable;
        private System.Windows.Forms.GroupBox addDepartmentBox;
        private System.Windows.Forms.Button buttonAddDepartment;
        private System.Windows.Forms.TextBox textBoxAddDepartmentName;
        private System.Windows.Forms.Label labelDepartmentName;
        private System.Windows.Forms.TextBox textBoxAddDepartmentCity;
        private System.Windows.Forms.Label labelDepartmentCity;
        private System.Windows.Forms.TextBox textBoxAddDepartmentId;
        private System.Windows.Forms.Label labelDepartmentId;
        private System.Windows.Forms.GroupBox addFreePlateBox;
        private System.Windows.Forms.ComboBox comboBoxAddFreePlateDepartmentId;
        private System.Windows.Forms.Button buttonAddFreePlate;
        private System.Windows.Forms.TextBox textBoxAddFreePlateValue;
        private System.Windows.Forms.Label labelFreePlateValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox addPayeblePlateBox;
        private System.Windows.Forms.ComboBox comboBoxAddPayablePlateDepartmentId;
        private System.Windows.Forms.Button buttonAddPayablePlate;
        private System.Windows.Forms.TextBox textBoxAddPayablePlateValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox removeFreePlateBox;
        private System.Windows.Forms.ComboBox comboBoxRemoveFreePlateValue;
        private System.Windows.Forms.ComboBox comboBoxRemoveFreePlateDepartmentId;
        private System.Windows.Forms.Button buttonRemoveFreePlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox removePayablePlateBox;
        private System.Windows.Forms.ComboBox comboBoxRemovePayablePlateValue;
        private System.Windows.Forms.ComboBox comboBoxRemovePayablePlateDepartmentId;
        private System.Windows.Forms.Button buttonRemovePayablePlate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox removeDepartmentBox;
        private System.Windows.Forms.ComboBox comboBoxRemoveDepartmentId;
        private System.Windows.Forms.Button buttonRemoveDepartment;
        private System.Windows.Forms.Label label10;
    }
}