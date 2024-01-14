namespace SortifyDB.Objects
{
    class Material
    {
        public Material(string SAP, string nazev, string typPripravku)
        {
            this.SAP = SAP;
            Nazev = nazev;
            TypPripravku = typPripravku;
        }

        public String SAP { get; set; }
        public String Nazev { get; set; }
        public String TypPripravku { get; set; }

        public bool ContainParemeter(string parametr)
        {
            if (SAP == parametr || Nazev == parametr)
            {
                return true;
            }
            return false;
        }

    }
}
