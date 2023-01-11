namespace InterfacesProject
{
    partial class EditMaterialForm
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
            this.update_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allPrices_richBox = new System.Windows.Forms.RichTextBox();
            this.addPriceBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.price_tbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.measure_cbox = new System.Windows.Forms.ComboBox();
            this.description_tbox = new System.Windows.Forms.RichTextBox();
            this.name_tbox = new System.Windows.Forms.TextBox();
            this.code_tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expand_button = new System.Windows.Forms.Button();
            this.presentLabel = new System.Windows.Forms.Label();
            this.tbox_Present = new System.Windows.Forms.RichTextBox();
            this.materialsTableAdapter1 = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.MATERIALSTableAdapter();
            this.pricE_LISTTableAdapter1 = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.PRICE_LISTTableAdapter();
            this.bomTableAdapter1 = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.BOMTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(688, 33);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(108, 37);
            this.update_btn.TabIndex = 20;
            this.update_btn.Text = "Update";
            this.toolTip1.SetToolTip(this.update_btn, "Updates the entity\'s information");
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allPrices_richBox);
            this.groupBox1.Controls.Add(this.addPriceBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.price_tbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(125, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 265);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price list";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price";
            // 
            // price_tbox
            // 
            this.price_tbox.Location = new System.Drawing.Point(368, 38);
            this.price_tbox.Name = "price_tbox";
            this.price_tbox.Size = new System.Drawing.Size(100, 22);
            this.price_tbox.TabIndex = 2;
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
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(49, 39);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // measure_cbox
            // 
            this.measure_cbox.FormattingEnabled = true;
            this.measure_cbox.Location = new System.Drawing.Point(288, 236);
            this.measure_cbox.Name = "measure_cbox";
            this.measure_cbox.Size = new System.Drawing.Size(121, 24);
            this.measure_cbox.TabIndex = 18;
            // 
            // description_tbox
            // 
            this.description_tbox.Location = new System.Drawing.Point(288, 115);
            this.description_tbox.Name = "description_tbox";
            this.description_tbox.Size = new System.Drawing.Size(123, 96);
            this.description_tbox.TabIndex = 17;
            this.description_tbox.Text = "";
            // 
            // name_tbox
            // 
            this.name_tbox.Location = new System.Drawing.Point(288, 75);
            this.name_tbox.Name = "name_tbox";
            this.name_tbox.Size = new System.Drawing.Size(123, 22);
            this.name_tbox.TabIndex = 16;
            // 
            // code_tbox
            // 
            this.code_tbox.Location = new System.Drawing.Point(288, 33);
            this.code_tbox.Name = "code_tbox";
            this.code_tbox.Size = new System.Drawing.Size(123, 22);
            this.code_tbox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Measure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Code";
            // 
            // expand_button
            // 
            this.expand_button.Location = new System.Drawing.Point(520, 120);
            this.expand_button.Name = "expand_button";
            this.expand_button.Size = new System.Drawing.Size(75, 23);
            this.expand_button.TabIndex = 23;
            this.expand_button.Text = "Details";
            this.expand_button.UseVisualStyleBackColor = true;
            this.expand_button.Visible = false;
            this.expand_button.Click += new System.EventHandler(this.expand_button_Click);
            // 
            // presentLabel
            // 
            this.presentLabel.AutoSize = true;
            this.presentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentLabel.Location = new System.Drawing.Point(517, 101);
            this.presentLabel.Name = "presentLabel";
            this.presentLabel.Size = new System.Drawing.Size(76, 16);
            this.presentLabel.TabIndex = 21;
            this.presentLabel.Text = "Present in";
            // 
            // tbox_Present
            // 
            this.tbox_Present.Location = new System.Drawing.Point(520, 164);
            this.tbox_Present.Name = "tbox_Present";
            this.tbox_Present.ReadOnly = true;
            this.tbox_Present.Size = new System.Drawing.Size(146, 96);
            this.tbox_Present.TabIndex = 22;
            this.tbox_Present.Text = "";
            this.tbox_Present.Visible = false;
            // 
            // materialsTableAdapter1
            // 
            this.materialsTableAdapter1.ClearBeforeFill = true;
            // 
            // pricE_LISTTableAdapter1
            // 
            this.pricE_LISTTableAdapter1.ClearBeforeFill = true;
            // 
            // bomTableAdapter1
            // 
            this.bomTableAdapter1.ClearBeforeFill = true;
            // 
            // EditMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.tbox_Present);
            this.Controls.Add(this.presentLabel);
            this.Controls.Add(this.expand_button);
            this.Controls.Add(this.update_btn);
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
            this.Name = "EditMaterialForm";
            this.Text = "Edit material";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox allPrices_richBox;
        private System.Windows.Forms.Button addPriceBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price_tbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox measure_cbox;
        private System.Windows.Forms.RichTextBox description_tbox;
        private System.Windows.Forms.TextBox name_tbox;
        private System.Windows.Forms.TextBox code_tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BillOfMaterialsDBDataSetTableAdapters.MATERIALSTableAdapter materialsTableAdapter1;
        private BillOfMaterialsDBDataSetTableAdapters.PRICE_LISTTableAdapter pricE_LISTTableAdapter1;
        private System.Windows.Forms.Button expand_button;
        private System.Windows.Forms.Label presentLabel;
        private System.Windows.Forms.RichTextBox tbox_Present;
        private BillOfMaterialsDBDataSetTableAdapters.BOMTableAdapter bomTableAdapter1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}