﻿
namespace Porject_Library_Management_APP
{
    partial class BooksForm
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
            this.BookGroupBox = new System.Windows.Forms.GroupBox();
            this.lblForm = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.BookGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookGroupBox
            // 
            this.BookGroupBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.BookGroupBox.Controls.Add(this.lblForm);
            this.BookGroupBox.Controls.Add(this.lblTitle);
            this.BookGroupBox.Location = new System.Drawing.Point(-1, -7);
            this.BookGroupBox.Name = "BookGroupBox";
            this.BookGroupBox.Size = new System.Drawing.Size(872, 129);
            this.BookGroupBox.TabIndex = 1;
            this.BookGroupBox.TabStop = false;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForm.Location = new System.Drawing.Point(383, 72);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(96, 33);
            this.lblForm.TabIndex = 1;
            this.lblForm.Text = "Books";
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
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(869, 559);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.BookGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.BookGroupBox.ResumeLayout(false);
            this.BookGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BookGroupBox;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHome;
    }
}