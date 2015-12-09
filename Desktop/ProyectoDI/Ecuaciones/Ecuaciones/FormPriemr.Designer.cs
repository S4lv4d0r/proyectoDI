namespace Ecuaciones
{
    partial class FormPriemr
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textoNumerico3 = new Ecuaciones.TextoNumerico();
            this.textoNumerico2 = new Ecuaciones.TextoNumerico();
            this.textoNumerico1 = new Ecuaciones.TextoNumerico();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ecuaciones de primer grado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Resolver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoNumerico3
            // 
            this.textoNumerico3.Location = new System.Drawing.Point(92, 131);
            this.textoNumerico3.Name = "textoNumerico3";
            this.textoNumerico3.Size = new System.Drawing.Size(100, 20);
            this.textoNumerico3.TabIndex = 3;
            this.textoNumerico3.TextChanged += new System.EventHandler(this.textoNumerico3_TextChanged);
            // 
            // textoNumerico2
            // 
            this.textoNumerico2.Location = new System.Drawing.Point(92, 89);
            this.textoNumerico2.Name = "textoNumerico2";
            this.textoNumerico2.Size = new System.Drawing.Size(100, 20);
            this.textoNumerico2.TabIndex = 2;
            this.textoNumerico2.TextChanged += new System.EventHandler(this.textoNumerico2_TextChanged);
            // 
            // textoNumerico1
            // 
            this.textoNumerico1.Location = new System.Drawing.Point(92, 45);
            this.textoNumerico1.Name = "textoNumerico1";
            this.textoNumerico1.Size = new System.Drawing.Size(100, 20);
            this.textoNumerico1.TabIndex = 1;
            this.textoNumerico1.TextChanged += new System.EventHandler(this.textoNumerico1_TextChanged);
            // 
            // FormPriemr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoNumerico3);
            this.Controls.Add(this.textoNumerico2);
            this.Controls.Add(this.textoNumerico1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPriemr";
            this.Text = "FormPriemr";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPriemr_FormClosed);
            this.Load += new System.EventHandler(this.FormPriemr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TextoNumerico textoNumerico1;
        private TextoNumerico textoNumerico2;
        private TextoNumerico textoNumerico3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}