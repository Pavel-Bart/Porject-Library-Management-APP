
namespace Porject_Library_Management_APP.ZForms
{
    partial class StudentsForm
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
            this.StudentsGroupBox = new System.Windows.Forms.GroupBox();
            this.lblForm = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.StudentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsGroupBox
            // 
            this.StudentsGroupBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.StudentsGroupBox.Controls.Add(this.lblForm);
            this.StudentsGroupBox.Controls.Add(this.lblTitle);
            this.StudentsGroupBox.Location = new System.Drawing.Point(-2, -8);
            this.StudentsGroupBox.Name = "StudentsGroupBox";
            this.StudentsGroupBox.Size = new System.Drawing.Size(874, 139);
            this.StudentsGroupBox.TabIndex = 2;
            this.StudentsGroupBox.TabStop = false;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForm.Location = new System.Drawing.Point(383, 72);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(129, 33);
            this.lblForm.TabIndex = 1;
            this.lblForm.Text = "Students";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(312, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(274, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PLibrary System";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(12, 500);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(83, 47);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(869, 559);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.StudentsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            this.StudentsGroupBox.ResumeLayout(false);
            this.StudentsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StudentsGroupBox;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHome;
    }
}