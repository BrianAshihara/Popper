using popper.domain.Base;

namespace popper.domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario()
        {

        }

        public Usuario(int id, string? nome, string? cpf):base(id)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public string? Nome { get; set; }
        public string? Cpf { get; set;}
    }
}
