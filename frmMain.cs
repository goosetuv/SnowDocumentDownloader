using System;
using Laim;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;

namespace SnowDocumentDownloader
{
    public partial class frmMain : Form
    {
        
        private bool isConnected = false;
        private string connectionString = "";

        private readonly int CID = 1;

        public frmMain()
        {
            InitializeComponent();

            try
            {
                Directory.CreateDirectory("Data");
                Directory.CreateDirectory(@"Data\Agreements");
                Directory.CreateDirectory(@"Data\Licenses");
                Directory.CreateDirectory(@"Data\Users");
                Directory.CreateDirectory(@"Data\Computers");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException + ex.StackTrace);
            }
        }

        private void cbSQLWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSQLWindowsAuth.Checked)
            {
                txtSQLUser.Enabled = false;
                txtSQLPass.Enabled = false;
            } else
            {
                txtSQLUser.Enabled = true;
                txtSQLPass.Enabled = true;
            }
        }

        private void btnSQLConnect_Click(object sender, EventArgs e)
        {
            if (txtSQLServer.Text == string.Empty)
            {
                MessageBox.Show("SQL Server is a required field.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbSQLWindowsAuth.Checked)
            {
                connectionString = "Data Source=" + txtSQLServer.Text + ";Application Name=SLMDocDownloader;Database=SnowLicenseManager;Integrated Security=SSPI";
            }
            else
            {
                if (txtSQLUser.Text == string.Empty || txtSQLPass.Text == string.Empty)
                {
                    MessageBox.Show("Username and Password are required if not using Windows Authentication.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connectionString = "Data Source=" + txtSQLServer.Text + ";Application Name=SLMDocDownloader;Database=SnowLicenseManager;User=" + txtSQLUser.Text + ";Password=" + txtSQLPass.Text;
            }

            if (connectionString == null)
            {
                MessageBox.Show("Connection String is not set.  This should never happen.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isConnected = MSSqlServer.CheckConnnection(connectionString);

            if (isConnected)
            {
                gbSQLServer.Enabled = false;
                cbDocType.Enabled = true;
                btnSaveAttachment.Enabled = true;

                cbDocType.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Connection was unsuccessful", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbDocType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string q = "";
                switch (cbDocType.Text)
                {
                    case "AGREEMENTS":
                        q = Properties.Resources.GetDocumentDataAgreements;
                        break;
                    case "LICENSES":
                        q = Properties.Resources.GetDocumentDataLicenses;
                        break;
                    case "USERS":
                        q = Properties.Resources.GetDocumentDataUsers;
                        break;
                    case "COMPUTERS":
                        q = Properties.Resources.GetDocumentDataComputers;
                        break;
                    default:
                        break;
                }

                List<SqlParameter> p = new List<SqlParameter> { new SqlParameter("@CID", CID) };
                dgvDocumentData.DataSource = MSSqlServer.ExecuteReadDataTable(connectionString, q, p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException + ex.StackTrace);
            }
        }

        private void btnSaveAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDocumentData.SelectedRows == null)
                {
                    MessageBox.Show("Select a row from the above grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                int fileID = (int)dgvDocumentData.SelectedRows[0].Cells["File ID"].Value;
                string fileName = (string)dgvDocumentData.SelectedRows[0].Cells["FileName"].Value; ;

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand(Properties.Resources.GetDocumentContent, conn);
                cmd.Parameters.Add("@CID", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@FileID", SqlDbType.Int).Value = fileID;

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                byte[] buffer = dt.AsEnumerable().Select(c => c.Field<byte[]>("Content")).SingleOrDefault();


                string filePath = @"Data\" + cbDocType.Text + @"\" + fileName;

                File.WriteAllBytes(filePath, buffer);

                conn.Close();

                if(File.Exists(filePath))
                {
                    MessageBox.Show("Attachment saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException + ex.StackTrace);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright (c) Laim McKenzie 2022 - v0.1");
            MessageBox.Show("This software is not affiliated with Snow Software.");
            MessageBox.Show("https://laim.scot");
        }
    }
}
