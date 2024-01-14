namespace SortifyDB.Objects
{
    class Granulat
    {
        public Granulat(string sap, string nazev, string typ, string xk, string jeAktivni, string vyrobce, string pouziti, string kombinaveS, string cisteni, string nevhodneKombinace, string slozeniDle, Dictionary<string, string> slozeni)
        {
            SAP = sap;
            Nazev = nazev;
            Typ = typ;
            Xk = xk;
            JeAktivni = jeAktivni;
            Vyrobce = vyrobce;
            Pouziti = pouziti;
            KombinaceS = kombinaveS;
            Cisteni = cisteni;
            NevhodneKombinace = nevhodneKombinace;
            SlozeniDle = slozeniDle;
            Slozeni = slozeni;
        }

        public String Nazev { get; set; }
        public String Typ { get; set; }
        public String SAP { get; set; }
        public String Xk { get; set; }
        public String JeAktivni { get; set; }
        public String Vyrobce { get; set; }
        public String Pouziti { get; set; }
        public String KombinaceS { get; set; }
        public String Cisteni { get; set; }
        public String NevhodneKombinace { get; set; }
        public String SlozeniDle { get; set; }

        //key = nazev, value = procenta
        public Dictionary<string, string> Slozeni { get; set; }

    }
}
