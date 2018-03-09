using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REST_Client {
    public partial class frmAbout : Form {
        public frmAbout() {
            InitializeComponent();
        }

        private static frmAbout _instance;
        public static frmAbout GetInstance() {
            if (_instance == null) _instance = new frmAbout();
            return _instance;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
