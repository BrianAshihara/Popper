using popper.domain.Base;

namespace popper.domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario()
        {

        }

        public Usuario(int id, string? nome, string? endereco):base(id)
        {
            Nome = nome;
            Endereco = endereco; 
        }

        public string? Nome { get; set; }
        public string? Endereco { get; set; }
    }
}
