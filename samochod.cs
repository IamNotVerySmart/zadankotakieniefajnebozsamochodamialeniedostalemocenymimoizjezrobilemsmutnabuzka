using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bartekjestazjatom
{
    internal class Samochod
    {
        string marka, model;
        double pojemnosc;
        int moc;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Pojemnosc
        {
            get { return pojemnosc; }
            set { pojemnosc = value; }
        }
        public int Moc
        {
            get { return moc; }
            set { moc = value; }
        }
        public Samochod()
        {
            marka = "";
            model = "";
            pojemnosc = 0;
            moc = 0;
        }
        public Samochod(string Marka, string Model, double Pojemnosc, int Moc)
        {
            this.marka = Marka;
            this.model = Model;
            this.pojemnosc = Pojemnosc;
            this.moc = Moc;
        }
        public Samochod(Samochod s)
        {
            marka = s.Marka;
            model = s.Model;
            pojemnosc = s.Pojemnosc;
            moc = s.Moc;
        }
        public void Copy(Samochod s)
        {
            marka = s.Marka;
            model = s.Model;
            pojemnosc = s.Pojemnosc;
            moc = s.Moc;
        }
        public override string ToString()
        {
            return "Marka: " + marka + " Model: " + model + " "+ pojemnosc + "L" + moc + "KM";
        }
    }
}
