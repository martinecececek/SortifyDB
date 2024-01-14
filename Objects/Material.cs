namespace SortifyDB.Objects
{
    class Material(string SAP, string nazev, string typPripravku)
    {
        public String SAP { get; set; } = SAP;
        public String Nazev { get; set; } = nazev;
        public String TypPripravku { get; set; } = typPripravku;

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
