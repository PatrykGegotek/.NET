﻿namespace RPG
{
    partial class CategoryModification
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.attributesBox = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atributes:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(118, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(269, 16);
            this.name.TabIndex = 2;
            this.name.Text = "label3";
            // 
            // attributesBox
            // 
            this.attributesBox.FormattingEnabled = true;
            this.attributesBox.ItemHeight = 16;
            this.attributesBox.Location = new System.Drawing.Point(118, 79);
            this.attributesBox.Name = "attributesBox";
            this.attributesBox.Size = new System.Drawing.Size(269, 100);
            this.attributesBox.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(418, 25);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(77, 70);
            this.add.TabIndex = 4;
            this.add.Text = "Add attribute";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(418, 109);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(77, 70);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete attribute";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Creator:";
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(118, 52);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(269, 16);
            this.author.TabIndex = 8;
            this.author.Text = "label3";
            // 
            // CategoryModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 221);
            this.Controls.Add(this.author);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.attributesBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "CategoryModification";
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.CategoryModification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ListBox attributesBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label author;
    }
}