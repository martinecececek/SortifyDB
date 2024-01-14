namespace SortifyDB.Objects
{
    class Projekt
    {
        public Projekt(string tl, string nazev, List<Material> materials, string zkracenyPopis, string sklo, string temp, string trh, string imds)
        {
            TL = tl;
            Nazev = nazev;
            Materials = materials;
            ZkracenyPopis = zkracenyPopis;
            Sklo = sklo;
            Temp = temp;
            Trh = trh;
            IMDS = imds;
        }

        public String TL { get; set; }
        public String Nazev { get; set; }
        public List<Material> Materials { get; set; }
        public String ZkracenyPopis { get; set; }
        public String Sklo { get; set; }
        public String Temp { get; set; }
        public String Trh { get; set; }
        public String IMDS { get; set; }

    }
}
