
namespace Calculator
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttn_plus = new System.Windows.Forms.Button();
            this.bttn_3 = new System.Windows.Forms.Button();
            this.bttn_2 = new System.Windows.Forms.Button();
            this.bttn_1 = new System.Windows.Forms.Button();
            this.bttn_6 = new System.Windows.Forms.Button();
            this.bttn_5 = new System.Windows.Forms.Button();
            this.bttn_4 = new System.Windows.Forms.Button();
            this.bttn_9 = new System.Windows.Forms.Button();
            this.bttn_8 = new System.Windows.Forms.Button();
            this.bttn_7 = new System.Windows.Forms.Button();
            this.bttn_decimal = new System.Windows.Forms.Button();
            this.bttn_division = new System.Windows.Forms.Button();
            this.bttn_x = new System.Windows.Forms.Button();
            this.bttn_0 = new System.Windows.Forms.Button();
            this.bttn_minus = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bttn_clear = new System.Windows.Forms.Button();
            this.bttn_equals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.AccessibleName = "aa";
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(316, 357);
            this.splitContainer1.SplitterDistance = 72;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Elephant", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 90);
            this.textBox1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(316, 281);
            this.splitContainer2.SplitterDistance = 163;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.bttn_plus, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bttn_3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttn_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttn_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttn_6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttn_5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttn_4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttn_9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttn_8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttn_7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttn_decimal, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttn_division, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttn_x, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttn_0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.bttn_minus, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(163, 281);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bttn_plus
            // 
            this.bttn_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_plus.Location = new System.Drawing.Point(3, 227);
            this.bttn_plus.Name = "bttn_plus";
            this.bttn_plus.Size = new System.Drawing.Size(48, 51);
            this.bttn_plus.TabIndex = 28;
            this.bttn_plus.Text = "+";
            this.bttn_plus.UseVisualStyleBackColor = true;
            // 
            // bttn_3
            // 
            this.bttn_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_3.Location = new System.Drawing.Point(111, 171);
            this.bttn_3.Name = "bttn_3";
            this.bttn_3.Size = new System.Drawing.Size(49, 50);
            this.bttn_3.TabIndex = 27;
            this.bttn_3.Text = "3";
            this.bttn_3.UseVisualStyleBackColor = true;
            // 
            // bttn_2
            // 
            this.bttn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_2.Location = new System.Drawing.Point(57, 171);
            this.bttn_2.Name = "bttn_2";
            this.bttn_2.Size = new System.Drawing.Size(48, 50);
            this.bttn_2.TabIndex = 26;
            this.bttn_2.Text = "2";
            this.bttn_2.UseVisualStyleBackColor = true;
            // 
            // bttn_1
            // 
            this.bttn_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_1.Location = new System.Drawing.Point(3, 171);
            this.bttn_1.Name = "bttn_1";
            this.bttn_1.Size = new System.Drawing.Size(48, 50);
            this.bttn_1.TabIndex = 25;
            this.bttn_1.Text = "1";
            this.bttn_1.UseVisualStyleBackColor = true;
            // 
            // bttn_6
            // 
            this.bttn_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_6.Location = new System.Drawing.Point(111, 115);
            this.bttn_6.Name = "bttn_6";
            this.bttn_6.Size = new System.Drawing.Size(49, 50);
            this.bttn_6.TabIndex = 24;
            this.bttn_6.Text = "6";
            this.bttn_6.UseVisualStyleBackColor = true;
            // 
            // bttn_5
            // 
            this.bttn_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_5.Location = new System.Drawing.Point(57, 115);
            this.bttn_5.Name = "bttn_5";
            this.bttn_5.Size = new System.Drawing.Size(48, 50);
            this.bttn_5.TabIndex = 23;
            this.bttn_5.Text = "5";
            this.bttn_5.UseVisualStyleBackColor = true;
            // 
            // bttn_4
            // 
            this.bttn_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_4.Location = new System.Drawing.Point(3, 115);
            this.bttn_4.Name = "bttn_4";
            this.bttn_4.Size = new System.Drawing.Size(48, 50);
            this.bttn_4.TabIndex = 22;
            this.bttn_4.Text = "4";
            this.bttn_4.UseVisualStyleBackColor = true;
            // 
            // bttn_9
            // 
            this.bttn_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_9.Location = new System.Drawing.Point(111, 59);
            this.bttn_9.Name = "bttn_9";
            this.bttn_9.Size = new System.Drawing.Size(49, 50);
            this.bttn_9.TabIndex = 21;
            this.bttn_9.Text = "9";
            this.bttn_9.UseVisualStyleBackColor = true;
            // 
            // bttn_8
            // 
            this.bttn_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_8.Location = new System.Drawing.Point(57, 59);
            this.bttn_8.Name = "bttn_8";
            this.bttn_8.Size = new System.Drawing.Size(48, 50);
            this.bttn_8.TabIndex = 20;
            this.bttn_8.Text = "8";
            this.bttn_8.UseVisualStyleBackColor = true;
            // 
            // bttn_7
            // 
            this.bttn_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_7.Location = new System.Drawing.Point(3, 59);
            this.bttn_7.Name = "bttn_7";
            this.bttn_7.Size = new System.Drawing.Size(48, 50);
            this.bttn_7.TabIndex = 19;
            this.bttn_7.Text = "7";
            this.bttn_7.UseVisualStyleBackColor = true;
            // 
            // bttn_decimal
            // 
            this.bttn_decimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_decimal.Location = new System.Drawing.Point(111, 3);
            this.bttn_decimal.Name = "bttn_decimal";
            this.bttn_decimal.Size = new System.Drawing.Size(49, 50);
            this.bttn_decimal.TabIndex = 18;
            this.bttn_decimal.Text = ".";
            this.bttn_decimal.UseVisualStyleBackColor = true;
            // 
            // bttn_division
            // 
            this.bttn_division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_division.Location = new System.Drawing.Point(57, 3);
            this.bttn_division.Name = "bttn_division";
            this.bttn_division.Size = new System.Drawing.Size(48, 50);
            this.bttn_division.TabIndex = 17;
            this.bttn_division.Text = "/";
            this.bttn_division.UseVisualStyleBackColor = true;
            // 
            // bttn_x
            // 
            this.bttn_x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_x.Location = new System.Drawing.Point(3, 3);
            this.bttn_x.Name = "bttn_x";
            this.bttn_x.Size = new System.Drawing.Size(48, 50);
            this.bttn_x.TabIndex = 16;
            this.bttn_x.Text = "X";
            this.bttn_x.UseVisualStyleBackColor = true;
            // 
            // bttn_0
            // 
            this.bttn_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_0.Location = new System.Drawing.Point(57, 227);
            this.bttn_0.Name = "bttn_0";
            this.bttn_0.Size = new System.Drawing.Size(48, 51);
            this.bttn_0.TabIndex = 15;
            this.bttn_0.Text = "0";
            this.bttn_0.UseVisualStyleBackColor = true;
            // 
            // bttn_minus
            // 
            this.bttn_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_minus.Location = new System.Drawing.Point(111, 227);
            this.bttn_minus.Name = "bttn_minus";
            this.bttn_minus.Size = new System.Drawing.Size(49, 51);
            this.bttn_minus.TabIndex = 14;
            this.bttn_minus.Text = "-";
            this.bttn_minus.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer3.Size = new System.Drawing.Size(149, 281);
            this.splitContainer3.SplitterDistance = 59;
            this.splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bttn_clear, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bttn_equals, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.14493F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.85507F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(59, 281);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // bttn_clear
            // 
            this.bttn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_clear.Location = new System.Drawing.Point(3, 3);
            this.bttn_clear.Name = "bttn_clear";
            this.bttn_clear.Size = new System.Drawing.Size(53, 78);
            this.bttn_clear.TabIndex = 0;
            this.bttn_clear.Text = "C";
            this.bttn_clear.UseVisualStyleBackColor = true;
            // 
            // bttn_equals
            // 
            this.bttn_equals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_equals.Location = new System.Drawing.Point(3, 87);
            this.bttn_equals.Name = "bttn_equals";
            this.bttn_equals.Size = new System.Drawing.Size(53, 191);
            this.bttn_equals.TabIndex = 1;
            this.bttn_equals.Text = "=";
            this.bttn_equals.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 357);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bttn_minus;
        private System.Windows.Forms.Button bttn_plus;
        private System.Windows.Forms.Button bttn_3;
        private System.Windows.Forms.Button bttn_2;
        private System.Windows.Forms.Button bttn_1;
        private System.Windows.Forms.Button bttn_6;
        private System.Windows.Forms.Button bttn_5;
        private System.Windows.Forms.Button bttn_4;
        private System.Windows.Forms.Button bttn_9;
        private System.Windows.Forms.Button bttn_8;
        private System.Windows.Forms.Button bttn_7;
        private System.Windows.Forms.Button bttn_decimal;
        private System.Windows.Forms.Button bttn_division;
        private System.Windows.Forms.Button bttn_x;
        private System.Windows.Forms.Button bttn_0;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bttn_clear;
        private System.Windows.Forms.Button bttn_equals;
        private System.Windows.Forms.TextBox textBox1;
    }
}

