﻿namespace MorgenHack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.writeTextBox = new System.Windows.Forms.TextBox();
            this.readTextBox = new System.Windows.Forms.TextBox();
            this.readButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writeTextBox
            // 
            this.writeTextBox.Location = new System.Drawing.Point(81, 59);
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.PlaceholderText = "Запись";
            this.writeTextBox.Size = new System.Drawing.Size(100, 23);
            this.writeTextBox.TabIndex = 0;
            // 
            // readTextBox
            // 
            this.readTextBox.Location = new System.Drawing.Point(198, 59);
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.PlaceholderText = "Чтение";
            this.readTextBox.Size = new System.Drawing.Size(100, 23);
            this.readTextBox.TabIndex = 1;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(198, 88);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "Чтение";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(81, 88);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(75, 23);
            this.writeButton.TabIndex = 3;
            this.writeButton.Text = "Запись";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 168);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.writeTextBox);
            this.Name = "Form1";
            this.Text = "MorgenHack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox writeTextBox;
        private TextBox readTextBox;
        private Button readButton;
        private Button writeButton;
    }
}