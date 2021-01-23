namespace WindowsFormsApp1
{
    partial class ProjectBrief
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
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelLang = new System.Windows.Forms.Label();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.labelSelectedPlatform = new System.Windows.Forms.Label();
            this.labelSelectedType = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSite = new System.Windows.Forms.CheckBox();
            this.checkBoxMobileApp = new System.Windows.Forms.CheckBox();
            this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.labelSite = new System.Windows.Forms.Label();
            this.labelMobileApp = new System.Windows.Forms.Label();
            this.groupBoxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(28, 42);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(70, 13);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Тип проекта";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Консольное приложение",
            "Оконное приложение"});
            this.comboBoxType.Location = new System.Drawing.Point(143, 39);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(202, 21);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(65, 284);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(276, 284);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Location = new System.Drawing.Point(285, 13);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(0, 13);
            this.labelLang.TabIndex = 4;
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.labelMobileApp);
            this.groupBoxSummary.Controls.Add(this.labelSite);
            this.groupBoxSummary.Controls.Add(this.labelSelectedPlatform);
            this.groupBoxSummary.Controls.Add(this.labelSelectedType);
            this.groupBoxSummary.Controls.Add(this.labelPrice);
            this.groupBoxSummary.Controls.Add(this.labelSum);
            this.groupBoxSummary.Location = new System.Drawing.Point(236, 159);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(172, 119);
            this.groupBoxSummary.TabIndex = 5;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Итог";
            // 
            // labelSelectedPlatform
            // 
            this.labelSelectedPlatform.AutoSize = true;
            this.labelSelectedPlatform.Location = new System.Drawing.Point(20, 44);
            this.labelSelectedPlatform.Name = "labelSelectedPlatform";
            this.labelSelectedPlatform.Size = new System.Drawing.Size(66, 13);
            this.labelSelectedPlatform.TabIndex = 1;
            this.labelSelectedPlatform.Text = "Платформа";
            // 
            // labelSelectedType
            // 
            this.labelSelectedType.AutoSize = true;
            this.labelSelectedType.Location = new System.Drawing.Point(18, 25);
            this.labelSelectedType.Name = "labelSelectedType";
            this.labelSelectedType.Size = new System.Drawing.Size(70, 13);
            this.labelSelectedType.TabIndex = 0;
            this.labelSelectedType.Text = "Тип проекта";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(138, 100);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(28, 13);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "0.00";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(119, 100);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(13, 13);
            this.labelSum.TabIndex = 0;
            this.labelSum.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тип проекта";
            // 
            // checkBoxSite
            // 
            this.checkBoxSite.AutoSize = true;
            this.checkBoxSite.Location = new System.Drawing.Point(31, 117);
            this.checkBoxSite.Name = "checkBoxSite";
            this.checkBoxSite.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSite.TabIndex = 6;
            this.checkBoxSite.Text = "Web сайт";
            this.checkBoxSite.UseVisualStyleBackColor = true;
            this.checkBoxSite.CheckedChanged += new System.EventHandler(this.checkBoxSite_CheckedChanged);
            // 
            // checkBoxMobileApp
            // 
            this.checkBoxMobileApp.AutoSize = true;
            this.checkBoxMobileApp.Location = new System.Drawing.Point(31, 140);
            this.checkBoxMobileApp.Name = "checkBoxMobileApp";
            this.checkBoxMobileApp.Size = new System.Drawing.Size(148, 17);
            this.checkBoxMobileApp.TabIndex = 7;
            this.checkBoxMobileApp.Text = "Мобильное приложение";
            this.checkBoxMobileApp.UseVisualStyleBackColor = true;
            this.checkBoxMobileApp.CheckedChanged += new System.EventHandler(this.checkBoxMobileApp_CheckedChanged);
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatform.FormattingEnabled = true;
            this.comboBoxPlatform.Items.AddRange(new object[] {
            "Windows",
            "MacOS",
            "Linux"});
            this.comboBoxPlatform.Location = new System.Drawing.Point(143, 80);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.comboBoxPlatform.Size = new System.Drawing.Size(202, 21);
            this.comboBoxPlatform.TabIndex = 8;
            this.comboBoxPlatform.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlatform_SelectedIndexChanged);
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Location = new System.Drawing.Point(28, 83);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(66, 13);
            this.labelPlatform.TabIndex = 9;
            this.labelPlatform.Text = "Платформа";
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(21, 62);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(0, 13);
            this.labelSite.TabIndex = 2;
            // 
            // labelMobileApp
            // 
            this.labelMobileApp.AutoSize = true;
            this.labelMobileApp.Location = new System.Drawing.Point(20, 80);
            this.labelMobileApp.Name = "labelMobileApp";
            this.labelMobileApp.Size = new System.Drawing.Size(0, 13);
            this.labelMobileApp.TabIndex = 2;
            // 
            // ProjectBrief
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 340);
            this.Controls.Add(this.labelPlatform);
            this.Controls.Add(this.comboBoxPlatform);
            this.Controls.Add(this.checkBoxMobileApp);
            this.Controls.Add(this.checkBoxSite);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLang);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Name = "ProjectBrief";
            this.Text = "ProjectBrief";
            this.Load += new System.EventHandler(this.ProjectBrief_Load);
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label labelSelectedType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSite;
        private System.Windows.Forms.CheckBox checkBoxMobileApp;
        private System.Windows.Forms.ComboBox comboBoxPlatform;
        private System.Windows.Forms.Label labelPlatform;
        private System.Windows.Forms.Label labelSelectedPlatform;
        private System.Windows.Forms.Label labelMobileApp;
        private System.Windows.Forms.Label labelSite;
    }
}