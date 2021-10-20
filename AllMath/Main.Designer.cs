
namespace AllMath
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SubjectPanel = new System.Windows.Forms.Panel();
            this.SubPanelStatistics = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.GraficaBtn = new System.Windows.Forms.Button();
            this.StatisticsBtn = new FontAwesome.Sharp.IconButton();
            this.SubPanelPhysical = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PhysicalBtn = new FontAwesome.Sharp.IconButton();
            this.SubPanelMath = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MathBtn = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubjectPanel.SuspendLayout();
            this.SubPanelStatistics.SuspendLayout();
            this.SubPanelPhysical.SuspendLayout();
            this.SubPanelMath.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectPanel
            // 
            this.SubjectPanel.AutoScroll = true;
            this.SubjectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.SubjectPanel.Controls.Add(this.SubPanelStatistics);
            this.SubjectPanel.Controls.Add(this.StatisticsBtn);
            this.SubjectPanel.Controls.Add(this.SubPanelPhysical);
            this.SubjectPanel.Controls.Add(this.PhysicalBtn);
            this.SubjectPanel.Controls.Add(this.SubPanelMath);
            this.SubjectPanel.Controls.Add(this.MathBtn);
            this.SubjectPanel.Controls.Add(this.PanelLogo);
            this.SubjectPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubjectPanel.Location = new System.Drawing.Point(0, 0);
            this.SubjectPanel.Name = "SubjectPanel";
            this.SubjectPanel.Size = new System.Drawing.Size(240, 681);
            this.SubjectPanel.TabIndex = 0;
            // 
            // SubPanelStatistics
            // 
            this.SubPanelStatistics.Controls.Add(this.button5);
            this.SubPanelStatistics.Controls.Add(this.GraficaBtn);
            this.SubPanelStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelStatistics.Location = new System.Drawing.Point(0, 376);
            this.SubPanelStatistics.Name = "SubPanelStatistics";
            this.SubPanelStatistics.Size = new System.Drawing.Size(240, 83);
            this.SubPanelStatistics.TabIndex = 7;
            this.SubPanelStatistics.Visible = false;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 30);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // GraficaBtn
            // 
            this.GraficaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GraficaBtn.Location = new System.Drawing.Point(0, 0);
            this.GraficaBtn.Name = "GraficaBtn";
            this.GraficaBtn.Size = new System.Drawing.Size(240, 30);
            this.GraficaBtn.TabIndex = 0;
            this.GraficaBtn.Text = "Graficas";
            this.GraficaBtn.UseVisualStyleBackColor = true;
            this.GraficaBtn.Click += new System.EventHandler(this.GraficaBtn_Click);
            // 
            // StatisticsBtn
            // 
            this.StatisticsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StatisticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatisticsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatisticsBtn.IconChar = FontAwesome.Sharp.IconChar.Poll;
            this.StatisticsBtn.IconColor = System.Drawing.Color.Black;
            this.StatisticsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StatisticsBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StatisticsBtn.Location = new System.Drawing.Point(0, 326);
            this.StatisticsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.StatisticsBtn.Name = "StatisticsBtn";
            this.StatisticsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.StatisticsBtn.Size = new System.Drawing.Size(240, 50);
            this.StatisticsBtn.TabIndex = 6;
            this.StatisticsBtn.Text = "Estadistica";
            this.StatisticsBtn.UseVisualStyleBackColor = false;
            this.StatisticsBtn.Click += new System.EventHandler(this.StatisticsBtn_Click);
            // 
            // SubPanelPhysical
            // 
            this.SubPanelPhysical.Controls.Add(this.button3);
            this.SubPanelPhysical.Controls.Add(this.button4);
            this.SubPanelPhysical.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelPhysical.Location = new System.Drawing.Point(0, 243);
            this.SubPanelPhysical.Name = "SubPanelPhysical";
            this.SubPanelPhysical.Size = new System.Drawing.Size(240, 83);
            this.SubPanelPhysical.TabIndex = 5;
            this.SubPanelPhysical.Visible = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 30);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PhysicalBtn
            // 
            this.PhysicalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PhysicalBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhysicalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhysicalBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhysicalBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PhysicalBtn.IconChar = FontAwesome.Sharp.IconChar.Flask;
            this.PhysicalBtn.IconColor = System.Drawing.Color.Black;
            this.PhysicalBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PhysicalBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PhysicalBtn.Location = new System.Drawing.Point(0, 193);
            this.PhysicalBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PhysicalBtn.Name = "PhysicalBtn";
            this.PhysicalBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.PhysicalBtn.Size = new System.Drawing.Size(240, 50);
            this.PhysicalBtn.TabIndex = 4;
            this.PhysicalBtn.Text = "Fisica";
            this.PhysicalBtn.UseVisualStyleBackColor = false;
            this.PhysicalBtn.Click += new System.EventHandler(this.PhysicalBtn_Click_1);
            // 
            // SubPanelMath
            // 
            this.SubPanelMath.Controls.Add(this.button2);
            this.SubPanelMath.Controls.Add(this.button1);
            this.SubPanelMath.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelMath.Location = new System.Drawing.Point(0, 110);
            this.SubPanelMath.Name = "SubPanelMath";
            this.SubPanelMath.Size = new System.Drawing.Size(240, 83);
            this.SubPanelMath.TabIndex = 3;
            this.SubPanelMath.Visible = false;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MathBtn
            // 
            this.MathBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MathBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MathBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MathBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MathBtn.IconChar = FontAwesome.Sharp.IconChar.SquareRootAlt;
            this.MathBtn.IconColor = System.Drawing.Color.Black;
            this.MathBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MathBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MathBtn.Location = new System.Drawing.Point(0, 60);
            this.MathBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MathBtn.Name = "MathBtn";
            this.MathBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MathBtn.Size = new System.Drawing.Size(240, 50);
            this.MathBtn.TabIndex = 1;
            this.MathBtn.Text = "Matematicas";
            this.MathBtn.UseVisualStyleBackColor = false;
            this.MathBtn.Click += new System.EventHandler(this.MathBtn_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(240, 60);
            this.PanelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(240, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 681);
            this.panel1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SubjectPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllMath";
            this.SubjectPanel.ResumeLayout(false);
            this.SubPanelStatistics.ResumeLayout(false);
            this.SubPanelPhysical.ResumeLayout(false);
            this.SubPanelMath.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SubjectPanel;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private FontAwesome.Sharp.IconButton MathBtn;
        private System.Windows.Forms.Panel SubPanelStatistics;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button GraficaBtn;
        private FontAwesome.Sharp.IconButton StatisticsBtn;
        private System.Windows.Forms.Panel SubPanelPhysical;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private FontAwesome.Sharp.IconButton PhysicalBtn;
        private System.Windows.Forms.Panel SubPanelMath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

