using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2026.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "O nome do veículo é obrigatório.")]
        public string nome { get; set; }

        [Required(ErrorMessage = "A placa do veículo é obrigatória.")]
        public string placa { get; set; }

        [Required(ErrorMessage = "O ano de fabricação do veículo é obrigatório.")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "O ano do modelo do veículo é obrigatório.")]
        public int AnoModelo { get; set; }
    }
}
