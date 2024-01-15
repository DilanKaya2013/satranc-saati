namespace satranc_saatti
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
            this.components = new System.ComponentModel.Container();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnBeyaz = new System.Windows.Forms.Button();
            this.btnSiyah = new System.Windows.Forms.Button();
            this.lblBeyaz = new System.Windows.Forms.Label();
            this.lblSiyah = new System.Windows.Forms.Label();
            this.timerBeyaz = new System.Windows.Forms.Timer(this.components);
            this.timerSiyah = new System.Windows.Forms.Timer(this.components);
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(12, 53);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(102, 44);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnBeyaz
            // 
            this.btnBeyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeyaz.Location = new System.Drawing.Point(12, 119);
            this.btnBeyaz.Name = "btnBeyaz";
            this.btnBeyaz.Size = new System.Drawing.Size(102, 44);
            this.btnBeyaz.TabIndex = 1;
            this.btnBeyaz.Text = "beyaz";
            this.btnBeyaz.UseVisualStyleBackColor = true;
            this.btnBeyaz.Click += new System.EventHandler(this.btnBeyaz_Click);
            // 
            // btnSiyah
            // 
            this.btnSiyah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiyah.Location = new System.Drawing.Point(12, 187);
            this.btnSiyah.Name = "btnSiyah";
            this.btnSiyah.Size = new System.Drawing.Size(102, 44);
            this.btnSiyah.TabIndex = 2;
            this.btnSiyah.Text = "siyah";
            this.btnSiyah.UseVisualStyleBackColor = true;
            this.btnSiyah.Click += new System.EventHandler(this.btnSiyah_Click);
            // 
            // lblBeyaz
            // 
            this.lblBeyaz.AutoSize = true;
            this.lblBeyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeyaz.Location = new System.Drawing.Point(120, 143);
            this.lblBeyaz.Name = "lblBeyaz";
            this.lblBeyaz.Size = new System.Drawing.Size(49, 20);
            this.lblBeyaz.TabIndex = 3;
            this.lblBeyaz.Text = "süre:";
            // 
            // lblSiyah
            // 
            this.lblSiyah.AutoSize = true;
            this.lblSiyah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiyah.Location = new System.Drawing.Point(120, 199);
            this.lblSiyah.Name = "lblSiyah";
            this.lblSiyah.Size = new System.Drawing.Size(49, 20);
            this.lblSiyah.TabIndex = 4;
            this.lblSiyah.Text = "süre:";
            // 
            // timerBeyaz
            // 
            this.timerBeyaz.Interval = 1000;
            this.timerBeyaz.Tick += new System.EventHandler(this.timerBeyaz_Tick);
            // 
            // timerSiyah
            // 
            this.timerSiyah.Interval = 1000;
            this.timerSiyah.Tick += new System.EventHandler(this.timerSiyah_Tick);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(195, 167);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(35, 13);
            this.lblMesaj.TabIndex = 5;
            this.lblMesaj.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 299);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblSiyah);
            this.Controls.Add(this.lblBeyaz);
            this.Controls.Add(this.btnSiyah);
            this.Controls.Add(this.btnBeyaz);
            this.Controls.Add(this.btnBaslat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnBeyaz;
        private System.Windows.Forms.Button btnSiyah;
        private System.Windows.Forms.Label lblBeyaz;
        private System.Windows.Forms.Label lblSiyah;
        private System.Windows.Forms.Timer timerBeyaz;
        private System.Windows.Forms.Timer timerSiyah;
        private System.Windows.Forms.Label lblMesaj;
    }
}

