namespace BMI_Calculator
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
            this.Reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextResult = new System.Windows.Forms.TextBox();
            this.Calculator = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Firebrick;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Reset.Location = new System.Drawing.Point(143, 219);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(134, 53);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.WeightBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HeightBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TextResult, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Calculator, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Reset, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 437);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(143, 147);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(100, 46);
            this.WeightBox.TabIndex = 6;
            this.WeightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 72);
            this.label2.TabIndex = 5;
            this.label2.Text = "My Height";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(143, 75);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(100, 46);
            this.HeightBox.TabIndex = 4;
            this.HeightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightBox_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 2);
            this.textBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.textBox1.Location = new System.Drawing.Point(3, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 46);
            this.textBox1.TabIndex = 7;
            // 
            // TextResult
            // 
            this.TextResult.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.SetColumnSpan(this.TextResult, 2);
            this.TextResult.ForeColor = System.Drawing.Color.Maroon;
            this.TextResult.Location = new System.Drawing.Point(3, 363);
            this.TextResult.Multiline = true;
            this.TextResult.Name = "TextResult";
            this.TextResult.Size = new System.Drawing.Size(274, 47);
            this.TextResult.TabIndex = 9;
            
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.Color.Firebrick;
            this.Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Calculator.Location = new System.Drawing.Point(3, 219);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(134, 53);
            this.Calculator.TabIndex = 8;
            this.Calculator.Text = "Calculate BMI";
            this.Calculator.UseVisualStyleBackColor = false;
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 72);
            this.label3.TabIndex = 10;
            this.label3.Text = "My Weight";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(143, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(134, 43);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Metric Units";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 43);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Imperial";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(319, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextResult;
        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.Label label3;
    }
}

