﻿namespace FilesSearchandMove
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxSource = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open List of Files Names";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Information";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Source Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxSource
            // 
            this.listBoxSource.FormattingEnabled = true;
            this.listBoxSource.ItemHeight = 16;
            this.listBoxSource.Location = new System.Drawing.Point(-1, 68);
            this.listBoxSource.Name = "listBoxSource";
            this.listBoxSource.Size = new System.Drawing.Size(288, 516);
            this.listBoxSource.TabIndex = 3;
            this.listBoxSource.SelectedIndexChanged += new System.EventHandler(this.listBoxSource_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Destination Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(655, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "Move";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 585);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBoxSource);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "File Filter by Sandy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

