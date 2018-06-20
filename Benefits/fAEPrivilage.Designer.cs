namespace Benefits
{
    partial class fAEPrivilage
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
            this.lFIO = new System.Windows.Forms.Label();
            this.lDateBirth = new System.Windows.Forms.Label();
            this.lGender = new System.Windows.Forms.Label();
            this.lAdres = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.cebPrivilage = new System.Windows.Forms.CheckBox();
            this.cobGender = new System.Windows.Forms.ComboBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.mtbDateBirth = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Location = new System.Drawing.Point(13, 18);
            this.lFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(53, 17);
            this.lFIO.TabIndex = 0;
            this.lFIO.Text = "Ф.И.О.";
            // 
            // lDateBirth
            // 
            this.lDateBirth.AutoSize = true;
            this.lDateBirth.Location = new System.Drawing.Point(13, 46);
            this.lDateBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDateBirth.Name = "lDateBirth";
            this.lDateBirth.Size = new System.Drawing.Size(103, 17);
            this.lDateBirth.TabIndex = 1;
            this.lDateBirth.Text = "Дата рождения";
            // 
            // lGender
            // 
            this.lGender.AutoSize = true;
            this.lGender.Location = new System.Drawing.Point(275, 48);
            this.lGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(33, 17);
            this.lGender.TabIndex = 2;
            this.lGender.Text = "Пол";
            // 
            // lAdres
            // 
            this.lAdres.AutoSize = true;
            this.lAdres.Location = new System.Drawing.Point(13, 75);
            this.lAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAdres.Name = "lAdres";
            this.lAdres.Size = new System.Drawing.Size(48, 17);
            this.lAdres.TabIndex = 3;
            this.lAdres.Text = "Адрес";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(73, 9);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(440, 25);
            this.tbFIO.TabIndex = 4;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(73, 70);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(440, 25);
            this.tbAdres.TabIndex = 5;
            // 
            // cebPrivilage
            // 
            this.cebPrivilage.AutoSize = true;
            this.cebPrivilage.Location = new System.Drawing.Point(442, 43);
            this.cebPrivilage.Name = "cebPrivilage";
            this.cebPrivilage.Size = new System.Drawing.Size(71, 21);
            this.cebPrivilage.TabIndex = 7;
            this.cebPrivilage.Text = "Льгота";
            this.cebPrivilage.UseVisualStyleBackColor = true;
            // 
            // cobGender
            // 
            this.cobGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobGender.FormattingEnabled = true;
            this.cobGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cobGender.Location = new System.Drawing.Point(315, 40);
            this.cobGender.Name = "cobGender";
            this.cobGender.Size = new System.Drawing.Size(121, 25);
            this.cobGender.TabIndex = 8;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(168, 114);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(90, 30);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(278, 114);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(90, 30);
            this.bCancel.TabIndex = 10;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // mtbDateBirth
            // 
            this.mtbDateBirth.Location = new System.Drawing.Point(123, 38);
            this.mtbDateBirth.Mask = "00/00/0000";
            this.mtbDateBirth.Name = "mtbDateBirth";
            this.mtbDateBirth.Size = new System.Drawing.Size(145, 25);
            this.mtbDateBirth.TabIndex = 11;
            this.mtbDateBirth.ValidatingType = typeof(System.DateTime);
            // 
            // fAEPrivilage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 160);
            this.Controls.Add(this.mtbDateBirth);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cobGender);
            this.Controls.Add(this.cebPrivilage);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.lAdres);
            this.Controls.Add(this.lGender);
            this.Controls.Add(this.lDateBirth);
            this.Controls.Add(this.lFIO);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fAEPrivilage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление льготника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.Label lDateBirth;
        private System.Windows.Forms.Label lGender;
        private System.Windows.Forms.Label lAdres;
        public System.Windows.Forms.TextBox tbFIO;
        public System.Windows.Forms.TextBox tbAdres;
        public System.Windows.Forms.CheckBox cebPrivilage;
        public System.Windows.Forms.ComboBox cobGender;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        public System.Windows.Forms.MaskedTextBox mtbDateBirth;
    }
}