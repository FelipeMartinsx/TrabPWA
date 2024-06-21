using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlunoModel;

namespace AlunoInfra.DAOs
{
    public class AlunoDAO : BaseDAO<Aluno>
    {
        public override string NomeTabela => "Aluno";

        public override Mapa[] Mapas => new Mapa[]
        {
            new() { Propriedade = "Id", Campo = "id" },
            new() { Propriedade = "Nome", Campo = "nome" },
            new() { Propriedade = "Matricula", Campo = "matricula" },
            new() { Propriedade = "Email", Campo = "email" },
            new() { Propriedade = "Situacao", Campo = "situacao" }
        };
    }
}