using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_POO_Celular.Models
{
  public class Iphone : Smartphone
  {
    public Iphone(string Numero, string Modelo, string Imei, int Memoria) : base(Numero, Modelo, Imei, Memoria)
    { }

    public override void InstalarAplicativo(string app)
    {
      Console.WriteLine($"Instalando o aplicativo {app} no Iphone");
    }
  }
}