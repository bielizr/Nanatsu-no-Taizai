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

    [Required]
    public int IdRaca { get; set; }

    [ForeignKey(nameof(IdRaca))]
    public Raca Raca { get; set; }

    public int? IdCla { get; set; }

    [ForeignKey(nameof(IdCla))]
    public Cla Cla { get; set; }

    public byte[] Imagem { get; set; }
}