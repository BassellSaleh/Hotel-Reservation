namespace HotelReservation
{
    partial class Reservation
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
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.resNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet = new HotelReservation.HotelReservationDataSet();
            this.reservationTableAdapter = new HotelReservation.HotelReservationDataSetTableAdapters.ReservationTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView8
            // 
            this.dataGridView8.AutoGenerateColumns = false;
            this.dataGridView8.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resNumberDataGridViewTextBoxColumn,
            this.checkinDataGridViewTextBoxColumn,
            this.checkoutDataGridViewTextBoxColumn,
            this.rNoDataGridViewTextBoxColumn,
            this.gidDataGridViewTextBoxColumn});
            this.dataGridView8.DataSource = this.reservationBindingSource;
            this.dataGridView8.Location = new System.Drawing.Point(61, 27);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.Size = new System.Drawing.Size(616, 160);
            this.dataGridView8.TabIndex = 0;
            // 
            // resNumberDataGridViewTextBoxColumn
            // 
            this.resNumberDataGridViewTextBoxColumn.DataPropertyName = "Res_Number";
            this.resNumberDataGridViewTextBoxColumn.HeaderText = "Res_Number";
            this.resNumberDataGridViewTextBoxColumn.Name = "resNumberDataGridViewTextBoxColumn";
            this.resNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkinDataGridViewTextBoxColumn
            // 
            this.checkinDataGridViewTextBoxColumn.DataPropertyName = "check_in";
            this.checkinDataGridViewTextBoxColumn.HeaderText = "check_in";
            this.checkinDataGridViewTextBoxColumn.Name = "checkinDataGridViewTextBoxColumn";
            // 
            // checkoutDataGridViewTextBoxColumn
            // 
            this.checkoutDataGridViewTextBoxColumn.DataPropertyName = "check_out";
            this.checkoutDataGridViewTextBoxColumn.HeaderText = "check_out";
            this.checkoutDataGridViewTextBoxColumn.Name = "checkoutDataGridViewTextBoxColumn";
            // 
            // rNoDataGridViewTextBoxColumn
            // 
            this.rNoDataGridViewTextBoxColumn.DataPropertyName = "R_No";
            this.rNoDataGridViewTextBoxColumn.HeaderText = "R_No";
            this.rNoDataGridViewTextBoxColumn.Name = "rNoDataGridViewTextBoxColumn";
            // 
            // gidDataGridViewTextBoxColumn
            // 
            this.gidDataGridViewTextBoxColumn.DataPropertyName = "G_id";
            this.gidDataGridViewTextBoxColumn.HeaderText = "G_id";
            this.gidDataGridViewTextBoxColumn.Name = "gidDataGridViewTextBoxColumn";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            this.reservationBindingSource.DataSource = this.hotelReservationDataSet;
            // 
            // hotelReservationDataSet
            // 
            this.hotelReservationDataSet.DataSetName = "HotelReservationDataSet";
            this.hotelReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(307, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView8);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView8;
        private HotelReservationDataSet hotelReservationDataSet;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private HotelReservationDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn resNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}