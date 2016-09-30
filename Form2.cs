using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace MyProject
{
    public partial class Form2 : Form
    {
        string provider;
        public Form2()
        {
            InitializeComponent();
            provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Filme.accdb";

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand();

            try
            {
                conexiune.Open();
                if(string.IsNullOrEmpty(tbDenumire.Text))
                {
                    erDenumire.SetError(tbDenumire, "Introduceti o denumire");
                }

                comanda.Connection = conexiune;
                comanda.CommandText = "insert into filme values(?,?,?,?)";

                comanda.Parameters.Add("Denumire", OleDbType.Char, 20).Value = tbDenumire.Text;

                int nota = Int32.Parse(cbNota.Text.Trim());
                comanda.Parameters.Add("Nota", OleDbType.Char, 10).Value = nota;

                string[] tmp = new string[clbGen.CheckedIndices.Count];
                int i = 0;
                foreach (string s in clbGen.CheckedItems)
                {
                    tmp[i] = s;
                    i++;
                }
                string gen = string.Join(",", tmp);

                comanda.Parameters.Add("Gen", OleDbType.Char, 10).Value =gen;
                Boolean vizualizat = cbVizualizat.Checked;
                comanda.Parameters.Add("Vizualizat/Nevizualizat", OleDbType.Char, 10).Value = vizualizat;



                comanda.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
                cbNota.Text = "";
                cbVizualizat.Checked = false;
                clbGen.ClearSelected();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    }

