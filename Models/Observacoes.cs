using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViuMeuPet_ProjetoFinal.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacoesId")]
        [Display(Name = "Código")]
        public int ObservacoesId { get; set; }

        [Column("ObservacoesDescricao")]
        [Display(Name = "Descrição")]
        public string ObservacoesDescricao { get; set; } = string.Empty;

        [Column("ObservacoesLocal")]
        [Display(Name = "Local")]
        public string ObservacoesLocal { get; set; } = string.Empty;

        [Column("ObservacoesData")]
        [Display(Name = "Local")]
        public DateTime ObservacoesData { get; set; }

        [ForeignKey("AnimaisId")]
        public int AnimaisId { get; set; }
        public Animais? Animais { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }


    }
}
