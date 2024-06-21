using AlunoFront.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoFront.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly List<Aluno> _alunos = new List<Aluno>
        {
            new Aluno { Id = "1", Nome = "João", Situacao = "Aprovado" },
            new Aluno { Id = "2", Nome = "Maria", Situacao = "Reprovado" },
            new Aluno { Id = "3", Nome = "José", Situacao = "Estudante" }
        };

        public Task<List<Aluno>> GetAlunos()
        {
            return Task.FromResult(_alunos);
        }

        public int GetQuantidadeAprovados(List<Aluno> alunos)
        {
            return alunos.Count(a => a.Situacao == "Aprovado");
        }

        public int GetQuantidadeReprovados(List<Aluno> alunos)
        {
            return alunos.Count(a => a.Situacao == "Reprovado");
        }
    }
}
