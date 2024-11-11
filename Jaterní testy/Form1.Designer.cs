namespace Jaterní_testy
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.poleALT = new System.Windows.Forms.TextBox();
            this.poleAST = new System.Windows.Forms.TextBox();
            this.poleBilirubin = new System.Windows.Forms.TextBox();
            this.tlacitkoVyhodnot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AST:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bilirubin:";
            // 
            // poleALT
            // 
            this.poleALT.Location = new System.Drawing.Point(74, 21);
            this.poleALT.Name = "poleALT";
            this.poleALT.Size = new System.Drawing.Size(100, 20);
            this.poleALT.TabIndex = 3;
            this.poleALT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleAST
            // 
            this.poleAST.Location = new System.Drawing.Point(74, 52);
            this.poleAST.Name = "poleAST";
            this.poleAST.Size = new System.Drawing.Size(100, 20);
            this.poleAST.TabIndex = 4;
            this.poleAST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleBilirubin
            // 
            this.poleBilirubin.Location = new System.Drawing.Point(74, 81);
            this.poleBilirubin.Name = "poleBilirubin";
            this.poleBilirubin.Size = new System.Drawing.Size(100, 20);
            this.poleBilirubin.TabIndex = 5;
            this.poleBilirubin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tlacitkoVyhodnot
            // 
            this.tlacitkoVyhodnot.Location = new System.Drawing.Point(25, 118);
            this.tlacitkoVyhodnot.Name = "tlacitkoVyhodnot";
            this.tlacitkoVyhodnot.Size = new System.Drawing.Size(149, 23);
            this.tlacitkoVyhodnot.TabIndex = 6;
            this.tlacitkoVyhodnot.TabStop = false;
            this.tlacitkoVyhodnot.Text = "Vyhodnoť";
            this.tlacitkoVyhodnot.UseVisualStyleBackColor = true;
            this.tlacitkoVyhodnot.Click += new System.EventHandler(this.tlacitkoVyhodnot_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.tlacitkoVyhodnot;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 154);
            this.Controls.Add(this.tlacitkoVyhodnot);
            this.Controls.Add(this.poleBilirubin);
            this.Controls.Add(this.poleAST);
            this.Controls.Add(this.poleALT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Jaterní testy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poleALT;
        private System.Windows.Forms.TextBox poleAST;
        private System.Windows.Forms.TextBox poleBilirubin;
        private System.Windows.Forms.Button tlacitkoVyhodnot;
    }
}

