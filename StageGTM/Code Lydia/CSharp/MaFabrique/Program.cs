using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaFabrique
{
    class Program
    {
        static void Main(string[] args)
        {

            Azo listeZo = new Azo();
            listeZo[0] = new Zo { Nom = "Da", Prenom = "Li" };
            listeZo[1]= (new Zo { Nom = "Da", Prenom = "Li" });
            //listeZo[2](new Zo { Nom = "Mè", Prenom = "ya" });

            //int indexDa;
            //for (int i = 0; i < listeZo.Count; i++)
            //{
            //    if (listeZo[i].Nom == "Da") indexDa = i;
            //}
            //Zo yaya;
            //foreach(Zo zo in listeZo) { if (zo.Prenom == "ya") yaya = zo; }

        }
    }

    class Zo
    {
        public string Nom;

        public string Prenom;

        public Zo()
        {

        }


        // public DateTime DateDeNaissance = DateTime.MinValue;
    }

    class Azo  //: IEnumerable<Zo>
    {
        //private List<Zo> ListePrivee = new List<Zo>();
        private Zo[] tabPrivee = new Zo[3];
        public Zo this[int i]
        {
            get
            {
                return tabPrivee[i];
            }
            set
            {
                tabPrivee[i] = value;
            }
        }
       



        //public void Add(Zo zo)
        //{
        //    ListePrivee.Add(zo);
        //}

        //public IEnumerator<Zo> GetEnumerator()
        //{
        //    return new ZoEnumerator(ListePrivee);
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return new ZoEnumerator(ListePrivee);
        //}

        //public int Count { get { return ListePrivee.Count; } }

        //public Zo this[int i] { get { return ListePrivee[i]; } }
    }

    //internal class ZoEnumerator : IEnumerator<Zo>
    //{
    //    private List<Zo> listePrivee2;
    //    private int ind =-1;

    //    public ZoEnumerator(List<Zo> liste)
    //    {
    //        listePrivee2 = liste;
    //    }

    //    public Zo Current
    //    {
    //        get
    //        {
    //            return listePrivee2[ind];
    //        }
    //    }

    //    object IEnumerator.Current
    //    {
    //        get
    //        {
    //            return listePrivee2[ind];
    //        }
    //    }


    //    public void Dispose()
    //    {

    //    }

    //    public bool MoveNext()
    //    {
    //        ind++;
    //        return ind < listePrivee2.Count;
    //    }

    //    public void Reset()
    //    {
    //        ind = -1;
    //    }
    //}
}
