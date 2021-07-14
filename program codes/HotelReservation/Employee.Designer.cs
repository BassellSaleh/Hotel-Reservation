namespace HotelReservation
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet = new HotelReservation.HotelReservationDataSet();
            this.employeesTableAdapter = new HotelReservation.HotelReservationDataSetTableAdapters.EmployeesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eidDataGridViewTextBoxColumn,
            this.enameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.jobtitleDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.bDateDataGridViewTextBoxColumn,
            this.hotelidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.employeesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(34, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(822, 146);
            this.dataGridView2.TabIndex = 0;
            // 
            // eidDataGridViewTextBoxColumn
            // 
            this.eidDataGridViewTextBoxColumn.DataPropertyName = "E_id";
            this.eidDataGridViewTextBoxColumn.HeaderText = "E_id";
            this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            this.eidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enameDataGridViewTextBoxColumn
            // 
            this.enameDataGridViewTextBoxColumn.DataPropertyName = "E_name";
            this.enameDataGridViewTextBoxColumn.HeaderText = "E_name";
            this.enameDataGridViewTextBoxColumn.Name = "enameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // jobtitleDataGridViewTextBoxColumn
            // 
            this.jobtitleDataGridViewTextBoxColumn.DataPropertyName = "Job_title";
            this.jobtitleDataGridViewTextBoxColumn.HeaderText = "Job_title";
            this.jobtitleDataGridViewTextBoxColumn.Name = "jobtitleDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // bDateDataGridViewTextBoxColumn
            // 
            this.bDateDataGridViewTextBoxColumn.DataPropertyName = "BDate";
            this.bDateDataGridViewTextBoxColumn.HeaderText = "BDate";
            this.bDateDataGridViewTextBoxColumn.Name = "bDateDataGridViewTextBoxColumn";
            // 
            // hotelidDataGridViewTextBoxColumn
            // 
            this.hotelidDataGridViewTextBoxColumn.DataPropertyName = "hotel_id";
            this.hotelidDataGridViewTextBoxColumn.HeaderText = "hotel_id";
            this.hotelidDataGridViewTextBoxColumn.Name = "hotelidDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hotelReservationDataSet;
            // 
            // hotelReservationDataSet
            // 
            this.hotelReservationDataSet.DataSetName = "HotelReservationDataSet";
            this.hotelReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(383, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(914, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private HotelReservationDataSet hotelReservationDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HotelReservationDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}