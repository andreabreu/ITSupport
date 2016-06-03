using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace ITSupport.Lib
{
    public class Contexto : IDisposable
    {
        private readonly SqlConnection _minhaConexao;

        public Contexto()
        {
            try
            {
                _minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnStrgHome"].ConnectionString);
                _minhaConexao.Open();
            }
            catch
            {
                _minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnStrgAon"].ConnectionString);
                _minhaConexao.Open();
            }
          
        }

        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = _minhaConexao
            };
            cmdComando.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var cmdComando = new SqlCommand(strQuery, _minhaConexao);
            return cmdComando.ExecuteReader();
        }
        

        public void Dispose()
        {
            if (_minhaConexao.State == ConnectionState.Open)
                _minhaConexao.Close();
        }
    }
}