using site01.library.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace site01.Models
{
    public class Palavra
    {

        public int  id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MaxLength(70, ErrorMessage = "O campo Nome deve conter no máximo 70 caracteres")]
        [UnicoNomePalavra]
        public string Nome { get; set; }

        // 1 facil 2 medio 3 dificil
        [Range(1,3, ErrorMessage ="Favor digitar um nível de 1 até 3")]
        public byte? Nivel { get; set; }

    }
}
