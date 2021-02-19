
namespace NyelvvizsgaForm
{
    partial class btnSikertelen
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
            this.btnSiker = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnElso = new System.Windows.Forms.Button();
            this.ofdSikeres = new System.Windows.Forms.OpenFileDialog();
            this.ofdSikertelen = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSiker
            // 
            this.btnSiker.Location = new System.Drawing.Point(33, 41);
            this.btnSiker.Name = "btnSiker";
            this.btnSiker.Size = new System.Drawing.Size(167, 46);
            this.btnSiker.TabIndex = 0;
            this.btnSiker.Text = "Sikeres vizsgák";
            this.btnSiker.UseVisualStyleBackColor = true;
            this.btnSiker.Click += new System.EventHandler(this.btnSiker_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sikertelen vizsgák";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnElso
            // 
            this.btnElso.Location = new System.Drawing.Point(360, 41);
            this.btnElso.Name = "btnElso";
            this.btnElso.Size = new System.Drawing.Size(167, 45);
            this.btnElso.TabIndex = 2;
            this.btnElso.Text = "1. feladat";
            this.btnElso.UseVisualStyleBackColor = true;
            this.btnElso.Click += new System.EventHandler(this.btnElso_Click);
            // 
            // ofdSikeres
            // 
            this.ofdSikeres.FileName = "sikeres.csv";
            this.ofdSikeres.Filter = "Adatfájlok|*.csv";
            // 
            // ofdSikertelen
            // 
            this.ofdSikertelen.FileName = "sikertelen.csv";
            this.ofdSikertelen.Filter = "Adatfájlok|*.csv";
            // 
            // btnSikertelen
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 584);
            this.Controls.Add(this.btnElso);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSiker);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "btnSikertelen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nyelvvizsga";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnElso;
        private System.Windows.Forms.OpenFileDialog ofdSikeres;
        private System.Windows.Forms.OpenFileDialog ofdSikertelen;
    }
}

