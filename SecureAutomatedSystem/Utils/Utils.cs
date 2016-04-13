using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureAutomatedSystem.Utils {
    public static class Utils {
        public static Bitmap GetKeyValidationIcon(string name, System.Reflection.Assembly asm) {
            return CreateBitmapFromResources(string.Format("SecureAutomatedSystem.DemoMode.UI.Icons.{0}.png", name), asm);
        }

        public static Bitmap CreateBitmapFromResources(string name, System.Reflection.Assembly asm) {
            return (Bitmap)CreateImageFromResources(name, asm);
        }
        public static Image CreateImageFromResources(string name, System.Reflection.Assembly asm) {
            System.IO.Stream stream = asm.GetManifestResourceStream(name);
            return Image.FromStream(stream);
        }
    }

    public static class UIStringId {
        public const string EnterLicenseKey = "Enter license key";
    }

    public static class Constants {
        public static int ValidKeyLenght = 10;
        public static string DemoKey = "DemoKey";
    }
}
