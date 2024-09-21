using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nanatsu_no_Taizai.Models;

public class Personagem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    public string Descricao { get; set; }

    public string Imagem { get; set; }

    [Required]
    public int id_raca { get; set; }

    [ForeignKey(nameof(id_raca))]
    public Raca Raca { get; set; }

    public int? id_cla { get; set; }

    [ForeignKey(nameof(id_cla))]
    public Cla Cla { get; set; }

    
}