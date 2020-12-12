using System.ComponentModel.DataAnnotations;

namespace senac_sjrp.Models
{
    public class Pie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é Obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Descrição Curta é Obrigatório")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Campo Descrição Longa é Obrigatório")]
        public string LongDescription { get; set; }

        public decimal Price { get; set; }

        [Url(ErrorMessage = "Campo URL da Imagem é Obrigatório")]
        [Required(ErrorMessage = "Campo URL da Imagem não está em um formato correto ")]
        public string ImageUrl { get; set; }

        public decimal Discount { get; set; }

    }
}