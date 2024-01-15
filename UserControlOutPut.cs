using SortifyDB.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortifyDB
{
    public partial class UserControlOutPut : UserControl
    {
        /// <summary>
        /// 0 = Projekty
        /// 1 = Materiály
        /// 2 = Čističe/Aktivátory
        /// 3 = Kluzké laky
        /// 4 = Granuláty
        /// </summary>
        int typList = 0;
        int TypList
        {
            get { return typList; }
            set { typList = value; }
        }
        Panel panel;
        public UserControlOutPut(int typVypsaniListu, Panel vys)
        {
            TypList = typVypsaniListu;
            panel = vys;
            InitializeComponent();
            ListDataGridVypis();
        }
        private void ClearDataGrid()
        {
            if (dataGridUCOutput.DataSource != null)
            {
                dataGridUCOutput.DataSource = null;
                dataGridUCOutput.Rows.Clear();
            }
        }
        private void ListDataGridVypis()
        {
            switch (TypList)
            {
                case 0:
                    ProjektyMet();
                    break;
                case 1:
                    MaterialsMet();
                    break;
                case 2:
                    CleanActivesMet();
                    break;
                case 3:
                    VarnishMet();
                    break;
                case 4:
                    GranMet();
                    break;
            }
        }
        private void ProjektyMet()
        {
            ClearDataGrid();

            dataGridUCOutput.DataSource = MainForm.Projekty;

            DataGridViewButtonColumn deleteButtonColumn = new()
            {
                HeaderText = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };

            dataGridUCOutput.Columns.Add(deleteButtonColumn);

            dataGridUCOutput.CellClick += dataGridOutput_CellClick;
        }

        private void dataGridOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dataGridUCOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridUCOutput.Rows[e.RowIndex];

                string tlValue = (string)selectedRow.Cells[1].Value;

                Projekt projekt = MainForm.Projekty.Find(x => x.TL == tlValue);

                ClearDataGrid();
            }*/
            
        }

        private void MaterialsMet()
        {
            ClearDataGrid();

            dataGridUCOutput.DataSource = MainForm.Materials;
        }

        private void CleanActivesMet()
        {
            ClearDataGrid();

            dataGridUCOutput.DataSource = MainForm.CisticeAktivatory;
        }

        private void VarnishMet()
        {
            ClearDataGrid();

            dataGridUCOutput.DataSource = MainForm.KluzkeLaky;
        }

        private void GranMet()
        {
            ClearDataGrid();

            dataGridUCOutput.DataSource = MainForm.Granulaty;
        }
    }
}
