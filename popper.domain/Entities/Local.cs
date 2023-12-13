using popper.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popper.domain.Entities
{
    public class Local : BaseEntity<int>
    {
        public Local() { }

        public Local(int id, string? localdesc, Usuario? nome, Usuario? idUsuario):base(id)
        {
            Localdesc = localdesc;
            Nome = nome;
            IdUsuario = idUsuario; 
        }

        public string? Localdesc { get; set; }
        
        public virtual Usuario? IdUsuario { get; set; }

        public virtual Usuario? Nome { get;set; }

    }
}
