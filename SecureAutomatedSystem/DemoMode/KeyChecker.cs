using System;
using System.Linq;
using SecureAutomatedSystem.Utils;

namespace SecureAutomatedSystem.DemoMode {
    public static class KeyChecker {
        public static string ValidLicenseKey { get; private set; }
        public static bool IsValidKey {
            get { return IsValid(ValidLicenseKey) || RegisterUtils.CheckRegister(); }
        }

        public static bool IsRegisterDemoKey {
            get {
                if (RegisterUtils.CheckRegister()) {
                    string demoKeyMD5 = CryptoUtils.GetMd5Hash(Constants.DemoKey);
                    return string.Equals(RegisterUtils.GetRegisterKeyValue(), demoKeyMD5);
                }
                return false;
            }
        }

        public static void RegisterKey(string key) {
            if (IsValid(key)) {
                ValidLicenseKey = key;
                RegisterUtils.SetInRegister(key);
            }
        }

        public static bool IsValid(string key) {
            if (string.Equals(key, Constants.DemoKey))
                return true;
            if (string.IsNullOrEmpty(key))
                return false;
            if (string.Equals(key, StringId.EnterLicenseKey))
                return false;
            if (key.Length != Constants.ValidKeyLenght)
                return false;
            return Validate(key);
        }

        static bool Validate(string key) {
            string left = key.Substring(0, Constants.ValidKeyLenght/2);
            string right = key.Substring(3, Constants.ValidKeyLenght/2);
            return left.Sum(x => Convert.ToInt32(x)) == right.Sum(x => Convert.ToInt32(x));
        }
    }
}
