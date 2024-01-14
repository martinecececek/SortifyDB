using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechnoWizz.Objects;
using Excel = Microsoft.Office.Interop.Excel;

namespace TechnoWizz.ManualAddingForm.Add
{
    public partial class CisticAktivatorAdd : UserControl
    {
        public CisticAktivatorAdd()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> KeyValuePairs = new Dictionary<string, string>();
        private void CisticAktivatorAdd_Load(object sender, EventArgs e)
        {
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoGenerateColumns = false;

            Excel.Worksheet worksheet = (Excel.Worksheet)Globals.ThisWorkbook.Worksheets[Globals.CisticeAktivatorySheet.Index];

            int i = 11;
            while (worksheet.Cells[i, 2].Value != null)
            {
                KeyValuePairs.Add(worksheet.Cells[i, 1].Value.ToString(), string.Empty);
                i++;
            }

            foreach (KeyValuePair<string, string> item in KeyValuePairs)
            {
                dataGrid.Rows.Add(item.Key, item.Value);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool CheckTextBoxes()
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Text == "")
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            if (CheckTextBoxes())
            {
                MainManualForm mainManualForm = new MainManualForm();

                mainManualForm.ClearUserControl();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Opravdu chcete zrušit přidávání materiálu?", "Zrušit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    MainManualForm mainManualForm = new MainManualForm();

                    mainManualForm.ClearUserControl();
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            bool CheckTextBoxes()
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Text == "")
                        {
                            return false;
                        }
                    }
                }

                return true;
            }


            if (CheckTextBoxes())
            {
                //get data from datagrid
                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        keyValuePairs[row.Cells[0].Value.ToString()] = row.Cells[1].Value.ToString();
                    }
                }


                CisticAktivator Cistic = new CisticAktivator(sap: txtBoxSAP.Text,
                                                             nazev: txtBoxName.Text,
                                                             jeAktivni: txtBoxAktivni.Text,
                                                             vyrobce: txtBoxVyrobce.Text,
                                                             pouziti: txtBoxPouziti.Text,
                                                             nevhodneKombinace: txtBoxNevhodKomb.Text,
                                                             slozeniDle: txtBoxSlozeniDle.Text,
                                                             slozeni: keyValuePairs);

                MainList.CisticeAktivatory.Add(Cistic);

                Excel.Worksheet worksheet = (Excel.Worksheet)Globals.ThisWorkbook.Worksheets[Globals.GranulatySheet.Index];
                int usedRows = worksheet.UsedRange.Rows.Count + 1;

                worksheet.Cells[usedRows, 1].Value = Cistic.SAP;
                worksheet.Cells[usedRows, 2].Value = Cistic.Nazev;
                worksheet.Cells[usedRows, 3].Value = Cistic.JeAktivni;
                worksheet.Cells[usedRows, 4].Value = Cistic.Vyrobce;
                worksheet.Cells[usedRows, 5].Value = Cistic.Pouziti;
                worksheet.Cells[usedRows, 6].Value = Cistic.NevhodneKombinace;
                worksheet.Cells[usedRows, 7].Value = Cistic.SlozeniDle;

                int i = 8;
                foreach (KeyValuePair<string, string> item in keyValuePairs)
                {
                    worksheet.Cells[usedRows, i].Value = item.Value;

                    i++;
                }

                DatabaseConnection.DatabaseConnection databaseConnection = new DatabaseConnection.DatabaseConnection();

                databaseConnection.PushCisticAktivatorToDatabase(Cistic);


            }
            else
            {
                MessageBox.Show("Vyplňte všechny údaje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            bool CheckTextBoxes()
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Text == "")
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            if (CheckTextBoxes())
            {
                MainManualForm mainManualForm = new MainManualForm();

                mainManualForm.ClearUserControl();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Opravdu chcete zrušit přidávání granulátu?", "Zrušit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    MainManualForm mainManualForm = new MainManualForm();

                    mainManualForm.ClearUserControl();
                }
            }
        }
    }
}
