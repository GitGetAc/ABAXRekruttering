namespace ABAXRekruttering
{
    internal class Kjøretøy
    {

        public string RegNummer { get; set; }
        public string Effekt { get; set; }

        public Kjøretøy(string regnummer, string effekt)
        {
            RegNummer = regnummer;
            Effekt = effekt;
        }

        public virtual void Kjør()
        {
            Console.WriteLine("Kjøretøyet begynte å kjøre!");
        }
    }
}
