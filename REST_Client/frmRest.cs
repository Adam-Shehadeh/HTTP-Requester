using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REST_Client{
    public partial class frmMain : Form{
        public frmMain(){
            InitializeComponent();
        }

        #region UI Event Handlers
        private void btnGo_Click(object sender, EventArgs e){
            performAction();
        }
        private void txtURI_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                performAction();
        }
        #endregion 

        private void performAction() {
            txtResponse.Text = string.Empty;
            RestClient rClient = new RestClient();
            rClient.endPoint = txtURI.Text;

            debugOutput("Rest Client Created");
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest();
            debugOutput(strResponse);
        }

        private void debugOutput (string strDebugText){
            try {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            } catch (Exception e) {
                System.Diagnostics.Debug.Write(e.Message, ToString() + Environment.NewLine);
            }
        }

        private void msExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void msAbout_Click(object sender, EventArgs e) {
            frmAbout frm = frmAbout.GetInstance();
            frm.Show();
            frm.BringToFront();
        }

        private void msGitHub_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/Adam-Shehadeh/HTTP-Requester");
        }
    }
}
