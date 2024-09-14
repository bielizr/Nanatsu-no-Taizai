using Nanatsu_no_Taizai.Models;

namespace Nanatsu_no_Taizai.ViewModels;

public class HomeVM
{
    public List<Raca> Raças { get; set; }
    public List<Personagem> Personagems { get; set; }

    public List<Cla> Clas { get; set; }
}