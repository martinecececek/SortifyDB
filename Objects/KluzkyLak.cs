namespace SortifyDB.Objects
{
    class KluzkyLak
    {
        public KluzkyLak(string sap, string nazev, string jeAktivni, string vyrobce, string pouziti, string nevhodneKombinace, string slozeniDle, Dictionary<string, string> slozeni)
        {
            SAP = sap;
            Nazev = nazev;
            JeAktivni = jeAktivni;
            Vyrobce = vyrobce;
            Pouziti = pouziti;
            NevhodneKombinace = nevhodneKombinace;
            SlozeniDle = slozeniDle;
            Slozeni = slozeni;
        }

        public String SAP { get; set; }
        public String Nazev { get; set; }
        public String JeAktivni { get; set; }
        public String Vyrobce { get; set; }
        public String Pouziti { get; set; }
        public String NevhodneKombinace { get; set; }
        public String SlozeniDle { get; set; }

        //key = nazev, value = procenta
        public Dictionary<string, string> Slozeni { get; set; }

    }
}
