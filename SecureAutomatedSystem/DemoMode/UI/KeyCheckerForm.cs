using System;
using System.CodeDom;
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
using SecureAutomatedSystem.Utils;

namespace SecureAutomatedSystem.DemoMode.UI {
    public partial class KeyCheckerForm : Form {
        public KeyCheckerForm() {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void keyField_MouseDown(object sender, MouseEventArgs e) {
            ((TextBox) sender).Text = string.Empty;
        }

        private void KeyCheckerForm_MouseClick(object sender, MouseEventArgs e) {
            ResetFieldValue();
        }

        private void ResetFieldValue() {
            if (string.IsNullOrEmpty(keyField.Text)) {
                keyField.Text = UIStringId.EnterLicenseKey;
                this.iconBox.Image = null;
            }
        }

        private void iconBox_MouseClick(object sender, MouseEventArgs e) {
            ResetFieldValue();
        }

        private void tableLayoutPanel1_MouseClick_1(object sender, MouseEventArgs e) {
            ResetFieldValue();
        }

        private void demoModecb_CheckedChanged(object sender, EventArgs e) {
            keyField.Enabled = false;
            SetIconSuccess();
            okButton.Enabled = ((CheckBox) sender).Checked;
        }

        private void keyField_TextChanged(object sender, EventArgs e) {
            if (((TextBox) sender).Text.Any()) {
                if (KeyChecker.IsValid(((TextBox) sender).Text)) {
                    SetIconSuccess();
                    this.okButton.Enabled = true;
                }
                else {
                    SeticonFail();
                    this.okButton.Enabled = false;
                }
            }
        }

        private void SeticonFail() {
            this.iconBox.Image = Utils.Utils.GetKeyValidationIcon("key_invalid", typeof (MainForm).Assembly);
        }

        private void SetIconSuccess() {
            this.iconBox.Image = Utils.Utils.GetKeyValidationIcon("key_valid", typeof (MainForm).Assembly);
        }

        private void okButton_Click(object sender, EventArgs e) {
            KeyChecker.RegisterKey(demoModecb.Checked ? Constants.DemoKey : keyField.Text);
            this.Close();
        }
    }
}
