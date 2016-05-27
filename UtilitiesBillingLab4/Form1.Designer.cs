namespace UtilitiesBillingLab4
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbResidential = new System.Windows.Forms.RadioButton();
            this.rbIndustrial = new System.Windows.Forms.RadioButton();
            this.rbCommercial = new System.Windows.Forms.RadioButton();
            this.grpCustomerType = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKWH1 = new System.Windows.Forms.Label();
            this.txtKWH1 = new System.Windows.Forms.TextBox();
            this.lblKWH2 = new System.Windows.Forms.Label();
            this.txtKWH2 = new System.Windows.Forms.TextBox();
            this.bthAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnExitAndSave = new System.Windows.Forms.Button();
            this.btnInsertCustomer = new System.Windows.Forms.Button();
            this.rtbCustDesc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCustomerType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 14;
            this.lstCustomers.Location = new System.Drawing.Point(357, 75);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(719, 578);
            this.lstCustomers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "BIG DOG UTILITY COMPANY";
            // 
            // rbResidential
            // 
            this.rbResidential.AutoSize = true;
            this.rbResidential.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbResidential.Location = new System.Drawing.Point(24, 51);
            this.rbResidential.Name = "rbResidential";
            this.rbResidential.Size = new System.Drawing.Size(77, 18);
            this.rbResidential.TabIndex = 3;
            this.rbResidential.TabStop = true;
            this.rbResidential.Text = "Residential";
            this.rbResidential.UseVisualStyleBackColor = true;
            this.rbResidential.CheckedChanged += new System.EventHandler(this.rbResidential_CheckedChanged);
            // 
            // rbIndustrial
            // 
            this.rbIndustrial.AutoSize = true;
            this.rbIndustrial.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIndustrial.Location = new System.Drawing.Point(25, 87);
            this.rbIndustrial.Name = "rbIndustrial";
            this.rbIndustrial.Size = new System.Drawing.Size(68, 18);
            this.rbIndustrial.TabIndex = 4;
            this.rbIndustrial.TabStop = true;
            this.rbIndustrial.Text = "Industrial";
            this.rbIndustrial.UseVisualStyleBackColor = true;
            this.rbIndustrial.CheckedChanged += new System.EventHandler(this.rbIndustrial_CheckedChanged);
            // 
            // rbCommercial
            // 
            this.rbCommercial.AutoSize = true;
            this.rbCommercial.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCommercial.Location = new System.Drawing.Point(25, 121);
            this.rbCommercial.Name = "rbCommercial";
            this.rbCommercial.Size = new System.Drawing.Size(80, 18);
            this.rbCommercial.TabIndex = 5;
            this.rbCommercial.TabStop = true;
            this.rbCommercial.Text = "Commercial";
            this.rbCommercial.UseVisualStyleBackColor = true;
            this.rbCommercial.CheckedChanged += new System.EventHandler(this.rbCommercial_CheckedChanged);
            // 
            // grpCustomerType
            // 
            this.grpCustomerType.Controls.Add(this.rbResidential);
            this.grpCustomerType.Controls.Add(this.rbCommercial);
            this.grpCustomerType.Controls.Add(this.rbIndustrial);
            this.grpCustomerType.Location = new System.Drawing.Point(14, 24);
            this.grpCustomerType.Name = "grpCustomerType";
            this.grpCustomerType.Size = new System.Drawing.Size(150, 201);
            this.grpCustomerType.TabIndex = 6;
            this.grpCustomerType.TabStop = false;
            this.grpCustomerType.Text = "Select Customer Type";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 262);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 20);
            this.txtName.TabIndex = 7;
            this.txtName.Tag = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer Name";
            // 
            // lblKWH1
            // 
            this.lblKWH1.AutoSize = true;
            this.lblKWH1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKWH1.Location = new System.Drawing.Point(10, 304);
            this.lblKWH1.Name = "lblKWH1";
            this.lblKWH1.Size = new System.Drawing.Size(76, 14);
            this.lblKWH1.TabIndex = 10;
            this.lblKWH1.Text = "Regular kWh";
            // 
            // txtKWH1
            // 
            this.txtKWH1.Location = new System.Drawing.Point(12, 321);
            this.txtKWH1.Name = "txtKWH1";
            this.txtKWH1.Size = new System.Drawing.Size(130, 20);
            this.txtKWH1.TabIndex = 9;
            // 
            // lblKWH2
            // 
            this.lblKWH2.AutoSize = true;
            this.lblKWH2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKWH2.Location = new System.Drawing.Point(156, 304);
            this.lblKWH2.Name = "lblKWH2";
            this.lblKWH2.Size = new System.Drawing.Size(168, 14);
            this.lblKWH2.TabIndex = 12;
            this.lblKWH2.Text = "Peak kWh (Where Applicable)";
            // 
            // txtKWH2
            // 
            this.txtKWH2.Location = new System.Drawing.Point(157, 321);
            this.txtKWH2.Name = "txtKWH2";
            this.txtKWH2.Size = new System.Drawing.Size(185, 20);
            this.txtKWH2.TabIndex = 11;
            // 
            // bthAdd
            // 
            this.bthAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthAdd.Location = new System.Drawing.Point(80, 375);
            this.bthAdd.Name = "bthAdd";
            this.bthAdd.Size = new System.Drawing.Size(180, 25);
            this.bthAdd.TabIndex = 13;
            this.bthAdd.Text = "Add Customer";
            this.bthAdd.UseVisualStyleBackColor = true;
            this.bthAdd.Click += new System.EventHandler(this.bthAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(80, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 25);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.Location = new System.Drawing.Point(80, 514);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(180, 25);
            this.btnClearForm.TabIndex = 15;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.Location = new System.Drawing.Point(80, 558);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(180, 25);
            this.btnClearList.TabIndex = 16;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnExitAndSave
            // 
            this.btnExitAndSave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitAndSave.Location = new System.Drawing.Point(80, 601);
            this.btnExitAndSave.Name = "btnExitAndSave";
            this.btnExitAndSave.Size = new System.Drawing.Size(180, 25);
            this.btnExitAndSave.TabIndex = 17;
            this.btnExitAndSave.Text = "Exit And Save The List";
            this.btnExitAndSave.UseVisualStyleBackColor = true;
            this.btnExitAndSave.Click += new System.EventHandler(this.btnExitAndSave_Click);
            // 
            // btnInsertCustomer
            // 
            this.btnInsertCustomer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCustomer.Location = new System.Drawing.Point(80, 421);
            this.btnInsertCustomer.Name = "btnInsertCustomer";
            this.btnInsertCustomer.Size = new System.Drawing.Size(180, 25);
            this.btnInsertCustomer.TabIndex = 18;
            this.btnInsertCustomer.Text = "Insert Customer";
            this.btnInsertCustomer.UseVisualStyleBackColor = true;
            this.btnInsertCustomer.Click += new System.EventHandler(this.btnInsertCustomer_Click);
            // 
            // rtbCustDesc
            // 
            this.rtbCustDesc.Enabled = false;
            this.rtbCustDesc.Location = new System.Drawing.Point(179, 41);
            this.rtbCustDesc.Name = "rtbCustDesc";
            this.rtbCustDesc.Size = new System.Drawing.Size(163, 184);
            this.rtbCustDesc.TabIndex = 19;
            this.rtbCustDesc.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "Customer Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 663);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbCustDesc);
            this.Controls.Add(this.btnInsertCustomer);
            this.Controls.Add(this.btnExitAndSave);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.bthAdd);
            this.Controls.Add(this.lblKWH2);
            this.Controls.Add(this.txtKWH2);
            this.Controls.Add(this.lblKWH1);
            this.Controls.Add(this.txtKWH1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grpCustomerType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCustomers);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCustomerType.ResumeLayout(false);
            this.grpCustomerType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbResidential;
        private System.Windows.Forms.RadioButton rbIndustrial;
        private System.Windows.Forms.RadioButton rbCommercial;
        private System.Windows.Forms.GroupBox grpCustomerType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKWH1;
        private System.Windows.Forms.TextBox txtKWH1;
        private System.Windows.Forms.Label lblKWH2;
        private System.Windows.Forms.TextBox txtKWH2;
        private System.Windows.Forms.Button bthAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnExitAndSave;
        private System.Windows.Forms.Button btnInsertCustomer;
        private System.Windows.Forms.RichTextBox rtbCustDesc;
        private System.Windows.Forms.Label label4;
    }
}

