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

        public Chamado(int id, string? desc, string? status, Usuario? usuario_idusuario, Tecnico? tecnico_idtecnico, TipoChamado? tipochamado_idtipochamado, Local? local_idlocal, Usuario? nome, string? tipo, Tecnico? tecnico ):base(id)
        {
            Desc = desc;
            Status = status;
            Usuario_idusuario = usuario_idusuario;
            Tecnico_idtecnico = tecnico_idtecnico;
            TipoChamado_idtipochamado = tipochamado_idtipochamado;
            Local_idlocal = local_idlocal;
            Tipo = tipo;
        }
        public string? Desc { get; set; }
        public string? Status { get; set; }

        public virtual Usuario? Usuario_idusuario { get; set; }
        
        public virtual Tecnico? Tecnico_idtecnico { get; set; }

        public virtual TipoChamado? TipoChamado_idtipochamado { get;}

        public virtual Local? Local_idlocal { get; set; }

        public virtual Usuario? Nome { get; set;}

        public virtual Tecnico? Tecnico { get; set;}
        

        public string? Tipo { get; set;}
    }
}
