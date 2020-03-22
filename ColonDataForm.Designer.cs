namespace IssaForms
{
    partial class ColonDataForm
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analInspectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRExamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ileumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cecumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigmoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rectumRetroflexionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premedicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scopeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referredDoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medazolamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pentaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.others1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicalDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endoscopistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colonDataSet = new IssaForms.ColonDataSet();
            this.colonsTableAdapter = new IssaForms.ColonDataSetTableAdapters.ColonsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.preparationDataGridViewTextBoxColumn,
            this.analInspectionDataGridViewTextBoxColumn,
            this.pRExamDataGridViewTextBoxColumn,
            this.ileumDataGridViewTextBoxColumn,
            this.cecumDataGridViewTextBoxColumn,
            this.colonDetailsDataGridViewTextBoxColumn,
            this.sigmoidDataGridViewTextBoxColumn,
            this.rectumRetroflexionDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.fileNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.premedicationDataGridViewTextBoxColumn,
            this.scopeDataGridViewTextBoxColumn,
            this.olympusDataGridViewTextBoxColumn,
            this.referredDoctorDataGridViewTextBoxColumn,
            this.medazolamDataGridViewTextBoxColumn,
            this.pentaxDataGridViewTextBoxColumn,
            this.othersDataGridViewTextBoxColumn,
            this.others1DataGridViewTextBoxColumn,
            this.clinicalDataDataGridViewTextBoxColumn,
            this.conclusionDataGridViewTextBoxColumn,
            this.endoscopistDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colonsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preparationDataGridViewTextBoxColumn
            // 
            this.preparationDataGridViewTextBoxColumn.DataPropertyName = "Preparation";
            this.preparationDataGridViewTextBoxColumn.HeaderText = "Preparation";
            this.preparationDataGridViewTextBoxColumn.Name = "preparationDataGridViewTextBoxColumn";
            // 
            // analInspectionDataGridViewTextBoxColumn
            // 
            this.analInspectionDataGridViewTextBoxColumn.DataPropertyName = "AnalInspection";
            this.analInspectionDataGridViewTextBoxColumn.HeaderText = "AnalInspection";
            this.analInspectionDataGridViewTextBoxColumn.Name = "analInspectionDataGridViewTextBoxColumn";
            // 
            // pRExamDataGridViewTextBoxColumn
            // 
            this.pRExamDataGridViewTextBoxColumn.DataPropertyName = "PRExam";
            this.pRExamDataGridViewTextBoxColumn.HeaderText = "PRExam";
            this.pRExamDataGridViewTextBoxColumn.Name = "pRExamDataGridViewTextBoxColumn";
            // 
            // ileumDataGridViewTextBoxColumn
            // 
            this.ileumDataGridViewTextBoxColumn.DataPropertyName = "Ileum";
            this.ileumDataGridViewTextBoxColumn.HeaderText = "Ileum";
            this.ileumDataGridViewTextBoxColumn.Name = "ileumDataGridViewTextBoxColumn";
            // 
            // cecumDataGridViewTextBoxColumn
            // 
            this.cecumDataGridViewTextBoxColumn.DataPropertyName = "Cecum";
            this.cecumDataGridViewTextBoxColumn.HeaderText = "Cecum";
            this.cecumDataGridViewTextBoxColumn.Name = "cecumDataGridViewTextBoxColumn";
            // 
            // colonDetailsDataGridViewTextBoxColumn
            // 
            this.colonDetailsDataGridViewTextBoxColumn.DataPropertyName = "ColonDetails";
            this.colonDetailsDataGridViewTextBoxColumn.HeaderText = "ColonDetails";
            this.colonDetailsDataGridViewTextBoxColumn.Name = "colonDetailsDataGridViewTextBoxColumn";
            // 
            // sigmoidDataGridViewTextBoxColumn
            // 
            this.sigmoidDataGridViewTextBoxColumn.DataPropertyName = "Sigmoid";
            this.sigmoidDataGridViewTextBoxColumn.HeaderText = "Sigmoid";
            this.sigmoidDataGridViewTextBoxColumn.Name = "sigmoidDataGridViewTextBoxColumn";
            // 
            // rectumRetroflexionDataGridViewTextBoxColumn
            // 
            this.rectumRetroflexionDataGridViewTextBoxColumn.DataPropertyName = "RectumRetroflexion";
            this.rectumRetroflexionDataGridViewTextBoxColumn.HeaderText = "RectumRetroflexion";
            this.rectumRetroflexionDataGridViewTextBoxColumn.Name = "rectumRetroflexionDataGridViewTextBoxColumn";
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
            // olympusDataGridViewTextBoxColumn
            // 
            this.olympusDataGridViewTextBoxColumn.DataPropertyName = "Olympus";
            this.olympusDataGridViewTextBoxColumn.HeaderText = "Olympus";
            this.olympusDataGridViewTextBoxColumn.Name = "olympusDataGridViewTextBoxColumn";
            // 
            // referredDoctorDataGridViewTextBoxColumn
            // 
            this.referredDoctorDataGridViewTextBoxColumn.DataPropertyName = "ReferredDoctor";
            this.referredDoctorDataGridViewTextBoxColumn.HeaderText = "ReferredDoctor";
            this.referredDoctorDataGridViewTextBoxColumn.Name = "referredDoctorDataGridViewTextBoxColumn";
            // 
            // medazolamDataGridViewTextBoxColumn
            // 
            this.medazolamDataGridViewTextBoxColumn.DataPropertyName = "Medazolam";
            this.medazolamDataGridViewTextBoxColumn.HeaderText = "Medazolam";
            this.medazolamDataGridViewTextBoxColumn.Name = "medazolamDataGridViewTextBoxColumn";
            // 
            // pentaxDataGridViewTextBoxColumn
            // 
            this.pentaxDataGridViewTextBoxColumn.DataPropertyName = "Pentax";
            this.pentaxDataGridViewTextBoxColumn.HeaderText = "Pentax";
            this.pentaxDataGridViewTextBoxColumn.Name = "pentaxDataGridViewTextBoxColumn";
            // 
            // othersDataGridViewTextBoxColumn
            // 
            this.othersDataGridViewTextBoxColumn.DataPropertyName = "Others";
            this.othersDataGridViewTextBoxColumn.HeaderText = "Others";
            this.othersDataGridViewTextBoxColumn.Name = "othersDataGridViewTextBoxColumn";
            // 
            // others1DataGridViewTextBoxColumn
            // 
            this.others1DataGridViewTextBoxColumn.DataPropertyName = "Others1";
            this.others1DataGridViewTextBoxColumn.HeaderText = "Others1";
            this.others1DataGridViewTextBoxColumn.Name = "others1DataGridViewTextBoxColumn";
            // 
            // clinicalDataDataGridViewTextBoxColumn
            // 
            this.clinicalDataDataGridViewTextBoxColumn.DataPropertyName = "ClinicalData";
            this.clinicalDataDataGridViewTextBoxColumn.HeaderText = "ClinicalData";
            this.clinicalDataDataGridViewTextBoxColumn.Name = "clinicalDataDataGridViewTextBoxColumn";
            // 
            // conclusionDataGridViewTextBoxColumn
            // 
            this.conclusionDataGridViewTextBoxColumn.DataPropertyName = "Conclusion";
            this.conclusionDataGridViewTextBoxColumn.HeaderText = "Conclusion";
            this.conclusionDataGridViewTextBoxColumn.Name = "conclusionDataGridViewTextBoxColumn";
            // 
            // endoscopistDataGridViewTextBoxColumn
            // 
            this.endoscopistDataGridViewTextBoxColumn.DataPropertyName = "Endoscopist";
            this.endoscopistDataGridViewTextBoxColumn.HeaderText = "Endoscopist";
            this.endoscopistDataGridViewTextBoxColumn.Name = "endoscopistDataGridViewTextBoxColumn";
            // 
            // colonsBindingSource
            // 
            this.colonsBindingSource.DataMember = "Colons";
            this.colonsBindingSource.DataSource = this.colonDataSet;
            // 
            // colonDataSet
            // 
            this.colonDataSet.DataSetName = "ColonDataSet";
            this.colonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colonsTableAdapter
            // 
            this.colonsTableAdapter.ClearBeforeFill = true;
            // 
            // ColonDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ColonDataForm";
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ColonDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private ColonDataSet colonDataSet;
        private System.Windows.Forms.BindingSource colonsBindingSource;
        private ColonDataSetTableAdapters.ColonsTableAdapter colonsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn analInspectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRExamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ileumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cecumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigmoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rectumRetroflexionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premedicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scopeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referredDoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medazolamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pentaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn othersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn others1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicalDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endoscopistDataGridViewTextBoxColumn;
    }
}