using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using SecureAutomatedSystem.Utils;

namespace SecureAutomatedSystem.Snapshot {
    public partial class SnapshotForm : MetroForm {
        public SnapshotForm() {
            InitializeComponent();
            outer_diameter_chart.BindToData("outer_diameter", AppRunner.EncryptionKey);
            inner_diameter_chart.BindToData("inner_diameter", AppRunner.EncryptionKey);
            outer_radius_chart.BindToData("outer_radius", AppRunner.EncryptionKey);
            inner_radius_chart.BindToData("inner_radius", AppRunner.EncryptionKey);
            ogive_pairing_radius_chart.BindToData("outer_pairing_radius", AppRunner.EncryptionKey);
            wall_thickness_chart.BindToData("wall_thickness", AppRunner.EncryptionKey);
            top_diameter_chart.BindToData("top_diameter", AppRunner.EncryptionKey);
            top_thickness_chart.BindToData("top_thickness", AppRunner. EncryptionKey);
            bottom_lowersection_height_chart.BindToData("bottom_lowersection_height", AppRunner.EncryptionKey);
            outer_pairing_radius_cyl_chart.BindToData("outer_pairing_radius_cylindrical_ogive", AppRunner.EncryptionKey);
        }
    }
}
