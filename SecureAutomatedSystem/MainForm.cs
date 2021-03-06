﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Globalization;
using System.IO;
using MetroFramework;
using SecureAutomatedSystem.DemoMode.UI;
using SecureAutomatedSystem.ProcessEmulation;
using SecureAutomatedSystem.Snapshot;

namespace SecureAutomatedSystem {
    public partial class MainForm : MetroForm {

        public MainForm() {
            InitializeComponent();
            LoadSuggestedparams();
            CheckLicense();
        }

        private void CheckLicense() {
            //this.EncryptInDB.Enabled = AppRunner.CurrentAppMode != AppMode.DemoMode;
            this.InputDelay.Enabled = AppRunner.CurrentAppMode != AppMode.DemoMode;
        }

        private CultureInfo culture = new CultureInfo("en-US");
        private void LoadSuggestedparams() {
            Product product = new Product();
            try {
                product.DeserializeFromXml("SuggestedParams.xml");
            }
            catch (Exception e) {
                Debug.WriteLine(e.Message);
            }
            textBox11. Text = product. OuterDiameter. ToString(culture);
            textBox15. Text = product. TopThickness. ToString(culture);
            textBox12. Text = product. InnerDiameter. ToString(culture);
            textBox16. Text = product. BottomLowersectionHeight. ToString(culture);
            textBox13. Text = product. OuterPairingRadius. ToString(culture);
            textBox17. Text = product. TopThickness. ToString(culture);
            textBox14. Text = product. WallThickness. ToString(culture);
            textBox18. Text = product. OuterPairingRadiusCylindricalOgive. ToString(culture);
        }

        private Emulator factory;
        private string KeyForNextSession;

        private void OnProductProduced(object sender, EventArgs e) {
            textBox1.Text = factory.CurrentProduct.OuterDiameter.ToString(culture);
            textBox2.Text = factory.CurrentProduct.OuterRadius.ToString(culture);
            textBox3.Text = factory.CurrentProduct.InnerDiameter.ToString(culture);
            textBox4.Text = factory.CurrentProduct.InnerRadius.ToString(culture);
            textBox5.Text = factory.CurrentProduct.OuterPairingRadius.ToString(culture);
            textBox6.Text = factory.CurrentProduct.WallThickness.ToString(culture);
            textBox7.Text = factory.CurrentProduct.TopThickness.ToString(culture);
            textBox8.Text = factory.CurrentProduct.BottomLowersectionHeight.ToString(culture);
            textBox9.Text = factory.CurrentProduct.TopDiameter.ToString(culture);
            textBox10.Text = factory.CurrentProduct.OuterPairingRadiusCylindricalOgive.ToString(culture);
        }

        private void RevertAccessibilityInProcessTab() {
            Stop.Enabled = !Stop.Enabled;
            Start.Enabled = !Start.Enabled;
            InputDelay.Enabled = !InputDelay.Enabled && AppRunner.CurrentAppMode != AppMode.DemoMode;
            //textBox11.Enabled = !textBox11.Enabled;
            //textBox12.Enabled = !textBox12.Enabled;
            //textBox13.Enabled = !textBox13.Enabled;
            //textBox14.Enabled = !textBox14.Enabled;
            //textBox15.Enabled = !textBox15.Enabled;
            //textBox16.Enabled = !textBox16.Enabled;
            //textBox17.Enabled = !textBox17.Enabled;
            //textBox18.Enabled = !textBox18.Enabled;
        }

        private void Start_Click(object sender, EventArgs e) {
            RevertAccessibilityInProcessTab();
            try {
                float p1 = Convert.ToSingle(textBox11.Text, culture);
                float p2 = p1/2;
                float p3 = Convert. ToSingle(textBox12. Text, culture);
                float p4 = p3/2;
                float p5 = Convert. ToSingle(textBox13. Text, culture);
                float p6 = Convert. ToSingle(textBox14. Text, culture);
                float p7 = Convert. ToSingle(textBox15. Text, culture);
                float p8 = Convert. ToSingle(textBox16. Text, culture);
                float p9 = Convert. ToSingle(textBox17. Text, culture);
                float p10 = Convert. ToSingle(textBox18. Text, culture);

                factory = new Emulator(Convert.ToSingle(InputDelay.Text), SavingInDB.Checked, EncryptInDB.Checked,
                    new Product(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
                if (KeyForNextSession != null) {
                    AppRunner.EncryptionKey = KeyForNextSession;
                }
            }
            catch {
                MessageBox.Show(
                    "All parameters must be float and use point delimiter! Start session with default settings.",
                    "Error", MessageBoxButtons.OK);
                factory = new Emulator();
            }
            factory.ProductProduced += OnProductProduced;
            factory.StartProducing();
        }

        private void Stop_Click(object sender, EventArgs e) {
            RevertAccessibilityInProcessTab();
            factory.StopProducing();
            KeyForNextSession = null;
        }

        private void SavingInDB_CheckedChanged(object sender, EventArgs e) {
            EncryptInDB.Enabled = !EncryptInDB.Enabled;
            if (factory != null) {
                factory.SaveInDB = !factory.SaveInDB;
            }            
        }

        private void EncryptInDB_CheckedChanged(object sender, EventArgs e) {
            SearchKeyButton.Enabled = !SearchKeyButton.Enabled;
            if (factory != null) {
                factory.EncryptData = !factory.EncryptData;
            }
        }

        private void snapshotTile_Click(object sender, EventArgs e) {
            using (SnapshotForm form = new SnapshotForm()) {
                form.ShowDialog();
            }
        }

        private void SearchKeyButton_Click(object sender, EventArgs e) {
            OpenFileDialog SearchKeyDialog = new OpenFileDialog();
            SearchKeyDialog.ShowDialog();
            FilePath.Text = SearchKeyDialog.FileName;
        }

        private void FilePath_TextChanged(object sender, EventArgs e) {
            try {
                using (StreamReader KeyReader = new StreamReader(@FilePath.Text)) {
                    string KeyForEncryption = KeyReader.ReadToEnd();
                    if (KeyForEncryption.Length != 8) {
                        MessageBox.Show("Key must contain 8 symbols. Statistic will be saved without encryption.",
                                        "Error", MessageBoxButtons.OK);
                    }
                    if (factory != null)
                        AppRunner.EncryptionKey = KeyForEncryption;
                    else
                        KeyForNextSession = KeyForEncryption;
                }
            }
            catch {
                MessageBox.Show("Can't find file with encryption key or file corrupted. Saving statistics without encryption",
                                       "Error", MessageBoxButtons.OK);
            }
        }

        private void licenseTile_Click(object sender, EventArgs e) {
            using (KeyCheckerForm form = new KeyCheckerForm()) {
                form. LicenseChanged += (s, ea) => {
                    CheckLicense();
                };
                form.ShowDialog();
            }
        }

        private void aboutTile_Click(object sender, EventArgs e) {
            string authorsString = "gr.230721 Inc.";
            MetroMessageBox.Show(this, authorsString, "Authors");
        }
    }
}
