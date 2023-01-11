namespace InterfacesProject
{
    partial class ExpenseMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseMainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eXPENCEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPENCENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPENCESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billOfMaterialsDBDataSet = new InterfacesProject.BillOfMaterialsDBDataSet();
            this.eXPENCESTableAdapter = new InterfacesProject.BillOfMaterialsDBDataSetTableAdapters.EXPENCESTableAdapter();
            this.addNew_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENCESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billOfMaterialsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eXPENCEIDDataGridViewTextBoxColumn,
            this.eXPENCENAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eXPENCESBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(221, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(171, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // eXPENCEIDDataGridViewTextBoxColumn
            // 
            this.eXPENCEIDDataGridViewTextBoxColumn.DataPropertyName = "EXPENCE_ID";
            this.eXPENCEIDDataGridViewTextBoxColumn.HeaderText = "EXPENCE_ID";
            this.eXPENCEIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXPENCEIDDataGridViewTextBoxColumn.Name = "eXPENCEIDDataGridViewTextBoxColumn";
            this.eXPENCEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eXPENCEIDDataGridViewTextBoxColumn.Visible = false;
            this.eXPENCEIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // eXPENCENAMEDataGridViewTextBoxColumn
            // 
            this.eXPENCENAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPENCE_NAME";
            this.eXPENCENAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.eXPENCENAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXPENCENAMEDataGridViewTextBoxColumn.Name = "eXPENCENAMEDataGridViewTextBoxColumn";
            this.eXPENCENAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eXPENCENAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eXPENCESBindingSource
            // 
            this.eXPENCESBindingSource.DataMember = "EXPENCES";
            this.eXPENCESBindingSource.DataSource = this.billOfMaterialsDBDataSet;
            // 
            // billOfMaterialsDBDataSet
            // 
            this.billOfMaterialsDBDataSet.DataSetName = "BillOfMaterialsDBDataSet";
            this.billOfMaterialsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXPENCESTableAdapter
            // 
            this.eXPENCESTableAdapter.ClearBeforeFill = true;
            // 
            // addNew_Btn
            // 
            this.addNew_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNew_Btn.FlatAppearance.BorderSize = 0;
            this.addNew_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNew_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNew_Btn.Image = ((System.Drawing.Image)(resources.GetObject("addNew_Btn.Image")));
            this.addNew_Btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addNew_Btn.Location = new System.Drawing.Point(445, 137);
            this.addNew_Btn.Name = "addNew_Btn";
            this.addNew_Btn.Size = new System.Drawing.Size(152, 81);
            this.addNew_Btn.TabIndex = 2;
            this.addNew_Btn.Text = "Add new expense";
            this.addNew_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addNew_Btn.UseVisualStyleBackColor = false;
            this.addNew_Btn.Click += new System.EventHandler(this.addNew_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expense Menu";
            // 
            // ExpenseMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNew_Btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExpenseMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpenseMainForm_FormClosing);
            this.Load += new System.EventHandler(this.ExpenseMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENCESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billOfMaterialsDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BillOfMaterialsDBDataSet billOfMaterialsDBDataSet;
        private System.Windows.Forms.BindingSource eXPENCESBindingSource;
        private BillOfMaterialsDBDataSetTableAdapters.EXPENCESTableAdapter eXPENCESTableAdapter;
        private System.Windows.Forms.Button addNew_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENCEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENCENAMEDataGridViewTextBoxColumn;
    }
}