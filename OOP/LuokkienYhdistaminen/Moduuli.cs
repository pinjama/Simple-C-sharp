using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Moduuli
    {
        private string nimi { get; set; }
        private List<Opettaja> Opettajat { get; set; } = new List<Opettaja>();

        public Moduuli(string moduulinNimi)
        {
            this.nimi = moduulinNimi;
        }
    public void LisaaOpettaja(Opettaja uusiOpettaja)
    {
        Opettajat.Add(uusiOpettaja);
    }
    public void Tulosta()
    {
        Console.WriteLine("- Moduuli " + nimi + ", opettajat: ");
        for (int i = 0; i < Opettajat.Count; i++)
        {
            Opettajat[i].Tulosta();
        }
        Console.WriteLine("");
    }

    }
