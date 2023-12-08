using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace InfnetMVC.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 4, ErrorMessage = "O nome deve conter, no mínimo, 4 caracteres.")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [Display(Name = "Nome do aluno")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório")]
        [Display(Name = "Endereço do aluno")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O telefone é obrigatório")]
        [Display(Name = "Telefone do aluno")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [Display(Name = "E-mail do aluno")]
        public int Email { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatório")]
        [Display(Name = "Data de nascimento do aluno")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DataDeNascimento { get; set; }
    }
    
}
