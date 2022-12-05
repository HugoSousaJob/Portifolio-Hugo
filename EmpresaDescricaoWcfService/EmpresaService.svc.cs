using EmpresaDescricaoWcfService.Data;
using EmpresaDescricaoWcfService.Model;
using System;
using System.Collections.Generic;

namespace EmpresaDescricaoWcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IEmpresaService
    {
        public List<Empresa> GetAll()
        {
            EmpresaDAL EmpresaDal = new EmpresaDAL();
            return EmpresaDal.getAll();
        }
    
    }
}
