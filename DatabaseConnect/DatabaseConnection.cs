using SortifyDB.Objects;
using System.Data;
using System.Data.SqlClient;

namespace SortifyDB.DatabaseConnect
{
    public class DatabaseConnection
    {
        //server connection string
        private static readonly string _connectionString = "Server=myServerAddress;Database=myDatabase;User=myUsername;Password=myPassword;";

        #region push data to database

        // push material to database
        public async Task PushMaterialToDatabase(Material material)
        {
            using var connection = new SqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();

                using var command = new SqlCommand("INSERT INTO materials (sap, name, type) VALUES (@sap,@name ,@type)", connection);
                command.Parameters.AddWithValue("@sap", material.SAP);
                command.Parameters.AddWithValue("@name", material.Nazev);
                command.Parameters.AddWithValue("@type", material.TypPripravku);

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task PushProjectToDatabase(Projekt project)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using var command = new SqlCommand("INSERT INTO projects (sap, name, type) VALUES (@sap,@name ,@type)", connection);
                    command.Parameters.AddWithValue("@tl", project.TL);
                    command.Parameters.AddWithValue("@nazev", project.Nazev);
                    command.Parameters.AddWithValue("@zkracenyPopis", project.ZkracenyPopis);
                    command.Parameters.AddWithValue("@sklo", project.Sklo);
                    command.Parameters.AddWithValue("@trh", project.Trh);
                    command.Parameters.AddWithValue("@imds", project.IMDS);

                    await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            foreach (var material in project.Materials)
            {
                PushMaterialToDatabase(material);
            }
        }

