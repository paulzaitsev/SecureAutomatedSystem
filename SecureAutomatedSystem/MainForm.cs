using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SecureAutomatedSystem.Modules.Views;
using System.Globalization;

namespace SecureAutomatedSystem {
    public partial class MainForm : MetroForm {
        
        public MainForm() {
            InitializeComponent();
            
        }
        private Emulator factory;

        private void GetCurrentProduct()
        {
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

        private void RevertAccessibilityInProcessTab()
        {
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

        private void Start_Click(object sender, EventArgs e)
        {
            RevertAccessibilityInProcessTab();
            try
            {             
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
                factory = new Emulator(Convert.ToSingle(InputDelay.Text),SavingInDB.Checked,EncryptInDB.Checked, new Product(p1,p2,p3,p4,p5,p6,p7,p8,p9,p10));
            }
            catch
            {
                MessageBox.Show("All parameters must be float and use point delimiter! Start session with default settings.", "Error", MessageBoxButtons.OK);
                factory = new Emulator();
            }
            
            factory.ProductProduced += GetCurrentProduct;
            factory.StartProducing();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            RevertAccessibilityInProcessTab();            
            factory.StopProducing();
        }

        private void SavingInDB_CheckedChanged(object sender, EventArgs e)
        {
            EncryptInDB.Enabled = !EncryptInDB.Enabled;
            factory.SaveInDB = !factory.SaveInDB;
        }

        private void EncryptInDB_CheckedChanged(object sender, EventArgs e)
        {
            factory.EncryptData = !factory.EncryptData;
        }
    }
}
