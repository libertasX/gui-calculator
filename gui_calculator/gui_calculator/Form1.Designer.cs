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
            this.Text_Box_Ergebnis = new System.Windows.Forms.TextBox();
            this.RB_Addition = new System.Windows.Forms.RadioButton();
            this.RB_Subtraktion = new System.Windows.Forms.RadioButton();
            this.RB_Multiplikation = new System.Windows.Forms.RadioButton();
            this.RB_Division = new System.Windows.Forms.RadioButton();
            this.Cmd_Berechnen = new System.Windows.Forms.Button();
            this.Cmd_Clean = new System.Windows.Forms.Button();
            this.Cmd_Beenden = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_Box_1
            // 
            this.Text_Box_1.Location = new System.Drawing.Point(72, 54);
            this.Text_Box_1.Name = "Text_Box_1";
            this.Text_Box_1.Size = new System.Drawing.Size(100, 20);
            this.Text_Box_1.TabIndex = 0;
            // 
            // Text_Box_2
            // 
            this.Text_Box_2.Location = new System.Drawing.Point(72, 80);
            this.Text_Box_2.Name = "Text_Box_2";
            this.Text_Box_2.Size = new System.Drawing.Size(100, 20);
            this.Text_Box_2.TabIndex = 1;
            // 
            // Text_Box_Ergebnis
            // 
            this.Text_Box_Ergebnis.Location = new System.Drawing.Point(56, 189);
            this.Text_Box_Ergebnis.Multiline = true;
            this.Text_Box_Ergebnis.Name = "Text_Box_Ergebnis";
            this.Text_Box_Ergebnis.Size = new System.Drawing.Size(116, 32);
            this.Text_Box_Ergebnis.TabIndex = 2;
            // 
            // RB_Addition
            // 
            this.RB_Addition.AutoSize = true;
            this.RB_Addition.Location = new System.Drawing.Point(263, 54);
            this.RB_Addition.Name = "RB_Addition";
            this.RB_Addition.Size = new System.Drawing.Size(63, 17);
            this.RB_Addition.TabIndex = 4;
            this.RB_Addition.TabStop = true;
            this.RB_Addition.Text = "Addition";
            this.RB_Addition.UseVisualStyleBackColor = true;
            // 
            // RB_Subtraktion
            // 
            this.RB_Subtraktion.AutoSize = true;
            this.RB_Subtraktion.Location = new System.Drawing.Point(263, 77);
            this.RB_Subtraktion.Name = "RB_Subtraktion";
            this.RB_Subtraktion.Size = new System.Drawing.Size(79, 17);
            this.RB_Subtraktion.TabIndex = 5;
            this.RB_Subtraktion.TabStop = true;
            this.RB_Subtraktion.Text = "Subtraktion";
            this.RB_Subtraktion.UseVisualStyleBackColor = true;
            // 
            // RB_Multiplikation
            // 
            this.RB_Multiplikation.AutoSize = true;
            this.RB_Multiplikation.Location = new System.Drawing.Point(263, 100);
            this.RB_Multiplikation.Name = "RB_Multiplikation";
            this.RB_Multiplikation.Size = new System.Drawing.Size(86, 17);
            this.RB_Multiplikation.TabIndex = 6;
            this.RB_Multiplikation.TabStop = true;
            this.RB_Multiplikation.Text = "Multiplikation";
            this.RB_Multiplikation.UseVisualStyleBackColor = true;
            // 
            // RB_Division
            // 
            this.RB_Division.AutoSize = true;
            this.RB_Division.Location = new System.Drawing.Point(263, 123);
            this.RB_Division.Name = "RB_Division";
            this.RB_Division.Size = new System.Drawing.Size(62, 17);
            this.RB_Division.TabIndex = 7;
            this.RB_Division.TabStop = true;
            this.RB_Division.Text = "Division";
            this.RB_Division.UseVisualStyleBackColor = true;
            // 
            // Cmd_Berechnen
            // 
            this.Cmd_Berechnen.Location = new System.Drawing.Point(440, 48);
            this.Cmd_Berechnen.Name = "Cmd_Berechnen";
            this.Cmd_Berechnen.Size = new System.Drawing.Size(75, 26);
            this.Cmd_Berechnen.TabIndex = 8;
            this.Cmd_Berechnen.Text = "Berechnen";
            this.Cmd_Berechnen.UseVisualStyleBackColor = true;
            this.Cmd_Berechnen.Click += new System.EventHandler(this.Cmd_Berechnen_Click);
            // 
            // Cmd_Clean
            // 
            this.Cmd_Clean.Location = new System.Drawing.Point(440, 94);
            this.Cmd_Clean.Name = "Cmd_Clean";
            this.Cmd_Clean.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Clean.TabIndex = 9;
            this.Cmd_Clean.Text = "Clean";
            this.Cmd_Clean.UseVisualStyleBackColor = true;
            this.Cmd_Clean.Click += new System.EventHandler(this.Cmd_Clean_Click);
            // 
            // Cmd_Beenden
            // 
            this.Cmd_Beenden.Location = new System.Drawing.Point(440, 146);
            this.Cmd_Beenden.Name = "Cmd_Beenden";
            this.Cmd_Beenden.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Beenden.TabIndex = 10;
            this.Cmd_Beenden.Text = "Beenden";
            this.Cmd_Beenden.UseVisualStyleBackColor = true;
            this.Cmd_Beenden.Click += new System.EventHandler(this.Cmd_Beenden_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cmd_Beenden);
            this.Controls.Add(this.Cmd_Clean);
            this.Controls.Add(this.Cmd_Berechnen);
            this.Controls.Add(this.RB_Division);
            this.Controls.Add(this.RB_Multiplikation);
            this.Controls.Add(this.RB_Subtraktion);
            this.Controls.Add(this.RB_Addition);
            this.Controls.Add(this.Text_Box_Ergebnis);
            this.Controls.Add(this.Text_Box_2);
            this.Controls.Add(this.Text_Box_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Box_1;
        private System.Windows.Forms.TextBox Text_Box_2;
        private System.Windows.Forms.TextBox Text_Box_Ergebnis;
        private System.Windows.Forms.RadioButton RB_Addition;
        private System.Windows.Forms.RadioButton RB_Subtraktion;
        private System.Windows.Forms.RadioButton RB_Multiplikation;
        private System.Windows.Forms.RadioButton RB_Division;
        private System.Windows.Forms.Button Cmd_Berechnen;
        private System.Windows.Forms.Button Cmd_Clean;
        private System.Windows.Forms.Button Cmd_Beenden;
        private System.Windows.Forms.Button button1;
    }
}

