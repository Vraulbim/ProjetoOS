using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PMBYOS.Library.Utils
{
    class HashPassword
    {
        private HashAlgorithm _algorithm;

        public HashPassword(HashAlgorithm algoritmo)
        {
            _algorithm = algoritmo;
        }

        public string criptograpyPassword(string password)
        {
            var encodedValue = Encoding.UTF8.GetBytes(password);
            var encryptedPassword = _algorithm.ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }

        public bool VerificarSenha(string senhaDigitada, string senhaCadastrada)
        {
            if (string.IsNullOrEmpty(senhaCadastrada))
            {
               MessageBox.Show("Usuário ou senha incorreta, verifique os dados e tente novamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var encryptedPassword = _algorithm.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada));

            var sb = new StringBuilder();
            foreach (var caractere in encryptedPassword)
            {
                sb.Append(caractere.ToString("X2"));
            }
            return sb.ToString() == senhaCadastrada;
        }
    }
}
