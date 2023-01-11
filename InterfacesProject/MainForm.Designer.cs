namespace InterfacesProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signout_btn = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.username_lbl = new System.Windows.Forms.Label();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.userLogo_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openExpense_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openMaterials_Btn = new System.Windows.Forms.Button();
            this.openProducts_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.signout_btn);
            this.panel1.Controls.Add(this.userPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // signout_btn
            // 
            this.signout_btn.BackColor = System.Drawing.Color.Silver;
            this.signout_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.signout_btn.FlatAppearance.BorderSize = 0;
            this.signout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.signout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signout_btn.Location = new System.Drawing.Point(0, 131);
            this.signout_btn.Name = "signout_btn";
            this.signout_btn.Size = new System.Drawing.Size(200, 29);
            this.signout_btn.TabIndex = 1;
            this.signout_btn.Text = "Sign Out";
            this.signout_btn.UseVisualStyleBackColor = false;
            this.signout_btn.Click += new System.EventHandler(this.signout_btn_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.username_lbl);
            this.userPanel.Controls.Add(this.welcome_lbl);
            this.userPanel.Controls.Add(this.userLogo_pictureBox);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(200, 131);
            this.userPanel.TabIndex = 0;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(93, 100);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(70, 25);
            this.username_lbl.TabIndex = 2;
            this.username_lbl.Text = "admin";
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.Location = new System.Drawing.Point(35, 100);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(64, 25);
            this.welcome_lbl.TabIndex = 1;
            this.welcome_lbl.Text = "User: ";
            // 
            // userLogo_pictureBox
            // 
            this.userLogo_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userLogo_pictureBox.Image")));
            this.userLogo_pictureBox.Location = new System.Drawing.Point(49, 0);
            this.userLogo_pictureBox.Name = "userLogo_pictureBox";
            this.userLogo_pictureBox.Size = new System.Drawing.Size(100, 97);
            this.userLogo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userLogo_pictureBox.TabIndex = 0;
            this.userLogo_pictureBox.TabStop = false;
            this.userLogo_pictureBox.Click += new System.EventHandler(this.userLogo_pictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to your Dashboard";
            // 
            // openExpense_Btn
            // 
            this.openExpense_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.openExpense_Btn.FlatAppearance.BorderSize = 0;
            this.openExpense_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.openExpense_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.openExpense_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openExpense_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openExpense_Btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openExpense_Btn.Location = new System.Drawing.Point(233, 112);
            this.openExpense_Btn.Name = "openExpense_Btn";
            this.openExpense_Btn.Size = new System.Drawing.Size(170, 122);
            this.openExpense_Btn.TabIndex = 3;
            this.openExpense_Btn.Text = "Expenses";
            this.openExpense_Btn.UseVisualStyleBackColor = false;
            this.openExpense_Btn.Click += new System.EventHandler(this.openExpense_Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // openMaterials_Btn
            // 
            this.openMaterials_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.openMaterials_Btn.FlatAppearance.BorderSize = 0;
            this.openMaterials_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.openMaterials_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.openMaterials_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMaterials_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openMaterials_Btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openMaterials_Btn.Location = new System.Drawing.Point(618, 112);
            this.openMaterials_Btn.Name = "openMaterials_Btn";
            this.openMaterials_Btn.Size = new System.Drawing.Size(170, 122);
            this.openMaterials_Btn.TabIndex = 4;
            this.openMaterials_Btn.Text = "Materials";
            this.openMaterials_Btn.UseVisualStyleBackColor = false;
            this.openMaterials_Btn.Click += new System.EventHandler(this.openMaterials_Btn_Click);
            // 
            // openProducts_btn
            // 
            this.openProducts_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.openProducts_btn.FlatAppearance.BorderSize = 0;
            this.openProducts_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.openProducts_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.openProducts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProducts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openProducts_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openProducts_btn.Location = new System.Drawing.Point(416, 277);
            this.openProducts_btn.Name = "openProducts_btn";
            this.openProducts_btn.Size = new System.Drawing.Size(170, 122);
            this.openProducts_btn.TabIndex = 5;
            this.openProducts_btn.Text = "Products";
            this.openProducts_btn.UseVisualStyleBackColor = false;
            this.openProducts_btn.Click += new System.EventHandler(this.openProducts_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openProducts_btn);
            this.Controls.Add(this.openMaterials_Btn);
            this.Controls.Add(this.openExpense_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signout_btn;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.PictureBox userLogo_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openExpense_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openMaterials_Btn;
        private System.Windows.Forms.Button openProducts_btn;
    }
}