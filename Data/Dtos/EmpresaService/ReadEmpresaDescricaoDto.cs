using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Data.Dtos.EmpresaService
{
    public class ReadEmpresaDescricaoDto
    {
        [Required( ErrorMessage = "O Descricao título é obrigatório")]
        public string Descricao { get; set; }

        public string NomeEmpresa { get; set; }



    }
}
