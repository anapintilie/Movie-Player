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
using System.IO;
using System.Xml.Serialization;

namespace MyProject
{
    public partial class Form1 : Form
    {
        DirectorVideo dv = new DirectorVideo();
        string provider;

        public Form1()
        {
            
            InitializeComponent();
            provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Filme.accdb";

        }

        private void openMediaPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void rewindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void fastforwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void AfisareFilme()
        {
            lvVideoPlayer.Items.Clear();

            foreach (FisierVideo video in dv.listVideo)
            {

                var film = new ListViewItem(video.Denumire);
                film.SubItems.Add(video.Nota.ToString());
                film.SubItems.Add(video.Gen);
                film.SubItems.Add(video.Vizualizat.ToString());
                lvVideoPlayer.Items.Add(film);
            }
        }


        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try {
                string denumire = axWindowsMediaPlayer1.URL;
                Boolean vizualizat = cbVizualizat.Checked;
                int nota = Int32.Parse(cbNota.Text.Trim());
                string[] tmp = new string[clbGen.CheckedIndices.Count];
                int i = 0;
                foreach (string s in clbGen.CheckedItems)
                {
                    tmp[i] = s;
                    i++;
                }
                string gen = string.Join(",", tmp);

                var video = new FisierVideo(denumire, nota, gen, vizualizat);
                dv.listVideo.Add(video);//il adaug in list de fis video
                //lvVideoPlayer.Items.Add(video)//il adaug in list view

                
                AfisareFilme();
                cbNota.Text = "";
                cbVizualizat.Checked = false;
                clbGen.ClearSelected();
            }catch(Exception execptie)
                {
                MessageBox.Show("Folderul nu a fost selectat!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  

        private void delete()
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;
                //stegre cate una:
                //comanda.CommandText = "delete from filme where Denumire=? ";
                //comanda.Parameters.Add("Denumire", OleDbType.Char, 100).Value = lvVideoPlayer.SelectedItems[0].SubItems[0].Text;
                //comanda.ExecuteNonQuery();

                //sterge mai multe
                //for (int i = 0; i <= lvVideoPlayer.SelectedItems.Count - 1; i++)
                //{
                //    comanda.CommandText = "delete from FisierVideo where Denumire=? ";
                //    comanda.Parameters.Add("Denumire", OleDbType.Char, 100).Value = lvVideoPlayer.SelectedItems[i].SubItems[0].Text;
                //    comanda.ExecuteNonQuery();
                //}

                //sterge multe cu chech box
                foreach(ListViewItem itm in lvVideoPlayer.Items)
                {
                    if (itm.Checked == true)
                    {
                        comanda.CommandText = "delete from filme where Denumire=? ";
                        comanda.Parameters.Add("Denumire", OleDbType.Char, 100).Value = itm.SubItems[0].Text;
                        comanda.ExecuteNonQuery();
                       lvVideoPlayer.Items.Remove(itm);//nu trebuie sa selectez toata linia,ci doar sa checkuiesc
                    }

                }
                MessageBox.Show("Data stersa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
         //   lvVideoPlayer.Items.RemoveAt(lvVideoPlayer.SelectedIndices[0]);//asa checkuiesc si selectez si toata linia
        }
        

        private void btnSterge_Click(object sender, EventArgs e)
        {
            try {
                delete(); }
            catch(Exception exce)
            
            {
                MessageBox.Show("Nu ati selectat niciun fisier!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        void CitireBD()
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM filme", conexiune);
            //lvVideoPlayer.Items.Clear();
            try
            {
                conexiune.Open();


                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["Denumire"].ToString());
                    itm.SubItems.Add(reader["Nota"].ToString());
                    itm.SubItems.Add(reader["Gen"].ToString());
                    itm.SubItems.Add(reader["Vizualizat/Nevizualizat"].ToString());

                    lvVideoPlayer.Items.Add(itm);

                    //pt a sle scrie in lista mea de video
                    Boolean viz;
                    if (reader["Vizualizat/Nevizualizat"].ToString() == "Yes")
                        viz = true;
                    else viz = false;
                    
                    FisierVideo nou = new FisierVideo( reader["Denumire"].ToString(), Int32.Parse(reader["Nota"].ToString()), reader["Gen"].ToString(), viz);
                    dv.listVideo.Add(nou);
                    

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("M-am conectat!");
            CitireBD();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //
        }

        private void btnInserare_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void reimprospatareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfisareFilme();
        }

        private void sortareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dv.listVideo.Sort();
            AfisareFilme();
        }

        private void btnEditare_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand("Update filme set Nota=? where Denumire=?",conexiune);
            
                    try
                    {
                        conexiune.Open();
               // comanda.CommandText = "Update filme set Nota=? where Denumire=?";
                comanda.Parameters.Add("Nota", OleDbType.Numeric, 2).Value = Int32.Parse(cbNota.Text.Trim());
                comanda.Parameters.Add("Denumire", OleDbType.Char, 100).Value = lvVideoPlayer.SelectedItems[0].SubItems[0].Text;
                      //  comanda.Connection = conexiune;
                        comanda.ExecuteNonQuery();
                        MessageBox.Show("Editare reusita!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexiune.Close();
                    }
            lvVideoPlayer.Items.Clear();
            CitireBD();
        }

        private void reimprospatareToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AfisareFilme();
        }

        private void sortareToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dv.listVideo.Sort();
            AfisareFilme();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();

        }

