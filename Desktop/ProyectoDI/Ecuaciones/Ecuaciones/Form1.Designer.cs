namespace Ecuaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.primer = new System.Windows.Forms.Button();
            this.segundo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primer
            // 
            this.primer.Location = new System.Drawing.Point(13, 13);
            this.primer.Name = "primer";
            this.primer.Size = new System.Drawing.Size(75, 23);
            this.primer.TabIndex = 0;
            this.primer.Text = "ax+b=c";
            this.primer.UseVisualStyleBackColor = true;
            this.primer.Click += new System.EventHandler(this.primer_Click);
            // 
            // segundo
            // 
            this.segundo.Location = new System.Drawing.Point(95, 13);
            this.segundo.Name = "segundo";
            this.segundo.Size = new System.Drawing.Size(93, 23);
            this.segundo.TabIndex = 1;
            this.segundo.Text = "ax^2+bx+c=d";
            this.segundo.UseVisualStyleBackColor = true;
            this.segundo.Click += new System.EventHandler(this.segundo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 51);
            this.Controls.Add(this.segundo);
            this.Controls.Add(this.primer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resolver Ecuaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button primer;
        private System.Windows.Forms.Button segundo;
    }
}

