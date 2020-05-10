using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFS_Shrink_Duplicate_V2._0
{
    public partial class Form1 : Form
    {
        // Program for fractal structures by Iterated Function Systems (IFS) - Construction by transformation of complete images / structures
        // 
        // Keeping Form1 and NewFrame as lean as possible all methodes are in class "MainMethodes" (well, it's now somehow in between...)
        // Async mode for outPut-methode due to long-term calculation of fractal construction is NOT working (in the meantime process is fast)
        // Async attempt at different positions in program lead to program interuption due to multi-use of PictureBox (e.g. at refreshing)
        // Lock does not work - after locking program area (including refreshing order) program still interrupts
        // Improving processing time of fractal calculation:
        // - Step #1: by factor of app. 3 brings time of 1 itteration from 3+sec down to 1+sec
        // - Step #2: by another factor of app. 3 by skipping all transparent pixels (alpha value != 255)  
        //   (for simple circle overall time is now <<1sec)
        //
        // Therfore open points (I stop now at this point - for this code I do not need further improvement):
        // - solving multi-use problem of PictureBox "field"
        // - speed up image processing -> have to step over to unsafe code 
        // - initial image could be filling complete 600x600 bitmap -> recent program: keeping image proportions, 

        // S.N.U.F 01.05.2020
        // Last change: 10.05.2020

        MainMethods MM0 = new MainMethods();            // Generation of MainMathode instance      
        private BindingSource dataSheet = new BindingSource();  // Generation of bindigsource for dataGridview
        private int size = 600;                          // definition of scale of playground / window
        private double[,] Para = new double[8, 7];

        public Form1()
        {
            InitializeComponent();
            this.Icon = new Icon("C:/Users/user/source/repos/00_Data/01_Icons/Nufer/NU_3x_256x256_TrueCol.ico");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Definition of datasource for dataGridView and initialization of bindingsource
            dataGridView2.DataSource = dataSheet;
            MM0.LoadData("sirpinski", textBox_Points, textBox_IFSName, dataSheet); // initial filling with sirpinski-parameter set
        }
        //
        // -------------------------------------------------------------------------------------------------
        //
        // Definition of fractal parameters (connected by checking radiobuttons
        private void radioButton_Sirpinski_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("sirpinski", textBox_Points, textBox_IFSName, dataSheet);
        }

        private void radioButton_Koch_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("koch", textBox_Points, textBox_IFSName, dataSheet);
        }

        private void radioButton_CantorLab_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("CantorLab", textBox_Points, textBox_IFSName, dataSheet);
        }

        private void radioButton_SirPenta_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("SirpinskiPenta", textBox_Points, textBox_IFSName, dataSheet);
        }

        private void radioButton_Vic_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("VicFractal", textBox_Points, textBox_IFSName, dataSheet);
        }

        private void radioButton_SirCarp_CheckedChanged(object sender, EventArgs e)
        {
            MM0.LoadData("SirpinskiCarp", textBox_Points, textBox_IFSName, dataSheet);
        }
        //
        // ------------------------------------------------------------------------------------------------------------------------------
        //
        // Definition of ToolStripButtons
        private void toolStripButton_Start_Click(object sender, EventArgs e)
        {
            // Grap parameters from dataGridview2 (they could be modified by user)
            string [][] AllData = MM0.GetData(dataGridView2, textBox_IFSName, textBox_Points);

            // new instance of NewFrame
            NewFrame outputWin = new NewFrame(size, AllData);
            outputWin.Show();

        } // open new frame for loading image and calculating fractal

        private void toolStripButton_Safe_Click(object sender, EventArgs e)
        {
            MM0.SafeIFS(dataGridView2, textBox_IFSName, textBox_Points);
        } // Safe IFS to CSV-file from data in dataGrid and textBoxes

        private void toolStripButton_Load_Click(object sender, EventArgs e)
        {
            // Align radiobutton array 
            radioButton_ImportIFS.Checked = true;
            // Load IFS from disk
            MM0.LoadIFS(dataSheet, textBox_IFSName, textBox_Points);
        } // Load IFS-data from CSV-file 

        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Program-End with Exit-Button

        private void toolStripButton_Info_Click(object sender, EventArgs e)
        {
            NewFrame Info = new NewFrame();
            Info.Show();
        } // Opens new frame with information regarding fractal construction methode 
        //
        // ------------------------------------------------------------------------------------------------------------------------------
        //
        // Control of allowed input for textBoxes...
        private void textBox_Points_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
        } // Control of allowed input

        private void textBox_IFSName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
        } // Control of allowed input
    }
}
