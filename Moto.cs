using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drag_Race
{
    internal class Moto
    {
        private string _marca;
        private string _modello;
        private int _cavalli;

        private double _tempoZeroCento;
        private int _cilindrata;



        //definiamo le proprietà della classe Moto
        public string Marca
        {
            get { return _marca; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La marca non può essere vuota.");
                }
                else
                {
                    _marca = value;
                }
            }
        }

        public string Modello
        {
            get { return _modello; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il modello non può essere vuoto.");
                }
                else
                {
                    _modello = value;
                }
            }
        }
        public double TempoZeroCento
        {
            get { return _tempoZeroCento; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Il tempo 0-100 non può essere negativo.");
                }
                else
                {
                    _tempoZeroCento = value;
                }
            }
        }

        public int Cavalli
        {
            get { return _cavalli; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("I cavalli non possono essere negativi.");
                }
                else
                {
                    _cavalli = value;
                }
            }
        }

        public int Cilindrata
        {
            get { return _cilindrata; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La cilindrata non può essere negativa.");
                }
                else
                {
                    _cilindrata = value;
                }
            }
        }

        //definiamo il costruttore della classe Moto
        public Moto(string marca, string modello, int cavalli, double tempoZeroCento, int cilindrata)
        {
            Marca = marca;
            Modello = modello;
            Cavalli = cavalli;
            TempoZeroCento = tempoZeroCento;
            Cilindrata = cilindrata;


        }

        // override del metodo ToString()
        public override string ToString()
        {
            return $"Marca: {Marca}, " +
                $"Modello: {Modello}, " +
                $"Cavalli: {Cavalli}, " +
                $"Tempo 0-100: {TempoZeroCento}," +
                $" Cilindrata: {Cilindrata}";
        }

        //metodo di confronto della cilindrata tra due moto
        public string ConfrontoCilindrata(Moto moto)
        {
            if (this.Cilindrata > moto.Cilindrata)
            {
                return $"{this.Marca} {this.Modello} ha una cilindrata maggiore di {moto.Marca} {moto.Modello}.";
            }
            else if (this.Cilindrata < moto.Cilindrata)
            {
                return $"{this.Marca} {this.Modello} ha una cilindrata minore di {moto.Marca} {moto.Modello}.";
            }
            else
            {
                return $"{this.Marca} {this.Modello} e {moto.Marca} {moto.Modello} hanno la stessa cilindrata.";
            }

        }

        //metodo confronto accelerazione sui 100 metri
        public string ConfrontaAccelerazione(Moto moto) {

            if (this.TempoZeroCento > moto.TempoZeroCento)
            {
                return $"{this.Marca} {this.Modello} ha un'accelerazione più lenta di {moto.Marca} {moto.Modello}.";
            }
            else if (this.TempoZeroCento == moto.TempoZeroCento)
            {
                return $"{this.Marca} {this.Modello} e {moto.Marca} {moto.Modello} hanno la stessa accelerazione.";
            }
            else { 
                return $"{this.Marca} {this.Modello} ha un'accelerazione più veloce di {moto.Marca} {moto.Modello}.";
            }
        
        }
    }
}