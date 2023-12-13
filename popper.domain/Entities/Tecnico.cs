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

        public Tecnico(int id, string? nome, string? endereco, string? tipo): base(id)  
        {
            Nome = nome;
            Endereco = endereco;
            TipoChamado = tipo;
        }

        public string? Nome { get; set; }
        public string? Endereco { get; set; }

        public string? TipoChamado { get; set; }

    }
}
