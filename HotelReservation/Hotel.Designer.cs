namespace HotelReservation
{
    partial class Hotel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hlocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet = new HotelReservation.HotelReservationDataSet();
            this.hotelTableAdapter = new HotelReservation.HotelReservationDataSetTableAdapters.HotelTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hidDataGridViewTextBoxColumn,
            this.hnameDataGridViewTextBoxColumn,
            this.hlocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hotelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(223, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 133);
            this.dataGridView1.TabIndex = 0;
            // 
            // hidDataGridViewTextBoxColumn
            // 
            this.hidDataGridViewTextBoxColumn.DataPropertyName = "H_id";
            this.hidDataGridViewTextBoxColumn.HeaderText = "H_id";
            this.hidDataGridViewTextBoxColumn.Name = "hidDataGridViewTextBoxColumn";
            this.hidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hnameDataGridViewTextBoxColumn
            // 
            this.hnameDataGridViewTextBoxColumn.DataPropertyName = "H_name";
            this.hnameDataGridViewTextBoxColumn.HeaderText = "H_name";
            this.hnameDataGridViewTextBoxColumn.Name = "hnameDataGridViewTextBoxColumn";
            // 
            // hlocationDataGridViewTextBoxColumn
            // 
            this.hlocationDataGridViewTextBoxColumn.DataPropertyName = "H_location";
            this.hlocationDataGridViewTextBoxColumn.HeaderText = "H_location";
            this.hlocationDataGridViewTextBoxColumn.Name = "hlocationDataGridViewTextBoxColumn";
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.hotelReservationDataSet;
            // 
            // hotelReservationDataSet
            // 
            this.hotelReservationDataSet.DataSetName = "HotelReservationDataSet";
            this.hotelReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(346, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(907, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Hotel";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Hotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelReservationDataSet hotelReservationDataSet;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private HotelReservationDataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hlocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}