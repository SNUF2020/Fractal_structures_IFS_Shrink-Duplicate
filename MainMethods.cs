using System;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace IFS_Shrink_Duplicate_V2._0
{
    class MainMethods
    {
        //
        // -------------------------------------------------------------------------------------------------
        //
        // Definition of fractal parameters (after checking radiobuttons)
        public void LoadData(string _case, TextBox textBoxSchleife, TextBox textBox_IFSName, BindingSource DatenQuelle)
        {
            // Generation of DataTable
            DataTable pt = new DataTable("IFS");

            string[] colHead = { "Color", "A", "B", "C", "D", "E", "F", "p" };
            DataColumn col0 = new DataColumn();
            col0.DataType = System.Type.GetType("System.String");
            col0.ColumnName = colHead[0];
            pt.Columns.Add(col0);

            for (int i = 1; i < 8; i++)
            {
                DataColumn col = new DataColumn();
                col.DataType = System.Type.GetType("System.Double");
                col.ColumnName = colHead[i];
                pt.Columns.Add(col);
            }
            if (_case == "sirpinski")
            {
                pt.Rows.Add(new Object[] { "Red", 0.5, 0, 0, 0.5, 0.50, 0.00, 0.333 });
                pt.Rows.Add(new Object[] { "Green", 0.5, 0, 0, 0.5, 0.00, 0.00, 0.333 });
                pt.Rows.Add(new Object[] { "Blue", 0.5, 0, 0, 0.5, 0.25, 0.50, 0.334 });
                // Shift X, Shift Y, scaling of fractal
                
                textBoxSchleife.Text = Convert.ToString(7);
                textBox_IFSName.Text = "Sierpiński Triangle";

            }
            else if (_case == "koch")
            {
                pt.Rows.Add(new Object[] { "Red", 0.33333, 0.000, 0.000, 0.333, 0.00000, 0.000, 0.25 });
                pt.Rows.Add(new Object[] { "Green", 0.16667, -0.288, 0.288, 0.167, 0.33333, 0.000, 0.25 });
                pt.Rows.Add(new Object[] { "Blue", 0.16667, 0.288, -0.288, 0.167, 0.50000, 0.288, 0.25 });
                pt.Rows.Add(new Object[] { "Lime", 0.33333, 0.000, 0.000, 0.333, 0.66667, 0.000, 0.25 });
                // Shift X, Shift Y, scaling of fractal
               
                textBoxSchleife.Text = Convert.ToString(7);
                textBox_IFSName.Text = "Koch Curve";
            }
            else if (_case == "CantorLab")
            {
                pt.Rows.Add(new Object[] { "Red", 0.333, 0.000, 0.00, 0.333, 0.333, 0.666, 0.14 });
                pt.Rows.Add(new Object[] { "Green", 0.000, 0.333, 1.00, 0.000, 0.667, 0.000, 0.43 });
                pt.Rows.Add(new Object[] { "Blue", 0.000, -0.333, 1.00, 0.000, 0.333, 0.000, 0.43 });
                // Shift X, Shift Y, scaling of fractal
               
                textBoxSchleife.Text = Convert.ToString(7);
                textBox_IFSName.Text = "Cantor Labyrinth";
            }
            else if (_case == "SirpinskiPenta")
            {
                pt.Rows.Add(new Object[] { "Red", 0.382, 0.000, 0.00, 0.382, 0.3072, 0.6190, 0.2 });
                pt.Rows.Add(new Object[] { "Green", 0.382, 0.000, 0.00, 0.382, 0.6033, 0.4044, 0.2 });
                pt.Rows.Add(new Object[] { "Blue", 0.382, 0.000, 0.00, 0.382, 0.0139, 0.4044, 0.2 });
                pt.Rows.Add(new Object[] { "Lime", 0.382, 0.000, 0.00, 0.382, 0.1253, 0.0595, 0.2 });
                pt.Rows.Add(new Object[] { "DarkCyan", 0.382, 0.000, 0.00, 0.382, 0.4920, 0.0595, 0.2 });
                // Shift X, Shift Y, scaling of fractal
                
                textBoxSchleife.Text = Convert.ToString(7);
                textBox_IFSName.Text = "Sirpinski Pentagram";
            }
            else if (_case == "VicFractal")
            {
                pt.Rows.Add(new Object[] { "Red", 0.333, 0.000, 0.00, 0.333, 0.000, 0.000, 0.2 });
                pt.Rows.Add(new Object[] { "Green", 0.333, 0.000, 0.00, 0.333, 0.667, 0.000, 0.2 });
                pt.Rows.Add(new Object[] { "Blue", 0.333, 0.000, 0.00, 0.333, 0.000, 0.667, 0.2 });
                pt.Rows.Add(new Object[] { "Lime", 0.333, 0.000, 0.00, 0.333, 0.667, 0.667, 0.2 });
                pt.Rows.Add(new Object[] { "DarkCyan", 0.333, 0.000, 0.00, 0.333, 0.333, 0.333, 0.2 });
                // Shift X, Shift Y, scaling of fractal
                
                textBoxSchleife.Text = Convert.ToString(7);
                textBox_IFSName.Text = "Vicsek Fractal";
            }
            else if (_case == "SirpinskiCarp")
            {
                pt.Rows.Add(new Object[] { "Red", 0.333, 0.000, 0.00, 0.333, 0.000, 0.000, 0.125 });
                pt.Rows.Add(new Object[] { "Green", 0.333, 0.000, 0.00, 0.333, 0.333, 0.000, 0.125 });
                pt.Rows.Add(new Object[] { "Blue", 0.333, 0.000, 0.00, 0.333, 0.667, 0.000, 0.125 });
                pt.Rows.Add(new Object[] { "Lime", 0.333, 0.000, 0.00, 0.333, 0.000, 0.333, 0.125 });
                pt.Rows.Add(new Object[] { "DarkCyan", 0.333, 0.000, 0.00, 0.333, 0.667, 0.333, 0.125 });
                pt.Rows.Add(new Object[] { "Plum", 0.333, 0.000, 0.00, 0.333, 0.000, 0.667, 0.125 });
                pt.Rows.Add(new Object[] { "Black", 0.333, 0.000, 0.00, 0.333, 0.333, 0.667, 0.125 });
                pt.Rows.Add(new Object[] { "Cyan", 0.333, 0.000, 0.00, 0.333, 0.667, 0.667, 0.125 });
                // Shift X, Shift Y, scaling of fractal
               
                textBoxSchleife.Text = Convert.ToString(7);
                textBox_IFSName.Text = "Sirpinski Carpet";
            }
            DatenQuelle.DataSource = pt;
            pt.Dispose();
        }
        //
        // -------------------------------------------------------------------------------------------------
        //
        // IO methods for load/safe of IFS-parameters (from CSV-file)
        public void SafeIFS(DataGridView dataGridView2, TextBox textBox_IFSName, TextBox textBox_Points)
        {
            // Displays a SaveFileDialog so the user can save the Data table
            using (SaveFileDialog sfDlg = new SaveFileDialog())
            {
                sfDlg.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                if (sfDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // generate instance if stringbuilder for later writing of csv.file
                        StringBuilder sbOutput = new StringBuilder();

                        // generate string table w/ 3 + dataGrid-rows
                        string[][] inaOutput = new string[1 + dataGridView2.Rows.Count][];

                        // first row: name of IFS
                        inaOutput[0] = new string[] { textBox_IFSName.Text };

                        // first row: number of iterations
                        inaOutput[1] = new string[] { textBox_Points.Text };

                        // second row: x-shift, y-shift and scaling factor
                        inaOutput[2] = new string[] { };

                        // next rows: ifs parameters
                        for (int i = 0; i < dataGridView2.Rows.Count; i++) // rows
                        {
                            inaOutput[i + 3] = new string[8];
                            for (int k = 0; k < 8; k++) // colums
                            {
                                inaOutput[i + 3][k] = Convert.ToString(dataGridView2.Rows[i].Cells[k].Value);
                            }
                        }
                        for (int i = 0; i < inaOutput.GetLength(0); i++)
                            sbOutput.AppendLine(string.Join(";", inaOutput[i]));

                        // Create and write the csv file
                        File.WriteAllText(sfDlg.FileName, sbOutput.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        } // Safe IFS table + all other parameters

        public void LoadIFS(BindingSource Tabelle, TextBox textBox_IFSName, TextBox textBox_Points)
        {
            using (OpenFileDialog ofDlg = new OpenFileDialog())
            {
                // Datei öffnen
                ofDlg.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                if (ofDlg.ShowDialog() == DialogResult.OK)
                {
                    // DataTable hält die gesplitteten CSV-Daten
                    DataTable dt = new DataTable();

                    string[] colHead = { "Color", "A", "B", "C", "D", "E", "F", "p" };
                    DataColumn col0 = new DataColumn();
                    col0.DataType = System.Type.GetType("System.String");
                    col0.ColumnName = colHead[0];
                    dt.Columns.Add(col0);

                    for (int i = 1; i < 8; i++)
                    {
                        DataColumn col = new DataColumn();
                        col.DataType = System.Type.GetType("System.Double");
                        col.ColumnName = colHead[i];
                        dt.Columns.Add(col);
                    }

                    // Datei öffnen, hier als UTF8
                    using (StreamReader sr = new StreamReader(ofDlg.FileName, Encoding.UTF8))
                    {
                        // bis Dateiende lesen
                        while (!sr.EndOfStream)
                        {
                            // Zeile einlesen und anhand des Trennzeichens ";" in einzelne Spalten (stringarray) splitten
                            string[] currentline = sr.ReadLine().Split(new string[] { ";" }, StringSplitOptions.None);
                            dt.Rows.Add(currentline);
                        }
                        // Stream schließen
                        sr.Close();
                    }
                    textBox_IFSName.Text = Convert.ToString(dt.Rows[0][0]);
                    textBox_Points.Text = Convert.ToString(dt.Rows[1][0]);

                    // Delete first three rows
                    DataRowCollection itemColumns = dt.Rows;
                    itemColumns[0].Delete();
                    itemColumns[0].Delete();
                    itemColumns[0].Delete();

                    // DataTable an das Gitter auf der Oberfläche übergeben und somit anzeigen
                    Tabelle.DataSource = dt;
                    dt.Dispose();
                }
            }
        }
        //
        // -------------------------------------------------------------------------------------------------
        //
        // IO methods for load/safe of images
        public void OpenImage(PictureBox Field)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    Bitmap Bild = new Bitmap(sr.BaseStream);
                    sr.Close();

                    // Resize to "right" scale (here: max. 600)
                    Bitmap RightImage = ResizeImage(Bild, new Size(600, 600));
                    // Plot "right" image to Field-Image
                    Graphics g = Graphics.FromImage(Field.Image);

                    PointF dummy = new PointF(0, 0);
                    if (RightImage.Width < 600)
                        dummy.X = (600 - RightImage.Width) / 2;
                    if (RightImage.Height < 600)
                        dummy.Y = (600 - RightImage.Height) / 2;

                    g.DrawImage(RightImage, dummy);
                    // Refresh image to show up loaded image
                    Field.Refresh();
                    g.Dispose();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        public void SafeImage(PictureBox Field)
        {
            // Displays a SaveFileDialog so the user can save the Image
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg|Gif Image|*.gif|Icon Image|*.ico";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                using (FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile())
                {
                    // Saves the Image in the appropriate ImageFormat based upon the
                    // File type selected in the dialog box.
                    // NOTE that the FilterIndex property is one-based.

                    ImageFormat imageFormat = null;
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            imageFormat = ImageFormat.Png;
                            break;
                        case 2:
                            imageFormat = ImageFormat.Bmp;
                            break;
                        case 3:
                            imageFormat = ImageFormat.Jpeg;
                            break;
                        case 4:
                            imageFormat = ImageFormat.Gif;
                            break;
                        case 5:
                            imageFormat = ImageFormat.Icon;
                            break;
                        default:
                            throw new NotSupportedException("File extension is not supported");
                    }
                    Field.Image.Save(fs, imageFormat);
                    fs.Close();
                }
            }
        }
        //
        // -------------------------------------------------------------------------------------------------
        //
        // Get all IFS parameters from main-frame dataGridView + textboxes
        public string [][] GetData(DataGridView Tabelle, TextBox textBox_IFSName, TextBox textBox_Points)
        {
            // generate string table w/ 3 + dataGrid-rows
            string[][] AllData = new string[3 + Tabelle.Rows.Count][];

            // first row: name of IFS
            AllData[0] = new string[] { textBox_IFSName.Text };

            // first row: number of iterations
            AllData[1] = new string[] { textBox_Points.Text };

            // second row: x-shift, y-shift and scaling factor
            AllData[2] = new string[] { "0", "0", "1" };

            // next rows: ifs parameters
            for (int i = 0; i < Tabelle.Rows.Count; i++) // rows
            {
                AllData[i + 3] = new string[8];
                for (int k = 0; k < 8; k++) // colums
                {
                    AllData[i + 3][k] = Convert.ToString(Tabelle.Rows[i].Cells[k].Value);
                }
            }
            return AllData;
        }
        //
        // -------------------------------------------------------------------------------------------------
        //
        // Modify Image (e.g. loaded from file) to maximum size (e.g. 600)
        private Bitmap ResizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width
            int sourceWidth = imgToResize.Width;
            //Get the image current height
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            //Calulate  width with new desired size
            nPercentW = ((float)size.Width / (float)sourceWidth);

            //Calculate height with new desired size
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            //New Width
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);

            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return b;
        }
    }
}
