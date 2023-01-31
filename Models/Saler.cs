using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_tech_test_api_tech.Models
{
    public class Saler
    {
        public int Id {get; set;}
        public string CPF {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Telefone {get; set;}
        public string Status {get; set;}
        public string Itens {get; set;}
        public bool IfAny()
        {
            if (CPF == null ||
            Nome == null ||
            Email == null ||
            Telefone == null ||
            Itens == null) return false; else return true;
        }
    }
}
