namespace KolekcijeSpremanje
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
            this.txtUnosIme = new System.Windows.Forms.RichTextBox();
            this.txtUnosPrezime = new System.Windows.Forms.RichTextBox();
            this.txtUnosGodRod = new System.Windows.Forms.RichTextBox();
            this.txtUnosEmail = new System.Windows.Forms.RichTextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godina Rođenja: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email: ";
            // 
            // txtUnosIme
            // 
            this.txtUnosIme.Location = new System.Drawing.Point(109, 30);
            this.txtUnosIme.Name = "txtUnosIme";
            this.txtUnosIme.Size = new System.Drawing.Size(206, 22);
            this.txtUnosIme.TabIndex = 4;
            this.txtUnosIme.Text = "";
            // 
            // txtUnosPrezime
            // 
            this.txtUnosPrezime.Location = new System.Drawing.Point(109, 79);
            this.txtUnosPrezime.Name = "txtUnosPrezime";
            this.txtUnosPrezime.Size = new System.Drawing.Size(206, 22);
            this.txtUnosPrezime.TabIndex = 5;
            this.txtUnosPrezime.Text = "";
            // 
            // txtUnosGodRod
            // 
            this.txtUnosGodRod.Location = new System.Drawing.Point(109, 129);
            this.txtUnosGodRod.Name = "txtUnosGodRod";
            this.txtUnosGodRod.Size = new System.Drawing.Size(206, 22);
            this.txtUnosGodRod.TabIndex = 6;
            this.txtUnosGodRod.Text = "";
            // 
            // txtUnosEmail
            // 
            this.txtUnosEmail.Location = new System.Drawing.Point(109, 182);
            this.txtUnosEmail.Name = "txtUnosEmail";
            this.txtUnosEmail.Size = new System.Drawing.Size(206, 22);
            this.txtUnosEmail.TabIndex = 7;
            this.txtUnosEmail.Text = "";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(15, 235);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(300, 125);
            this.btnUnos.TabIndex = 8;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(333, 380);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtUnosEmail);
            this.Controls.Add(this.txtUnosGodRod);
            this.Controls.Add(this.txtUnosPrezime);
            this.Controls.Add(this.txtUnosIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtUnosIme;
        private System.Windows.Forms.RichTextBox txtUnosPrezime;
        private System.Windows.Forms.RichTextBox txtUnosGodRod;
        private System.Windows.Forms.RichTextBox txtUnosEmail;
        private System.Windows.Forms.Button btnUnos;
    }
}

