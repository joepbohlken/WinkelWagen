using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinkelWagenProgramma
{
    class Categorie
    {
        public string name = "Categorie";
        public List<string> CategorieList = new List<string>();
        public void addToCategorieList()
        {
            CategorieList.Add("Zuivel");
            CategorieList.Add("Vlees Ware");
            CategorieList.Add("Groente");
            CategorieList.Add("Fruit");
            CategorieList.Add("Snoep");
        }
    }
}