        Point p = new Point(45, 60);
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            foreach(FisierVideo video in dv.listVideo)
            {
                
                e.Graphics.DrawString("\n"+video.Denumire + "\n " + video.Vizualizat+"\n",new Font("Arial",15,FontStyle.Italic),Brushes.BlueViolet,p.X=45,p.Y=p.Y+25);

            }
        }

        //treeView
        String URLFolder;
        private void button3_Click(object sender, EventArgs e)
        {
            try {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    URLFolder = folderBrowserDialog.SelectedPath;
                }
                
                TreeNode path = new TreeNode(URLFolder);
                DirectoryInfo directoryInfo = new DirectoryInfo(@URLFolder);
                DirectoryInfo[] directories = directoryInfo.GetDirectories();
                tvFilme.Nodes.Add(path);
                if (directories.Length > 0)
                {
                    foreach (DirectoryInfo directory in directories)
                    {
                        TreeNode node = tvFilme.Nodes[path.Index].Nodes.Add(directory.Name);

                        foreach (FileInfo file in directory.GetFiles())
                        {
                            if (file.Exists)
                            {
                                TreeNode nodes = tvFilme.Nodes[0].Nodes[node.Index].Nodes.Add(file.Name);

                            }
                        }
                    }
                }
            }catch(Exception est)
            
            {
                MessageBox.Show("Alegeti o cale mai intai!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
         
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
       
            XmlSerializer serializer = new XmlSerializer(typeof(List<FisierVideo>));
            using (TextWriter writer = new StreamWriter("SerializedXML.xml"))
            {
                serializer.Serialize(writer, dv.listVideo);
            }
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<FisierVideo>));
            using (StreamReader streamReader = new StreamReader("SerializedXML.xml"))
            {
                dv.listVideo = (List<FisierVideo>)serializer.Deserialize(streamReader);
                AfisareFilme();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand();

            try
            {
                conexiune.Open();


                comanda.Connection = conexiune;
                foreach (FisierVideo video in dv.listVideo)
                {
                    comanda.CommandText = "insert into filme values(?,?,?,?)";
                    comanda.Parameters.Add("Denumire", OleDbType.Char, 100).Value = video.Denumire;
                    comanda.Parameters.Add("Nota", OleDbType.Numeric, 2).Value = video.Nota;
                    comanda.Parameters.Add("Gen", OleDbType.Char, 100).Value = video.Gen;
                    if (video.Vizualizat == true)
                    {
                        comanda.Parameters.Add("Vizualizat/Nevizualizat", OleDbType.Char, 20).Value = "Yes";
                    }
                    else
                    {
                        comanda.Parameters.Add("Vizualizat/Nevizualizat", OleDbType.Char, 20).Value = "No";
                    }
                   

                    comanda.ExecuteNonQuery();

                }
                MessageBox.Show("Date salvate!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Boolean v;
            lvVideoPlayer.Items.Clear();
            if (comboBox1.Text.Trim() == "Vizualizat")
                v = true;
            else v = false;
            foreach (FisierVideo video in dv.listVideo)
            {

                if (video.Vizualizat == v)
                {
                    string notas;
                    var film = new ListViewItem(video.Denumire);
                    film.SubItems.Add(video.Nota.ToString());
                    film.SubItems.Add(video.Gen);
                    if (video.Vizualizat == true)
                        notas = "vizualizat";
                    else notas = "nevizualizat";
                    film.SubItems.Add(notas);
                    lvVideoPlayer.Items.Add(film);
                }
            }
        }

        private void tvFilme_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
    }

