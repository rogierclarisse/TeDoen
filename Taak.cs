using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TeDoen
{
    //event ToonMij:  Dit event wordt opgeroepen telkens als een object getoond wordt en
    //heeft drie parameters (titel , inhoud, dringend) waarbij de boolean dringend aanstaat als Tijdstip != null;
    public delegate void Toon(string titel);
    //deze klasse is de PUBLISHER
    public class Taak
    {
        //event 
        
        public int Id { get; set; }
        public DateTime? Tijdstip { get; set; }
        public string Titel { get; set; }
        public string? Informatie { get; set; }

        public static int teller = 1;

        public event Toon ToonMij;

        //boolean voor event
        public bool dringend;

        public Taak()
        {
            Id = teller;
            teller++;
        }

        public Taak(string titel)
        {
            Titel = titel;
            Id = teller;
            teller++;
        }

        //wanneer afzonderlijke informatie in textboxes w ingegeven, worden die
        // eerst in een array gezet, en die array wordt meegegeven.
        public Taak(string titel, string? informatie, DateTime? tijdstip)
        {
            if (tijdstip > DateTime.Now && tijdstip != null)
            {
                Titel = titel;
                Informatie = informatie;
                Tijdstip = tijdstip;
                //boolean Dringend == True als er een tijdstip is
                //dringend = true;
                Id = teller;
                teller++;
            }
            else
            {
                throw new TooEarlyException();
            }
        }

        public void StartProcess(string titel)
        {
            OnToonMij(" Dit is een test");
           
        }

        public void OnToonMij(string titel)
        {
            ToonMij?.Invoke(titel);

        }

    
        public override string ToString()
        {
            if (Informatie != null)
            {
                //foreach (string item in Informatie)
                //{
                //    info += info + "; ";
                //}
                return "Item nr." + Id + ": " + Titel + " moet uitgevoerd worden op " + Tijdstip + " en heeft bijkomende informatie: " + Informatie+"/n";
            }
            else
            {
                return "Item nr." + Id + ": " + Titel + " moet uitgevoerd worden op " + Tijdstip + "/n";

            }
        }




    }
}
