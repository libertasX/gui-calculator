namespace gui_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.radioButtonAdditon = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtraction = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiplication = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_1
            // 
            this.textBox_1.Location = new System.Drawing.Point(29, 48);
            this.textBox_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(65, 22);
            this.textBox_1.TabIndex = 0;
            // 
            // textBox_2
            // 
            this.textBox_2.Location = new System.Drawing.Point(29, 95);
            this.textBox_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.Size = new System.Drawing.Size(65, 22);
            this.textBox_2.TabIndex = 1;
            // 
            // radioButtonAdditon
            // 
            this.radioButtonAdditon.AutoSize = true;
            this.radioButtonAdditon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdditon.Location = new System.Drawing.Point(319, 48);
            this.radioButtonAdditon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAdditon.Name = "radioButtonAdditon";
            this.radioButtonAdditon.Size = new System.Drawing.Size(84, 22);
            this.radioButtonAdditon.TabIndex = 4;
            this.radioButtonAdditon.TabStop = true;
            this.radioButtonAdditon.Text = "Addition";
            this.radioButtonAdditon.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtraction
            // 
            this.radioButtonSubtraction.AutoSize = true;
            this.radioButtonSubtraction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSubtraction.Location = new System.Drawing.Point(480, 46);
            this.radioButtonSubtraction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSubtraction.Name = "radioButtonSubtraction";
            this.radioButtonSubtraction.Size = new System.Drawing.Size(105, 22);
            this.radioButtonSubtraction.TabIndex = 5;
            this.radioButtonSubtraction.TabStop = true;
            this.radioButtonSubtraction.Text = "Subtraktion";
            this.radioButtonSubtraction.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiplication
            // 
            this.radioButtonMultiplication.AutoSize = true;
            this.radioButtonMultiplication.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMultiplication.Location = new System.Drawing.Point(319, 76);
            this.radioButtonMultiplication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMultiplication.Name = "radioButtonMultiplication";
            this.radioButtonMultiplication.Size = new System.Drawing.Size(116, 22);
            this.radioButtonMultiplication.TabIndex = 6;
            this.radioButtonMultiplication.TabStop = true;
            this.radioButtonMultiplication.Text = "Multiplikation";
            this.radioButtonMultiplication.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDivision.Location = new System.Drawing.Point(480, 76);
            this.radioButtonDivision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(82, 22);
            this.radioButtonDivision.TabIndex = 7;
            this.radioButtonDivision.TabStop = true;
            this.radioButtonDivision.Text = "Division";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Arial", 11.25F);
            this.buttonCalculate.Location = new System.Drawing.Point(319, 127);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(116, 32);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Berechnen";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.CalculateClick);
            // 
            // buttonClean
            // 
            this.buttonClean.Font = new System.Drawing.Font("Arial", 11F);
            this.buttonClean.Location = new System.Drawing.Point(480, 127);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(100, 32);
            this.buttonClean.TabIndex = 9;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.CleanClick);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(111, 203);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 16);
            this.Label.TabIndex = 11;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.Control;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(24, 146);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 25);
            this.labelResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 324);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.radioButtonDivision);
            this.Controls.Add(this.radioButtonMultiplication);
            this.Controls.Add(this.radioButtonSubtraction);
            this.Controls.Add(this.radioButtonAdditon);
            this.Controls.Add(this.textBox_2);
            this.Controls.Add(this.textBox_1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.TextBox textBox_2;
        private System.Windows.Forms.RadioButton radioButtonAdditon;
        private System.Windows.Forms.RadioButton radioButtonSubtraction;
        private System.Windows.Forms.RadioButton radioButtonMultiplication;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label labelResult;
    }
}

