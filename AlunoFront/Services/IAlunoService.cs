using AlunoFront.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlunoFront.Services
{
    public interface IAlunoService
    {
        Task<List<Aluno>> GetAlunos();
        int GetQuantidadeAprovados(List<Aluno> alunos);
        int GetQuantidadeReprovados(List<Aluno> alunos);
    }
}
