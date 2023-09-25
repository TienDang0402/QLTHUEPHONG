using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONG
{
    public partial class frmConnectCSDL : DevExpress.XtraEditors.XtraForm
    {
        public frmConnectCSDL()
        {
            InitializeComponent();
        }

        SqlConnection getCon(string server, string username, string password, string database)
        {
            if(rdbtSql.Checked)
            {
                return new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID=" + txtUser.Text + ";Password=" + txtPass.Text + ";");
            }
            else
            {
                return new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDatabase.Text + ";Integrated Security=true;");
            }

        }
        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            SqlConnection con = getCon(txtServer.Text, txtUser.Text, txtPass.Text, txtDatabase.Text);
            try
            {
                con.Open();
                MessageBox.Show("ket noi thanh cong");
            }
            catch (Exception)
            {
                MessageBox.Show("ket noi khong thanh cong");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //string svEncrypt = Encryptor.Encrypt(txtServer.Text, "qwertyuiop", true);
            //string usEncrypt = Encryptor.Encrypt(txtUser.Text, "qwertyuiop", true);
            //string pwEncrypt = Encryptor.Encrypt(txtPass.Text, "qwertyuiop", true);
            //string dbEncrypt = Encryptor.Encrypt(txtDatabase.Text, "qwertyuiop", true);
            
            //connect cn = new connect(svEncrypt, usEncrypt, pwEncrypt, dbEncrypt);
            //cn.ConnectData();
            //MessageBox.Show("luu file thanh cong", "Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Information);

            //frmMain mainForm = new frmMain();
            //mainForm.Show();
            //this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbtWindow_Click(object sender, EventArgs e)
        {
            if(rdbtWindow.Checked)
            {
                txtUser.Enabled = false;
                txtPass.Enabled = false;
            }
            else
            {
                txtUser.Enabled = true;
                txtPass.Enabled = true;
            }
        }

        private void rdbtSql_Click(object sender, EventArgs e)
        {
            if (rdbtSql.Checked)
            {
                txtUser.Enabled = true;
                txtPass.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtPass.Enabled = false;
            }
        }

        private void frmConnectCSDL_Load(object sender, EventArgs e)
        {
            txtUser.Enabled = false;
            txtPass.Enabled = false;

        }
    }
}