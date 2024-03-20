namespace myCourses
{
    partial class deleteCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteAcademyName_txtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteCourse_bttn = new System.Windows.Forms.Button();
            this.deleteCourse_txtBx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 339);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.deleteAcademyName_txtBx);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.deleteCourse_bttn);
            this.groupBox2.Controls.Add(this.deleteCourse_txtBx);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // deleteAcademyName_txtBx
            // 
            this.deleteAcademyName_txtBx.Location = new System.Drawing.Point(241, 133);
            this.deleteAcademyName_txtBx.Name = "deleteAcademyName_txtBx";
            this.deleteAcademyName_txtBx.Size = new System.Drawing.Size(182, 31);
            this.deleteAcademyName_txtBx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Academy:";
            // 
            // deleteCourse_bttn
            // 
            this.deleteCourse_bttn.BackColor = System.Drawing.Color.IndianRed;
            this.deleteCourse_bttn.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteCourse_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteCourse_bttn.Location = new System.Drawing.Point(114, 206);
            this.deleteCourse_bttn.Name = "deleteCourse_bttn";
            this.deleteCourse_bttn.Size = new System.Drawing.Size(275, 38);
            this.deleteCourse_bttn.TabIndex = 3;
            this.deleteCourse_bttn.Text = "DELETE COURSE";
            this.deleteCourse_bttn.UseVisualStyleBackColor = false;
            this.deleteCourse_bttn.Click += new System.EventHandler(this.deleteCourse_bttn_Click);
            // 
            // deleteCourse_txtBx
            // 
            this.deleteCourse_txtBx.Location = new System.Drawing.Point(241, 75);
            this.deleteCourse_txtBx.Name = "deleteCourse_txtBx";
            this.deleteCourse_txtBx.Size = new System.Drawing.Size(182, 31);
            this.deleteCourse_txtBx.TabIndex = 1;
            // 
            // deleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(530, 332);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(548, 390);
            this.MinimumSize = new System.Drawing.Size(548, 296);
            this.Name = "deleteCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DELETE COURSE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button deleteCourse_bttn;
        private TextBox deleteCourse_txtBx;
        private TextBox deleteAcademyName_txtBx;
        private Label label2;
    }
}