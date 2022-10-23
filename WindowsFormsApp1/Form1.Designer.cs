
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtTurkceDogru = new System.Windows.Forms.TextBox();
            this.txtTurkceYanlis = new System.Windows.Forms.TextBox();
            this.txtTurkceNet = new System.Windows.Forms.TextBox();
            this.txtMatDogru = new System.Windows.Forms.TextBox();
            this.txtMatYanlis = new System.Windows.Forms.TextBox();
            this.txtMatNet = new System.Windows.Forms.TextBox();
            this.txtFizikDogru = new System.Windows.Forms.TextBox();
            this.txtFizikYanlis = new System.Windows.Forms.TextBox();
            this.txtFizikNet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türkce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matematik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fizik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "NET";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(93, 210);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(210, 30);
            this.btnHesapla.TabIndex = 15;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTurkceDogru
            // 
            this.txtTurkceDogru.Location = new System.Drawing.Point(93, 82);
            this.txtTurkceDogru.Name = "txtTurkceDogru";
            this.txtTurkceDogru.Size = new System.Drawing.Size(59, 20);
            this.txtTurkceDogru.TabIndex = 16;
            // 
            // txtTurkceYanlis
            // 
            this.txtTurkceYanlis.Location = new System.Drawing.Point(174, 82);
            this.txtTurkceYanlis.Name = "txtTurkceYanlis";
            this.txtTurkceYanlis.Size = new System.Drawing.Size(55, 20);
            this.txtTurkceYanlis.TabIndex = 17;
            // 
            // txtTurkceNet
            // 
            this.txtTurkceNet.Enabled = false;
            this.txtTurkceNet.Location = new System.Drawing.Point(248, 78);
            this.txtTurkceNet.Name = "txtTurkceNet";
            this.txtTurkceNet.Size = new System.Drawing.Size(55, 20);
            this.txtTurkceNet.TabIndex = 18;
            // 
            // txtMatDogru
            // 
            this.txtMatDogru.Location = new System.Drawing.Point(93, 126);
            this.txtMatDogru.Name = "txtMatDogru";
            this.txtMatDogru.Size = new System.Drawing.Size(59, 20);
            this.txtMatDogru.TabIndex = 19;
            // 
            // txtMatYanlis
            // 
            this.txtMatYanlis.Location = new System.Drawing.Point(174, 126);
            this.txtMatYanlis.Name = "txtMatYanlis";
            this.txtMatYanlis.Size = new System.Drawing.Size(55, 20);
            this.txtMatYanlis.TabIndex = 20;
            // 
            // txtMatNet
            // 
            this.txtMatNet.Enabled = false;
            this.txtMatNet.Location = new System.Drawing.Point(248, 123);
            this.txtMatNet.Name = "txtMatNet";
            this.txtMatNet.Size = new System.Drawing.Size(55, 20);
            this.txtMatNet.TabIndex = 21;
            // 
            // txtFizikDogru
            // 
            this.txtFizikDogru.Location = new System.Drawing.Point(93, 165);
            this.txtFizikDogru.Name = "txtFizikDogru";
            this.txtFizikDogru.Size = new System.Drawing.Size(59, 20);
            this.txtFizikDogru.TabIndex = 22;
            // 
            // txtFizikYanlis
            // 
            this.txtFizikYanlis.Location = new System.Drawing.Point(171, 168);
            this.txtFizikYanlis.Name = "txtFizikYanlis";
            this.txtFizikYanlis.Size = new System.Drawing.Size(58, 20);
            this.txtFizikYanlis.TabIndex = 23;
            // 
            // txtFizikNet
            // 
            this.txtFizikNet.Enabled = false;
            this.txtFizikNet.Location = new System.Drawing.Point(248, 168);
            this.txtFizikNet.Name = "txtFizikNet";
            this.txtFizikNet.Size = new System.Drawing.Size(55, 20);
            this.txtFizikNet.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 282);
            this.Controls.Add(this.txtFizikNet);
            this.Controls.Add(this.txtFizikYanlis);
            this.Controls.Add(this.txtFizikDogru);
            this.Controls.Add(this.txtMatNet);
            this.Controls.Add(this.txtMatYanlis);
            this.Controls.Add(this.txtMatDogru);
            this.Controls.Add(this.txtTurkceNet);
            this.Controls.Add(this.txtTurkceYanlis);
            this.Controls.Add(this.txtTurkceDogru);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtTurkceDogru;
        private System.Windows.Forms.TextBox txtTurkceYanlis;
        private System.Windows.Forms.TextBox txtTurkceNet;
        private System.Windows.Forms.TextBox txtMatDogru;
        private System.Windows.Forms.TextBox txtMatYanlis;
        private System.Windows.Forms.TextBox txtMatNet;
        private System.Windows.Forms.TextBox txtFizikDogru;
        private System.Windows.Forms.TextBox txtFizikYanlis;
        private System.Windows.Forms.TextBox txtFizikNet;
    }
}

