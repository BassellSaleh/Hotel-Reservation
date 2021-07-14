namespace HotelReservation
{
    partial class Room_Type
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
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.rtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet = new HotelReservation.HotelReservationDataSet();
            this.room_TypeTableAdapter = new HotelReservation.HotelReservationDataSetTableAdapters.Room_TypeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rtypeDataGridViewTextBoxColumn,
            this.rtypeDataGridViewTextBoxColumn1,
            this.rNoDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.roomTypeBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(237, 34);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(388, 93);
            this.dataGridView5.TabIndex = 0;
            // 
            // rtypeDataGridViewTextBoxColumn
            // 
            this.rtypeDataGridViewTextBoxColumn.DataPropertyName = "R_type";
            this.rtypeDataGridViewTextBoxColumn.HeaderText = "R_type";
            this.rtypeDataGridViewTextBoxColumn.Name = "rtypeDataGridViewTextBoxColumn";
            this.rtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rtypeDataGridViewTextBoxColumn1
            // 
            this.rtypeDataGridViewTextBoxColumn1.DataPropertyName = "Rtype";
            this.rtypeDataGridViewTextBoxColumn1.HeaderText = "Rtype";
            this.rtypeDataGridViewTextBoxColumn1.Name = "rtypeDataGridViewTextBoxColumn1";
            // 
            // rNoDataGridViewTextBoxColumn
            // 
            this.rNoDataGridViewTextBoxColumn.DataPropertyName = "R_No";
            this.rNoDataGridViewTextBoxColumn.HeaderText = "R_No";
            this.rNoDataGridViewTextBoxColumn.Name = "rNoDataGridViewTextBoxColumn";
            // 
            // roomTypeBindingSource
            // 
            this.roomTypeBindingSource.DataMember = "Room_Type";
            this.roomTypeBindingSource.DataSource = this.hotelReservationDataSet;
            // 
            // hotelReservationDataSet
            // 
            this.hotelReservationDataSet.DataSetName = "HotelReservationDataSet";
            this.hotelReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // room_TypeTableAdapter
            // 
            this.room_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(344, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Room_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(838, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView5);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Room_Type";
            this.Text = "Room_Type";
            this.Load += new System.EventHandler(this.Room_Type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView5;
        private HotelReservationDataSet hotelReservationDataSet;
        private System.Windows.Forms.BindingSource roomTypeBindingSource;
        private HotelReservationDataSetTableAdapters.Room_TypeTableAdapter room_TypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}