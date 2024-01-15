namespace SortifyDB.Objects
{
    public class KluzkyLak(string sap, string nazev, string jeAktivni, string vyrobce, string pouziti, string nevhodneKombinace, string slozeniDle, Dictionary<string, string> slozeni)
    {
        public String SAP { get; set; } = sap;
        public String Nazev { get; set; } = nazev;
        public String JeAktivni { get; set; } = jeAktivni;
        public String Vyrobce { get; set; } = vyrobce;
        public String Pouziti { get; set; } = pouziti;
        public String NevhodneKombinace { get; set; } = nevhodneKombinace;
        public String SlozeniDle { get; set; } = slozeniDle;

        //key = nazev, value = procenta (13 items)
        public Dictionary<string, string> Slozeni { get; set; } = slozeni;

    }
}
