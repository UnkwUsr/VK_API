﻿
namespace VK_API
{
    partial class Firend_info
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Friend = new System.Windows.Forms.ListBox();
            this.bd_checkBox = new System.Windows.Forms.CheckBox();
            this.Status_checkBox = new System.Windows.Forms.CheckBox();
            this.Sex_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(366, 416);
            this.textBox1.TabIndex = 0;
            // 
            // Friend
            // 
            this.Friend.FormattingEnabled = true;
            this.Friend.ItemHeight = 16;
            this.Friend.Location = new System.Drawing.Point(563, 12);
            this.Friend.Name = "Friend";
            this.Friend.Size = new System.Drawing.Size(225, 420);
            this.Friend.TabIndex = 1;
            this.Friend.SelectedIndexChanged += new System.EventHandler(this.Filtr_Changed);
            // 
            // bd_checkBox
            // 
            this.bd_checkBox.AutoSize = true;
            this.bd_checkBox.ForeColor = System.Drawing.Color.White;
            this.bd_checkBox.Location = new System.Drawing.Point(18, 60);
            this.bd_checkBox.Name = "bd_checkBox";
            this.bd_checkBox.Size = new System.Drawing.Size(133, 21);
            this.bd_checkBox.TabIndex = 2;
            this.bd_checkBox.Text = "День рождения";
            this.bd_checkBox.UseVisualStyleBackColor = true;
            this.bd_checkBox.CheckedChanged += new System.EventHandler(this.Filtr_Changed);
            // 
            // Status_checkBox
            // 
            this.Status_checkBox.AutoSize = true;
            this.Status_checkBox.ForeColor = System.Drawing.Color.White;
            this.Status_checkBox.Location = new System.Drawing.Point(18, 87);
            this.Status_checkBox.Name = "Status_checkBox";
            this.Status_checkBox.Size = new System.Drawing.Size(75, 21);
            this.Status_checkBox.TabIndex = 3;
            this.Status_checkBox.Text = "Статус";
            this.Status_checkBox.UseVisualStyleBackColor = true;
            this.Status_checkBox.CheckedChanged += new System.EventHandler(this.Filtr_Changed);
            // 
            // Sex_checkBox
            // 
            this.Sex_checkBox.AutoSize = true;
            this.Sex_checkBox.ForeColor = System.Drawing.Color.White;
            this.Sex_checkBox.Location = new System.Drawing.Point(18, 33);
            this.Sex_checkBox.Name = "Sex_checkBox";
            this.Sex_checkBox.Size = new System.Drawing.Size(56, 21);
            this.Sex_checkBox.TabIndex = 5;
            this.Sex_checkBox.Text = "Пол";
            this.Sex_checkBox.UseVisualStyleBackColor = true;
            this.Sex_checkBox.CheckedChanged += new System.EventHandler(this.Filtr_Changed);
            // 
            // Firend_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sex_checkBox);
            this.Controls.Add(this.Status_checkBox);
            this.Controls.Add(this.bd_checkBox);
            this.Controls.Add(this.Friend);
            this.Controls.Add(this.textBox1);
            this.Name = "Firend_info";
            this.Text = "Firend_info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox Friend;
        private System.Windows.Forms.CheckBox bd_checkBox;
        private System.Windows.Forms.CheckBox Status_checkBox;
        private System.Windows.Forms.CheckBox Sex_checkBox;
    }
}