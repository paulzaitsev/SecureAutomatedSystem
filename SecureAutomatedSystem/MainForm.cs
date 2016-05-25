using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Globalization;
using System.IO;
using SecureAutomatedSystem.ProcessEmulation;
using SecureAutomatedSystem.Snapshot;

namespace SecureAutomatedSystem {
    public partial class MainForm : MetroForm {

        public MainForm() {
            InitializeComponent();
        }

        private Emulator factory;
        private string KeyForNextSession;

        private void OnProductProduced(object sender, EventArgs e) {
            textBox1.Text = factory.CurrentProduct.OuterDiameter.ToString();
            textBox2.Text = factory.CurrentProduct.OuterRadius.ToString();
            textBox3.Text = factory.CurrentProduct.InnerDiameter.ToString();
            textBox4.Text = factory.CurrentProduct.InnerRadius.ToString();
            textBox5.Text = factory.CurrentProduct.OuterPairingRadius.ToString();
            textBox6.Text = factory.CurrentProduct.WallThickness.ToString();
            textBox7.Text = factory.CurrentProduct.TopThickness.ToString();
            textBox8.Text = factory.CurrentProduct.BottomLowersectionHeight.ToString();
            textBox9.Text = factory.CurrentProduct.TopDiameter.ToString();
            textBox10.Text = factory.CurrentProduct.OuterPairingRadiusCyl.ToString();
        }

        private void RevertAccessibilityInProcessTab() {
            Stop.Enabled = !Stop.Enabled;
            Start.Enabled = !Start.Enabled;
            InputDelay.Enabled = !InputDelay.Enabled;
            textBox11.Enabled = !textBox11.Enabled;
            textBox12.Enabled = !textBox12.Enabled;
            textBox13.Enabled = !textBox13.Enabled;
            textBox14.Enabled = !textBox14.Enabled;
            textBox15.Enabled = !textBox15.Enabled;
            textBox16.Enabled = !textBox16.Enabled;
            textBox17.Enabled = !textBox17.Enabled;
            textBox18.Enabled = !textBox18.Enabled;
        }

        private void Start_Click(object sender, EventArgs e) {
            RevertAccessibilityInProcessTab();
            try {
                float p1 = Convert.ToSingle(textBox11.Text, new CultureInfo("en-US"));
                float p2 = p1/2;
                float p3 = Convert.ToSingle(textBox12.Text, new CultureInfo("en-US"));
                float p4 = p3/2;
                float p5 = Convert.ToSingle(textBox13.Text, new CultureInfo("en-US"));
                float p6 = Convert.ToSingle(textBox14.Text, new CultureInfo("en-US"));
                float p7 = Convert.ToSingle(textBox15.Text, new CultureInfo("en-US"));
                float p8 = Convert.ToSingle(textBox16.Text, new CultureInfo("en-US"));
                float p9 = Convert.ToSingle(textBox17.Text, new CultureInfo("en-US"));
                float p10 = Convert.ToSingle(textBox18.Text, new CultureInfo("en-US"));

                factory = new Emulator(Convert. ToSingle(InputDelay. Text), SavingInDB. Checked, EncryptInDB. Checked,
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
            factory. ProductProduced += OnProductProduced;
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

    }
}
