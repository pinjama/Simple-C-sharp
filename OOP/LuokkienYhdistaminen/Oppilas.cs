using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Oppilas
    {
    private string nimi { get; set; }
    private List<Moduuli> Moduulit { get; set; } = new List<Moduuli>();

    public Oppilas(string oppilaanNimi)
    {
        this.nimi = oppilaanNimi;
    }
    public void LisaaModuuli(Moduuli uusiModuuli)
    {
        Moduulit.Add(uusiModuuli);
    }

    //metodi tulostaa listalla olevien objektien verran pyydettyä lausetta
    public void Tulosta()
    {
        Console.WriteLine("Oppilas " + nimi + "lla " + "on ");
        for (int i = 0; i < Moduulit.Count; i++)
        {
            Moduulit[i].Tulosta();
        }
        Console.WriteLine("");
    }
}
