using Nanatsu_no_Taizai.Models;

namespace Nanatsu_no_Taizai.ViewModels;

public class DetailsVM
{
    public Personagem Anterior { get; set; }
    public Personagem Atual { get; set; }
    public Personagem Proximo { get; set; }
}