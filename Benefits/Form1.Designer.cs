﻿namespace Benefits
{
    partial class fMainBenefits
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cebFIO = new System.Windows.Forms.CheckBox();
            this.cebDateBirth = new System.Windows.Forms.CheckBox();
            this.cebPrivilage = new System.Windows.Forms.CheckBox();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.cebYesPrivilage = new System.Windows.Forms.CheckBox();
            this.dgvPrivilage = new System.Windows.Forms.DataGridView();
            this.dataDataSet = new Benefits.dataDataSet();
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableAdapter = new Benefits.dataDataSetTableAdapters.dataTableAdapter();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilageDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cebFIO
            // 
            this.cebFIO.AutoSize = true;
            this.cebFIO.Location = new System.Drawing.Point(28, 16);
            this.cebFIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cebFIO.Name = "cebFIO";
            this.cebFIO.Size = new System.Drawing.Size(82, 21);
            this.cebFIO.TabIndex = 0;
            this.cebFIO.Text = "По ФИО";
            this.cebFIO.UseVisualStyleBackColor = true;
            // 
            // cebDateBirth
            // 
            this.cebDateBirth.AutoSize = true;
            this.cebDateBirth.Location = new System.Drawing.Point(28, 45);
            this.cebDateBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cebDateBirth.Name = "cebDateBirth";
            this.cebDateBirth.Size = new System.Drawing.Size(142, 21);
            this.cebDateBirth.TabIndex = 1;
            this.cebDateBirth.Text = "По дате рождения";
            this.cebDateBirth.UseVisualStyleBackColor = true;
            // 
            // cebPrivilage
            // 
            this.cebPrivilage.AutoSize = true;
            this.cebPrivilage.Location = new System.Drawing.Point(330, 45);
            this.cebPrivilage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cebPrivilage.Name = "cebPrivilage";
            this.cebPrivilage.Size = new System.Drawing.Size(90, 21);
            this.cebPrivilage.TabIndex = 2;
            this.cebPrivilage.Text = "По льготе";
            this.cebPrivilage.UseVisualStyleBackColor = true;
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(117, 12);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(412, 25);
            this.tbFIO.TabIndex = 3;
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.Location = new System.Drawing.Point(177, 43);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(146, 25);
            this.dtpDateBirth.TabIndex = 4;
            // 
            // cebYesPrivilage
            // 
            this.cebYesPrivilage.AutoSize = true;
            this.cebYesPrivilage.Location = new System.Drawing.Point(427, 45);
            this.cebYesPrivilage.Name = "cebYesPrivilage";
            this.cebYesPrivilage.Size = new System.Drawing.Size(102, 21);
            this.cebYesPrivilage.TabIndex = 5;
            this.cebYesPrivilage.Text = "Есть льгота";
            this.cebYesPrivilage.UseVisualStyleBackColor = true;
            // 
            // dgvPrivilage
            // 
            this.dgvPrivilage.AutoGenerateColumns = false;
            this.dgvPrivilage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrivilage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn,
            this.datebirthDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.privilageDataGridViewCheckBoxColumn});
            this.dgvPrivilage.DataSource = this.dataBindingSource;
            this.dgvPrivilage.Location = new System.Drawing.Point(28, 74);
            this.dgvPrivilage.Name = "dgvPrivilage";
            this.dgvPrivilage.Size = new System.Drawing.Size(501, 467);
            this.dgvPrivilage.TabIndex = 6;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataDataSetBindingSource
            // 
            this.dataDataSetBindingSource.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource.Position = 0;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "data";
            this.dataBindingSource.DataSource = this.dataDataSetBindingSource;
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // datebirthDataGridViewTextBoxColumn
            // 
            this.datebirthDataGridViewTextBoxColumn.DataPropertyName = "date_birth";
            this.datebirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.datebirthDataGridViewTextBoxColumn.Name = "datebirthDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // privilageDataGridViewCheckBoxColumn
            // 
            this.privilageDataGridViewCheckBoxColumn.DataPropertyName = "privilage";
            this.privilageDataGridViewCheckBoxColumn.HeaderText = "Льгота";
            this.privilageDataGridViewCheckBoxColumn.Name = "privilageDataGridViewCheckBoxColumn";
            // 
            // fMainBenefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 553);
            this.Controls.Add(this.dgvPrivilage);
            this.Controls.Add(this.cebYesPrivilage);
            this.Controls.Add(this.dtpDateBirth);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.cebPrivilage);
            this.Controls.Add(this.cebDateBirth);
            this.Controls.Add(this.cebFIO);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fMainBenefits";
            this.Text = "Журнал льготников";
            this.Load += new System.EventHandler(this.fMainBenefits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cebFIO;
        private System.Windows.Forms.CheckBox cebDateBirth;
        private System.Windows.Forms.CheckBox cebPrivilage;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        private System.Windows.Forms.CheckBox cebYesPrivilage;
        private System.Windows.Forms.DataGridView dgvPrivilage;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private dataDataSetTableAdapters.dataTableAdapter dataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn privilageDataGridViewCheckBoxColumn;
    }
}
