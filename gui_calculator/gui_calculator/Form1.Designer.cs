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
            this.Text_Box_1 = new System.Windows.Forms.TextBox();
            this.Text_Box_2 = new System.Windows.Forms.TextBox();
            this.RB_Addition = new System.Windows.Forms.RadioButton();
            this.RB_Subtraktion = new System.Windows.Forms.RadioButton();
            this.RB_Multiplikation = new System.Windows.Forms.RadioButton();
            this.RB_Division = new System.Windows.Forms.RadioButton();
            this.Cmd_Berechnen = new System.Windows.Forms.Button();
            this.Cmd_Clean = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.Label_Ergebnis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text_Box_1
            // 
            this.Text_Box_1.Location = new System.Drawing.Point(96, 66);
            this.Text_Box_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Box_1.Name = "Text_Box_1";
            this.Text_Box_1.Size = new System.Drawing.Size(132, 22);
            this.Text_Box_1.TabIndex = 0;
            // 
            // Text_Box_2
            // 
            this.Text_Box_2.Location = new System.Drawing.Point(96, 98);
            this.Text_Box_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Box_2.Name = "Text_Box_2";
            this.Text_Box_2.Size = new System.Drawing.Size(132, 22);
            this.Text_Box_2.TabIndex = 1;
            // 
            // RB_Addition
            // 
            this.RB_Addition.AutoSize = true;
            this.RB_Addition.Location = new System.Drawing.Point(351, 66);
            this.RB_Addition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB_Addition.Name = "RB_Addition";
            this.RB_Addition.Size = new System.Drawing.Size(80, 21);
            this.RB_Addition.TabIndex = 4;
            this.RB_Addition.TabStop = true;
            this.RB_Addition.Text = "Addition";
            this.RB_Addition.UseVisualStyleBackColor = true;
            // 
            // RB_Subtraktion
            // 
            this.RB_Subtraktion.AutoSize = true;
            this.RB_Subtraktion.Location = new System.Drawing.Point(351, 95);
            this.RB_Subtraktion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB_Subtraktion.Name = "RB_Subtraktion";
            this.RB_Subtraktion.Size = new System.Drawing.Size(101, 21);
            this.RB_Subtraktion.TabIndex = 5;
            this.RB_Subtraktion.TabStop = true;
            this.RB_Subtraktion.Text = "Subtraktion";
            this.RB_Subtraktion.UseVisualStyleBackColor = true;
            // 
            // RB_Multiplikation
            // 
            this.RB_Multiplikation.AutoSize = true;
            this.RB_Multiplikation.Location = new System.Drawing.Point(351, 123);
            this.RB_Multiplikation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB_Multiplikation.Name = "RB_Multiplikation";
            this.RB_Multiplikation.Size = new System.Drawing.Size(110, 21);
            this.RB_Multiplikation.TabIndex = 6;
            this.RB_Multiplikation.TabStop = true;
            this.RB_Multiplikation.Text = "Multiplikation";
            this.RB_Multiplikation.UseVisualStyleBackColor = true;
            // 
            // RB_Division
            // 
            this.RB_Division.AutoSize = true;
            this.RB_Division.Location = new System.Drawing.Point(351, 151);
            this.RB_Division.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB_Division.Name = "RB_Division";
            this.RB_Division.Size = new System.Drawing.Size(78, 21);
            this.RB_Division.TabIndex = 7;
            this.RB_Division.TabStop = true;
            this.RB_Division.Text = "Division";
            this.RB_Division.UseVisualStyleBackColor = true;
            // 
            // Cmd_Berechnen
            // 
            this.Cmd_Berechnen.Location = new System.Drawing.Point(587, 59);
            this.Cmd_Berechnen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmd_Berechnen.Name = "Cmd_Berechnen";
            this.Cmd_Berechnen.Size = new System.Drawing.Size(100, 32);
            this.Cmd_Berechnen.TabIndex = 8;
            this.Cmd_Berechnen.Text = "Berechnen";
            this.Cmd_Berechnen.UseVisualStyleBackColor = true;
            this.Cmd_Berechnen.Click += new System.EventHandler(this.Cmd_Berechnen_Click);
            // 
            // Cmd_Clean
            // 
            this.Cmd_Clean.Location = new System.Drawing.Point(587, 116);
            this.Cmd_Clean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmd_Clean.Name = "Cmd_Clean";
            this.Cmd_Clean.Size = new System.Drawing.Size(100, 28);
            this.Cmd_Clean.TabIndex = 9;
            this.Cmd_Clean.Text = "Clean";
            this.Cmd_Clean.UseVisualStyleBackColor = true;
            this.Cmd_Clean.Click += new System.EventHandler(this.Cmd_Clean_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(96, 203);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 17);
            this.Label.TabIndex = 11;
            // 
            // Label_Ergebnis
            // 
            this.Label_Ergebnis.AutoSize = true;
            this.Label_Ergebnis.Location = new System.Drawing.Point(96, 203);
            this.Label_Ergebnis.Name = "Label_Ergebnis";
            this.Label_Ergebnis.Size = new System.Drawing.Size(0, 17);
            this.Label_Ergebnis.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 345);
            this.Controls.Add(this.Label_Ergebnis);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Cmd_Clean);
            this.Controls.Add(this.Cmd_Berechnen);
            this.Controls.Add(this.RB_Division);
            this.Controls.Add(this.RB_Multiplikation);
            this.Controls.Add(this.RB_Subtraktion);
            this.Controls.Add(this.RB_Addition);
            this.Controls.Add(this.Text_Box_2);
            this.Controls.Add(this.Text_Box_1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Box_1;
        private System.Windows.Forms.TextBox Text_Box_2;
        private System.Windows.Forms.RadioButton RB_Addition;
        private System.Windows.Forms.RadioButton RB_Subtraktion;
        private System.Windows.Forms.RadioButton RB_Multiplikation;
        private System.Windows.Forms.RadioButton RB_Division;
        private System.Windows.Forms.Button Cmd_Berechnen;
        private System.Windows.Forms.Button Cmd_Clean;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Label_Ergebnis;
    }
}

