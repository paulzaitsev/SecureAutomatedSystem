using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureAutomatedSystem.Utils {
    static class Utils {
        public static Bitmap CreateBitmapFromResources(string name, System.Reflection.Assembly asm) {
            return (Bitmap)CreateImageFromResources(name, asm);
        }
        public static Image CreateImageFromResources(string name, System.Reflection.Assembly asm) {
            System.IO.Stream stream = asm.GetManifestResourceStream(name);
            return Image.FromStream(stream);
        }
    }
}
