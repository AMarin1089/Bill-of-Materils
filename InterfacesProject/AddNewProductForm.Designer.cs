namespace InterfacesProject
{
    partial class AddNewProductForm
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
            this.addNewProduct_btn = new System.Windows.Forms.Button();
            this.description_tbox = new System.Windows.Forms.RichTextBox();
            this.name_tbox = new System.Windows.Forms.TextBox();
            this.code_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productTableAdapter1 = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.PRODUCTTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // addNewProduct_btn
            // 
            this.addNewProduct_btn.Location = new System.Drawing.Point(520, 84);
            this.addNewProduct_btn.Name = "addNewProduct_btn";
            this.addNewProduct_btn.Size = new System.Drawing.Size(108, 37);
            this.addNewProduct_btn.TabIndex = 17;
            this.addNewProduct_btn.Text = "Add product";
            this.toolTip1.SetToolTip(this.addNewProduct_btn, "Persists this entity to the database");
            this.addNewProduct_btn.UseVisualStyleBackColor = true;
            this.addNewProduct_btn.Click += new System.EventHandler(this.addNewProduct_btn_Click);
            // 
            // description_tbox
            // 
            this.description_tbox.Location = new System.Drawing.Point(281, 116);
            this.description_tbox.Name = "description_tbox";
            this.description_tbox.Size = new System.Drawing.Size(123, 96);
            this.description_tbox.TabIndex = 16;
            this.description_tbox.Text = "";
            // 
            // name_tbox
            // 
            this.name_tbox.Location = new System.Drawing.Point(281, 76);
            this.name_tbox.Name = "name_tbox";
            this.name_tbox.Size = new System.Drawing.Size(123, 22);
            this.name_tbox.TabIndex = 15;
            // 
            // code_tbox
            // 
            this.code_tbox.Location = new System.Drawing.Point(281, 34);
            this.code_tbox.Name = "code_tbox";
            this.code_tbox.Size = new System.Drawing.Size(123, 22);
            this.code_tbox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Code";
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // AddNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 272);
            this.Controls.Add(this.addNewProduct_btn);
            this.Controls.Add(this.description_tbox);
            this.Controls.Add(this.name_tbox);
            this.Controls.Add(this.code_tbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewProduct_btn;
        private System.Windows.Forms.RichTextBox description_tbox;
        private System.Windows.Forms.TextBox name_tbox;
        private System.Windows.Forms.TextBox code_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BillOfMaterialsDBDataSetTableAdapters.PRODUCTTableAdapter productTableAdapter1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}