
namespace AllMath
{
    partial class GraficosForm
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
            this.TxtResultAngulo = new System.Windows.Forms.TextBox();
            this.TxtSumaFrecuencia = new System.Windows.Forms.TextBox();
            this.TxtFrecuencia = new System.Windows.Forms.TextBox();
            this.AnguloBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grafico de pastel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frecuencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Suma de las frecuencias";
            // 
            // TxtResultAngulo
            // 
            this.TxtResultAngulo.Enabled = false;
            this.TxtResultAngulo.Location = new System.Drawing.Point(111, 154);
            this.TxtResultAngulo.Name = "TxtResultAngulo";
            this.TxtResultAngulo.Size = new System.Drawing.Size(57, 23);
            this.TxtResultAngulo.TabIndex = 4;
            // 
            // TxtSumaFrecuencia
            // 
            this.TxtSumaFrecuencia.Location = new System.Drawing.Point(22, 116);
            this.TxtSumaFrecuencia.Name = "TxtSumaFrecuencia";
            this.TxtSumaFrecuencia.Size = new System.Drawing.Size(146, 23);
            this.TxtSumaFrecuencia.TabIndex = 5;
            // 
            // TxtFrecuencia
            // 
            this.TxtFrecuencia.Location = new System.Drawing.Point(22, 67);
            this.TxtFrecuencia.Name = "TxtFrecuencia";
            this.TxtFrecuencia.Size = new System.Drawing.Size(100, 23);
            this.TxtFrecuencia.TabIndex = 6;
            // 
            // AnguloBtn
            // 
            this.AnguloBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnguloBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnguloBtn.Location = new System.Drawing.Point(22, 154);
            this.AnguloBtn.Name = "AnguloBtn";
            this.AnguloBtn.Size = new System.Drawing.Size(79, 23);
            this.AnguloBtn.TabIndex = 7;
            this.AnguloBtn.Text = "ANGULO";
            this.AnguloBtn.UseVisualStyleBackColor = true;
            this.AnguloBtn.Click += new System.EventHandler(this.AnguloBtn_Click);
            // 
            // GraficosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.AnguloBtn);
            this.Controls.Add(this.TxtFrecuencia);
            this.Controls.Add(this.TxtSumaFrecuencia);
            this.Controls.Add(this.TxtResultAngulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraficosForm";
            this.Text = "GraficosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtResultAngulo;
        private System.Windows.Forms.TextBox TxtSumaFrecuencia;
        private System.Windows.Forms.TextBox TxtFrecuencia;
        private System.Windows.Forms.Button AnguloBtn;
    }
}