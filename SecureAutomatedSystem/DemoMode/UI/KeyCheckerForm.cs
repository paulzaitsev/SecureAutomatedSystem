using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SecureAutomatedSystem.DemoMode.UI {
    public partial class KeyCheckerForm : Form {
        public KeyCheckerForm() {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void keyField_MouseDown(object sender, MouseEventArgs e) {
            ((TextBox)sender).Text = string.Empty;
        }

        private void KeyCheckerForm_MouseClick(object sender, MouseEventArgs e) {
            ResetFieldValue();
        }

        private void tableLayoutPanel2_MouseClick(object sender, MouseEventArgs e) {
            ResetFieldValue();
        }

        private void ResetFieldValue() {
            if (string.IsNullOrEmpty(keyField.Text))
                keyField.Text = UIStringId.EnterLicenseKey;
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e) {
            ResetFieldValue();
        }

        private void iconBox_MouseClick(object sender, MouseEventArgs e) {
            ResetFieldValue();
        }

        private void KeyCheckerForm_Load(object sender, EventArgs e) {
        }

    }

    public static class UIStringId {
        public const string EnterLicenseKey = "Enter license key";
    }
}
