namespace InterfacesProject
{
    partial class ProductDetails
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
            this.description_tbox = new System.Windows.Forms.RichTextBox();
            this.name_tbox = new System.Windows.Forms.TextBox();
            this.code_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exists_lbl = new System.Windows.Forms.Label();
            this.costs_gbox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalCosts_tbox = new System.Windows.Forms.TextBox();
            this.other_textbox = new System.Windows.Forms.TextBox();
            this.material_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productTableAdapter1 = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.PRODUCTTableAdapter();
            this.costs_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // description_tbox
            // 
            this.description_tbox.Location = new System.Drawing.Point(342, 113);
            this.description_tbox.Name = "description_tbox";
            this.description_tbox.ReadOnly = true;
            this.description_tbox.Size = new System.Drawing.Size(123, 96);
            this.description_tbox.TabIndex = 23;
            this.description_tbox.Text = "";
            // 
            // name_tbox
            // 
            this.name_tbox.Location = new System.Drawing.Point(342, 73);
            this.name_tbox.Name = "name_tbox";
            this.name_tbox.ReadOnly = true;
            this.name_tbox.Size = new System.Drawing.Size(123, 22);
            this.name_tbox.TabIndex = 22;
            // 
            // code_tbox
            // 
            this.code_tbox.Location = new System.Drawing.Point(342, 31);
            this.code_tbox.Name = "code_tbox";
            this.code_tbox.ReadOnly = true;
            this.code_tbox.Size = new System.Drawing.Size(123, 22);
            this.code_tbox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Code";
            // 
            // exists_lbl
            // 
            this.exists_lbl.AutoSize = true;
            this.exists_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exists_lbl.Location = new System.Drawing.Point(222, 224);
            this.exists_lbl.Name = "exists_lbl";
            this.exists_lbl.Size = new System.Drawing.Size(403, 20);
            this.exists_lbl.TabIndex = 24;
            this.exists_lbl.Text = "This product does not have a specification yet!";
            // 
            // costs_gbox
            // 
            this.costs_gbox.Controls.Add(this.label6);
            this.costs_gbox.Controls.Add(this.totalCosts_tbox);
            this.costs_gbox.Controls.Add(this.other_textbox);
            this.costs_gbox.Controls.Add(this.material_textbox);
            this.costs_gbox.Controls.Add(this.label5);
            this.costs_gbox.Controls.Add(this.label4);
            this.costs_gbox.Location = new System.Drawing.Point(226, 247);
            this.costs_gbox.Name = "costs_gbox";
            this.costs_gbox.Size = new System.Drawing.Size(331, 159);
            this.costs_gbox.TabIndex = 25;
            this.costs_gbox.TabStop = false;
            this.costs_gbox.Text = "Total costs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // totalCosts_tbox
            // 
            this.totalCosts_tbox.Location = new System.Drawing.Point(145, 111);
            this.totalCosts_tbox.Name = "totalCosts_tbox";
            this.totalCosts_tbox.ReadOnly = true;
            this.totalCosts_tbox.Size = new System.Drawing.Size(100, 22);
            this.totalCosts_tbox.TabIndex = 4;
            // 
            // other_textbox
            // 
            this.other_textbox.Location = new System.Drawing.Point(145, 65);
            this.other_textbox.Name = "other_textbox";
            this.other_textbox.ReadOnly = true;
            this.other_textbox.Size = new System.Drawing.Size(100, 22);
            this.other_textbox.TabIndex = 3;
            // 
            // material_textbox
            // 
            this.material_textbox.Location = new System.Drawing.Point(145, 22);
            this.material_textbox.Name = "material_textbox";
            this.material_textbox.ReadOnly = true;
            this.material_textbox.Size = new System.Drawing.Size(100, 22);
            this.material_textbox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Other";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Material";
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.costs_gbox);
            this.Controls.Add(this.exists_lbl);
            this.Controls.Add(this.description_tbox);
            this.Controls.Add(this.name_tbox);
            this.Controls.Add(this.code_tbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product details";
            this.costs_gbox.ResumeLayout(false);
            this.costs_gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox description_tbox;
        private System.Windows.Forms.TextBox name_tbox;
        private System.Windows.Forms.TextBox code_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exists_lbl;
        private System.Windows.Forms.GroupBox costs_gbox;
        private System.Windows.Forms.TextBox other_textbox;
        private System.Windows.Forms.TextBox material_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalCosts_tbox;
        private BillOfMaterialsDBDataSetTableAdapters.PRODUCTTableAdapter productTableAdapter1;
    }
}