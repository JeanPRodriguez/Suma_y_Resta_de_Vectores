namespace Interfaz
{
    partial class Interfaz
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_S = new System.Windows.Forms.Button();
            this.Btn_R = new System.Windows.Forms.Button();
            this.Btn_M = new System.Windows.Forms.Button();
            this.Btn_D = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_S
            // 
            this.Btn_S.Location = new System.Drawing.Point(71, 88);
            this.Btn_S.Name = "Btn_S";
            this.Btn_S.Size = new System.Drawing.Size(75, 23);
            this.Btn_S.TabIndex = 0;
            this.Btn_S.Text = "Sumar";
            this.Btn_S.UseVisualStyleBackColor = true;
            this.Btn_S.Click += new System.EventHandler(this.Btn_S_Click);
            // 
            // Btn_R
            // 
            this.Btn_R.Location = new System.Drawing.Point(256, 88);
            this.Btn_R.Name = "Btn_R";
            this.Btn_R.Size = new System.Drawing.Size(75, 23);
            this.Btn_R.TabIndex = 1;
            this.Btn_R.Text = "Restar";
            this.Btn_R.UseVisualStyleBackColor = true;
            this.Btn_R.Click += new System.EventHandler(this.Btn_R_Click);
            // 
            // Btn_M
            // 
            this.Btn_M.Location = new System.Drawing.Point(62, 230);
            this.Btn_M.Name = "Btn_M";
            this.Btn_M.Size = new System.Drawing.Size(75, 22);
            this.Btn_M.TabIndex = 3;
            this.Btn_M.Text = "Multiplicar";
            this.Btn_M.UseVisualStyleBackColor = true;
            this.Btn_M.Click += new System.EventHandler(this.Btn_M_Click);
            // 
            // Btn_D
            // 
            this.Btn_D.Location = new System.Drawing.Point(243, 230);
            this.Btn_D.Name = "Btn_D";
            this.Btn_D.Size = new System.Drawing.Size(75, 22);
            this.Btn_D.TabIndex = 2;
            this.Btn_D.Text = "Dividir";
            this.Btn_D.UseVisualStyleBackColor = true;
            this.Btn_D.Click += new System.EventHandler(this.Btn_D_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "https://www.aulafacil.com/cursos/programacion/en-c/ejercicio-final-baraja-de-cart" +
    "as-l23548";
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_M);
            this.Controls.Add(this.Btn_D);
            this.Controls.Add(this.Btn_R);
            this.Controls.Add(this.Btn_S);
            this.Name = "Interfaz";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_S;
        private System.Windows.Forms.Button Btn_R;
        private System.Windows.Forms.Button Btn_M;
        private System.Windows.Forms.Button Btn_D;
        private System.Windows.Forms.Label label1;
    }
}

