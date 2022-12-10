namespace ProjekatOsoba
{
    partial class fmOdeljenje
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbRazred = new System.Windows.Forms.TextBox();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.cbRazredni = new System.Windows.Forms.ComboBox();
            this.cbSmer = new System.Windows.Forms.ComboBox();
            this.cbGodina = new System.Windows.Forms.ComboBox();
            this.btFirst = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btUnesi = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btIzbrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(12, 68);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(154, 23);
            this.tbID.TabIndex = 0;
            // 
            // tbRazred
            // 
            this.tbRazred.Location = new System.Drawing.Point(12, 97);
            this.tbRazred.Multiline = true;
            this.tbRazred.Name = "tbRazred";
            this.tbRazred.Size = new System.Drawing.Size(154, 23);
            this.tbRazred.TabIndex = 1;
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(12, 126);
            this.tbIndex.Multiline = true;
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(154, 23);
            this.tbIndex.TabIndex = 2;
            // 
            // cbRazredni
            // 
            this.cbRazredni.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRazredni.FormattingEnabled = true;
            this.cbRazredni.Location = new System.Drawing.Point(12, 185);
            this.cbRazredni.Name = "cbRazredni";
            this.cbRazredni.Size = new System.Drawing.Size(154, 24);
            this.cbRazredni.TabIndex = 8;
            // 
            // cbSmer
            // 
            this.cbSmer.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSmer.FormattingEnabled = true;
            this.cbSmer.Location = new System.Drawing.Point(12, 155);
            this.cbSmer.Name = "cbSmer";
            this.cbSmer.Size = new System.Drawing.Size(154, 24);
            this.cbSmer.TabIndex = 9;
            // 
            // cbGodina
            // 
            this.cbGodina.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGodina.FormattingEnabled = true;
            this.cbGodina.Location = new System.Drawing.Point(12, 215);
            this.cbGodina.Name = "cbGodina";
            this.cbGodina.Size = new System.Drawing.Size(154, 24);
            this.cbGodina.TabIndex = 10;
            // 
            // btFirst
            // 
            this.btFirst.BackColor = System.Drawing.Color.OliveDrab;
            this.btFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFirst.Location = new System.Drawing.Point(12, 245);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(34, 25);
            this.btFirst.TabIndex = 11;
            this.btFirst.Text = "<<";
            this.btFirst.UseVisualStyleBackColor = false;
            // 
            // btPrev
            // 
            this.btPrev.BackColor = System.Drawing.Color.OliveDrab;
            this.btPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrev.Location = new System.Drawing.Point(52, 245);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(34, 25);
            this.btPrev.TabIndex = 12;
            this.btPrev.Text = "<";
            this.btPrev.UseVisualStyleBackColor = false;
            // 
            // btLast
            // 
            this.btLast.BackColor = System.Drawing.Color.OliveDrab;
            this.btLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLast.Location = new System.Drawing.Point(132, 245);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(34, 25);
            this.btLast.TabIndex = 13;
            this.btLast.Text = ">>";
            this.btLast.UseVisualStyleBackColor = false;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.OliveDrab;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Location = new System.Drawing.Point(92, 245);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(34, 25);
            this.btNext.TabIndex = 14;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = false;
            // 
            // btUnesi
            // 
            this.btUnesi.Location = new System.Drawing.Point(235, 27);
            this.btUnesi.Name = "btUnesi";
            this.btUnesi.Size = new System.Drawing.Size(75, 23);
            this.btUnesi.TabIndex = 15;
            this.btUnesi.Text = "Unesi";
            this.btUnesi.UseVisualStyleBackColor = true;
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(235, 56);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btIzmeni.TabIndex = 16;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            // 
            // btIzbrisi
            // 
            this.btIzbrisi.Location = new System.Drawing.Point(235, 85);
            this.btIzbrisi.Name = "btIzbrisi";
            this.btIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btIzbrisi.TabIndex = 17;
            this.btIzbrisi.Text = "Izbrisi";
            this.btIzbrisi.UseVisualStyleBackColor = true;
            // 
            // fmOdeljenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.btIzbrisi);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btUnesi);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btLast);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.cbGodina);
            this.Controls.Add(this.cbSmer);
            this.Controls.Add(this.cbRazredni);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.tbRazred);
            this.Controls.Add(this.tbID);
            this.Name = "fmOdeljenje";
            this.Text = "Odeljenje";
            this.Load += new System.EventHandler(this.fmOdeljenje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbRazred;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.ComboBox cbRazredni;
        private System.Windows.Forms.ComboBox cbSmer;
        private System.Windows.Forms.ComboBox cbGodina;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btUnesi;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btIzbrisi;
    }
}