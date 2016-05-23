using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSupport.Lib
{
    public class Repositorio
    {
        private Contexto contexto;


        public void Inserir(Computador Computador)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            var strQuery = "";
            strQuery += " INSERT INTO tblComputer (Tipo, Fornecedor, Modelo, ServiceTag, Processador, HardDrive, Memoria, Hostname, Localidade, CentroCusto, Status, Ativo, LastUser, Datacadastro, DataUpdate) ";
            strQuery += string.Format(" VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}') ",

                Computador.Tipo,
                Computador.Fornecedor,
                Computador.Modelo,
                Computador.ServiceTag,
                Computador.Processador,
                Computador.HardDrive,
                Computador.Memoria,
                Computador.Hostname,
                Computador.Localidade,
                Computador.CentroCusto,
                Computador.Status,
                Computador.Ativo,
                null,
                sqlFormattedDate,
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
            strQuery += string.Format(" Fornecedor = '{0}', ", Computador.Fornecedor);
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
            strQuery += string.Format(" WHERE ID = {0} ", Computador.ID);
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }

        public void Salvar(Computador Computador)
        {
            if (Computador.ID > 0)
                Alterar(Computador);
            else
                Inserir(Computador);
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
            var Lista = new List<string>();
            while (reader.Read())
            {
                Lista.Add(reader.GetString(0));
            }
            reader.Close();
            return Lista;
        }


        public List<string> ListaColuna(string coluna, string tabela)
        {
            List<string> Listagem = Lista("SELECT DISTINCT " + coluna + " FROM " + tabela + "");

            return Listagem;
        }

        public List<string> ListaModelo(string modelo)
        {
            List<string> Listagem = Lista("Select Modelo from tblEquipamento where Fornecedor = '" + modelo + "' order by Modelo DESC");
            return Listagem;
        }

        public string Typeahead(string coluna, string tabela)
        {
            List<string> Users = ListaColuna(coluna, tabela);

            StringBuilder builder = new StringBuilder();
            foreach (string item in Users) // Loop through all strings
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
                            descricao = reader["hostname"].ToString() + " - " + reader["Fornecedor"].ToString()
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
