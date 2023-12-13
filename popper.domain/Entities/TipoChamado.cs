using popper.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popper.domain.Entities
{
    public class TipoChamado : BaseEntity<int>
    {
        public TipoChamado()
        {

        }

        public TipoChamado(int id, Tecnico? idtecnico, string? tipo): base(id) 
        {
            Tecnico = idtecnico;
            Tipo = tipo;
        }
        public virtual Tecnico? Tecnico { get; set; }

        public string Tipo { get; set; }
    }
}
