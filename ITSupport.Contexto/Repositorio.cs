using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ITSupport.Lib
{
    public class Repositorio
    {
        private Contexto contexto;

        public void InserirComputador(Computador computador)
        {
            var myDateTime = DateTime.Now;

            var strQuery = "";
            strQuery += " INSERT INTO tblComputador (Tipo, Fabricante, Modelo, ServiceTag, Processador, HardDrive, Memoria, Hostname, CentroCusto, Status, Ativo, DataCadastro, DataUpdate) ";
            strQuery += string.Format(" VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}', '{12}') ",

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

        public void InserirFabricante(CadastroFabricante fabricante)
        {
            var strQuery = "";
            strQuery += " INSERT INTO tblFabricante (FabricanteNome, CNPJ, WebSite) ";
            strQuery += string.Format(" VALUES ('{0}','{1}','{2}') ",

                fabricante.FabricanteNome,
                fabricante.CNPJ,
                fabricante.WebSite);
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }

        public void InserirModelo(CadastroModelo modelo)
        {
            var strQuery = "";
            strQuery += " INSERT INTO tblModelo (Fabricante, ModeloNome) ";
            strQuery += string.Format(" VALUES ('{0}','{1}') ",

                modelo.Fabricante,
                modelo.ModeloNome);
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }

        public void InserirUsuario(Usuario usuario)
        {
            var myDateTime = DateTime.Now;

            var strQuery = "";
            strQuery += " INSERT INTO tblUsuario (Nome, Username, Departamento, Email, Ramal, Cargo, Superior, ScriptPath, Matricula, Created, AccountExpirationDate, Enabled, LastLogon, LastPasswordSet, Domain) ";
            strQuery += string.Format(" VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}', '{12}', '{13}', '{14}') ",

                usuario.Nome,
                usuario.Username,
                usuario.Departamento,
                usuario.Email,
                usuario.Ramal,
                usuario.Cargo,
                usuario.Superior,
                usuario.ScriptPath,
                usuario.Matricula,
                usuario.Created,
                usuario.AccountExpirationDate,
                usuario.Enabled,
                usuario.LastLogon,
                usuario.LastPasswordSet,
                "br.aon.bz");
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }


        public List<string> ListaSelect(string filtro)
        {
            string query = "";

            if (filtro == "Fabricante")
            {
                query = "select distinct FabricanteID, FabricanteNome from tblFabricante order by FabricanteID ASC";
            }

            if (filtro == "Modelo")
            {
                query = "select distinct Fabricante, ModeloNome from tblModelo order by Fabricante ASC";
            }

            if (filtro == "Escritorio")
            {
                query = "select Nome, Cidade from tblEscritorio order by Cidade ASC";
            }

            if (filtro == "CentroDeCusto")
            {
                query = "Select CentroDeCustoID, CentroDeCustoNome from tblCentroDeCusto order by CentroDeCustoID ASC";
                
            }


            var lista = new List<string>();

            using (contexto = new Contexto())
            {
                SqlDataReader reader = contexto.ExecutaComandoComRetorno(query);

                while (reader.Read())
                {
                    if (filtro == "CentroDeCusto")
                    {
                        lista.Add("<option value='" + reader.GetString(0) + " - " + reader.GetString(1) + "'>" +
                                  reader.GetString(0) + " - " + reader.GetString(1) + "</option>");
                    }
                    else
                    {
                        lista.Add("<option value='" + reader.GetString(1) + "'>" + reader.GetString(1) + "</option>");
                    }
                    
                }
                reader.Close();
            }

            return lista;

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
                lista.Add(reader.GetInt32(0) + " " + reader.GetString(1));
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


        //Validacao
        public bool CheckExist(string database, string column, string field)
        {
            var strQuery = "SELECT * from " + database + " where " + column + " = '" + field + "'";

            using (contexto = new Contexto())
            {
                SqlDataReader retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                if (retornoDataReader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }


        }



    }
}
