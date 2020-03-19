using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    class Usuario
    {
        public string login { get; set; }
        public string senha { get; set; }
        

        public Boolean autenticar()
        {
            if (login == "joao" && senha == "123")
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
