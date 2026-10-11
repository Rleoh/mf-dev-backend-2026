using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2026.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O perfil é obrigatório")]
        public Perfil Perfil { get; set; }
    }

   public enum Perfil
    {
        Admin,
        User
    }
}
