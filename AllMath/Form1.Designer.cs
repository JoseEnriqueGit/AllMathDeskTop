
namespace AllMath
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFrecuencia = new System.Windows.Forms.TextBox();
            this.TxtTotalFrecuencia = new System.Windows.Forms.TextBox();
            this.BtTotalAngulo = new System.Windows.Forms.Button();
            this.TxtTotalAngulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANGULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "FRECUENCIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL DE LA FRECUENCIA";
            // 
            // TxtFrecuencia
            // 
            this.TxtFrecuencia.Location = new System.Drawing.Point(94, 66);
            this.TxtFrecuencia.Name = "TxtFrecuencia";
            this.TxtFrecuencia.Size = new System.Drawing.Size(100, 23);
            this.TxtFrecuencia.TabIndex = 3;
            // 
            // TxtTotalFrecuencia
            // 
            this.TxtTotalFrecuencia.Location = new System.Drawing.Point(169, 102);
            this.TxtTotalFrecuencia.Name = "TxtTotalFrecuencia";
            this.TxtTotalFrecuencia.Size = new System.Drawing.Size(100, 23);
            this.TxtTotalFrecuencia.TabIndex = 4;
            // 
            // BtTotalAngulo
            // 
            this.BtTotalAngulo.Location = new System.Drawing.Point(13, 134);
            this.BtTotalAngulo.Name = "BtTotalAngulo";
            this.BtTotalAngulo.Size = new System.Drawing.Size(256, 23);
            this.BtTotalAngulo.TabIndex = 5;
            this.BtTotalAngulo.Text = "=";
            this.BtTotalAngulo.UseVisualStyleBackColor = true;
            this.BtTotalAngulo.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtTotalAngulo
            // 
            this.TxtTotalAngulo.Enabled = false;
            this.TxtTotalAngulo.Location = new System.Drawing.Point(94, 23);
            this.TxtTotalAngulo.Name = "TxtTotalAngulo";
            this.TxtTotalAngulo.Size = new System.Drawing.Size(100, 23);
            this.TxtTotalAngulo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 161);
            this.Controls.Add(this.TxtTotalAngulo);
            this.Controls.Add(this.BtTotalAngulo);
            this.Controls.Add(this.TxtTotalFrecuencia);
            this.Controls.Add(this.TxtFrecuencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(290, 200);
            this.MinimumSize = new System.Drawing.Size(290, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllMath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFrecuencia;
        private System.Windows.Forms.TextBox TxtTotalFrecuencia;
        private System.Windows.Forms.Button BtTotalAngulo;
        private System.Windows.Forms.TextBox TxtTotalAngulo;
    }
}

