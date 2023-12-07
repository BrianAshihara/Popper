using popper.domain.Base;

namespace popper.domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario()
        {

        }

        public Usuario(int id, string? nome):base(id)
        {
            Nome = nome;        }

        public string? Nome { get; set; }
    }
}
