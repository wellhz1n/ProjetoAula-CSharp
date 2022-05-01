using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaEdy.Classes
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public string Email { get; set; }




        public Usuario()
        {
        }
        public bool ValidaCpf()
        {
            return Cpf.Length == 11;
        }

        public bool VerificarNome()
        {
            return !string.IsNullOrEmpty(Nome);
        }

        public bool EmailValido()
        {
            return !string.IsNullOrEmpty(Email) && Email.Contains("@");
        }


    }
}
