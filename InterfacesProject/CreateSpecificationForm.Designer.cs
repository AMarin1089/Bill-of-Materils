namespace InterfacesProject
{
    partial class CreateSpecificationForm
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
            this.product_tbox = new System.Windows.Forms.TextBox();
            this.product_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addMaterial_btn = new System.Windows.Forms.Button();
            this.materials_richBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.matQuantity_Tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materials_Combobox = new System.Windows.Forms.ComboBox();
            this.productTableAdapter1 = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.PRODUCTTableAdapter();
            this.materialsTableAdapter1 = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.MATERIALSTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.createSpec_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.currentTotal_label = new System.Windows.Forms.Label();
            this.pricE_LISTTableAdapter1 = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.PRICE_LISTTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addExpense_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.expensesValue_tbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.expenseType_cbox = new System.Windows.Forms.ComboBox();
            this.expencesTableAdapter1 = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.EXPENCESTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_tbox
            // 
            this.product_tbox.Location = new System.Drawing.Point(383, 27);
            this.product_tbox.Name = "product_tbox";
            this.product_tbox.ReadOnly = true;
            this.product_tbox.Size = new System.Drawing.Size(123, 22);
            this.product_tbox.TabIndex = 22;
            // 
            // product_label
            // 
            this.product_label.AutoSize = true;
            this.product_label.Location = new System.Drawing.Point(312, 30);
            this.product_label.Name = "product_label";
            this.product_label.Size = new System.Drawing.Size(53, 16);
            this.product_label.TabIndex = 19;
            this.product_label.Text = "Product";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addMaterial_btn);
            this.groupBox1.Controls.Add(this.materials_richBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.matQuantity_Tbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.materials_Combobox);
            this.groupBox1.Location = new System.Drawing.Point(16, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 265);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materials";
            // 
            // addMaterial_btn
            // 
            this.addMaterial_btn.Location = new System.Drawing.Point(184, 113);
            this.addMaterial_btn.Name = "addMaterial_btn";
            this.addMaterial_btn.Size = new System.Drawing.Size(75, 23);
            this.addMaterial_btn.TabIndex = 5;
            this.addMaterial_btn.Text = "Add";
            this.addMaterial_btn.UseVisualStyleBackColor = true;
            this.addMaterial_btn.Click += new System.EventHandler(this.addMaterial_btn_Click);
            // 
            // materials_richBox
            // 
            this.materials_richBox.Location = new System.Drawing.Point(126, 142);
            this.materials_richBox.Name = "materials_richBox";
            this.materials_richBox.ReadOnly = true;
            this.materials_richBox.Size = new System.Drawing.Size(188, 106);
            this.materials_richBox.TabIndex = 4;
            this.materials_richBox.Text = "";
            this.toolTip1.SetToolTip(this.materials_richBox, "The current materials and their quantity will be listed here");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // matQuantity_Tbox
            // 
            this.matQuantity_Tbox.Location = new System.Drawing.Point(161, 76);
            this.matQuantity_Tbox.Name = "matQuantity_Tbox";
            this.matQuantity_Tbox.Size = new System.Drawing.Size(121, 22);
            this.matQuantity_Tbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // materials_Combobox
            // 
            this.materials_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materials_Combobox.FormattingEnabled = true;
            this.materials_Combobox.Location = new System.Drawing.Point(161, 31);
            this.materials_Combobox.Name = "materials_Combobox";
            this.materials_Combobox.Size = new System.Drawing.Size(121, 24);
            this.materials_Combobox.TabIndex = 0;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // materialsTableAdapter1
            // 
            this.materialsTableAdapter1.ClearBeforeFill = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(124, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(188, 106);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.toolTip1.SetToolTip(this.richTextBox1, "The current materials and their quantity will be listed here");
            // 
            // createSpec_btn
            // 
            this.createSpec_btn.Location = new System.Drawing.Point(775, 12);
            this.createSpec_btn.Name = "createSpec_btn";
            this.createSpec_btn.Size = new System.Drawing.Size(108, 37);
            this.createSpec_btn.TabIndex = 24;
            this.createSpec_btn.Text = "Create";
            this.createSpec_btn.UseVisualStyleBackColor = true;
            this.createSpec_btn.Click += new System.EventHandler(this.createSpec_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Current total:";
            // 
            // currentTotal_label
            // 
            this.currentTotal_label.AutoSize = true;
            this.currentTotal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTotal_label.Location = new System.Drawing.Point(804, 56);
            this.currentTotal_label.Name = "currentTotal_label";
            this.currentTotal_label.Size = new System.Drawing.Size(71, 16);
            this.currentTotal_label.TabIndex = 26;
            this.currentTotal_label.Text = "CurrTotal";
            // 
            // pricE_LISTTableAdapter1
            // 
            this.pricE_LISTTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.addExpense_Btn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.expensesValue_tbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.expenseType_cbox);
            this.groupBox2.Location = new System.Drawing.Point(429, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 265);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expenses";
            // 
            // addExpense_Btn
            // 
            this.addExpense_Btn.Location = new System.Drawing.Point(184, 113);
            this.addExpense_Btn.Name = "addExpense_Btn";
            this.addExpense_Btn.Size = new System.Drawing.Size(75, 23);
            this.addExpense_Btn.TabIndex = 5;
            this.addExpense_Btn.Text = "Add";
            this.addExpense_Btn.UseVisualStyleBackColor = true;
            this.addExpense_Btn.Click += new System.EventHandler(this.addExpense_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Value";
            // 
            // expensesValue_tbox
            // 
            this.expensesValue_tbox.Location = new System.Drawing.Point(161, 76);
            this.expensesValue_tbox.Name = "expensesValue_tbox";
            this.expensesValue_tbox.Size = new System.Drawing.Size(121, 22);
            this.expensesValue_tbox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Type";
            // 
            // expenseType_cbox
            // 
            this.expenseType_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expenseType_cbox.FormattingEnabled = true;
            this.expenseType_cbox.Location = new System.Drawing.Point(161, 31);
            this.expenseType_cbox.Name = "expenseType_cbox";
            this.expenseType_cbox.Size = new System.Drawing.Size(121, 24);
            this.expenseType_cbox.TabIndex = 0;
            // 
            // expencesTableAdapter1
            // 
            this.expencesTableAdapter1.ClearBeforeFill = true;
            // 
            // CreateSpecificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.currentTotal_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createSpec_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.product_tbox);
            this.Controls.Add(this.product_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateSpecificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create specification";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox product_tbox;
        private System.Windows.Forms.Label product_label;
        private BillOfMaterialsDBDataSetTableAdapters.PRODUCTTableAdapter productTableAdapter1;
        private BillOfMaterialsDBDataSetTableAdapters.MATERIALSTableAdapter materialsTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materials_Combobox;
        private System.Windows.Forms.RichTextBox materials_richBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox matQuantity_Tbox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button addMaterial_btn;
        private System.Windows.Forms.Button createSpec_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentTotal_label;
        private BillOfMaterialsDBDataSetTableAdapters.PRICE_LISTTableAdapter pricE_LISTTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addExpense_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expensesValue_tbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox expenseType_cbox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private BillOfMaterialsDBDataSetTableAdapters.EXPENCESTableAdapter expencesTableAdapter1;
    }
}