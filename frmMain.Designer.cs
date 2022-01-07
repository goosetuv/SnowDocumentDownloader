
namespace SnowDocumentDownloader
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvDocumentData = new System.Windows.Forms.DataGridView();
            this.gbSQLServer = new System.Windows.Forms.GroupBox();
            this.btnSQLConnect = new System.Windows.Forms.Button();
            this.cbSQLWindowsAuth = new System.Windows.Forms.CheckBox();
            this.lblSQLPassword = new System.Windows.Forms.Label();
            this.lblSQLUser = new System.Windows.Forms.Label();
            this.txtSQLPass = new System.Windows.Forms.TextBox();
            this.txtSQLUser = new System.Windows.Forms.TextBox();
            this.lblSQLServer = new System.Windows.Forms.Label();
            this.txtSQLServer = new System.Windows.Forms.TextBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSaveAttachment = new System.Windows.Forms.Button();
            this.lblDocType = new System.Windows.Forms.Label();
            this.cbDocType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentData)).BeginInit();
            this.gbSQLServer.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDocumentData
            // 
            this.dgvDocumentData.AllowUserToAddRows = false;
            this.dgvDocumentData.AllowUserToDeleteRows = false;
            this.dgvDocumentData.AllowUserToResizeColumns = false;
            this.dgvDocumentData.AllowUserToResizeRows = false;
            this.dgvDocumentData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentData.ColumnHeadersVisible = false;
            this.dgvDocumentData.Location = new System.Drawing.Point(0, 0);
            this.dgvDocumentData.MultiSelect = false;
            this.dgvDocumentData.Name = "dgvDocumentData";
            this.dgvDocumentData.ReadOnly = true;
            this.dgvDocumentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentData.Size = new System.Drawing.Size(787, 394);
            this.dgvDocumentData.TabIndex = 0;
            // 
            // gbSQLServer
            // 
            this.gbSQLServer.Controls.Add(this.btnSQLConnect);
            this.gbSQLServer.Controls.Add(this.cbSQLWindowsAuth);
            this.gbSQLServer.Controls.Add(this.lblSQLPassword);
            this.gbSQLServer.Controls.Add(this.lblSQLUser);
            this.gbSQLServer.Controls.Add(this.txtSQLPass);
            this.gbSQLServer.Controls.Add(this.txtSQLUser);
            this.gbSQLServer.Controls.Add(this.lblSQLServer);
            this.gbSQLServer.Controls.Add(this.txtSQLServer);
            this.gbSQLServer.Location = new System.Drawing.Point(6, 3);
            this.gbSQLServer.Name = "gbSQLServer";
            this.gbSQLServer.Size = new System.Drawing.Size(315, 153);
            this.gbSQLServer.TabIndex = 1;
            this.gbSQLServer.TabStop = false;
            this.gbSQLServer.Text = "SQL Connection";
            // 
            // btnSQLConnect
            // 
            this.btnSQLConnect.Location = new System.Drawing.Point(77, 121);
            this.btnSQLConnect.Name = "btnSQLConnect";
            this.btnSQLConnect.Size = new System.Drawing.Size(191, 23);
            this.btnSQLConnect.TabIndex = 7;
            this.btnSQLConnect.Text = "Connect";
            this.btnSQLConnect.UseVisualStyleBackColor = true;
            this.btnSQLConnect.Click += new System.EventHandler(this.btnSQLConnect_Click);
            // 
            // cbSQLWindowsAuth
            // 
            this.cbSQLWindowsAuth.AutoSize = true;
            this.cbSQLWindowsAuth.Location = new System.Drawing.Point(77, 98);
            this.cbSQLWindowsAuth.Name = "cbSQLWindowsAuth";
            this.cbSQLWindowsAuth.Size = new System.Drawing.Size(141, 17);
            this.cbSQLWindowsAuth.TabIndex = 6;
            this.cbSQLWindowsAuth.Text = "Windows Authentication";
            this.cbSQLWindowsAuth.UseVisualStyleBackColor = true;
            this.cbSQLWindowsAuth.CheckedChanged += new System.EventHandler(this.cbSQLWindowsAuth_CheckedChanged);
            // 
            // lblSQLPassword
            // 
            this.lblSQLPassword.AutoSize = true;
            this.lblSQLPassword.Location = new System.Drawing.Point(15, 75);
            this.lblSQLPassword.Name = "lblSQLPassword";
            this.lblSQLPassword.Size = new System.Drawing.Size(56, 13);
            this.lblSQLPassword.TabIndex = 5;
            this.lblSQLPassword.Text = "Password:";
            // 
            // lblSQLUser
            // 
            this.lblSQLUser.AutoSize = true;
            this.lblSQLUser.Location = new System.Drawing.Point(13, 49);
            this.lblSQLUser.Name = "lblSQLUser";
            this.lblSQLUser.Size = new System.Drawing.Size(58, 13);
            this.lblSQLUser.TabIndex = 4;
            this.lblSQLUser.Text = "Username:";
            // 
            // txtSQLPass
            // 
            this.txtSQLPass.Location = new System.Drawing.Point(77, 72);
            this.txtSQLPass.Name = "txtSQLPass";
            this.txtSQLPass.Size = new System.Drawing.Size(191, 20);
            this.txtSQLPass.TabIndex = 3;
            // 
            // txtSQLUser
            // 
            this.txtSQLUser.Location = new System.Drawing.Point(77, 46);
            this.txtSQLUser.Name = "txtSQLUser";
            this.txtSQLUser.Size = new System.Drawing.Size(191, 20);
            this.txtSQLUser.TabIndex = 2;
            // 
            // lblSQLServer
            // 
            this.lblSQLServer.AutoSize = true;
            this.lblSQLServer.Location = new System.Drawing.Point(6, 23);
            this.lblSQLServer.Name = "lblSQLServer";
            this.lblSQLServer.Size = new System.Drawing.Size(65, 13);
            this.lblSQLServer.TabIndex = 1;
            this.lblSQLServer.Text = "SQL Server:";
            // 
            // txtSQLServer
            // 
            this.txtSQLServer.Location = new System.Drawing.Point(77, 20);
            this.txtSQLServer.Name = "txtSQLServer";
            this.txtSQLServer.Size = new System.Drawing.Size(191, 20);
            this.txtSQLServer.TabIndex = 0;
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.btnAbout);
            this.gbControls.Controls.Add(this.btnSaveAttachment);
            this.gbControls.Controls.Add(this.lblDocType);
            this.gbControls.Controls.Add(this.cbDocType);
            this.gbControls.Location = new System.Drawing.Point(327, 3);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(457, 153);
            this.gbControls.TabIndex = 2;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(373, 124);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSaveAttachment
            // 
            this.btnSaveAttachment.Enabled = false;
            this.btnSaveAttachment.Location = new System.Drawing.Point(132, 65);
            this.btnSaveAttachment.Name = "btnSaveAttachment";
            this.btnSaveAttachment.Size = new System.Drawing.Size(117, 23);
            this.btnSaveAttachment.TabIndex = 9;
            this.btnSaveAttachment.Text = "Save Attachment";
            this.btnSaveAttachment.UseVisualStyleBackColor = true;
            this.btnSaveAttachment.Click += new System.EventHandler(this.btnSaveAttachment_Click);
            // 
            // lblDocType
            // 
            this.lblDocType.AutoSize = true;
            this.lblDocType.Location = new System.Drawing.Point(6, 23);
            this.lblDocType.Name = "lblDocType";
            this.lblDocType.Size = new System.Drawing.Size(120, 13);
            this.lblDocType.TabIndex = 8;
            this.lblDocType.Text = "Document Parent Type:";
            // 
            // cbDocType
            // 
            this.cbDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocType.Enabled = false;
            this.cbDocType.FormattingEnabled = true;
            this.cbDocType.Items.AddRange(new object[] {
            "AGREEMENTS",
            "COMPUTERS",
            "LICENSES",
            "USERS"});
            this.cbDocType.Location = new System.Drawing.Point(132, 19);
            this.cbDocType.Name = "cbDocType";
            this.cbDocType.Size = new System.Drawing.Size(319, 21);
            this.cbDocType.TabIndex = 0;
            this.cbDocType.SelectedIndexChanged += new System.EventHandler(this.cbDocType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbControls);
            this.panel1.Controls.Add(this.gbSQLServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 166);
            this.panel1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDocumentData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snow Document Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentData)).EndInit();
            this.gbSQLServer.ResumeLayout(false);
            this.gbSQLServer.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocumentData;
        private System.Windows.Forms.GroupBox gbSQLServer;
        private System.Windows.Forms.Label lblSQLServer;
        private System.Windows.Forms.TextBox txtSQLServer;
        private System.Windows.Forms.TextBox txtSQLPass;
        private System.Windows.Forms.TextBox txtSQLUser;
        private System.Windows.Forms.Label lblSQLPassword;
        private System.Windows.Forms.Label lblSQLUser;
        private System.Windows.Forms.Button btnSQLConnect;
        private System.Windows.Forms.CheckBox cbSQLWindowsAuth;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Label lblDocType;
        private System.Windows.Forms.ComboBox cbDocType;
        private System.Windows.Forms.Button btnSaveAttachment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAbout;
    }
}

