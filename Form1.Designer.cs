namespace WindowsFormsApp1
{
    partial class Form1
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
            this.labelHello = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSayHello = new System.Windows.Forms.Button();
            this.labelCalcRes = new System.Windows.Forms.Label();
            this.buttonDecrement = new System.Windows.Forms.Button();
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.groupBoxIncrCalc = new System.Windows.Forms.GroupBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.groupBoxUserInput = new System.Windows.Forms.GroupBox();
            this.buttonSetName = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxProjectBrief = new System.Windows.Forms.GroupBox();
            this.buttonFillBrief = new System.Windows.Forms.Button();
            this.groupBoxIncrCalc.SuspendLayout();
            this.groupBoxUserInput.SuspendLayout();
            this.groupBoxProjectBrief.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelHello.Location = new System.Drawing.Point(92, 19);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(89, 24);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Привет ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(171, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "мир!";
            // 
            // buttonSayHello
            // 
            this.buttonSayHello.Location = new System.Drawing.Point(129, 59);
            this.buttonSayHello.Name = "buttonSayHello";
            this.buttonSayHello.Size = new System.Drawing.Size(75, 23);
            this.buttonSayHello.TabIndex = 2;
            this.buttonSayHello.Text = "Say hello";
            this.buttonSayHello.UseVisualStyleBackColor = true;
            this.buttonSayHello.Click += new System.EventHandler(this.buttonSayHello_Click);
            // 
            // labelCalcRes
            // 
            this.labelCalcRes.AutoSize = true;
            this.labelCalcRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalcRes.Location = new System.Drawing.Point(134, 19);
            this.labelCalcRes.Name = "labelCalcRes";
            this.labelCalcRes.Size = new System.Drawing.Size(32, 24);
            this.labelCalcRes.TabIndex = 3;
            this.labelCalcRes.Text = "10";
            // 
            // buttonDecrement
            // 
            this.buttonDecrement.Location = new System.Drawing.Point(6, 19);
            this.buttonDecrement.Name = "buttonDecrement";
            this.buttonDecrement.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrement.TabIndex = 4;
            this.buttonDecrement.Text = "Decrement";
            this.buttonDecrement.UseVisualStyleBackColor = true;
            this.buttonDecrement.Click += new System.EventHandler(this.buttonDecrement_Click);
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Location = new System.Drawing.Point(201, 19);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(75, 23);
            this.buttonIncrement.TabIndex = 5;
            this.buttonIncrement.Text = "Increment";
            this.buttonIncrement.UseVisualStyleBackColor = true;
            this.buttonIncrement.Click += new System.EventHandler(this.buttonIncrement_Click);
            // 
            // groupBoxIncrCalc
            // 
            this.groupBoxIncrCalc.Controls.Add(this.labelCalcRes);
            this.groupBoxIncrCalc.Controls.Add(this.buttonIncrement);
            this.groupBoxIncrCalc.Controls.Add(this.buttonDecrement);
            this.groupBoxIncrCalc.Location = new System.Drawing.Point(24, 115);
            this.groupBoxIncrCalc.Name = "groupBoxIncrCalc";
            this.groupBoxIncrCalc.Size = new System.Drawing.Size(282, 56);
            this.groupBoxIncrCalc.TabIndex = 6;
            this.groupBoxIncrCalc.TabStop = false;
            this.groupBoxIncrCalc.Text = "Incremental Calc";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(225, 372);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // groupBoxUserInput
            // 
            this.groupBoxUserInput.Controls.Add(this.textBoxName);
            this.groupBoxUserInput.Controls.Add(this.labelName);
            this.groupBoxUserInput.Controls.Add(this.buttonSetName);
            this.groupBoxUserInput.Location = new System.Drawing.Point(24, 177);
            this.groupBoxUserInput.Name = "groupBoxUserInput";
            this.groupBoxUserInput.Size = new System.Drawing.Size(282, 78);
            this.groupBoxUserInput.TabIndex = 8;
            this.groupBoxUserInput.TabStop = false;
            this.groupBoxUserInput.Text = "User input demo";
            // 
            // buttonSetName
            // 
            this.buttonSetName.Location = new System.Drawing.Point(201, 24);
            this.buttonSetName.Name = "buttonSetName";
            this.buttonSetName.Size = new System.Drawing.Size(75, 23);
            this.buttonSetName.TabIndex = 0;
            this.buttonSetName.Text = "Set";
            this.buttonSetName.UseVisualStyleBackColor = true;
            this.buttonSetName.Click += new System.EventHandler(this.buttonSetName_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(80, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // groupBoxProjectBrief
            // 
            this.groupBoxProjectBrief.Controls.Add(this.buttonFillBrief);
            this.groupBoxProjectBrief.Location = new System.Drawing.Point(24, 261);
            this.groupBoxProjectBrief.Name = "groupBoxProjectBrief";
            this.groupBoxProjectBrief.Size = new System.Drawing.Size(282, 105);
            this.groupBoxProjectBrief.TabIndex = 9;
            this.groupBoxProjectBrief.TabStop = false;
            this.groupBoxProjectBrief.Text = "Project Brief";
            // 
            // buttonFillBrief
            // 
            this.buttonFillBrief.Location = new System.Drawing.Point(201, 19);
            this.buttonFillBrief.Name = "buttonFillBrief";
            this.buttonFillBrief.Size = new System.Drawing.Size(75, 23);
            this.buttonFillBrief.TabIndex = 0;
            this.buttonFillBrief.Text = "Заполнить";
            this.buttonFillBrief.UseVisualStyleBackColor = true;
            this.buttonFillBrief.Click += new System.EventHandler(this.buttonFillBrief_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 407);
            this.Controls.Add(this.groupBoxProjectBrief);
            this.Controls.Add(this.groupBoxUserInput);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.groupBoxIncrCalc);
            this.Controls.Add(this.buttonSayHello);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHello);
            this.Name = "Form1";
            this.Text = "Знакомство с WinForms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxIncrCalc.ResumeLayout(false);
            this.groupBoxIncrCalc.PerformLayout();
            this.groupBoxUserInput.ResumeLayout(false);
            this.groupBoxUserInput.PerformLayout();
            this.groupBoxProjectBrief.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSayHello;
        private System.Windows.Forms.Label labelCalcRes;
        private System.Windows.Forms.Button buttonDecrement;
        private System.Windows.Forms.Button buttonIncrement;
        private System.Windows.Forms.GroupBox groupBoxIncrCalc;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.GroupBox groupBoxUserInput;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonSetName;
        private System.Windows.Forms.GroupBox groupBoxProjectBrief;
        private System.Windows.Forms.Button buttonFillBrief;
    }
}

