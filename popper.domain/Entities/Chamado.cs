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

        public Chamado(int id, string? desc, string? status, DateTime? hora, Usuario? usuario_idusuario, Tecnico? tecnico_idtecnico, TipoChamado? tipochamado_idtipochamado, Local? local_idlocal, Usuario? nome, string tipo ):base(id)
        {
            Desc = desc;
            Status = status;
            Hora = hora;
            Usuario_idusuario = usuario_idusuario;
            Tecnico_idtecnico = tecnico_idtecnico;
            TipoChamado_idtipochamado = tipochamado_idtipochamado;
            Local_idlocal = local_idlocal;
        }
        public string? Desc { get; set; }
        public string? Status { get; set; }
        public DateTime? Hora { get; set;}

        public Usuario? Usuario_idusuario { get;}
        
        public Tecnico? Tecnico_idtecnico { get; }

        public TipoChamado? TipoChamado_idtipochamado { get;}

        public Local? Local_idlocal { get;}

        public Usuario? Nome { get; set;}

        public TipoChamado? Tipo { get; set;}
    }
}
