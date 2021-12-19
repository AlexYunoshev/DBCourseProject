
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainData)).BeginInit();
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
            this.dgvMainData.Size = new System.Drawing.Size(1240, 257);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgvMainData);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home page";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMainData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepFree;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepPayable;
    }
}