using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace AlunoFront.Models.Validators
{
    public class AlunoValidator : Validator<Aluno>
    {
        public AlunoValidator()
        {
            AddRule(p => p.Nome).NotEmpty().NotNull().WithMessage("Nome não pode ser nulo ou vazio");
            AddRule(p => p.Nome).MinimumLength(3).WithMessage("Nome deve ter entre 3 e 10 caracteres");
            AddRule(p => p.Nome).MaximumLength(10).WithMessage("Nome deve ter entre 3 e 10 caracteres");
            AddRule(p => p.Nome).Matches("^[a-zA-Z0-9_]*$").WithMessage("Nome não pode ter caracteres especiais");
            AddRule(p => p.Nome).Length(0, 255).WithMessage("Nome não pode ter mais do que 255 caracteres");
            AddRule(p => p.Matricula).MinimumLength(3).WithMessage("Matricula deve ter entre 3 e 10 caracteres");
        }
    }
}