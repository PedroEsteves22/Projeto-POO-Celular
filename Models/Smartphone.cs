using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_POO_Celular.Models
{
    public abstract class Smartphone
    {

        public Smartphone(string Numero, string Modelo, string Imei, int Memoria)
        {
            this.Numero = Numero;
            this.Modelo = Modelo;
            this.Imei = Imei;
            this.Memoria = Memoria;
        }

        private string _numero;
        public string Numero 
        { 
            get => _numero;
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("Esse campo não pode ser vazio");
                }
                _numero = value;
            } 
        }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string app);
    }
}