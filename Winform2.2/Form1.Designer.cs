namespace Winform2._2
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
            this.resultLbl = new System.Windows.Forms.Label();
            this.firstValue = new System.Windows.Forms.Button();
            this.secondValue = new System.Windows.Forms.Button();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.divison = new System.Windows.Forms.Button();
            this.rresultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.ForeColor = System.Drawing.Color.Black;
            this.resultLbl.Location = new System.Drawing.Point(186, 261);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(72, 25);
            this.resultLbl.TabIndex = 9;
            this.resultLbl.Text = "Result";
            // 
            // firstValue
            // 
            this.firstValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstValue.Location = new System.Drawing.Point(155, 31);
            this.firstValue.Name = "firstValue";
            this.firstValue.Size = new System.Drawing.Size(141, 44);
            this.firstValue.TabIndex = 10;
            this.firstValue.Text = "First value";
            this.firstValue.UseVisualStyleBackColor = true;
            // 
            // secondValue
            // 
            this.secondValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondValue.Location = new System.Drawing.Point(155, 146);
            this.secondValue.Name = "secondValue";
            this.secondValue.Size = new System.Drawing.Size(158, 40);
            this.secondValue.TabIndex = 11;
            this.secondValue.Text = "Second value";
            this.secondValue.UseVisualStyleBackColor = true;
            // 
            // firstTextBox
            // 
            this.firstTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(51)))));
            this.firstTextBox.Location = new System.Drawing.Point(377, 31);
            this.firstTextBox.Multiline = true;
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(301, 44);
            this.firstTextBox.TabIndex = 12;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTextBox.Location = new System.Drawing.Point(376, 146);
            this.secondTextBox.Multiline = true;
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(302, 40);
            this.secondTextBox.TabIndex = 13;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(99, 348);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 43);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(285, 348);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(115, 43);
            this.subtract.TabIndex = 16;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.Location = new System.Drawing.Point(471, 348);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(115, 43);
            this.multiplication.TabIndex = 17;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // divison
            // 
            this.divison.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divison.Location = new System.Drawing.Point(633, 348);
            this.divison.Name = "divison";
            this.divison.Size = new System.Drawing.Size(118, 43);
            this.divison.TabIndex = 18;
            this.divison.Text = "/";
            this.divison.UseVisualStyleBackColor = true;
            this.divison.Click += new System.EventHandler(this.divison_Click);
            // 
            // rresultLbl
            // 
            this.rresultLbl.AutoSize = true;
            this.rresultLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rresultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rresultLbl.ForeColor = System.Drawing.Color.Black;
            this.rresultLbl.Location = new System.Drawing.Point(373, 261);
            this.rresultLbl.Name = "rresultLbl";
            this.rresultLbl.Size = new System.Drawing.Size(54, 25);
            this.rresultLbl.TabIndex = 19;
            this.rresultLbl.Text = "       ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rresultLbl);
            this.Controls.Add(this.divison);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.secondValue);
            this.Controls.Add(this.firstValue);
            this.Controls.Add(this.resultLbl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button firstValue;
        private System.Windows.Forms.Button secondValue;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button divison;
        private System.Windows.Forms.Label rresultLbl;
    }
}

