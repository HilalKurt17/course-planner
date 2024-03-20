namespace myCourses
{
    partial class updateCourse : Form
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
            this.update_txtBx = new System.Windows.Forms.TextBox();
            this.update_bttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.completedDateTime_txtBx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.completedAcademyName_txtBx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // update_txtBx
            // 
            this.update_txtBx.Location = new System.Drawing.Point(295, 65);
            this.update_txtBx.Name = "update_txtBx";
            this.update_txtBx.Size = new System.Drawing.Size(382, 28);
            this.update_txtBx.TabIndex = 1;
            // 
            // update_bttn
            // 
            this.update_bttn.BackColor = System.Drawing.Color.Crimson;
            this.update_bttn.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_bttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update_bttn.Location = new System.Drawing.Point(211, 279);
            this.update_bttn.Name = "update_bttn";
            this.update_bttn.Size = new System.Drawing.Size(286, 65);
            this.update_bttn.TabIndex = 4;
            this.update_bttn.Text = "UPDATE COURSE";
            this.update_bttn.UseVisualStyleBackColor = false;
            this.update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Completed Course Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Completion Time:";
            // 
            // completedDateTime_txtBx
            // 
            this.completedDateTime_txtBx.Location = new System.Drawing.Point(295, 195);
            this.completedDateTime_txtBx.Name = "completedDateTime_txtBx";
            this.completedDateTime_txtBx.Size = new System.Drawing.Size(382, 28);
            this.completedDateTime_txtBx.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.completedAcademyName_txtBx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.completedDateTime_txtBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.update_bttn);
            this.groupBox1.Controls.Add(this.update_txtBx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 379);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Academy:";
            // 
            // completedAcademyName_txtBx
            // 
            this.completedAcademyName_txtBx.Location = new System.Drawing.Point(295, 131);
            this.completedAcademyName_txtBx.Name = "completedAcademyName_txtBx";
            this.completedAcademyName_txtBx.Size = new System.Drawing.Size(382, 28);
            this.completedAcademyName_txtBx.TabIndex = 2;
            // 
            // updateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(753, 403);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(771, 450);
            this.MinimumSize = new System.Drawing.Size(771, 346);
            this.Name = "updateCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPDATE COURSE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private TextBox update_txtBx;
        private Button update_bttn;
        private Label label2;
        private Label label1;
        private TextBox completedDateTime_txtBx;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox completedAcademyName_txtBx;
    }
}