using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CFahrzeug
    {

        //Free Game assets für Graphic nachschauen https://bayat.itch.io/platform-game-assets

        protected double pGeschwindigkeit ; //protectetd  die vererbten können den Wert ändern
        private double pBeschleunigung , pMaxGeschwindigkeit ;
        private double pXStarposition, pYStartposition, plaenge;
        protected Color farbe;
        private List<CFahrzeug> kolonne; //List damit die Anzahl der Fahrzeuge nicht manuell eingegeben werden muss

        public CFahrzeug(int Y, Color Farbe, int Laenge, double MaxGeschwindigkeit, double Beschleunigung)
        {
            if (kolonne == null)
            {
                kolonne = new List<CFahrzeug>();
            }
            pXStarposition = 100 - Laenge;
            pYStartposition = Y;
            farbe = Farbe;
            plaenge = Laenge;
            pGeschwindigkeit = 0;
            pMaxGeschwindigkeit = MaxGeschwindigkeit;
            pBeschleunigung = Beschleunigung;
            foreach (CFahrzeug K in kolonne)
            {
             
            }
            kolonne.Add(this);
        }




    }
}
