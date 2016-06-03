using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace ITSupport.Lib
{
    public class Usuario
    {
        public string Nome { get; set; } //displayName\\
        public string Username { get; set; } //sAMAccountName\\
        public string Departamento { get; set; } //description\\
        public string Email { get; set; } //mail\\
        public string Ramal { get; set; } //telephoneNumber
        public string Cargo { get; set; } //title
        public string Superior { get; set; } //manager
        public string ScriptPath { get; set; } //scriptPath
        public string Matricula { get; set; } //pager
        public string Dominio { get; set; }

        //Informacoes AD
        public DateTime Created { get; set; }

        public DateTime AccountExpirationDate { get; set; }
        //Um DateTime que especifica a data e hora em que a conta expira ou null se a conta nunca expira. 
        public string DistinguishedName { get; set; } //O DN para esta entidade ou null se não houver nenhum DN.
        public string Enabled { get; set; }
        //true Se o objeto é ativado ou nulo se a conta não persistiu; Caso contrário, false.
        public DateTime LastLogon { get; set; }
        //Um Nullable DateTime que especifica a data e hora do último logon para esta conta. 
        public DateTime LastPasswordSet { get; set; }
        //Um Nullable DateTime que especifica a última data e hora em que a senha foi definida para esta conta.
        
    }

    public class Computador
    {
        public int Id { get; set; }

        //Location
        [Required]
        public string Hostname { get; set; }
        public string Localidade { get; set; }
        public string CentroCusto { get; set; }
        public string Status { get; set; } //Em Uso, em Reparo, bla bla
        [Required]
        public string Ativo { get; set; }
        public string LastUser { get; set; }
        public string Dominio { get; set; }

        //Hardware
        public string Tipo { get; set; }
        public string Fabricante { get; set; } //Win32_ComputerSystem - Manufacturer
        public string Modelo { get; set; } //Win32_ComputerSystem - Model

        public string Memoria { get; set; } //Win32_ComputerSystem - TotalPhysicalMemory
        public string Processador { get; set; } //Win32_Processor - Name
        public string HardDrive { get; set; }
        [Required]
        public string ServiceTag { get; set; } //Win32_BIOS - SerialNumber

        public string BiosVersion { get; set; } //Win32_BIOS - SMBIOSBIOSVersion
        public string DateBios { get; set; } //Win32_BIOS - Description
        public string FirstMonitor { get; set; } //Informações do Primeiro Monitor
        public string SecondMonitor { get; set; } //Informações do Segundo Monitor


        //McAfee Information
        public string AgentMcAfee { get; set; }
        public string EpoMcAfee { get; set; }
        public string EngineMcAfee { get; set; }
        public string DatMcAfee { get; set; }
    }

    public class SearchInformation
    {
        public string tipo { get; set; }
        public string descricao { get; set; }
    }

    //Controller RecursosHumanos
    public class Admissao
    {
        //Informacoes do Colaborador
        public DateTime DataInicio { get; set; }

        [Required]
        [Display(Name = "Nome Completo: ")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Data de Nascimento: ")]
        public DateTime DataNascimento { get; set; }
        
        [Required]
        [Display(Name = "R.G.: ")]
        public string Rg { get; set; }

        [Required]
        [Display(Name = "C.P.F: ")]
        public string Cpf { get; set; }

        [Required]
        [Display(Name = "Telefone Residencial: ")]
        public string TelefoneResidencial { get; set; }

        
        [Required]
        [Display(Name = "Telefone Celular: ")]
        public string TelefoneCelular { get; set; }

        [Required]
        [Display(Name = "Email Pessoal: ")]
        public string EmailPessoal { get; set; }


        [Required]
        [Display(Name = "Nome da Mae: ")]
        public string NomeMae { get; set; }

        [Required]
        [Display(Name = "Endereco: ")]
        public string Endereco { get; set; }

        [Required]
        [Display(Name = "CEP: ")]
        public string Cep { get; set; }

        [Required]
        [Display(Name = "Bairro: ")]
        public string Bairro { get; set; }

        [Required]
        [Display(Name = "Cidade: ")]
        public string Cidade { get; set; }

        [Required]
        [Display(Name = "Estado: ")]
        public string Estado { get; set; }


        /// <summary>
        /// INFORMACOOES DE CONTRATACAO
        /// </summary>
        [Required]
        [Display(Name = "Cargo: ")]
        public string Cargo { get; set; }

        public int JobLeveling { get; set; }

        public string VinculoEmpregaticio { get; set; }

        [Required]
        [Display(Name = "Matricula: ")]
        public int Matricula { get; set; }

        [Display(Name = "PeoPle Soft: ")]
        public int IdPeopleSoft { get; set; }
        
        public string CentroDeCusto { get; set; }

        public string Area { get; set; }

        public string UnidadeDeNegocio { get; set; }

        [Required]
        [Display(Name = "Gestor: ")]
        public string Gestor { get; set; }

        [Required]
        [Display(Name = "Matricula do Gestor: ")]
        public int MatriculaGestor { get; set; }


        public string LocalDeTrabalho { get; set; }


        public string Cliente { get; set; } //S ou N

        public string MotivoVaga { get; set; }
        public string Efetivacao { get; set; }

        public string VinculoAnterior { get; set; }


        //Informacoes sobre Infra-Estrutura
        public string AlteracaoLayout { get; set; }
        public string NovaEstacao { get; set; }
        public string NovoEquipamento { get; set; }
        public string NovoRamal { get; set; }
        public string NumeroRamal { get; set; }
        public string TipoEquipamento { get; set; }

        //Informacoes para E-mail
        public string GrupoDeEmail { get; set; }
        public string SugestaoDeEmail { get; set; }

        //Mapeamento de Perfis
        public string AcessoRede { get; set; }
        public string AcessoSalesForce { get; set; }
        public string AcessoAonAccess { get; set; }
        public string AcessoGams { get; set; }
        public string AcessoRelatoriosWeb { get; set; }
        public string AcessoMicrosiga { get; set; }
        public string AcessoCol { get; set; }
        public string AcessoInfraClient { get; set; }
        public string AcessoInfraManut { get; set; }
        public string OutrosAcessos { get; set; }

        public DateTime DataSolicitacao { get; set; }

    }




    //Controller Cadastro
    public class CadastroComputador
    {
        public int Id { get; set; }

        //Location
        public string Hostname { get; set; }
        public string Localidade { get; set; }
        public string CentroCusto { get; set; }
        public string Status { get; set; } //Em Uso, em Reparo, bla bla
        [Required]
        [Remote("DoesAtivoExist", "Cadastro", HttpMethod = "POST", ErrorMessage = "Este ativo ja esta cadastrado no Sistema, favor validar o Inventario.")]
        public string Ativo { get; set; }
        public string Dominio { get; set; }

        //Hardware
        public string Tipo { get; set; }
        public string Fabricante { get; set; } //Win32_ComputerSystem - Manufacturer
        public string Modelo { get; set; } //Win32_ComputerSystem - Model

        public string Memoria { get; set; } //Win32_ComputerSystem - TotalPhysicalMemory
        public string Processador { get; set; } //Win32_Processor - Name
        public string HardDrive { get; set; }
        [Required]
        [Display(Name = "Service TAG")]
        [Remote("DoesServiceTagExist", "Cadastro", HttpMethod = "POST", ErrorMessage = "Esta Service Tag ja esta cadastrado no sistema, favor validar o Inventario.")]
        public string ServiceTag { get; set; } //Win32_BIOS - SerialNumber

    }

    public class CadastroFabricante
    {
        [Required]
        public string FabricanteNome { get; set; }
        [Required]
        public string CNPJ { get; set; }
        public string WebSite { get; set; }

    }

    public class CadastroModelo
    {
        public string Fabricante { get; set; }
        public string ModeloNome { get; set; }
    }
}
