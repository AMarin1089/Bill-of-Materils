namespace InterfacesProject
{
    partial class AddNewMaterialForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.code_tbox = new System.Windows.Forms.TextBox();
            this.name_tbox = new System.Windows.Forms.TextBox();
            this.description_tbox = new System.Windows.Forms.RichTextBox();
            this.measure_cbox = new System.Windows.Forms.ComboBox();
            this.addNewMaterial_btn = new System.Windows.Forms.Button();
            this.materialsTableAdapter1 = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.MATERIALSTableAdapter();
            this.pricE_LISTTableAdapter1 = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.PRICE_LISTTableAdapter();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.price_tbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addPriceBtn = new System.Windows.Forms.Button();
            this.allPrices_richBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Measure";
            // 
            // code_tbox
            // 
            this.code_tbox.Location = new System.Drawing.Point(341, 27);
            this.code_tbox.Name = "code_tbox";
            this.code_tbox.Size = new System.Drawing.Size(123, 22);
            this.code_tbox.TabIndex = 4;
            // 
            // name_tbox
            // 
            this.name_tbox.Location = new System.Drawing.Point(341, 69);
            this.name_tbox.Name = "name_tbox";
            this.name_tbox.Size = new System.Drawing.Size(123, 22);
            this.name_tbox.TabIndex = 6;
            // 
            // description_tbox
            // 
            this.description_tbox.Location = new System.Drawing.Point(341, 109);
            this.description_tbox.Name = "description_tbox";
            this.description_tbox.Size = new System.Drawing.Size(123, 96);
            this.description_tbox.TabIndex = 7;
            this.description_tbox.Text = "";
            // 
            // measure_cbox
            // 
            this.measure_cbox.FormattingEnabled = true;
            this.measure_cbox.Location = new System.Drawing.Point(341, 230);
            this.measure_cbox.Name = "measure_cbox";
            this.measure_cbox.Size = new System.Drawing.Size(121, 24);
            this.measure_cbox.TabIndex = 8;
            // 
            // addNewMaterial_btn
            // 
            this.addNewMaterial_btn.Location = new System.Drawing.Point(680, 12);
            this.addNewMaterial_btn.Name = "addNewMaterial_btn";
            this.addNewMaterial_btn.Size = new System.Drawing.Size(108, 37);
            this.addNewMaterial_btn.TabIndex = 10;
            this.addNewMaterial_btn.Text = "Add material";
            this.toolTip1.SetToolTip(this.addNewMaterial_btn, "Persists this entity to the database");
            this.addNewMaterial_btn.UseVisualStyleBackColor = true;
            this.addNewMaterial_btn.Click += new System.EventHandler(this.addNewMaterial_btn_Click);
            // 
            // materialsTableAdapter1
            // 
            this.materialsTableAdapter1.ClearBeforeFill = true;
            // 
            // pricE_LISTTableAdapter1
            // 
            this.pricE_LISTTableAdapter1.ClearBeforeFill = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(49, 39);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date";
            // 
            // price_tbox
            // 
            this.price_tbox.Location = new System.Drawing.Point(368, 38);
            this.price_tbox.Name = "price_tbox";
            this.price_tbox.Size = new System.Drawing.Size(100, 22);
            this.price_tbox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price";
            // 
            // addPriceBtn
            // 
            this.addPriceBtn.Location = new System.Drawing.Point(211, 223);
            this.addPriceBtn.Name = "addPriceBtn";
            this.addPriceBtn.Size = new System.Drawing.Size(75, 23);
            this.addPriceBtn.TabIndex = 4;
            this.addPriceBtn.Text = "Add price";
            this.addPriceBtn.UseVisualStyleBackColor = true;
            this.addPriceBtn.Click += new System.EventHandler(this.addPriceBtn_Click);
            // 
            // allPrices_richBox
            // 
            this.allPrices_richBox.Location = new System.Drawing.Point(49, 67);
            this.allPrices_richBox.Name = "allPrices_richBox";
            this.allPrices_richBox.ReadOnly = true;
            this.allPrices_richBox.Size = new System.Drawing.Size(419, 135);
            this.allPrices_richBox.TabIndex = 5;
            this.allPrices_richBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allPrices_richBox);
            this.groupBox1.Controls.Add(this.addPriceBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.price_tbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(102, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 265);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price list";
            // 
            // AddNewMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.addNewMaterial_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.measure_cbox);
            this.Controls.Add(this.description_tbox);
            this.Controls.Add(this.name_tbox);
            this.Controls.Add(this.code_tbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewMaterialForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox code_tbox;
        private System.Windows.Forms.TextBox name_tbox;
        private System.Windows.Forms.RichTextBox description_tbox;
        private System.Windows.Forms.ComboBox measure_cbox;
        private System.Windows.Forms.Button addNewMaterial_btn;
        private BillOfMaterialsDBDataSetTableAdapters.MATERIALSTableAdapter materialsTableAdapter1;
        private BillOfMaterialsDBDataSetTableAdapters.PRICE_LISTTableAdapter pricE_LISTTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price_tbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addPriceBtn;
        private System.Windows.Forms.RichTextBox allPrices_richBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}