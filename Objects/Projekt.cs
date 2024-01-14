namespace SortifyDB.Objects
{
    public class Projekt(string tl, string nazev, List<Material> materials, string zkracenyPopis, string sklo, string temp, string trh, string imds)
    {
        public String TL { get; set; } = tl;
        public String Nazev { get; set; } = nazev;
        public List<Material> Materials { get; set; } = materials;
        public String ZkracenyPopis { get; set; } = zkracenyPopis;
        public String Sklo { get; set; } = sklo;
        public String Temp { get; set; } = temp;
        public String Trh { get; set; } = trh;
        public String IMDS { get; set; } = imds;

    }
}