        public async Task PushGranulatToDatabase(Granulat granulat)
        {
            #region query string for column names
            //query string for column names
            string columnNames = "sap, nazev, typ, xk, jeAktivni, vyrobceDodavatel, pouziti, " +
                                "kombinaceS, cisteni, nevhodneKombinace, slozeniDle," +
                                "tetramethyl, sopropylidendifenol, dichlorooktyl, benzinovaFrakce" +
                                "carbonBlack, diisodecylftalat, ethylenpropylendienovyKaucuk, chloridCinaty" +
                                "chloridCinatyDihydrat, kaolin, mastek, mineralniOlejBilyRopny, oxidZinečnaty" +
                                "polyethylen, polyethylen2, polypropylen, polypropylen2, polyvinylchlorid" +
                                "skelnaVlakna, sojovyOlejEpoxidovany, styren-ethylen, termoplastickyElastomerStyrenový" +
                                "termoplastickyElastomerVulkanizovany, uhlicitanVapenaty, vapenec" +
                                "nedeklarovanePigmenty, nedeklarovaneSlozky";

            string[] values = ["@sap, @nazev",
                "@typ",
                "@xk",
                "@jeAktivni",
                "@vyrobceDodavatel",
                "@pouziti",
                "@kombinaceS",
                "@cisteni",
                "@nevhodneKombinace",
                "@slozeniDle",
                "@tetramethyl",
                "@sopropylidendifenol",
                "@dichlorooktyl",
                "@benzinovaFrakce",
                "@carbonBlack",
                "@diisodecylftalat",
                "@ethylenpropylendienovyKaucuk",
                "@chloridCinaty",
                "@chloridCinatyDihydrat",
                "@kaolin",
                "@mastek",
                "@mineralniOlejBilyRopny",
                "@oxidZinečnaty",
                "@polyethylen",
                "@polyethylen2",
                "@polypropylen",
                "@polypropylen2",
                "@polyvinylchlorid",
                "@skelnaVlakna",
                "@sojovyOlejEpoxidovany",
                "@styren-ethylen",
                "@termoplastickyElastomerStyrenový",
                "@termoplastickyElastomerVulkanizovany",
                "@uhlicitanVapenaty",
                "@vapenec",
                "@nedeklarovanePigmenty",
                "@nedeklarovaneSlozky"];

            List<string> slozeni = new(granulat.Slozeni.Values);

            #endregion

            using var connection = new SqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();

                using var command = new SqlCommand($"INSERT INTO granulaty ({columnNames}) VALUES ({string.Join(",", values)})", connection);
                //paramters to instert data to database
                #region parameters
                command.Parameters.AddWithValue(values[0], granulat.SAP);
                command.Parameters.AddWithValue(values[1], granulat.Nazev);
                command.Parameters.AddWithValue(values[2], granulat.Typ);
                command.Parameters.AddWithValue(values[3], granulat.Xk);
                command.Parameters.AddWithValue(values[4], granulat.JeAktivni);
                command.Parameters.AddWithValue(values[5], granulat.Vyrobce);
                command.Parameters.AddWithValue(values[6], granulat.Pouziti);
                command.Parameters.AddWithValue(values[7], granulat.KombinaceS);
                command.Parameters.AddWithValue(values[8], granulat.Cisteni);
                command.Parameters.AddWithValue(values[9], granulat.NevhodneKombinace);
                command.Parameters.AddWithValue(values[10], granulat.SlozeniDle);
                command.Parameters.AddWithValue(values[11], slozeni[0]);
                command.Parameters.AddWithValue(values[12], slozeni[1]);
                command.Parameters.AddWithValue(values[13], slozeni[2]);
                command.Parameters.AddWithValue(values[14], slozeni[3]);
                command.Parameters.AddWithValue(values[15], slozeni[4]);
                command.Parameters.AddWithValue(values[16], slozeni[5]);
                command.Parameters.AddWithValue(values[17], slozeni[6]);
                command.Parameters.AddWithValue(values[18], slozeni[7]);
                command.Parameters.AddWithValue(values[19], slozeni[8]);
                command.Parameters.AddWithValue(values[20], slozeni[9]);
                command.Parameters.AddWithValue(values[21], slozeni[10]);
                command.Parameters.AddWithValue(values[22], slozeni[11]);
                command.Parameters.AddWithValue(values[23], slozeni[12]);
                command.Parameters.AddWithValue(values[24], slozeni[13]);
                command.Parameters.AddWithValue(values[25], slozeni[14]);
                command.Parameters.AddWithValue(values[26], slozeni[15]);
                command.Parameters.AddWithValue(values[27], slozeni[16]);
                command.Parameters.AddWithValue(values[28], slozeni[17]);
                command.Parameters.AddWithValue(values[29], slozeni[18]);
                command.Parameters.AddWithValue(values[30], slozeni[19]);
                command.Parameters.AddWithValue(values[31], slozeni[20]);
                command.Parameters.AddWithValue(values[32], slozeni[21]);
                command.Parameters.AddWithValue(values[33], slozeni[22]);
                command.Parameters.AddWithValue(values[34], slozeni[23]);
                command.Parameters.AddWithValue(values[35], slozeni[24]);
                command.Parameters.AddWithValue(values[36], slozeni[25]);
                command.Parameters.AddWithValue(values[37], slozeni[26]);
                #endregion

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task PushKluzkyLakToDatabase(KluzkyLak kluzkyLak)
        {
            #region query string for column names
            string[] columnNames = ["sap, Nazev, JeAktivni, vyrobce, pouziti, nevhodneKombinace, slozeniDle, " +
                                     "benzoisothiazol3_2H_on, diethylaminoethanol, alifaticky_alkoholm, " +
                                     "alkyl_polyglykolether, cyklohexyldimethylamin, diethanolamin, ethan12_diol, " +
                                     "hexamethylendiisokyanat_oligomery, hexan16_diyldiisokyanat, mastny_aminalkyl_etoxylovany" +
                                     "nonylfenol, polyethylenglykoltridecyletherfosfat, triethylamin"];

            string[] values = ["@sap, @Nazev",
                "@JeAktivni",
                "@vyrobce",
                "@pouziti",
                "@nevhodneKombinace",
                "@slozeniDle, ",
                "@benzoisothiazol3_2H_on",
                "@diethylaminoethanol",
                "@alifaticky_alkoholm, ",
                "@alkyl_polyglykolether",
                "@cyklohexyldimethylamin",
                "@diethanolamin",
                "@ethan12_diol, ",
                "@hexamethylendiisokyanat_oligomery",
                "@hexan16_diyldiisokyanat",
                "@mastny_aminalkyl_etoxylovany",
                "@nonylfenol",
                "@polyethylenglykoltridecyletherfosfat",
                "@triethylamin"];
            List<string> slozeni = new(kluzkyLak.Slozeni.Values);

            #endregion

            using var connection = new SqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();

                using var command = new SqlCommand($"INSERT INTO kluzkyLaky ({string.Join(",", columnNames)}) VALUES ({string.Join(",", values)})", connection);
                //paramters to instert data to database
                #region parameters
                command.Parameters.AddWithValue(values[0], kluzkyLak.SAP);
                command.Parameters.AddWithValue(values[1], kluzkyLak.Nazev);
                command.Parameters.AddWithValue(values[2], kluzkyLak.JeAktivni);
                command.Parameters.AddWithValue(values[3], kluzkyLak.Vyrobce);
                command.Parameters.AddWithValue(values[4], kluzkyLak.Pouziti);
                command.Parameters.AddWithValue(values[5], kluzkyLak.NevhodneKombinace);
                command.Parameters.AddWithValue(values[6], kluzkyLak.SlozeniDle);
                command.Parameters.AddWithValue(values[7], slozeni[0]);
                command.Parameters.AddWithValue(values[8], slozeni[1]);
                command.Parameters.AddWithValue(values[9], slozeni[2]);
                command.Parameters.AddWithValue(values[10], slozeni[3]);
                command.Parameters.AddWithValue(values[11], slozeni[4]);
                command.Parameters.AddWithValue(values[12], slozeni[5]);
                command.Parameters.AddWithValue(values[13], slozeni[6]);
                command.Parameters.AddWithValue(values[14], slozeni[7]);
                command.Parameters.AddWithValue(values[15], slozeni[8]);
                command.Parameters.AddWithValue(values[16], slozeni[9]);
                command.Parameters.AddWithValue(values[17], slozeni[10]);
                command.Parameters.AddWithValue(values[18], slozeni[11]);
                #endregion

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task PushCisticAktivatorToDatabase(CisiticAktivator cisticAktivator)
        {
            #region query string for column names
            string[] columnNames = ["sap ,Nazev, JeAktivni, vyrobce, pouziti, nevhodneKombinace, slozeniDle, " +
                                     "dioxolan_1_3, aminopropyltriethoxysilan, trimethoxysilyl_propanthiol, " +
                                     "benzen1_3_diol_resorcinol, dichlormetan, ethanol, heptan, isopropanol, " +
                                     "trimethoxysilyl_propyl_ethandiamin, voda, voda_demi"];

            string[] values = ["@sap, @Nazev",
                "@JeAktivni",
                "@vyrobce",
                "@pouziti",
                "@nevhodneKombinace",
                "@slozeniDle, ",
                "@dioxolan_1_3",
                "@aminopropyltriethoxysilan",
                "@trimethoxysilyl_propanthiol, ",
                "@benzen1_3_diol_resorcinol",
                " @dichlormetan",
                " @ethanol",
                " @heptan",
                "@isopropanol, ",
                "@trimethoxysilyl_propyl_ethandiamin",
                " @voda",
                "@voda_demi"];

            List<string> slozeni = new(cisticAktivator.Slozeni.Values);
            #endregion

            using var connection = new SqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();

                using var command = new SqlCommand($"INSERT INTO kluzkyLaky ({string.Join(",", columnNames)}) VALUES ({string.Join(",", values)})", connection);
                //paramters to instert data to database
                #region parameters
                command.Parameters.AddWithValue(values[0], cisticAktivator.SAP);
                command.Parameters.AddWithValue(values[1], cisticAktivator.Nazev);
                command.Parameters.AddWithValue(values[2], cisticAktivator.JeAktivni);
                command.Parameters.AddWithValue(values[3], cisticAktivator.Vyrobce);
                command.Parameters.AddWithValue(values[4], cisticAktivator.Pouziti);
                command.Parameters.AddWithValue(values[5], cisticAktivator.NevhodneKombinace);
                command.Parameters.AddWithValue(values[6], cisticAktivator.SlozeniDle);
                command.Parameters.AddWithValue(values[7], slozeni[0]);
                command.Parameters.AddWithValue(values[8], slozeni[1]);
                command.Parameters.AddWithValue(values[9], slozeni[2]);
                command.Parameters.AddWithValue(values[10], slozeni[3]);
                command.Parameters.AddWithValue(values[11], slozeni[4]);
                command.Parameters.AddWithValue(values[12], slozeni[5]);
                command.Parameters.AddWithValue(values[13], slozeni[6]);
                command.Parameters.AddWithValue(values[14], slozeni[7]);
                command.Parameters.AddWithValue(values[15], slozeni[8]);
                command.Parameters.AddWithValue(values[16], slozeni[9]);
                command.Parameters.AddWithValue(values[17], slozeni[10]);
                command.Parameters.AddWithValue(values[18], slozeni[11]);
                #endregion

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region get data from database
        public static List<Projekt> Projects = [];
        public static List<Granulat> Granulaty = [];
        public static List<Material> Materials = [];
        public static List<KluzkyLak> KluzkeLaky = [];
        public static List<CisiticAktivator> CisticeAktivatory = [];

        #region encapsulation
        public List<Material> GetMaterials()
        {
            return Materials;
        }

        public List<Granulat> GetGranulaty()
        {
            return Granulaty;
        }

        public List<KluzkyLak> GetKluzkeLaky()
        {
            return KluzkeLaky;
        }

        public List<CisiticAktivator> GetCisticeAktivatory()
        {
            return CisticeAktivatory;
        }

        public List<Projekt> GetProjects()
        {
            return Projects;
        }
        #endregion



        #region DataTables
        private static readonly DataTable MaterialDataTable = new();
        private static readonly DataTable KluzkyLakDataTable = new();
        private static readonly DataTable GranulatyDataTable = new();
        private static readonly DataTable CisticeAktivatoryDataTable = new();
        private static readonly DataTable ProjectsDataTable = new();
        private static readonly DataTable ProjectMaterialsDataTable = new();
        #endregion

        public static bool isConnected;
        public static async Task GetAllDataFromDatabase()
        {
            using (SqlConnection connection = new(_connectionString))
            {
                try
                {
                    connection.Open();

                    #region Query for materials
                    string sqlMaterial = "SELECT * FROM materials";
                    SqlCommand commandMaterial = new(sqlMaterial, connection);
                    using (SqlDataReader dataReader = commandMaterial.ExecuteReader())
                    {
                        MaterialDataTable.Load(dataReader);

                        if (MaterialDataTable != null)
                        {
                            await Task.Run(() => ProcessMaterials());
                        }
                    }
                    #endregion

                    #region Query for kluzkylak
                    string sqlLak = "SELECT * FROM kluzkylak1";
                    SqlCommand commandLak = new(sqlLak, connection);
                    using (SqlDataReader dataReader = commandLak.ExecuteReader())
                    {
                        KluzkyLakDataTable.Load(dataReader);

                        if (KluzkyLakDataTable != null)
                        {
                            await Task.Run(() => ProcessKluzkeLaky());
                        }
                    }
                    #endregion

                    #region Query for granulaty
                    string sqlGranulaty = "SELECT * FROM granulaty";
                    SqlCommand commandGranulaty = new(sqlGranulaty, connection);
                    using (SqlDataReader dataReader = commandLak.ExecuteReader())
                    {
                        GranulatyDataTable.Load(dataReader);

                        if (GranulatyDataTable != null)
                        {
                            await Task.Run(() => ProcessGranulaty());
                        }
                    }
                    #endregion

                    #region Query for cisticeaktivatory
                    string sqlCistic = "SELECT * FROM cisticeaktivatory";
                    SqlCommand commandCistic = new(sqlCistic, connection);
                    using (SqlDataReader dataReader = commandLak.ExecuteReader())
                    {
                        KluzkyLakDataTable.Load(dataReader);

                        if (CisticeAktivatoryDataTable != null)
                        {
                            await Task.Run(() => ProcessCistice());
                        }
                    }
                    #endregion

                    #region Query for projects
                    string sqlProject = "SELECT * FROM projects";
                    SqlCommand commandProject = new(sqlProject, connection);
                    using (SqlDataReader dataReader = commandLak.ExecuteReader())
                    {
                        ProjectMaterialsDataTable.Load(dataReader);
                    }
                    #endregion

                    #region Query for project_materials
                    string sqlProject_Materials = "SELECT * FROM project_materials";
                    SqlCommand commandProject_Materials = new(sqlProject_Materials, connection);
                    using (SqlDataReader dataReader = commandLak.ExecuteReader())
                    {
                        ProjectMaterialsDataTable.Load(dataReader);
                    }

                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    isConnected = false;
                }
            }

            Task.WaitAll();

            await Task.Run(() => ProcessProjects());

            Task.WaitAll();
        }

        private async static void ProcessMaterials()
        {
            foreach (MySqlX.XDevAPI.Relational.Row row in MaterialDataTable.Rows)
            {
                Materials.Add(new Material(row[0].ToString(), row[1].ToString(), row[2].ToString()));
            }
        }

        private async static void ProcessCistice()
        {
            foreach (MySqlX.XDevAPI.Relational.Row row in CisticeAktivatoryDataTable.Rows)
            {
                Dictionary<string, string> slozeni = new()
                {
                    { "dioxolan_1_3", row[7].ToString() },
                    { "aminopropyltriethoxysilan", row[8].ToString() },
                    { "trimethoxysilyl_propanthiol", row[9].ToString() },
                    { "benzen1_3_diol_resorcinol", row[10].ToString() },
                    { "dichlormetan", row[11].ToString() },
                    { "ethanol", row[12].ToString() },
                    { "heptan", row[13].ToString() },
                    { "isopropanol", row[14].ToString() },
                    { "trimethoxysilyl_propyl_ethandiamin", row[15].ToString() },
                    { "voda", row[16].ToString() },
                    { "voda_demi", row[17].ToString() }
                };

                CisticeAktivatory.Add(new CisiticAktivator(sap: row[0].ToString(),
                                                          nazev: row[1].ToString(),
                                                          jeAktivni: row[2].ToString(),
                                                          vyrobce: row[3].ToString(),
                                                          pouziti: row[4].ToString(),
                                                          nevhodneKombinace: row[5].ToString(),
                                                          slozeniDle: row[6].ToString(),
                                                          slozeni));
            }
        }

        private async static void ProcessGranulaty()
        {
            foreach (MySqlX.XDevAPI.Relational.Row row in GranulatyDataTable.Rows)
            {
                Dictionary<string, string> slozeni = new()
                {
                    { "tetramethyl", row[10].ToString() },
                    { "sopropylidendifenol", row[11].ToString() },
                    { "dichlorooktyl", row[12].ToString() },
                    { "benzinovaFrakce", row[13].ToString() },
                    { "carbonBlack", row[14].ToString() },
                    { "diisodecylftalat", row[15].ToString() },
                    { "ethylenpropylendienovyKaucuk", row[16].ToString() },
                    { "chloridCinaty", row[17].ToString() },
                    { "chloridCinatyDihydrat", row[18].ToString() },
                    { "kaolin", row[19].ToString() },
                    { "mastek", row[20].ToString() },
                    { "mineralniOlejBilyRopny", row[21].ToString() },
                    { "oxidZinečnaty", row[22].ToString() },
                    { "polyethylen", row[23].ToString() },
                    { "polyethylen2", row[24].ToString() },
                    { "polypropylen", row[25].ToString() },
                    { "polypropylen2", row[26].ToString() },
                    { "polyvinylchlorid", row[27].ToString() },
                    { "skelnaVlakna", row[28].ToString() },
                    { "sojovyOlejEpoxidovany", row[29].ToString() },
                    { "styren-ethylen", row[30].ToString() },
                    { "termoplastickyElastomerStyrenový", row[31].ToString() },
                    { "termoplastickyElastomerVulkanizovany", row[32].ToString() },
                    { "uhlicitanVapenaty", row[33].ToString() },
                    { "vapenec", row[34].ToString() },
                    { "nedeklarovanePigmenty", row[35].ToString() },
                    { "nedeklarovaneSlozky", row[36].ToString() }
                };

                Granulaty.Add(new Granulat(sap: row[0].ToString(),
                                           nazev: row[1].ToString(),
                                           typ: row[2].ToString(),
                                           xk: row[3].ToString(),
                                           jeAktivni: row[4].ToString(),
                                           vyrobce: row[5].ToString(),
                                           pouziti: row[6].ToString(),
                                           kombinaveS: row[7].ToString(),
                                           cisteni: row[8].ToString(),
                                           nevhodneKombinace: row[9].ToString(),
                                           slozeniDle: row[10].ToString(),
                                           slozeni));
            }
        }

        private async static void ProcessKluzkeLaky()
        {
            foreach (MySqlX.XDevAPI.Relational.Row row in KluzkyLakDataTable.Rows)
            {
                //add data to dictionary for slozeni
                Dictionary<string, string> slozeni = new()
                {
                    { "benzoisothiazol3_2H_on", row[6].ToString() },
                    { "diethylaminoethanol", row[7].ToString() },
                    { "alifaticky_alkoholm", row[8].ToString() },
                    { "alkyl_polyglykolether", row[9].ToString() },
                    { "cyklohexyldimethylamin", row[10].ToString() },
                    { "diethanolamin", row[11].ToString() },
                    { "ethan12_diol", row[12].ToString() },
                    { "hexamethylendiisokyanat_oligomery", row[13].ToString() },
                    { "hexan16_diyldiisokyanat", row[14].ToString() },
                    { "mastny_aminalkyl_etoxylovany", row[15].ToString() },
                    { "nonylfenol", row[16].ToString() },
                    { "polyethylenglykoltridecyletherfosfat", row[17].ToString() },
                    { "triethylamin", row[18].ToString() }
                };

                KluzkeLaky.Add(new KluzkyLak(sap: row[0].ToString(),
                                             nazev: row[1].ToString(),
                                             jeAktivni: row[2].ToString(),
                                             vyrobce: row[3].ToString(),
                                             pouziti: row[4].ToString(),
                                             nevhodneKombinace: row[5].ToString(),
                                             slozeniDle: row[6].ToString(),
                                             slozeni));
            }
        }

        private async static void ProcessProjects()
        {
            foreach (MySqlX.XDevAPI.Relational.Row rowProject in ProjectsDataTable.Rows)
            {
                string tl = rowProject[0].ToString();

                //find all rows with same tl
                List<MySqlX.XDevAPI.Relational.Row> rows = [];
                foreach (MySqlX.XDevAPI.Relational.Row rowProjectMaterials in ProjectMaterialsDataTable.Rows)
                {
                    if (tl == rowProjectMaterials[0].ToString())
                    {
                        rows.Add(rowProjectMaterials);
                    }
                }

                //get materials from rows
                List<Material> materials = [];
                foreach (MySqlX.XDevAPI.Relational.Row row in rows)
                {
                    foreach (Material material in Materials)
                    {
                        if (material.SAP == row[1].ToString())
                        {
                            materials.Add(material);
                        }
                    }
                }

                Projects.Add(new Projekt(tl, rowProject[1].ToString(), materials,
                             rowProject[2].ToString(), rowProject[3].ToString(),
                             rowProject[4].ToString(), rowProject[5].ToString(),
                             rowProject[6].ToString()));

            }
        }

        #endregion

        #region delete data from database

        public async void DeleteProject(string tl)
        {
            using var connection = new SqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();

                using var command = new SqlCommand("DELETE FROM projects WHERE tl = @tl", connection);
                command.Parameters.AddWithValue("@type", tl);

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task DeleteMaterial(string sap)
        {
            using var connection = new SqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();

                using var command = new SqlCommand("DELETE FROM materials WHERE sap = @sap", connection);
                command.Parameters.AddWithValue("@sap", sap);

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void DeleteKluzkyLak(string id)
        {
            using var connection = new SqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();

                using var command = new SqlCommand("DELETE FROM kluzkylak1 WHERE Nazev = @Nazev", connection);
                command.Parameters.AddWithValue("@Nazev", id);

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void DeleteGranulat(string id)
        {
            using var connection = new SqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();

                using var command = new SqlCommand("DELETE FROM granulaty WHERE nazev = @nazev", connection);
                command.Parameters.AddWithValue("@nazev", id);

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void DeleteCisticAktivator(string id)
        {
            using var connection = new SqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();

                using var command = new SqlCommand("DELETE FROM cisticeaktivatory WHERE Nazev = @Nazev", connection);
                command.Parameters.AddWithValue("@Nazev", id);

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void DeleteProjectMaterial(string tl)
        {
            using var connection = new SqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();

                using var command = new SqlCommand("DELETE FROM project_materials WHERE tl = @tl", connection);
                command.Parameters.AddWithValue("@tl", tl);

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region update data in database

        public async void UpdateMaterial(Material material)
        {
            using var connection = new SqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();

                using var command = new SqlCommand("UPDATE materials SET sap = @sap, name = @name, type = @type WHERE sap = @sap", connection);
                command.Parameters.AddWithValue("@sap", material.SAP);
                command.Parameters.AddWithValue("@name", material.Nazev);
                command.Parameters.AddWithValue("@type", material.TypPripravku);

                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection faied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void UpdateProject(Projekt project)
        {

        }

        public async void UpdateGranulat(Granulat granulat)
        {

        }

        public async void UpdateKluzkyLak(KluzkyLak kluzkyLak)
        {

        }

        public async void UpdateCisticAktivator(CisiticAktivator cisticAktivator)
        {

        }

        public async void UpdateProjectMaterial(Projekt project)
        {

        }


        #endregion
    }
}
