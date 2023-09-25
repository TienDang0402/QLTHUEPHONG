namespace THUEPHONG
{
    partial class frmConnectCSDL
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnKiemtra = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtWindow = new System.Windows.Forms.RadioButton();
            this.rdbtSql = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.btnKiemtra);
            this.groupControl1.Controls.Add(this.txtPass);
            this.groupControl1.Controls.Add(this.txtUser);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtDatabase);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtServer);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(368, 421);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin kết nối";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(109, 65);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(185, 23);
            this.txtServer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(109, 111);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(185, 23);
            this.txtDatabase.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(109, 257);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(185, 23);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(109, 310);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(185, 23);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnKiemtra
            // 
            this.btnKiemtra.Location = new System.Drawing.Point(45, 371);
            this.btnKiemtra.Name = "btnKiemtra";
            this.btnKiemtra.Size = new System.Drawing.Size(75, 23);
            this.btnKiemtra.TabIndex = 4;
            this.btnKiemtra.Text = "Kiểm tra";
            this.btnKiemtra.UseVisualStyleBackColor = true;
            this.btnKiemtra.Click += new System.EventHandler(this.btnKiemtra_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(138, 371);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(228, 371);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtSql);
            this.groupBox1.Controls.Add(this.rdbtWindow);
            this.groupBox1.Location = new System.Drawing.Point(109, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rdbtWindow
            // 
            this.rdbtWindow.AutoSize = true;
            this.rdbtWindow.Location = new System.Drawing.Point(26, 26);
            this.rdbtWindow.Name = "rdbtWindow";
            this.rdbtWindow.Size = new System.Drawing.Size(135, 20);
            this.rdbtWindow.TabIndex = 0;
            this.rdbtWindow.TabStop = true;
            this.rdbtWindow.Text = "Kết nối với window";
            this.rdbtWindow.UseVisualStyleBackColor = true;
            this.rdbtWindow.Click += new System.EventHandler(this.rdbtWindow_Click);
            // 
            // rdbtSql
            // 
            this.rdbtSql.AutoSize = true;
            this.rdbtSql.Location = new System.Drawing.Point(26, 65);
            this.rdbtSql.Name = "rdbtSql";
            this.rdbtSql.Size = new System.Drawing.Size(109, 20);
            this.rdbtSql.TabIndex = 1;
            this.rdbtSql.TabStop = true;
            this.rdbtSql.Text = "Kết nối với Sql";
            this.rdbtSql.UseVisualStyleBackColor = true;
            this.rdbtSql.Click += new System.EventHandler(this.rdbtSql_Click);
            // 
            // frmConnectCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 421);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmConnectCSDL";
            this.Text = "frmConnectCSDL";
            this.Load += new System.EventHandler(this.frmConnectCSDL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKiemtra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtSql;
        private System.Windows.Forms.RadioButton rdbtWindow;
    }
}