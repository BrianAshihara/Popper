using popper.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popper.domain.Entities
{
    public class Tecnico : BaseEntity<int>
    {
        public Tecnico() { }

        public Tecnico(int id, string? nome, string? endereco): base(id)  
        {
            Nome = nome;
            Endereco = endereco;
        }

        public string? Nome { get; set; }
        public string? Endereco { get; set; }
    }
}
