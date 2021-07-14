namespace HotelReservation
{
    partial class Bill
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
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.billidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet = new HotelReservation.HotelReservationDataSet();
            this.billTableAdapter = new HotelReservation.HotelReservationDataSetTableAdapters.BillTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView9
            // 
            this.dataGridView9.AutoGenerateColumns = false;
            this.dataGridView9.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billidDataGridViewTextBoxColumn,
            this.gnameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.bDateDataGridViewTextBoxColumn,
            this.gidDataGridViewTextBoxColumn});
            this.dataGridView9.DataSource = this.billBindingSource;
            this.dataGridView9.Location = new System.Drawing.Point(76, 60);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.Size = new System.Drawing.Size(621, 74);
            this.dataGridView9.TabIndex = 0;
            // 
            // billidDataGridViewTextBoxColumn
            // 
            this.billidDataGridViewTextBoxColumn.DataPropertyName = "Bill_id";
            this.billidDataGridViewTextBoxColumn.HeaderText = "Bill_id";
            this.billidDataGridViewTextBoxColumn.Name = "billidDataGridViewTextBoxColumn";
            this.billidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gnameDataGridViewTextBoxColumn
            // 
            this.gnameDataGridViewTextBoxColumn.DataPropertyName = "G_name";
            this.gnameDataGridViewTextBoxColumn.HeaderText = "G_name";
            this.gnameDataGridViewTextBoxColumn.Name = "gnameDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // bDateDataGridViewTextBoxColumn
            // 
            this.bDateDataGridViewTextBoxColumn.DataPropertyName = "B_Date";
            this.bDateDataGridViewTextBoxColumn.HeaderText = "B_Date";
            this.bDateDataGridViewTextBoxColumn.Name = "bDateDataGridViewTextBoxColumn";
            // 
            // gidDataGridViewTextBoxColumn
            // 
            this.gidDataGridViewTextBoxColumn.DataPropertyName = "G_id";
            this.gidDataGridViewTextBoxColumn.HeaderText = "G_id";
            this.gidDataGridViewTextBoxColumn.Name = "gidDataGridViewTextBoxColumn";
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.hotelReservationDataSet;
            // 
            // hotelReservationDataSet
            // 
            this.hotelReservationDataSet.DataSetName = "HotelReservationDataSet";
            this.hotelReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView9);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView9;
        private HotelReservationDataSet hotelReservationDataSet;
        private System.Windows.Forms.BindingSource billBindingSource;
        private HotelReservationDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}