namespace InterfacesProject
{
    partial class ProductMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_Btn = new System.Windows.Forms.Button();
            this.desc_tbox = new System.Windows.Forms.TextBox();
            this.name_tbox = new System.Windows.Forms.TextBox();
            this.id_tbox = new System.Windows.Forms.TextBox();
            this.search_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billOfMaterialsDBDataSet = new InterfacesProject.BillOfMaterialsDBDataSet();
            this.pRODUCTTableAdapter = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.PRODUCTTableAdapter();
            this.addNew_Btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pRODUCTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateSpec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billOfMaterialsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_Btn);
            this.groupBox1.Controls.Add(this.desc_tbox);
            this.groupBox1.Controls.Add(this.name_tbox);
            this.groupBox1.Controls.Add(this.id_tbox);
            this.groupBox1.Controls.Add(this.search_Btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(185, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // clear_Btn
            // 
            this.clear_Btn.Location = new System.Drawing.Point(356, 82);
            this.clear_Btn.Name = "clear_Btn";
            this.clear_Btn.Size = new System.Drawing.Size(75, 23);
            this.clear_Btn.TabIndex = 4;
            this.clear_Btn.Text = "Clear";
            this.toolTip1.SetToolTip(this.clear_Btn, "Resets any search parameters");
            this.clear_Btn.UseVisualStyleBackColor = true;
            this.clear_Btn.Click += new System.EventHandler(this.clear_Btn_Click);
            // 
            // desc_tbox
            // 
            this.desc_tbox.Location = new System.Drawing.Point(114, 86);
            this.desc_tbox.Name = "desc_tbox";
            this.desc_tbox.Size = new System.Drawing.Size(145, 22);
            this.desc_tbox.TabIndex = 6;
            // 
            // name_tbox
            // 
            this.name_tbox.Location = new System.Drawing.Point(114, 54);
            this.name_tbox.Name = "name_tbox";
            this.name_tbox.Size = new System.Drawing.Size(145, 22);
            this.name_tbox.TabIndex = 5;
            // 
            // id_tbox
            // 
            this.id_tbox.Location = new System.Drawing.Point(114, 25);
            this.id_tbox.Name = "id_tbox";
            this.id_tbox.Size = new System.Drawing.Size(145, 22);
            this.id_tbox.TabIndex = 4;
            // 
            // search_Btn
            // 
            this.search_Btn.Location = new System.Drawing.Point(356, 31);
            this.search_Btn.Name = "search_Btn";
            this.search_Btn.Size = new System.Drawing.Size(75, 23);
            this.search_Btn.TabIndex = 3;
            this.search_Btn.Text = "Search";
            this.search_Btn.UseVisualStyleBackColor = true;
            this.search_Btn.Click += new System.EventHandler(this.search_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODUCTIDDataGridViewTextBoxColumn,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn,
            this.CreateSpec,
            this.Details});
            this.dataGridView1.DataSource = this.pRODUCTBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(185, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(449, 218);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.billOfMaterialsDBDataSet;
            // 
            // billOfMaterialsDBDataSet
            // 
            this.billOfMaterialsDBDataSet.DataSetName = "BillOfMaterialsDBDataSet";
            this.billOfMaterialsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // addNew_Btn
            // 
            this.addNew_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNew_Btn.FlatAppearance.BorderSize = 0;
            this.addNew_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addNew_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNew_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNew_Btn.Image = ((System.Drawing.Image)(resources.GetObject("addNew_Btn.Image")));
            this.addNew_Btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addNew_Btn.Location = new System.Drawing.Point(651, 180);
            this.addNew_Btn.Name = "addNew_Btn";
            this.addNew_Btn.Size = new System.Drawing.Size(137, 86);
            this.addNew_Btn.TabIndex = 5;
            this.addNew_Btn.Text = "Add new material";
            this.addNew_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addNew_Btn.UseVisualStyleBackColor = false;
            this.addNew_Btn.Click += new System.EventHandler(this.addNew_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Products Menu";
            // 
            // pRODUCTIDDataGridViewTextBoxColumn
            // 
            this.pRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_ID";
            this.pRODUCTIDDataGridViewTextBoxColumn.HeaderText = "Code";
            this.pRODUCTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUCTIDDataGridViewTextBoxColumn.Name = "pRODUCTIDDataGridViewTextBoxColumn";
            this.pRODUCTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTNAMEDataGridViewTextBoxColumn
            // 
            this.pRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Name = "pRODUCTNAMEDataGridViewTextBoxColumn";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_DESCRIPTION";
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Description";
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.Name = "pRODUCTDESCRIPTIONDataGridViewTextBoxColumn";
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCTDESCRIPTIONDataGridViewTextBoxColumn.Width = 125;
            // 
            // CreateSpec
            // 
            this.CreateSpec.HeaderText = "Create Specification";
            this.CreateSpec.MinimumWidth = 6;
            this.CreateSpec.Name = "CreateSpec";
            this.CreateSpec.ReadOnly = true;
            this.CreateSpec.Width = 125;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 125;
            // 
            // ProductMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addNew_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductMainForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billOfMaterialsDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear_Btn;
        private System.Windows.Forms.TextBox desc_tbox;
        private System.Windows.Forms.TextBox name_tbox;
        private System.Windows.Forms.TextBox id_tbox;
        private System.Windows.Forms.Button search_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BillOfMaterialsDBDataSet billOfMaterialsDBDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private BillOfMaterialsDBDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.Button addNew_Btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn CreateSpec;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
    }
}