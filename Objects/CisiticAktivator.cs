namespace SortifyDB.Objects
{
    public class CisiticAktivator(string sap, string nazev, string typ, string jeAktivni, string vyrobce, string pouziti, string nevhodneKombinace, string slozeniDle, Dictionary<string, string> slozeni)
    {
        public String SAP { get; set; } = sap;
        public String Nazev { get; set; } = nazev;
        public String Typ { get; set; } = typ;
        public String JeAktivni { get; set; } = jeAktivni;
        public String Vyrobce { get; set; } = vyrobce;
        public String Pouziti { get; set; } = pouziti;
        public String NevhodneKombinace { get; set; } = nevhodneKombinace;
        public String SlozeniDle { get; set; } = slozeniDle;

        //key = nazev, value = procenta
        public Dictionary<string, string> Slozeni { get; set; } = slozeni;
    }
}
