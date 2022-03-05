using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Ułamek : IComparable, IEquatable<Ułamek>
    {
        private int licznik;
        private int mianownik;

        public Ułamek()
        {

        }

        public Ułamek(int licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public Ułamek(Ułamek u)
        {
            licznik = u.licznik;
            mianownik = u.mianownik;
        }

        public override string ToString()
        {
            return $"licznik {licznik} mianownik {mianownik}";
        }

        public int getLicznik()
        {
            return licznik;
        }

        public int getMianownik()
        {
            return mianownik;
        }


        public int CompareTo(Ułamek obj)
        {
            if (obj == null) return 1;

            Ułamek other = obj as Ułamek;
            if (other != null)
                return this.licznik.CompareTo(other.licznik);
            else
                throw new ArgumentException("Obiekt nie jest ułamkiem");
        }

        public bool Equals(Ułamek other)
        {
            if (other == null)
                return false;

            if (this.mianownik == other.mianownik && this.licznik == other.licznik)
                return true;
            else
                return false;
        }

        public static Ułamek operator +(Ułamek x, Ułamek y)
        {
            return new Ułamek(x.licznik + y.licznik, x.mianownik + y.mianownik);
        }

        public static Ułamek operator -(Ułamek x, Ułamek y)
        {
            return new Ułamek(x.licznik - y.licznik, x.mianownik - y.mianownik);
        }

        public static Ułamek operator *(Ułamek x, Ułamek y)
        {
            return new Ułamek(x.licznik * y.licznik, x.mianownik * y.mianownik);
        }

        public static Ułamek operator /(Ułamek x, Ułamek y)
        {
            return new Ułamek(x.licznik / y.licznik, x.mianownik / y.mianownik);
        }


    }
}
