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
    public enum AppMode {
        DemoMode,
        LicensedMode
    }

    static class AppRunner {
        public static void Run() {
            var mainForm = new MainForm();
            if (!RegisterUtils.CheckRegister()) {
                Application.Run(new KeyCheckerForm());
            }
            if(KeyChecker.IsValidKey)
                Application. Run(mainForm);
        }

        public static AppMode CurrentAppMode {
            get {
                return KeyChecker.IsRegisterDemoKey ? AppMode.DemoMode : AppMode.LicensedMode;
            }
        }

        public static string EncryptionKey {
            get; set;
        }
    }
}
