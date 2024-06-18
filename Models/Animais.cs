using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViuMeuPet_ProjetoFinal.Models
{
    [Table("Animais")]
    public class Animais
    {
        [Column("AnimaisId")]
        [Display(Name = "Código")]
        public int AnimaisId { get; set; }

        [Column("AnimalNome")]
        [Display(Name = "Nome do animal")]
        public string AnimalNome { get; set; } = string.Empty;

        [Column("AnimalRaca")]
        [Display(Name = "Raça do animal")]
        public string AnimalRaca { get; set; } = string.Empty;

        [Column("AnimalTipo")]
        [Display(Name = "Tipo do animal")]
        public string AnimalTipo { get; set; } = string.Empty;

        [Column("AnimalCor")]
        [Display(Name = "Cor do animal")]
        public string AnimalCor { get; set; } = string.Empty;

        [Column("AnimalSexo")]
        [Display(Name = "Sexo do animal")]
        public string AnimalSexo { get; set; } = string.Empty;

        [Column("AnimalObservacao")]
        [Display(Name = "Observações do animal")]
        public string AnimalObservacao { get; set; } = string.Empty;

        [Column("AnimalFoto")]
        [Display(Name = "Foto do animal")]
        public string AnimalFoto { get; set; } = string.Empty;

        [Column("AnimalDtDesaparecimento")]
        [Display(Name = "Data do desaparecimento do animal")]
        public DateTime AnimalDtDesaparecimento { get; set; }

        [Column("AnimalDtEncontro")]
        [Display(Name = "Data do encontro do animal")]
        public DateTime? AnimalDtEncontro { get; set; }

        [Column("AnimalStatus")]
        [Display(Name = "Status do animal")]
        public byte AnimalStatus { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
