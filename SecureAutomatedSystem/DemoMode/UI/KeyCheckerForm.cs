using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using SecureAutomatedSystem.Utils;

namespace SecureAutomatedSystem.DemoMode.UI {
    public partial class KeyCheckerForm : MetroForm {
        public KeyCheckerForm() {
            InitializeComponent();
            CheckLicenseInfo();
        }

        public EventHandler LicenseChanged;
        private void CheckLicenseInfo() {
            this.demoModecb.Checked = KeyChecker.IsRegisterDemoKey;
            if (RegisterUtils.CheckRegister()) {
                SetIconSuccess();
                this.keyField.Enabled = true;
            }
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
                keyField.Text = StringId.EnterLicenseKey;
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
            bool check = ((CheckBox) sender).Checked;
            keyField.Enabled = !check;
            if (check)
                SetIconSuccess();
            else SeticonFail();
            okButton.Enabled = check;
        }

        private void keyField_TextChanged(object sender, EventArgs e) {
            if (((TextBox) sender).Text.Any()) {
                if (KeyChecker.IsValid(((TextBox) sender).Text)) {
                    SetIconSuccess();
                    this.okButton.Enabled = true;
                    this.demoModecb.Checked = false;
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
            if (LicenseChanged != null)
                LicenseChanged(this, EventArgs.Empty);
            this.Close();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e) {

        }
    }
}
