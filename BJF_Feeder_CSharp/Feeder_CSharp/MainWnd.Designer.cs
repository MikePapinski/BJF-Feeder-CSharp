﻿namespace Feeder_CSharp
{
    partial class MainWnd
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
            this.m_ComboFeeder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_TxtUserName = new System.Windows.Forms.TextBox();
            this.m_BtnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_ComboFeeder
            // 
            this.m_ComboFeeder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_ComboFeeder.FormattingEnabled = true;
            this.m_ComboFeeder.Items.AddRange(new object[] {
            "US",
            "UK"});
            this.m_ComboFeeder.Location = new System.Drawing.Point(63, 18);
            this.m_ComboFeeder.Name = "m_ComboFeeder";
            this.m_ComboFeeder.Size = new System.Drawing.Size(75, 20);
            this.m_ComboFeeder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Feeder :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName :";
            // 
            // m_TxtUserName
            // 
            this.m_TxtUserName.Location = new System.Drawing.Point(235, 18);
            this.m_TxtUserName.Name = "m_TxtUserName";
            this.m_TxtUserName.Size = new System.Drawing.Size(166, 19);
            this.m_TxtUserName.TabIndex = 2;
            // 
            // m_BtnStart
            // 
            this.m_BtnStart.Location = new System.Drawing.Point(426, 17);
            this.m_BtnStart.Name = "m_BtnStart";
            this.m_BtnStart.Size = new System.Drawing.Size(107, 21);
            this.m_BtnStart.TabIndex = 3;
            this.m_BtnStart.Text = "START";
            this.m_BtnStart.UseVisualStyleBackColor = true;
            this.m_BtnStart.Click += new System.EventHandler(this.m_BtnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_TxtUserName);
            this.groupBox1.Controls.Add(this.m_BtnStart);
            this.groupBox1.Controls.Add(this.m_ComboFeeder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 80);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWnd";
            this.Text = "Feeder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWnd_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox m_ComboFeeder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_TxtUserName;
        private System.Windows.Forms.Button m_BtnStart;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

