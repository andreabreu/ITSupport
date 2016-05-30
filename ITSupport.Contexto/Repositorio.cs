using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ITSupport.Lib
{
    public class Repositorio
    {
        private Contexto contexto;


        public void Inserir(Computador computador)
        {
            var myDateTime = DateTime.Now;

            var strQuery = "";
            strQuery += " INSERT INTO tblComputador (Tipo, Fabricante, Modelo, ServiceTag, Processador, HardDrive, Memoria, Hostname, CentroCusto, Status, Ativo, DataCadastro, DataUpdate) ";
            strQuery += string.Format(" VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}', `{12}`) ",

                computador.Tipo,
                computador.Fabricante,
                computador.Modelo,
                computador.ServiceTag,
                computador.Processador,
                computador.HardDrive,
                computador.Memoria,
                computador.Hostname,
                computador.CentroCusto,
                computador.Status,
                computador.Ativo,
                myDateTime,
                null);
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }

        private void Alterar(Computador Computador)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            var strQuery = "";
            strQuery += " UPDATE tblComputer SET ";
            strQuery += string.Format(" Tipo = '{0}', ", Computador.Tipo);
            strQuery += string.Format(" Fornecedor = '{0}', ", Computador.Fabricante);
            strQuery += string.Format(" Modelo = '{0}', ", Computador.Modelo);
            strQuery += string.Format(" ServiceTag = '{0}', ", Computador.ServiceTag);
            strQuery += string.Format(" Processador = '{0}', ", Computador.Processador);
            strQuery += string.Format(" HardDrive = '{0}', ", Computador.HardDrive);
            strQuery += string.Format(" Memoria = '{0}', ", Computador.Memoria);
            strQuery += string.Format(" Hostname = '{0}', ", Computador.Hostname);
            strQuery += string.Format(" Localidade = '{0}', ", Computador.Localidade);
            strQuery += string.Format(" CentroCusto = '{0}', ", Computador.CentroCusto);
            strQuery += string.Format(" Status = '{0}', ", Computador.Status);
            strQuery += string.Format(" Ativo = '{0}', ", Computador.Ativo);
            strQuery += string.Format(" LastUser = '{0}', ", Computador.LastUser);
            strQuery += string.Format(" DataUpdate = '{0}' ", sqlFormattedDate);
            strQuery += string.Format(" WHERE ID = {0} ", Computador.Id);
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }

        public void Salvar(Computador computador)
        {
            if (computador.Id > 0)
                Alterar(computador);
            else
                Inserir(computador);
        }

        public SqlDataReader ChecaTagExiste(Computador computador)
        {

            var strQuery = "SELECT COUNT(*) from tblComputador where ServiceTag like '" + computador.ServiceTag + "'";

            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return retornoDataReader;
            }



        }




        public void Excluir(int id)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" DELETE FROM tblComputer WHERE ID = {0}", id);
                contexto.ExecutaComando(strQuery);
            }
        }

        public List<string> Lista(string query)
        {
            using (contexto = new Contexto())
            {
                var retornoDataReader = contexto.ExecutaComandoComRetorno(query);
                return TransformaReaderEmListaDeObjeto(retornoDataReader);
            }
        }

        private List<string> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var lista = new List<string>();
            while (reader.Read())
            {
                lista.Add(reader.GetString(0));
            }
            reader.Close();
            return lista;
        }


        public List<string> ListaColuna(string coluna, string tabela)
        {
            List<string> listagem = Lista("SELECT DISTINCT " + coluna + " FROM " + tabela + "");

            return listagem;
        }

        public List<string> ListaModelo(string modelo)
        {
            List<string> listagem = Lista("Select Modelo from tblEquipamento where Fornecedor = '" + modelo + "' order by Modelo DESC");
            return listagem;
        }

        public string Typeahead(string coluna, string tabela)
        {
            List<string> users = ListaColuna(coluna, tabela);

            StringBuilder builder = new StringBuilder();
            foreach (string item in users) // Loop through all strings
            {
                string itemnovo = "'" + item + "',";
                builder.Append(item).Replace(item, itemnovo.ToLower());

            }
            string result = builder.ToString();

            return result;


        }


        public List<SearchInformation> Buscar(string item, SearchInformation buscamerda)
        {
            using (contexto = new Contexto())
            {
                var strQuery = "SELECT DISTINCT * FROM tblLogins where logins like '%" + item + "%'";
                if (item.Contains("BR"))
                {
                    strQuery = string.Format("SELECT DISTINCT * FROM tblComputer where hostname like '%" + item + "%'");
                }

                //var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                //return TransformaEmListaDeObjeto(retornoDataReader).FirstOrDefault();

                var resultado = new List<SearchInformation>();
                SqlDataReader reader = contexto.ExecutaComandoComRetorno(strQuery);

                while (reader.Read())
                {
                    var temObjeto = new SearchInformation();


                    if (strQuery.Contains("tblComputer"))
                    {
                        temObjeto = new SearchInformation()
                        {
                            tipo = "<span class=\"glyphicon glyphicon-hdd\"></span>",
                            descricao = reader["hostname"] + " - " + reader["Fornecedor"]
                        };
                    }
                    if (strQuery.Contains("tblLogins"))
                    {
                        temObjeto = new SearchInformation()
                        {
                            tipo = "<span class=\"glyphicon glyphicon-user\"></span>",
                            descricao = reader.GetString(0)
                        };
                    }




                    resultado.Add(temObjeto);
                }
                reader.Close();

                return resultado;


            }


        }


        private List<SearchInformation> TransformaEmListaDeObjeto(SqlDataReader reader)
        {
            var usuarios = new List<SearchInformation>();
            while (reader.Read())
            {
                var temObjeto = new SearchInformation()
                {
                    tipo = "<span class=\"glyphicon glyphicon-user\"></span>",
                    descricao = reader["logins"].ToString()
                };
                usuarios.Add(temObjeto);
            }
            reader.Close();
            return usuarios;
        }
    }
}
