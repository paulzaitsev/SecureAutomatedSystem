using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SecureAutomatedSystem.Utils {
    public static class Utils {
        public static Bitmap GetKeyValidationIcon(string name, System.Reflection.Assembly asm) {
            return CreateBitmapFromResources(string.Format("SecureAutomatedSystem.DemoMode.UI.Icons.{0}.png", name), asm);
        }

        public static Bitmap CreateBitmapFromResources(string name, System.Reflection.Assembly asm) {
            return (Bitmap) CreateImageFromResources(name, asm);
        }

        public static Image CreateImageFromResources(string name, System.Reflection.Assembly asm) {
            System.IO.Stream stream = asm.GetManifestResourceStream(name);
            return Image.FromStream(stream);
        }
    }

    public static class RegisterUtils {
        public static void SetInRegister(string value) {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(StringId.RegistrySubKeyName)) {
                key.SetValue(StringId.LicenseKey, CryptoUtils.GetMd5Hash(value));
            }
        }

        public static bool CheckRegister() {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(StringId.RegistrySubKeyName)) {
                return key != null && key.GetValue(StringId.LicenseKey) != null;
            }
        }

        public static string GetRegisterKeyValue() {
            using (RegistryKey key = Registry. CurrentUser. OpenSubKey(StringId. RegistrySubKeyName)) {
                if (key != null && key.GetValue(StringId.LicenseKey) != null) {
                    return key.GetValue(StringId.LicenseKey).ToString();
                }
            }
            return string.Empty;
        }
    }

    public static class StringId {
        public const string EnterLicenseKey = "Enter license key";
        public const string LicenseKey = "Licensekey";
        public const string AppName = "SecureAutomatedSystem";
        public const string RegistrySubKeyName = "SOFTWARE" + "\\" + "SecureAutomatedSystem";
    }

    public static class Constants {
        public static int ValidKeyLenght = 6;
        public static string DemoKey = "DemoKey";
    }
}
