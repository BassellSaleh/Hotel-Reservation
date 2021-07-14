namespace HotelReservation
{
    partial class Rooms
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet = new HotelReservation.HotelReservationDataSet();
            this.roomsTableAdapter = new HotelReservation.HotelReservationDataSetTableAdapters.RoomsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.rviewDataGridViewTextBoxColumn,
            this.rlevelDataGridViewTextBoxColumn,
            this.gidDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.roomsBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(148, 24);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(496, 70);
            this.dataGridView4.TabIndex = 0;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room_Number";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Room_Number";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rviewDataGridViewTextBoxColumn
            // 
            this.rviewDataGridViewTextBoxColumn.DataPropertyName = "R_view";
            this.rviewDataGridViewTextBoxColumn.HeaderText = "R_view";
            this.rviewDataGridViewTextBoxColumn.Name = "rviewDataGridViewTextBoxColumn";
            // 
            // rlevelDataGridViewTextBoxColumn
            // 
            this.rlevelDataGridViewTextBoxColumn.DataPropertyName = "R_level";
            this.rlevelDataGridViewTextBoxColumn.HeaderText = "R_level";
            this.rlevelDataGridViewTextBoxColumn.Name = "rlevelDataGridViewTextBoxColumn";
            // 
            // gidDataGridViewTextBoxColumn
            // 
            this.gidDataGridViewTextBoxColumn.DataPropertyName = "G_id";
            this.gidDataGridViewTextBoxColumn.HeaderText = "G_id";
            this.gidDataGridViewTextBoxColumn.Name = "gidDataGridViewTextBoxColumn";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelReservationDataSet;
            // 
            // hotelReservationDataSet
            // 
            this.hotelReservationDataSet.DataSetName = "HotelReservationDataSet";
            this.hotelReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(324, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private HotelReservationDataSet hotelReservationDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HotelReservationDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}