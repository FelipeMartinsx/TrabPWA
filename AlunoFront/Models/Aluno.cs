using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlunoFront.Models.Validators;

namespace AlunoFront.Models
{
    public class Aluno: Modelo<Aluno>
    {
        public string Nome { get; set; } = "";
        public string Matricula { get; set; }
        public string Email { get; set; }
        public string Situacao { get; set; }

        public override void ConfigValidator(out Validator<Aluno> validator, out Aluno obj)
        {
            validator = new AlunoValidator();
            obj = this;
        }
    }
}
