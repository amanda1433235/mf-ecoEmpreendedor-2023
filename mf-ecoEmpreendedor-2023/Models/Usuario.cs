using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_ecoEmpreendedor_2023.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de nascimento!")]
        [Display(Name = "Data de Nascimento")]
        public string DataNasc { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o endereço!")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o login!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o telefone!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o RG!")]
        [Display(Name = "RG")]
        public int Rg { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o CPF!")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }



    }
}
