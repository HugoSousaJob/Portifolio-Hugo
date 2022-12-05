using EmpresaDescricaoWcfService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
//using Portifolio.Data.Dtos.EmpresaService;

namespace EmpresaDescricaoWcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IEmpresaService
    {

        [OperationContract]
        List<Empresa> GetAll();   
    }  
}
