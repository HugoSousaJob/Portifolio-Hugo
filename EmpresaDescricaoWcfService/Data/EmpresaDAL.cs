using EmpresaDescricaoWcfService.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmpresaDescricaoWcfService.Data
{
    public class EmpresaDAL
    {
      
        private readonly List<Empresa> listEmpresa = new List<Empresa>();
        
        public EmpresaDAL()
        {
          
        }
        public List<Empresa> getAll()
        {

            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmpresasConnectionString"].ToString());
            try
            {
                connection.Open();
                Empresa Empresa = new Empresa();
                SqlCommand cmd = new SqlCommand($"select descricao,nomeEmpresa from Empresa", connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Empresa.Descricao = dr["Descricao"].ToString();
                        Empresa.NomeEmpresa = dr["NomeEmpresa"].ToString();
                        listEmpresa.Add(Empresa);
                    }
                }
            }
            catch
            {
                connection.Close();
            }
            connection.Close();
            return listEmpresa;
        }

    }
}