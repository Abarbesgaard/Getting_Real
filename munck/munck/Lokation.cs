using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munck
{
    public class Lokation
    {
        //privat felt
        private List<Aktivitet> _aktiviteter;

        // Name Property
        private string _navn;
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        //LokationId proptery
        private string _lokationId;

        public string LokationId
        {
            get { return _lokationId; }
            set { _lokationId = value; }
        }

        //Property EstimeredeTimer
        private double _estimeredeTimer;

        public double EstimeredeTimer
        {
            get { return _estimeredeTimer; }
            set { _estimeredeTimer = value; }
        }

        //Property Igang

        private bool _igang;

        public bool Igang
        {
            get { return _igang; }
            set { _igang = value; }
        }

        //static property Igangværende
        private static int _igangværendeLokationer;

        public static int IgangværendeLokationer
        {
            get { return _igangværendeLokationer; }
            set { _igangværendeLokationer = value; }
        }
        private static int _afsluttet;

        public static int Afsluttet
        {
            get { return _afsluttet; }
            set { _afsluttet = value; }
        }

        //Constructor 
        public Lokation(string Navn, string LokationId)
        {
            _navn = Navn;
            _lokationId = LokationId;
            Lokation._igangværendeLokationer += 1;
        }

     

        public void TilføjMaskine(Maskine maskine)
        {
            //brug en liste/array til at gemme maskinerne
            //Maskine maskine = new Maskine("", "", MaskineType.Gravko);
            //vi skal kigge gennem alle vores aktiviteter
            //er der en som matcher vores maskineId
            //hvis der ikke er en der matcher - opret ny

            // Instantier en værdi til at gemme om der findes en aktivitet med den maskine
            bool maskineFundet = false;

            // Gå gennem vores liste af aktiviteter med maskiner
            foreach (Aktivitet aktivitet in _aktiviteter)
            {
                if (aktivitet.Maskine.MaskineId == maskine.MaskineId)
                {
                    //der findes en aktivitet med den maskine
                    maskineFundet = true;
                }
            }

            // I tilfælde af der ikke findes en aktivitet med den maskine
            if (!maskineFundet)
            {
                //Opret en ny aktivitet med den givne maskine
                Aktivitet aktivitet = new Aktivitet(maskine);

               //Tilføj den nye aktivitet til listen
                _aktiviteter.Add(aktivitet);
            }
            
        }

        public void FjernMaskine(Maskine Maskine)
        {
            // Her skal koden kunne fjerne en maskine / den valgte maskine.
            Maskine maskine = 
        }

        public void RegistrerTimer(Maskine maskine, double timer)
        {
            // Her skal koden kunne registrer antal timer maskinen har været i brug for denne session
            
        }

        public void TotaleAntalTimer()
        {
           // Her skal koden kunne beregne det totale antal timer, hvor maskinen er blevet brugt
        }

        public void SkiftStatus()
        {
            
        }

    }
}
