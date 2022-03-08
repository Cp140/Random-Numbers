namespace Random_Numbers
{
    partial class form
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lblMinuimum = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(323, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter a maximum and minimun value";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(111, 73);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(224, 23);
            this.txtMin.TabIndex = 1;
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(204, 112);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(113, 32);
            this.btnInt.TabIndex = 2;
            this.btnInt.Text = "Get Intiger";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(28, 112);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(113, 32);
            this.btnDouble.TabIndex = 3;
            this.btnDouble.Text = "Get Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // lblMinuimum
            // 
            this.lblMinuimum.AutoSize = true;
            this.lblMinuimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuimum.Location = new System.Drawing.Point(12, 72);
            this.lblMinuimum.Name = "lblMinuimum";
            this.lblMinuimum.Size = new System.Drawing.Size(88, 24);
            this.lblMinuimum.TabIndex = 4;
            this.lblMinuimum.Text = "Minimum";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(12, 34);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(93, 24);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "Maximum";
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(111, 36);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(224, 23);
            this.txtMax.TabIndex = 6;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(12, 158);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(283, 24);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Numbers Example, 1.638368928";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 202);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMinuimum);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblTitle);
            this.Name = "form";
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lblMinuimum;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblOutput;
    }
}

