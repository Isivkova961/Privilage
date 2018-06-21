namespace Benefits
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainBenefits));
            this.cebFIO = new System.Windows.Forms.CheckBox();
            this.cebDateBirth = new System.Windows.Forms.CheckBox();
            this.cebPrivilage = new System.Windows.Forms.CheckBox();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.dtpDateBirthS = new System.Windows.Forms.DateTimePicker();
            this.cebYesPrivilage = new System.Windows.Forms.CheckBox();
            this.dgvPrivilage = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new Benefits.dataDataSet();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableAdapter = new Benefits.dataDataSetTableAdapters.dataTableAdapter();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.lDateS = new System.Windows.Forms.Label();
            this.lDatePo = new System.Windows.Forms.Label();
            this.dtpDateBirthPo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cebFIO
            // 
            this.cebFIO.AutoSize = true;
            this.cebFIO.Location = new System.Drawing.Point(28, 16);
            this.cebFIO.Margin = new System.Windows.Forms.Padding(4);
            this.cebFIO.Name = "cebFIO";
            this.cebFIO.Size = new System.Drawing.Size(82, 21);
            this.cebFIO.TabIndex = 1;
            this.cebFIO.Text = "По ФИО";
            this.cebFIO.UseVisualStyleBackColor = true;
            this.cebFIO.CheckedChanged += new System.EventHandler(this.cebFIO_CheckedChanged);
            // 
            // cebDateBirth
            // 
            this.cebDateBirth.AutoSize = true;
            this.cebDateBirth.Location = new System.Drawing.Point(28, 45);
            this.cebDateBirth.Margin = new System.Windows.Forms.Padding(4);
            this.cebDateBirth.Name = "cebDateBirth";
            this.cebDateBirth.Size = new System.Drawing.Size(142, 21);
            this.cebDateBirth.TabIndex = 4;
            this.cebDateBirth.Text = "По дате рождения";
            this.cebDateBirth.UseVisualStyleBackColor = true;
            this.cebDateBirth.CheckedChanged += new System.EventHandler(this.cebDateBirth_CheckedChanged);
            // 
            // cebPrivilage
            // 
            this.cebPrivilage.AutoSize = true;
            this.cebPrivilage.Location = new System.Drawing.Point(394, 46);
            this.cebPrivilage.Margin = new System.Windows.Forms.Padding(4);
            this.cebPrivilage.Name = "cebPrivilage";
            this.cebPrivilage.Size = new System.Drawing.Size(90, 21);
            this.cebPrivilage.TabIndex = 6;
            this.cebPrivilage.Text = "По льготе";
            this.cebPrivilage.UseVisualStyleBackColor = true;
            this.cebPrivilage.CheckedChanged += new System.EventHandler(this.cebPrivilage_CheckedChanged);
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(117, 12);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(476, 25);
            this.tbFIO.TabIndex = 0;
            this.tbFIO.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            // 
            // dtpDateBirthS
            // 
            this.dtpDateBirthS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBirthS.Location = new System.Drawing.Point(177, 43);
            this.dtpDateBirthS.Name = "dtpDateBirthS";
            this.dtpDateBirthS.Size = new System.Drawing.Size(88, 25);
            this.dtpDateBirthS.TabIndex = 2;
            // 
            // cebYesPrivilage
            // 
            this.cebYesPrivilage.AutoSize = true;
            this.cebYesPrivilage.Location = new System.Drawing.Point(491, 46);
            this.cebYesPrivilage.Name = "cebYesPrivilage";
            this.cebYesPrivilage.Size = new System.Drawing.Size(102, 21);
            this.cebYesPrivilage.TabIndex = 5;
            this.cebYesPrivilage.Text = "Есть льгота";
            this.cebYesPrivilage.UseVisualStyleBackColor = true;
            // 
            // dgvPrivilage
            // 
            this.dgvPrivilage.AllowUserToAddRows = false;
            this.dgvPrivilage.AllowUserToDeleteRows = false;
            this.dgvPrivilage.AutoGenerateColumns = false;
            this.dgvPrivilage.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrivilage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrivilage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fio,
            this.date_birth,
            this.adres,
            this.gender,
            this.privilage});
            this.dgvPrivilage.DataSource = this.dataBindingSource1;
            this.dgvPrivilage.Location = new System.Drawing.Point(28, 74);
            this.dgvPrivilage.Name = "dgvPrivilage";
            this.dgvPrivilage.ReadOnly = true;
            this.dgvPrivilage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrivilage.Size = new System.Drawing.Size(854, 330);
            this.dgvPrivilage.TabIndex = 7;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // fio
            // 
            this.fio.DataPropertyName = "fio";
            this.fio.HeaderText = "Ф.И.О.";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            this.fio.Width = 200;
            // 
            // date_birth
            // 
            this.date_birth.DataPropertyName = "date_birth";
            this.date_birth.HeaderText = "Дата рождения";
            this.date_birth.Name = "date_birth";
            this.date_birth.ReadOnly = true;
            this.date_birth.Width = 120;
            // 
            // adres
            // 
            this.adres.DataPropertyName = "adres";
            this.adres.HeaderText = "Адрес";
            this.adres.Name = "adres";
            this.adres.ReadOnly = true;
            this.adres.Width = 300;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Пол";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // privilage
            // 
            this.privilage.DataPropertyName = "privilage";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.privilage.DefaultCellStyle = dataGridViewCellStyle2;
            this.privilage.HeaderText = "Льгота";
            this.privilage.Name = "privilage";
            this.privilage.ReadOnly = true;
            this.privilage.Width = 80;
            // 
            // dataBindingSource1
            // 
            this.dataBindingSource1.DataMember = "data";
            this.dataBindingSource1.DataSource = this.dataDataSetBindingSource;
            // 
            // dataDataSetBindingSource
            // 
            this.dataDataSetBindingSource.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource.Position = 0;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(890, 77);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(86, 32);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(890, 115);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(86, 32);
            this.bEdit.TabIndex = 9;
            this.bEdit.Text = "Изменить";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(890, 153);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(86, 32);
            this.bDelete.TabIndex = 10;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // lDateS
            // 
            this.lDateS.AutoSize = true;
            this.lDateS.Location = new System.Drawing.Point(165, 47);
            this.lDateS.Name = "lDateS";
            this.lDateS.Size = new System.Drawing.Size(15, 17);
            this.lDateS.TabIndex = 13;
            this.lDateS.Text = "с";
            // 
            // lDatePo
            // 
            this.lDatePo.AutoSize = true;
            this.lDatePo.Location = new System.Drawing.Point(271, 46);
            this.lDatePo.Name = "lDatePo";
            this.lDatePo.Size = new System.Drawing.Size(22, 17);
            this.lDatePo.TabIndex = 14;
            this.lDatePo.Text = "по";
            // 
            // dtpDateBirthPo
            // 
            this.dtpDateBirthPo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBirthPo.Location = new System.Drawing.Point(299, 43);
            this.dtpDateBirthPo.Name = "dtpDateBirthPo";
            this.dtpDateBirthPo.Size = new System.Drawing.Size(88, 25);
            this.dtpDateBirthPo.TabIndex = 3;
            // 
            // fMainBenefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 412);
            this.Controls.Add(this.dtpDateBirthPo);
            this.Controls.Add(this.lDatePo);
            this.Controls.Add(this.lDateS);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dgvPrivilage);
            this.Controls.Add(this.cebYesPrivilage);
            this.Controls.Add(this.dtpDateBirthS);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.cebPrivilage);
            this.Controls.Add(this.cebDateBirth);
            this.Controls.Add(this.cebFIO);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMainBenefits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал льготников";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fMainBenefits_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cebFIO;
        private System.Windows.Forms.CheckBox cebDateBirth;
        private System.Windows.Forms.CheckBox cebPrivilage;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.DateTimePicker dtpDateBirthS;
        private System.Windows.Forms.CheckBox cebYesPrivilage;
        public System.Windows.Forms.DataGridView dgvPrivilage;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private dataDataSetTableAdapters.dataTableAdapter dataTableAdapter;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label lDateS;
        private System.Windows.Forms.Label lDatePo;
        private System.Windows.Forms.DateTimePicker dtpDateBirthPo;
        private System.Windows.Forms.BindingSource dataBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn privilage;
    }
}

