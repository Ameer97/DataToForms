namespace IssaForms
{
    partial class StomacheDataForm
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
            this.stomachDataSet = new IssaForms.StomachDataSet();
            this.stomachesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stomachesTableAdapter = new IssaForms.StomachDataSetTableAdapters.StomachesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premedicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scopeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referredDoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicalDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gEJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esophagusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stomachDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endoscopistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stomachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stomachesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.fileNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.premedicationDataGridViewTextBoxColumn,
            this.scopeDataGridViewTextBoxColumn,
            this.referredDoctorDataGridViewTextBoxColumn,
            this.clinicalDataDataGridViewTextBoxColumn,
            this.gEJDataGridViewTextBoxColumn,
            this.esophagusDataGridViewTextBoxColumn,
            this.stomachDetailsDataGridViewTextBoxColumn,
            this.d1DataGridViewTextBoxColumn,
            this.d2DataGridViewTextBoxColumn,
            this.conclusionDataGridViewTextBoxColumn,
            this.assistantDataGridViewTextBoxColumn,
            this.endoscopistDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stomachesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // stomachDataSet
            // 
            this.stomachDataSet.DataSetName = "StomachDataSet";
            this.stomachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stomachesBindingSource
            // 
            this.stomachesBindingSource.DataMember = "Stomaches";
            this.stomachesBindingSource.DataSource = this.stomachDataSet;
            // 
            // stomachesTableAdapter
            // 
            this.stomachesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // fileNoDataGridViewTextBoxColumn
            // 
            this.fileNoDataGridViewTextBoxColumn.DataPropertyName = "FileNo";
            this.fileNoDataGridViewTextBoxColumn.HeaderText = "FileNo";
            this.fileNoDataGridViewTextBoxColumn.Name = "fileNoDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // premedicationDataGridViewTextBoxColumn
            // 
            this.premedicationDataGridViewTextBoxColumn.DataPropertyName = "Premedication";
            this.premedicationDataGridViewTextBoxColumn.HeaderText = "Premedication";
            this.premedicationDataGridViewTextBoxColumn.Name = "premedicationDataGridViewTextBoxColumn";
            // 
            // scopeDataGridViewTextBoxColumn
            // 
            this.scopeDataGridViewTextBoxColumn.DataPropertyName = "Scope";
            this.scopeDataGridViewTextBoxColumn.HeaderText = "Scope";
            this.scopeDataGridViewTextBoxColumn.Name = "scopeDataGridViewTextBoxColumn";
            // 
            // referredDoctorDataGridViewTextBoxColumn
            // 
            this.referredDoctorDataGridViewTextBoxColumn.DataPropertyName = "ReferredDoctor";
            this.referredDoctorDataGridViewTextBoxColumn.HeaderText = "ReferredDoctor";
            this.referredDoctorDataGridViewTextBoxColumn.Name = "referredDoctorDataGridViewTextBoxColumn";
            // 
            // clinicalDataDataGridViewTextBoxColumn
            // 
            this.clinicalDataDataGridViewTextBoxColumn.DataPropertyName = "ClinicalData";
            this.clinicalDataDataGridViewTextBoxColumn.HeaderText = "ClinicalData";
            this.clinicalDataDataGridViewTextBoxColumn.Name = "clinicalDataDataGridViewTextBoxColumn";
            // 
            // gEJDataGridViewTextBoxColumn
            // 
            this.gEJDataGridViewTextBoxColumn.DataPropertyName = "GEJ";
            this.gEJDataGridViewTextBoxColumn.HeaderText = "GEJ";
            this.gEJDataGridViewTextBoxColumn.Name = "gEJDataGridViewTextBoxColumn";
            // 
            // esophagusDataGridViewTextBoxColumn
            // 
            this.esophagusDataGridViewTextBoxColumn.DataPropertyName = "Esophagus";
            this.esophagusDataGridViewTextBoxColumn.HeaderText = "Esophagus";
            this.esophagusDataGridViewTextBoxColumn.Name = "esophagusDataGridViewTextBoxColumn";
            // 
            // stomachDetailsDataGridViewTextBoxColumn
            // 
            this.stomachDetailsDataGridViewTextBoxColumn.DataPropertyName = "StomachDetails";
            this.stomachDetailsDataGridViewTextBoxColumn.HeaderText = "StomachDetails";
            this.stomachDetailsDataGridViewTextBoxColumn.Name = "stomachDetailsDataGridViewTextBoxColumn";
            // 
            // d1DataGridViewTextBoxColumn
            // 
            this.d1DataGridViewTextBoxColumn.DataPropertyName = "D1";
            this.d1DataGridViewTextBoxColumn.HeaderText = "D1";
            this.d1DataGridViewTextBoxColumn.Name = "d1DataGridViewTextBoxColumn";
            // 
            // d2DataGridViewTextBoxColumn
            // 
            this.d2DataGridViewTextBoxColumn.DataPropertyName = "D2";
            this.d2DataGridViewTextBoxColumn.HeaderText = "D2";
            this.d2DataGridViewTextBoxColumn.Name = "d2DataGridViewTextBoxColumn";
            // 
            // conclusionDataGridViewTextBoxColumn
            // 
            this.conclusionDataGridViewTextBoxColumn.DataPropertyName = "Conclusion";
            this.conclusionDataGridViewTextBoxColumn.HeaderText = "Conclusion";
            this.conclusionDataGridViewTextBoxColumn.Name = "conclusionDataGridViewTextBoxColumn";
            // 
            // assistantDataGridViewTextBoxColumn
            // 
            this.assistantDataGridViewTextBoxColumn.DataPropertyName = "Assistant";
            this.assistantDataGridViewTextBoxColumn.HeaderText = "Assistant";
            this.assistantDataGridViewTextBoxColumn.Name = "assistantDataGridViewTextBoxColumn";
            // 
            // endoscopistDataGridViewTextBoxColumn
            // 
            this.endoscopistDataGridViewTextBoxColumn.DataPropertyName = "Endoscopist";
            this.endoscopistDataGridViewTextBoxColumn.HeaderText = "Endoscopist";
            this.endoscopistDataGridViewTextBoxColumn.Name = "endoscopistDataGridViewTextBoxColumn";
            // 
            // StomacheDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StomacheDataForm";
            this.Text = "StomacheDataForm";
            this.Load += new System.EventHandler(this.StomacheDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stomachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stomachesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StomachDataSet stomachDataSet;
        private System.Windows.Forms.BindingSource stomachesBindingSource;
        private StomachDataSetTableAdapters.StomachesTableAdapter stomachesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premedicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scopeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referredDoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicalDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gEJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esophagusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stomachDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endoscopistDataGridViewTextBoxColumn;
    }
}