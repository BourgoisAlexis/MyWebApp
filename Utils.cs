using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;
using Microsoft.JSInterop;

namespace BlazorApp1 {
    public static class Utils {
        public static string GenerateNonce() {
            const string chars = "abcdefghijklmnopqrstuvwxyz123456789";
            var random = new Random();
            var nonce = new char[128];
            for (int i = 0; i < nonce.Length; i++) {
                nonce[i] = chars[random.Next(chars.Length)];
            }

            return new string(nonce);
        }

        public static string GenerateCodeChallenge(string codeVerifier) {
            using var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(codeVerifier));
            var b64Hash = Convert.ToBase64String(hash);
            var code = Regex.Replace(b64Hash, "\\+", "-");
            code = Regex.Replace(code, "\\/", "_");
            code = Regex.Replace(code, "=+$", "");
            return code;
        }
    }
}
