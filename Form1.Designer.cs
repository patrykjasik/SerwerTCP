namespace SerwerTCP
{
    partial class Form1
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
            this.adres = new System.Windows.Forms.TextBox();
            this.port_p = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.przycisk_start = new System.Windows.Forms.Button();
            this.przycisk_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.port_p)).BeginInit();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(13, 13);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(364, 20);
            this.adres.TabIndex = 0;
            this.adres.Text = "Adres";
            // 
            // port_p
            // 
            this.port_p.Location = new System.Drawing.Point(418, 14);
            this.port_p.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port_p.Name = "port_p";
            this.port_p.Size = new System.Drawing.Size(417, 20);
            this.port_p.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(856, 368);
            this.listBox1.TabIndex = 2;
            // 
            // przycisk_start
            // 
            this.przycisk_start.Location = new System.Drawing.Point(119, 467);
            this.przycisk_start.Name = "przycisk_start";
            this.przycisk_start.Size = new System.Drawing.Size(153, 42);
            this.przycisk_start.TabIndex = 3;
            this.przycisk_start.Text = "Start";
            this.przycisk_start.UseVisualStyleBackColor = true;
            this.przycisk_start.Click += new System.EventHandler(this.przycisk_start_Click);
            // 
            // przycisk_stop
            // 
            this.przycisk_stop.Location = new System.Drawing.Point(548, 467);
            this.przycisk_stop.Name = "przycisk_stop";
            this.przycisk_stop.Size = new System.Drawing.Size(144, 43);
            this.przycisk_stop.TabIndex = 4;
            this.przycisk_stop.Text = "Stop";
            this.przycisk_stop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 532);
            this.Controls.Add(this.przycisk_stop);
            this.Controls.Add(this.przycisk_start);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.port_p);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.port_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown port_p;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button przycisk_start;
        private System.Windows.Forms.Button przycisk_stop;
    }
}

