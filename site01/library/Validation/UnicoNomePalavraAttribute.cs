using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using site01.Database;
using site01.Models;

namespace site01.library.Validation
{
    public class UnicoNomePalavraAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            Palavra palavra = validationContext.ObjectInstance as Palavra;
            var _Db = (DatabaseContext)validationContext.GetService(typeof(DatabaseContext));

            // ja existe no banco 1 registro que tenha o mesmo nome
            // verificar se nome ja existe
            // verificar se o id é o mesmo do registro no banco


            var palavraBanco = _Db.Palavras.Where(a => a.Nome == palavra.Nome && a.id != palavra.id).FirstOrDefault();
            if (palavraBanco == null)

            {

                return ValidationResult.Success;

            }
            else
            {

                return new ValidationResult("A palavra ' " + palavra.Nome +  " ' já está sendo utilizada");

            }

        }

    }
}
