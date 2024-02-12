namespace ABAXRekruttering
{
    internal class Program
    {
        static void Main()
        {
            Bil bil1 = new("NF123456", "174kw", "200km/t", "grønn", "lett");
            Bil bil2 = new("NF654321", "150kw", "195km/t", "blå", "lett");

            Fly fly = new("LN1234", "1000kw", "30m", "2T", "10T", "Jetfly");
            
            Båt båt = new("ABC123", "100kw", "30knop", "500kg");

            Console.Write("Bil1: "); bil1.PrintInfo();
            Console.Write("Bil2: "); bil2.PrintInfo();

            Console.Write("Fly: "); fly.PrintInfo();

            Console.Write("Båt: "); båt.PrintInfo();


            Console.WriteLine("Vi har bedt flyet å fly, og bil1 til å starte å kjøre"); 
            fly.Kjør();

            bil1.Kjør();

            Console.WriteLine("Sammenligning av de to bilene (bi1 == bli2?)\n");

            if (bil1.RegNummer == bil2.RegNummer && bil1.Effekt == bil2.Effekt && bil1.MaksFart == bil2.MaksFart && bil1.Farge == bil2.Farge && bil1.Type == bil2.Type)
            {
                Console.WriteLine("Bilene er like!");
            }
            else { Console.WriteLine("Bilene er ikke like."); }

        }
    }

    
    
    
    
    
    
    
    
    
    /*Skriv et konsoll-program i C# som kan:

        1. Printe informasjon om en en bil 1 med            //reg. nr NF123456, 147kw effekt, maksfart 200km/t, grønn farge av typen lett kjøretøy. 
        2. Printe informasjon om en annen bil (bil 2) med   //reg. nr NF654321, 150kw effekt, maksfart 195km/t, blå farge og av typen lett kjøretøy

        3. Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet

        4. Printe informasjon om et fly med kjennetegn LN1234, 1000kw effekt, 30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly

        5. Konsollprogrammet skal be flyet om å fly og printe dette i konsollet.

        6. Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet
    
        7. Printe informasjon om en                         // båt med kjennetegn ABC123, 100kw effekt, maksfart på 30knop, 500kg bruttotonnasje.

    Løsninger:
    Hoved-løsningsforslag: github.com/GetAcademy/AbaxSimple
    Alternativt mer komplekst løsningsforslag: github.com/GetAcademy/AbaxTest*/
}
