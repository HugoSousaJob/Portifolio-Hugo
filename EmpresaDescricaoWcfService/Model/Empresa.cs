using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpresaDescricaoWcfService.Model
{
    public class Empresa
    { 
        public int IdEmpresa { get; set; } 
        public string Descricao { get; set; }
        public string NomeEmpresa { get; set; }
    }
}