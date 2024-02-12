namespace ABAXRekruttering
{
    internal class Båt : Kjøretøy
    {
        public string MaksFart { get; set; }
        public string BruttoVekt { get; set; }

        public Båt(string regnummer, string effekt, string maksFart, string bruttoVekt) : base(regnummer, effekt)
        {
            MaksFart = maksFart;
            BruttoVekt = bruttoVekt;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{RegNummer} {Effekt} {MaksFart} {BruttoVekt}");
        }
    }
}
