using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    [Serializable]
    public class FisierVideo :IComparable<FisierVideo>,ICloneable
    {
        protected string denumire;
        protected int nota;
        protected string gen;
        protected Boolean vizualizat;
        private FisierVideo[] video;

        //index:
        public FisierVideo this[int index]
        {
            get { return video[index]; }
            set { video[index] = value; }
        }

        //+
        public static FisierVideo operator+(FisierVideo[] d,FisierVideo f)
        {
            return d[d.Length] = f;
        }

        //bool
        public static bool operator >(FisierVideo f1,FisierVideo f2)
            {
                return f1.nota>f2.nota;
            }

        public static bool operator <(FisierVideo f1, FisierVideo f2)
        {
            return f1.nota < f2.nota;
        }


        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }
        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }
        public string Gen
        {
            get { return gen; }
            set { gen = value; }
        }
        public Boolean Vizualizat
        {
            get { return vizualizat; }
            set { vizualizat = value; }
        }

        public FisierVideo(string Denumire, int Nota, string Gen, Boolean Vizualizat)
        {
            denumire = Denumire;
            nota = Nota;
            gen = Gen;
            vizualizat = Vizualizat;
        }

        public FisierVideo() { }

        public int CompareTo(FisierVideo other)
        {
            return nota.CompareTo(other.nota);
        }

        public object Clone()
        {
            return new FisierVideo(this.denumire, this.nota, this.gen, this.vizualizat);
        }

       
    }
}
