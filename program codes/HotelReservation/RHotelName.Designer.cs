namespace HotelReservation
{
    partial class RHotelName
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RbyHotelNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HotelReservationDataSet = new HotelReservation.HotelReservationDataSet();
            this.hotelReservationDataSet1 = new HotelReservation.HotelReservationDataSet();
            this.hotelReservationDataSet2 = new HotelReservation.HotelReservationDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RbyHotelNameTableAdapter = new HotelReservation.HotelReservationDataSetTableAdapters.RbyHotelNameTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.hotelTableAdapter = new HotelReservation.HotelReservationDataSetTableAdapters.HotelTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RbyHotelNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelReservationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RbyHotelNameBindingSource
            // 
            this.RbyHotelNameBindingSource.DataMember = "RbyHotelName";
            this.RbyHotelNameBindingSource.DataSource = this.HotelReservationDataSet;
            // 
            // HotelReservationDataSet
            // 
            this.HotelReservationDataSet.DataSetName = "HotelReservationDataSet";
            this.HotelReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelReservationDataSet1
            // 
            this.hotelReservationDataSet1.DataSetName = "HotelReservationDataSet";
            this.hotelReservationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelReservationDataSet2
            // 
            this.hotelReservationDataSet2.DataSetName = "HotelReservationDataSet";
            this.hotelReservationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.LightCoral;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RbyHotelNameBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelReservation.RHotelName.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 138);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1375, 249);
            this.reportViewer1.TabIndex = 0;
            // 
            // RbyHotelNameTableAdapter
            // 
            this.RbyHotelNameTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(810, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(526, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 25);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter The Hotel Name";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DataSource = this.hotelBindingSource;
            this.comboBox1.DisplayMember = "H_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(507, 88);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 25);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "H_name";
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.HotelReservationDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Your Hotel name";
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1022, 41);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(39, 48);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 65);
            this.button3.TabIndex = 7;
            this.button3.Text = "Go to Main form";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RHotelName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 390);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RHotelName";
            this.Text = "RHotelName";
            this.Load += new System.EventHandler(this.RHotelName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RbyHotelNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelReservationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelReservationDataSet hotelReservationDataSet1;
        private HotelReservationDataSet hotelReservationDataSet2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RbyHotelNameBindingSource;
        private HotelReservationDataSet HotelReservationDataSet;
        private HotelReservationDataSetTableAdapters.RbyHotelNameTableAdapter RbyHotelNameTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private HotelReservationDataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}