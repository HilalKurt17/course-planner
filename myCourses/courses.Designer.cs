namespace myCourses
{
    partial class courses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(courses));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttn_allCourses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chckBx_isFinished = new System.Windows.Forms.CheckBox();
            this.bttn_delete = new System.Windows.Forms.Button();
            this.bttn_update = new System.Windows.Forms.Button();
            this.bttn_register = new System.Windows.Forms.Button();
            this.txtBx_dueDate = new System.Windows.Forms.TextBox();
            this.txtBx_courseAcademy = new System.Windows.Forms.TextBox();
            this.txtBx_courseName = new System.Windows.Forms.TextBox();
            this.txtBx_userName = new System.Windows.Forms.TextBox();
            this.lbl_dueDate = new System.Windows.Forms.Label();
            this.lbl_courseAcademy = new System.Windows.Forms.Label();
            this.lbl_courseName = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttn_allCourses);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chckBx_isFinished);
            this.groupBox1.Controls.Add(this.bttn_delete);
            this.groupBox1.Controls.Add(this.bttn_update);
            this.groupBox1.Controls.Add(this.bttn_register);
            this.groupBox1.Controls.Add(this.txtBx_dueDate);
            this.groupBox1.Controls.Add(this.txtBx_courseAcademy);
            this.groupBox1.Controls.Add(this.txtBx_courseName);
            this.groupBox1.Controls.Add(this.txtBx_userName);
            this.groupBox1.Controls.Add(this.lbl_dueDate);
            this.groupBox1.Controls.Add(this.lbl_courseAcademy);
            this.groupBox1.Controls.Add(this.lbl_courseName);
            this.groupBox1.Controls.Add(this.lbl_userName);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // bttn_allCourses
            // 
            this.bttn_allCourses.BackColor = System.Drawing.Color.SteelBlue;
            this.bttn_allCourses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.bttn_allCourses, "bttn_allCourses");
            this.bttn_allCourses.Name = "bttn_allCourses";
            this.bttn_allCourses.UseVisualStyleBackColor = false;
            this.bttn_allCourses.Click += new System.EventHandler(this.bttn_allCourses_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // chckBx_isFinished
            // 
            resources.ApplyResources(this.chckBx_isFinished, "chckBx_isFinished");
            this.chckBx_isFinished.Name = "chckBx_isFinished";
            this.chckBx_isFinished.UseVisualStyleBackColor = true;
            // 
            // bttn_delete
            // 
            this.bttn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.bttn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.bttn_delete, "bttn_delete");
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.UseVisualStyleBackColor = false;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_clicked);
            // 
            // bttn_update
            // 
            this.bttn_update.BackColor = System.Drawing.Color.SteelBlue;
            this.bttn_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.bttn_update, "bttn_update");
            this.bttn_update.Name = "bttn_update";
            this.bttn_update.UseVisualStyleBackColor = false;
            this.bttn_update.Click += new System.EventHandler(this.bttn_clicked);
            // 
            // bttn_register
            // 
            this.bttn_register.BackColor = System.Drawing.Color.SteelBlue;
            this.bttn_register.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.bttn_register, "bttn_register");
            this.bttn_register.Name = "bttn_register";
            this.bttn_register.UseVisualStyleBackColor = false;
            this.bttn_register.Click += new System.EventHandler(this.bttn_clicked);
            // 
            // txtBx_dueDate
            // 
            resources.ApplyResources(this.txtBx_dueDate, "txtBx_dueDate");
            this.txtBx_dueDate.Name = "txtBx_dueDate";
            // 
            // txtBx_courseAcademy
            // 
            resources.ApplyResources(this.txtBx_courseAcademy, "txtBx_courseAcademy");
            this.txtBx_courseAcademy.Name = "txtBx_courseAcademy";
            // 
            // txtBx_courseName
            // 
            resources.ApplyResources(this.txtBx_courseName, "txtBx_courseName");
            this.txtBx_courseName.Name = "txtBx_courseName";
            // 
            // txtBx_userName
            // 
            resources.ApplyResources(this.txtBx_userName, "txtBx_userName");
            this.txtBx_userName.Name = "txtBx_userName";
            // 
            // lbl_dueDate
            // 
            resources.ApplyResources(this.lbl_dueDate, "lbl_dueDate");
            this.lbl_dueDate.Name = "lbl_dueDate";
            // 
            // lbl_courseAcademy
            // 
            resources.ApplyResources(this.lbl_courseAcademy, "lbl_courseAcademy");
            this.lbl_courseAcademy.Name = "lbl_courseAcademy";
            // 
            // lbl_courseName
            // 
            resources.ApplyResources(this.lbl_courseName, "lbl_courseName");
            this.lbl_courseName.Name = "lbl_courseName";
            // 
            // lbl_userName
            // 
            resources.ApplyResources(this.lbl_userName, "lbl_userName");
            this.lbl_userName.Name = "lbl_userName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            // 
            // courses
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "courses";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBx_dueDate;
        private TextBox txtBx_courseAcademy;
        private TextBox txtBx_courseName;
        private TextBox txtBx_userName;
        private Label lbl_dueDate;
        private Label lbl_courseAcademy;
        private Label lbl_courseName;
        private Label lbl_userName;
        private Button bttn_register;
        private Button bttn_allCourses;
        private Label label1;
        private CheckBox chckBx_isFinished;
        private Button bttn_delete;
        private Button bttn_update;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
    }
}