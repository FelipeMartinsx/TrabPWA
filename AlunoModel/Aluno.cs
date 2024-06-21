using System.Security.Cryptography;
using System.Text;

namespace AlunoModel;

public class Aluno : IModel
{
    public string? Id { get; set; }
    public string Nome { get; set; } = "";
    public string Matricula { get; set; } = "";
    public string Email { get; set; } = "";
    private string _senha = "";
    public string Senha
    {
        get => _senha;
        set => _senha = ComputeMD5Hash(value);
    }
    public string Token { get; set; } = "";
    public string Situacao { get; set; } = "";

    private string ComputeMD5Hash(string input)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}

