﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace ITSupport.Lib
{
    public class Contexto : IDisposable
    {
        private readonly SqlConnection minhaConexao;

        public Contexto()
        {
            string srtConnectionLocal = @"Data Source =.\SQLEXPRESS; Initial Catalog = dbITSupport; Integrated Security = SSPI;";
            

            string strAon = "server=BRSP015884;Trusted_Connection=yes;database=dbITSupport; user id=andre_abreu_trp;password=Suporte01; connection timeout=5";
            try
            {
                minhaConexao = new SqlConnection(srtConnectionLocal);
                minhaConexao.Open();
            }
            catch
            {
                minhaConexao = new SqlConnection(strAon);
                minhaConexao.Open();
            }
          
        }

        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = minhaConexao
            };
            cmdComando.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var cmdComando = new SqlCommand(strQuery, minhaConexao);
            return cmdComando.ExecuteReader();
        }
        

        public void Dispose()
        {
            if (minhaConexao.State == ConnectionState.Open)
                minhaConexao.Close();
        }
    }
}