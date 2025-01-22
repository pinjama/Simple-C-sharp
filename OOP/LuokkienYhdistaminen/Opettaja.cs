using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Opettaja
{
    public string nimi { get; set; }

    public Opettaja(string opettajanNimi)
    {
        this.nimi = opettajanNimi;
    }
    public void Tulosta()
    {
        Console.Write(nimi + " ");
    }

}
