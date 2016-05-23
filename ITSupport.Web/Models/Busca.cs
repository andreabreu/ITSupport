using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITSupport.Web.Models
{
    public class Search
    {
        public List<SearchInformation> Searching(string q) {


            Repositorio Repo = new Repositorio();
            SearchInformation Resultado = new SearchInformation();
           // SearchInformation BuscaUser = Repo.BuscaUsername(q);
            List<SearchInformation> BuscaAsset = Repo.Buscar(q, Resultado);
            // SearchInformation BuscaUser = Repo.BuscaUsername(q);

            
            
            return BuscaAsset;
        }

    }
}