namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.mainNumber = new System.Windows.Forms.Label();
            this.row1 = new System.Windows.Forms.Button();
            this.row2 = new System.Windows.Forms.Button();
            this.row4 = new System.Windows.Forms.Button();
            this.row3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recordlbl = new System.Windows.Forms.Label();
            this.nextNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainNumber
            // 
            this.mainNumber.BackColor = System.Drawing.Color.Yellow;
            this.mainNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainNumber.Location = new System.Drawing.Point(170, 455);
            this.mainNumber.Name = "mainNumber";
            this.mainNumber.Size = new System.Drawing.Size(94, 94);
            this.mainNumber.TabIndex = 0;
            this.mainNumber.Text = "2";
            this.mainNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row1
            // 
            this.row1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.row1.FlatAppearance.BorderSize = 0;
            this.row1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.row1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.row1.Location = new System.Drawing.Point(12, 394);
            this.row1.Name = "row1";
            this.row1.Size = new System.Drawing.Size(94, 35);
            this.row1.TabIndex = 1;
            this.row1.Text = "🔺";
            this.row1.UseVisualStyleBackColor = false;
            this.row1.Click += new System.EventHandler(this.mainNumber_Click);
            this.row1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.row1_MouseDown);
            // 
            // row2
            // 
            this.row2.BackColor = System.Drawing.Color.Blue;
            this.row2.FlatAppearance.BorderSize = 0;
            this.row2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.row2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.row2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.row2.Location = new System.Drawing.Point(117, 394);
            this.row2.Name = "row2";
            this.row2.Size = new System.Drawing.Size(94, 35);
            this.row2.TabIndex = 2;
            this.row2.Text = "🔺";
            this.row2.UseVisualStyleBackColor = false;
            this.row2.Click += new System.EventHandler(this.mainNumber_Click);
            this.row2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.row2_MouseDown);
            // 
            // row4
            // 
            this.row4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.row4.FlatAppearance.BorderSize = 0;
            this.row4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.row4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.row4.Location = new System.Drawing.Point(328, 394);
            this.row4.Name = "row4";
            this.row4.Size = new System.Drawing.Size(94, 35);
            this.row4.TabIndex = 4;
            this.row4.Text = "🔺";
            this.row4.UseVisualStyleBackColor = false;
            this.row4.Click += new System.EventHandler(this.mainNumber_Click);
            this.row4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.row4_MouseDown);
            // 
            // row3
            // 
            this.row3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.row3.FlatAppearance.BorderSize = 0;
            this.row3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.row3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.row3.Location = new System.Drawing.Point(222, 394);
            this.row3.Name = "row3";
            this.row3.Size = new System.Drawing.Size(94, 35);
            this.row3.TabIndex = 3;
            this.row3.Text = "🔺";
            this.row3.UseVisualStyleBackColor = false;
            this.row3.Click += new System.EventHandler(this.mainNumber_Click);
            this.row3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.row3_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "0,0,0,0,";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "0,0,0,0,";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "0,0,0,0,";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "0,0,0,0,";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "score:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // scoreLbl
            // 
            this.scoreLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.scoreLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLbl.Location = new System.Drawing.Point(43, 484);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(50, 50);
            this.scoreLbl.TabIndex = 14;
            //همینجاس
            this.scoreLbl.Text = record.ToString();
            //خودشه
            this.scoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "timer:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(226, 640);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(24, 28);
            this.timerLabel.TabIndex = 16;
            this.timerLabel.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "record:";
            // 
            // recordlbl
            // 
            this.recordlbl.AutoSize = true;
            this.recordlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recordlbl.ForeColor = System.Drawing.Color.DimGray;
            this.recordlbl.Location = new System.Drawing.Point(83, 645);
            this.recordlbl.Name = "recordlbl";
            this.recordlbl.Size = new System.Drawing.Size(20, 23);
            this.recordlbl.TabIndex = 18;
            this.recordlbl.Text =record.ToString();
            // 
            // nextNumber
            // 
            this.nextNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nextNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextNumber.Location = new System.Drawing.Point(194, 569);
            this.nextNumber.Name = "nextNumber";
            this.nextNumber.Size = new System.Drawing.Size(49, 49);
            this.nextNumber.TabIndex = 19;
            this.nextNumber.Text = "4";
            this.nextNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 686);
            this.Controls.Add(this.nextNumber);
            this.Controls.Add(this.recordlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.row4);
            this.Controls.Add(this.row3);
            this.Controls.Add(this.row2);
            this.Controls.Add(this.row1);
            this.Controls.Add(this.mainNumber);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erfun Ghodoosi Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mainNumber;
        private Button row1;
        private Button row2;
        private Button row4;
        private Button row3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label scoreLbl;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label timerLabel;
        private Label label2;
        private Label recordlbl;
        private Label nextNumber;
    }
}