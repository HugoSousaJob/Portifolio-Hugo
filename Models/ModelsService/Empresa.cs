using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Models.ModelsService
{
    public class Empresa
    {
        [Key]
        [Required]
        public int IdEmpresa { get; set; }
        [Required(ErrorMessage = "o campo descrição é obrigatorio")]
        public string Descricao { get; set; }

        public string NomeEmpresa { get; set; }
    }
}
