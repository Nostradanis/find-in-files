using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FindInFiles
{
    public partial class Form1 : Form
    {

        public string APP_PATH = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public StringComparison caseinsensitive = StringComparison.OrdinalIgnoreCase;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "C:\\";

            listOrigenes.View = View.Details;
            listOrigenes.Columns.Add("Origen", listOrigenes.Size.Width, HorizontalAlignment.Left);

            listResultados.View = View.Details;
            listResultados.FullRowSelect = true;
            listResultados.Columns.Add("Ruta", listResultados.Size.Width - 90, HorizontalAlignment.Left);
            listResultados.Columns.Add("#", 90, HorizontalAlignment.Left);

            RefrescarListaOrigenes();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (txtRuta.Text.Length > 0)
            {
                folderBrowserDialog1.SelectedPath = txtRuta.Text;
            }
            

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialog1.SelectedPath;

            }
        }



        void DirSearch_ex3(string sDir, string sPattern)
        {
            //Console.WriteLine("DirSearch..(" + sDir + ")");
            try
            {



                foreach (string f in Directory.GetFiles(sDir, sPattern))
                {

                    buscarTextoFichero(f, txtBuscar.Text);

                }

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    DirSearch_ex3(d, sPattern);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }


        void buscarTextoFichero(string fichero, string texto)
        {


            int counter = 0;
            string line;



            System.IO.StreamReader file =
                new System.IO.StreamReader(fichero);

            while ((line = file.ReadLine()) != null)
            {

                if (chkCase.Checked)
                {
                    //Case sensitive
                    if (line.Contains(texto))
                    {
                        ListViewItem lvi = new ListViewItem(fichero);
                        lvi.SubItems.Add("" + counter);
                        listResultados.Items.Add(lvi);
                    }
                }
                else
                {
                    //Case insensitive

                    if (line.IndexOf(texto, caseinsensitive) >= 0)
                    {
                        ListViewItem lvi = new ListViewItem(fichero);
                        lvi.SubItems.Add("" + counter);
                        listResultados.Items.Add(lvi);
                    }

                }



                counter++;
            }

            file.Close();


        }

        private void Buscar()
        {


            if(txtBuscar.Text.Length == 0){ return; }

            listResultados.Items.Clear();
            lblFicheroSelec.Text = "";
            txtFichero.Clear();
            btnBuscar.Text = "Buscando...";
            btnBuscar.Enabled = false;

            if (txtRuta.Text.Length > 0 && txtPattern.Text.Length > 0)
            {

                string[] patterns = txtPattern.Text.Split('|');
                foreach (string pattern in patterns)
                {
                    DirSearch_ex3(txtRuta.Text, pattern);
                }
            }
            else
            {

                MessageBox.Show("Debes seleccionar un ORIGEN", "¿Donde Busco?",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
            }

            btnBuscar.Text = "Buscar";
            btnBuscar.Enabled = true;
            lblNumRegistros.Text = listResultados.Items.Count + "  registros";

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                Buscar();
            }

        }

        private void listResultados_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                //txtFichero.LoadFile(e.Item.Text, RichTextBoxStreamType.PlainText);

                txtFichero.Text = File.ReadAllText(e.Item.Text, Encoding.UTF8);

                lblFicheroSelec.Text = listResultados.FocusedItem.SubItems[0].Text.Split('\\')[listResultados.FocusedItem.SubItems[0].Text.Split('\\').Length-1] ;

                //scroll
                if (Int32.Parse(listResultados.FocusedItem.SubItems[1].Text) > txtFichero.Lines.Count()) return;
                txtFichero.SelectionStart = txtFichero.Find(txtFichero.Lines[Int32.Parse(listResultados.FocusedItem.SubItems[1].Text)]);
                txtFichero.ScrollToCaret();

                //seleccionar
                HighlightText(txtFichero, txtBuscar.Text, Color.Red);


            }
        }

        public void HighlightText(RichTextBox myRtb, string word, Color color)
        {

            if (word == string.Empty)
                return;

            int s_start = myRtb.SelectionStart, startIndex = 0, index;


            if (chkCase.Checked)
            {
                //Case sensitive

                while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1)
                {
                    myRtb.Select(index, word.Length);
                    myRtb.SelectionColor = color;

                    startIndex = index + word.Length;
                }

            }
            else
            {
                //Case insensitive

                while ((index = myRtb.Text.IndexOf(word, startIndex, caseinsensitive)) != -1)
                {
                    myRtb.Select(index, word.Length);
                    myRtb.SelectionColor = color;

                    startIndex = index + word.Length;
                }

            }




            myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            myRtb.SelectionColor = Color.Black;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarLista();


        }

        public void RefrescarListaOrigenes()
        {

            listOrigenes.Items.Clear();

            foreach (string f in Directory.GetFiles(APP_PATH + "\\conf", "*.txt"))
            {

                listOrigenes.Items.Add(new ListViewItem(f.Split('\\')[f.Split('\\').Length - 1].Replace(".txt", "")));

            }
        }

        public void CargarLista(string nombre)
        {

            String line;
            try
            {


                StreamReader sr = getReader("conf", nombre + ".txt");

                if (sr != null)
                {

                    txtNombre.Text = nombre;

                    line = sr.ReadLine();
                    txtRuta.Text = line;

                    line = sr.ReadLine();
                    txtPattern.Text = line;

                    sr.Close();
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }


        public void GuardarLista()
        {

            try
            {

                System.IO.StreamWriter SaveFile = getWriter("conf", txtNombre.Text + ".txt");
                SaveFile.WriteLine(txtRuta.Text);
                SaveFile.WriteLine(txtPattern.Text);
                SaveFile.Close();

                RefrescarListaOrigenes();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }

        private System.IO.StreamReader getReader(string carpeta, string fichero)
        {

            string ruta = APP_PATH + "\\" + carpeta;
            bool folderExists = Directory.Exists(ruta);
            bool fileExists = File.Exists(ruta + "\\" + fichero);

            if (!folderExists || !fileExists) return null;

            return new StreamReader(ruta + "\\" + fichero);


        }

        private System.IO.StreamWriter getWriter(string carpeta, string fichero)
        {

            string ruta = APP_PATH + "\\" + carpeta;
            CrearRutaSiNoExiste(ruta);

            return new System.IO.StreamWriter(ruta + "\\" + fichero);

        }

        private void CrearRutaSiNoExiste(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
        }

        private void listOrigenes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listOrigenes.SelectedItems.Count > 0)
            {
                CargarLista(listOrigenes.SelectedItems[0].Text);
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void listResultados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listResultados.Items.Count > 0)
            {
                System.Diagnostics.Process.Start(listResultados.SelectedItems[0].SubItems[0].Text);


            }
        }

        private void listResultados_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (listResultados.Items.Count > 0 && ((int)e.KeyChar == (int)Keys.Enter))
            {
                System.Diagnostics.Process.Start(listResultados.SelectedItems[0].SubItems[0].Text);


            }
        }


        private void listOrigenes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                File.Delete(APP_PATH + "\\conf\\" + listOrigenes.SelectedItems[0].Text + ".txt");
                txtNombre.Text = "";
                txtRuta.Text = "";
                txtPattern.Text = "";
                listOrigenes.SelectedItems[0].Remove();
            }
        }

        private void rdbTXT_CheckedChanged(object sender, EventArgs e)
        {
            txtPattern.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rdbTS_CheckedChanged(object sender, EventArgs e)
        {
            txtPattern.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rdbHTML_CheckedChanged(object sender, EventArgs e)
        {
            txtPattern.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rdbCSS_CheckedChanged(object sender, EventArgs e)
        {
            txtPattern.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rdbJSON_CheckedChanged(object sender, EventArgs e)
        {
            txtPattern.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rdbJS_CheckedChanged(object sender, EventArgs e)
        {
            txtPattern.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtPattern.Text = ((RadioButton)sender).Tag.ToString();
        }
    }
}
