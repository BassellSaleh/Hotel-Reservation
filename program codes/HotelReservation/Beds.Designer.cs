namespace HotelReservation
{
    partial class Beds
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
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet = new HotelReservation.HotelReservationDataSet();
            this.bedsTableAdapter = new HotelReservation.HotelReservationDataSetTableAdapters.BedsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidDataGridViewTextBoxColumn,
            this.btypeDataGridViewTextBoxColumn,
            this.rNoDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.bedsBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(198, 30);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(426, 72);
            this.dataGridView6.TabIndex = 0;
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "B_id";
            this.bidDataGridViewTextBoxColumn.HeaderText = "B_id";
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btypeDataGridViewTextBoxColumn
            // 
            this.btypeDataGridViewTextBoxColumn.DataPropertyName = "B_type";
            this.btypeDataGridViewTextBoxColumn.HeaderText = "B_type";
            this.btypeDataGridViewTextBoxColumn.Name = "btypeDataGridViewTextBoxColumn";
            // 
            // rNoDataGridViewTextBoxColumn
            // 
            this.rNoDataGridViewTextBoxColumn.DataPropertyName = "R_No";
            this.rNoDataGridViewTextBoxColumn.HeaderText = "R_No";
            this.rNoDataGridViewTextBoxColumn.Name = "rNoDataGridViewTextBoxColumn";
            // 
            // bedsBindingSource
            // 
            this.bedsBindingSource.DataMember = "Beds";
            this.bedsBindingSource.DataSource = this.hotelReservationDataSet;
            // 
            // hotelReservationDataSet
            // 
            this.hotelReservationDataSet.DataSetName = "HotelReservationDataSet";
            this.hotelReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bedsTableAdapter
            // 
            this.bedsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(310, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Beds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(862, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView6);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Beds";
            this.Text = "Beds";
            this.Load += new System.EventHandler(this.Beds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView6;
        private HotelReservationDataSet hotelReservationDataSet;
        private System.Windows.Forms.BindingSource bedsBindingSource;
        private HotelReservationDataSetTableAdapters.BedsTableAdapter bedsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}