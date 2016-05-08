using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecureAutomatedSystem.DemoMode;
using SecureAutomatedSystem.DemoMode.UI;
using SecureAutomatedSystem.Utils;

namespace SecureAutomatedSystem {
    static class AppRunner {
        public static void Run() {
            if (!RegisterUtils.CheckRegister()) {
                Application.Run(new KeyCheckerForm());
            }
            if(KeyChecker.IsValidKey)
                Application.Run(new MainForm());
        }

        public static string EncryptionKey {
            get; set;
        }
    }
}
