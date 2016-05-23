namespace ITSupport.Collector
{
    partial class Home
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
            this.log = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gb_domain2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_domain2 = new System.Windows.Forms.ComboBox();
            this.tx_password2 = new System.Windows.Forms.TextBox();
            this.tx_username2 = new System.Windows.Forms.TextBox();
            this.gb_domain1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_domain1 = new System.Windows.Forms.ComboBox();
            this.tx_password1 = new System.Windows.Forms.TextBox();
            this.txt_username1 = new System.Windows.Forms.TextBox();
            this.cl_local = new System.Windows.Forms.CheckedListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_scan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_domain2.SuspendLayout();
            this.gb_domain1.SuspendLayout();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.Control;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.log.Location = new System.Drawing.Point(7, 20);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(315, 338);
            this.log.TabIndex = 0;
            this.log.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.log);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(508, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 364);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logs";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gb_domain2);
            this.groupBox3.Controls.Add(this.gb_domain1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 118);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Autentication";
            // 
            // gb_domain2
            // 
            this.gb_domain2.Controls.Add(this.label4);
            this.gb_domain2.Controls.Add(this.label5);
            this.gb_domain2.Controls.Add(this.cb_domain2);
            this.gb_domain2.Controls.Add(this.tx_password2);
            this.gb_domain2.Controls.Add(this.tx_username2);
            this.gb_domain2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_domain2.Location = new System.Drawing.Point(260, 16);
            this.gb_domain2.Name = "gb_domain2";
            this.gb_domain2.Size = new System.Drawing.Size(232, 87);
            this.gb_domain2.TabIndex = 29;
            this.gb_domain2.TabStop = false;
            this.gb_domain2.Text = "Auth Domain 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username:";
            // 
            // cb_domain2
            // 
            this.cb_domain2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_domain2.FormattingEnabled = true;
            this.cb_domain2.Items.AddRange(new object[] {
            "br.aon.bz",
            "aonbrasgsao01",
            "aonnet.aon.net"});
            this.cb_domain2.Location = new System.Drawing.Point(6, 18);
            this.cb_domain2.Name = "cb_domain2";
            this.cb_domain2.Size = new System.Drawing.Size(220, 24);
            this.cb_domain2.TabIndex = 4;
            this.cb_domain2.Text = "aonbrasgsao01";
            // 
            // tx_password2
            // 
            this.tx_password2.Location = new System.Drawing.Point(126, 61);
            this.tx_password2.Name = "tx_password2";
            this.tx_password2.PasswordChar = '*';
            this.tx_password2.Size = new System.Drawing.Size(100, 21);
            this.tx_password2.TabIndex = 3;
            this.tx_password2.Text = "Suporte01";
            // 
            // tx_username2
            // 
            this.tx_username2.Location = new System.Drawing.Point(4, 61);
            this.tx_username2.Name = "tx_username2";
            this.tx_username2.Size = new System.Drawing.Size(100, 21);
            this.tx_username2.TabIndex = 2;
            this.tx_username2.Text = "aabreu";
            // 
            // gb_domain1
            // 
            this.gb_domain1.Controls.Add(this.label3);
            this.gb_domain1.Controls.Add(this.label1);
            this.gb_domain1.Controls.Add(this.cb_domain1);
            this.gb_domain1.Controls.Add(this.tx_password1);
            this.gb_domain1.Controls.Add(this.txt_username1);
            this.gb_domain1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_domain1.Location = new System.Drawing.Point(8, 16);
            this.gb_domain1.Name = "gb_domain1";
            this.gb_domain1.Size = new System.Drawing.Size(232, 87);
            this.gb_domain1.TabIndex = 28;
            this.gb_domain1.TabStop = false;
            this.gb_domain1.Text = "Auth Domain 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // cb_domain1
            // 
            this.cb_domain1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_domain1.FormattingEnabled = true;
            this.cb_domain1.Items.AddRange(new object[] {
            "br.aon.bz",
            "aonbrasgsao01",
            "aonnet.aon.net"});
            this.cb_domain1.Location = new System.Drawing.Point(6, 18);
            this.cb_domain1.Name = "cb_domain1";
            this.cb_domain1.Size = new System.Drawing.Size(220, 24);
            this.cb_domain1.TabIndex = 4;
            this.cb_domain1.Text = "br.aon.bz";
            // 
            // tx_password1
            // 
            this.tx_password1.Location = new System.Drawing.Point(126, 61);
            this.tx_password1.Name = "tx_password1";
            this.tx_password1.PasswordChar = '*';
            this.tx_password1.Size = new System.Drawing.Size(100, 21);
            this.tx_password1.TabIndex = 3;
            this.tx_password1.Text = "Suporte01";
            // 
            // txt_username1
            // 
            this.txt_username1.Location = new System.Drawing.Point(4, 61);
            this.txt_username1.Name = "txt_username1";
            this.txt_username1.Size = new System.Drawing.Size(100, 21);
            this.txt_username1.TabIndex = 2;
            this.txt_username1.Text = "andre_abreu_trp";
            // 
            // cl_local
            // 
            this.cl_local.BackColor = System.Drawing.SystemColors.Window;
            this.cl_local.CheckOnClick = true;
            this.cl_local.ColumnWidth = 233;
            this.cl_local.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_local.FormattingEnabled = true;
            this.cl_local.HorizontalExtent = 200;
            this.cl_local.Items.AddRange(new object[] {
            "Belo Horizonte",
            "Campinas",
            "Curitiba",
            "Porto Alegre",
            "Ribeirão Preto",
            "Rio de Janeiro",
            "Salvador",
            "Vitória",
            "Verizon VPN",
            "São Paulo - Wi-Fi",
            "São Paulo - 1º Andar",
            "São Paulo - 2º Andar",
            "São Paulo - 3º Andar",
            "São Paulo - 4º Andar",
            "São Paulo - 5º Andar",
            "São Paulo - 6º Andar",
            "São Paulo - 7º Andar",
            "São Paulo - 8º Andar",
            "São Paulo - 9º Andar",
            "São Paulo - 10º Andar"});
            this.cl_local.Location = new System.Drawing.Point(5, 146);
            this.cl_local.MultiColumn = true;
            this.cl_local.Name = "cl_local";
            this.cl_local.Size = new System.Drawing.Size(497, 164);
            this.cl_local.TabIndex = 30;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 345);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(497, 23);
            this.progressBar1.TabIndex = 32;
            // 
            // btn_scan
            // 
            this.btn_scan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scan.Location = new System.Drawing.Point(5, 316);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(497, 23);
            this.btn_scan.TabIndex = 33;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Selecione o local:\r\n";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 373);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cl_local);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gb_domain2.ResumeLayout(false);
            this.gb_domain2.PerformLayout();
            this.gb_domain1.ResumeLayout(false);
            this.gb_domain1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gb_domain2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_domain2;
        private System.Windows.Forms.TextBox tx_password2;
        private System.Windows.Forms.TextBox tx_username2;
        private System.Windows.Forms.GroupBox gb_domain1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_domain1;
        private System.Windows.Forms.TextBox tx_password1;
        private System.Windows.Forms.TextBox txt_username1;
        private System.Windows.Forms.CheckedListBox cl_local;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Label label2;
    }
}

