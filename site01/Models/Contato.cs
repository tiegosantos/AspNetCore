using site01.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace site01.Models
{
    public class Contato
    {
        [Required(ErrorMessage ="O campo Nome é obrigatório")]
        [MaxLength(50,ErrorMessage = "O campo Nome deve conter no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo E-mail é obrigatório")]
        [MaxLength(70, ErrorMessage = "O campo Nome deve conter no máximo 70 caracteres")]
        [EmailAddress (ErrorMessage = "E-mail no formato incorreto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Assunto é obrigatório")]
        [MaxLength(70, ErrorMessage = "O campo Nome deve conter no máximo 70 caracteres")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "O campo Mensagem é obrigatório")]
        [MaxLength(2000, ErrorMessage = "O campo Nome deve conter no máximo 2000 caracteres")]
        public string Mensagem { get; set; }

        public static implicit operator Contato(ContatoController v)
        {
            throw new NotImplementedException();
        }
    }
}
