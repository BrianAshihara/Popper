using popper.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popper.domain.Entities
{
    public class Chamado : BaseEntity<int>
    {
        public Chamado() { }

        public Chamado(int id, string? desc, Usuario? idusuario, Tecnico? idtecnico, TipoChamado? idtipochamado, Local? idlocal, string? tipo ):base(id)
        {
            Desc = desc;
            Usuario = idusuario;
            Tecnico = idtecnico;
            TipoChamado = idtipochamado;
            Local = idlocal;
            Tipo = tipo;
        }
        public string? Desc { get; set; }

        public virtual Usuario? Usuario { get; set; }
        
        public virtual Tecnico? Tecnico { get; set; }

        public virtual TipoChamado? TipoChamado { get;}

        public virtual Local? Local { get; set; }
        public string? Tipo { get; set;}
    }
}
