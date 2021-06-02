
namespace Porject_Library_Management_APP
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.UpperGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLibrarians = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.UpperGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperGroupBox
            // 
            this.UpperGroupBox.BackColor = System.Drawing.Color.DarkRed;
            this.UpperGroupBox.Controls.Add(this.label1);
            this.UpperGroupBox.Controls.Add(this.btnBooks);
            this.UpperGroupBox.Controls.Add(this.btnLibrarians);
            this.UpperGroupBox.Location = new System.Drawing.Point(0, 33);
            this.UpperGroupBox.Name = "UpperGroupBox";
            this.UpperGroupBox.Size = new System.Drawing.Size(870, 66);
            this.UpperGroupBox.TabIndex = 0;
            this.UpperGroupBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Porject_Library_Management_APP.Properties.Resources.alfons_morales_YLSwjSy7stw_unsplash;
            this.pictureBox1.Image = global::Porject_Library_Management_APP.Properties.Resources.alfons_morales_YLSwjSy7stw_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(0, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(885, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLibrary";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Brown;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(755, 522);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 36);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLibrarians
            // 
            this.btnLibrarians.BackColor = System.Drawing.Color.Brown;
            this.btnLibrarians.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLibrarians.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarians.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLibrarians.Location = new System.Drawing.Point(768, 0);
            this.btnLibrarians.Name = "btnLibrarians";
            this.btnLibrarians.Size = new System.Drawing.Size(102, 62);
            this.btnLibrarians.TabIndex = 1;
            this.btnLibrarians.Text = "Librarians";
            this.btnLibrarians.UseVisualStyleBackColor = false;
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.Brown;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBooks.Location = new System.Drawing.Point(670, 0);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(102, 62);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(869, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.UpperGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.UpperGroupBox.ResumeLayout(false);
            this.UpperGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UpperGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnLibrarians;
        private System.Windows.Forms.Button btnLogout;
    }
}