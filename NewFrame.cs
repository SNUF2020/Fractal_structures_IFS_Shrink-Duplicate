using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFS_Shrink_Duplicate_V2._0
{
    class NewFrame : Form
    {
        private MainMethods MM1 = new MainMethods();            // Generation of MainMathode instance   

        private MainMenu myMainMenu;

        private MenuItem myMItemRun;
        private MenuItem myMItemOpen;
        private MenuItem myMItemSafe;

        private StatusBar myStatusBar;

        private string[][] AllData_NewFrame; // all IFS parameters from main-frame dataGridview + textboxes

        private Bitmap Bitmap1 = new Bitmap(600, 600, PixelFormat.Format24bppRgb);
        //public Bitmap Bitmap2 = new Bitmap(600, 600, PixelFormat.Format24bppRgb);
        private PictureBox Field;

        private LinkLabel LinkText;

        //
        // -------------------------------------------------------------------------------------------------
        //
        // First constructor: frame for fractal calculation (including also load/safe of image)
        public NewFrame(int size, string [][] allData)
        {
            // caption bar text and icon of NewFrame
            this.Text = "Output Window";
            this.Icon = new Icon("C:/Users/user/source/repos/00_Data/01_Icons/Win10_Icons/imageres_106.ico");
            this.AllData_NewFrame = allData;
            //
            //-----------------------------------------------------------------------
            //
            // MainMenu = container for MenuIltems at top end of frame
            myMainMenu = new MainMenu();
            // Items of MainMenue
            myMItemRun = new MenuItem();
            myMItemOpen = new MenuItem();
            myMItemSafe = new MenuItem();
            // Lables of items
            myMItemRun.Text = "Start Iteration";
            myMItemOpen.Text = "Open Image";
            myMItemSafe.Text = "Safe Image";
            // Eventhandler click on MenueItem
            myMItemRun.Click += new EventHandler(myMenuEvent);
            myMItemOpen.Click += new EventHandler(myMenuEvent);
            myMItemSafe.Click += new EventHandler(myMenuEvent);
            // First menue level:
            myMainMenu.MenuItems.Add(myMItemRun);
            myMainMenu.MenuItems.Add(myMItemOpen);
            myMainMenu.MenuItems.Add(myMItemSafe);
            // allocation of myMainMenu to menu of class NewFrame
            this.Menu = myMainMenu;
            //
            //--------------------------------------------------------------------------
            //
            // settings of NewFrame
            this.MaximizeBox = false;                            // Set the MaximizeBox to false to remove the maximize box.
            this.MinimizeBox = false;                            // Set the MinimizeBox to false to remove the minimize box.
            this.StartPosition = FormStartPosition.CenterScreen; // Set the start position of the form to the center of the screen.
            this.AutoSize = false;
            this.Size = new Size(size+20, size+80);
            //
            //-----------------------------------------------------------------------------
            //
            // feature #1: pictureBox 
            this.Field = new PictureBox()
            {
                Size = new Size(size, size)
            };
            Field.Image = Bitmap1;
            this.Bitmap1.MakeTransparent();

            Graphics g = Graphics.FromImage(Bitmap1);
            //g.Clear(Color.White);

            Pen blackPen = new Pen(Color.Black, 3);
            SolidBrush red_Brush = new SolidBrush(Color.Black);
            Rectangle rect1 = new Rectangle(150, 150, 300, 300);
            g.DrawEllipse(blackPen, rect1);
            g.FillEllipse(red_Brush, rect1);
            Controls.Add(Field);
            g.Dispose();
            blackPen.Dispose();
            red_Brush.Dispose();
            //
            //------------------------------------------------------------------------------------
            //
            // StatusBar at lower end of frame
            myStatusBar = new StatusBar();
            myStatusBar.Text = AllData_NewFrame[0][0];
            myStatusBar.SizingGrip = true;
            Controls.Add(myStatusBar);
        } // constructor of NewFrame, first overload
        //
        // -------------------------------------------------------------------------------------------------
        //
        // Second constructor: frame with information regarding fractal construction
        public NewFrame()
        {
            // caption bar text and icon of NewFrame
            this.Text = "Information Window";
            this.Icon = new Icon("C:/Users/user/source/repos/00_Data/01_Icons/Win10_Icons/imageres_81.ico");
            //
            //-----------------------------------------------------------------------
            //
            // settings of NewFrame
            this.MaximizeBox = false;                            // Set the MaximizeBox to false to remove the maximize box.
            this.MinimizeBox = false;                            // Set the MinimizeBox to false to remove the minimize box.
            this.StartPosition = FormStartPosition.CenterScreen; // Set the start position of the form to the center of the screen.
            this.AutoSize = false;
            this.Size = new Size(520, 300);
            //
            //-----------------------------------------------------------------------------
            //
            // feature #1: Labels with information 
            Label HeadLine = new Label()
            {
                Size = new Size(500, 20),
                Location = new Point(5, 10),
                Text = "Iterated Function System (IFS) and Image Transformation",
                AutoSize = false,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            Controls.Add(HeadLine);

            Label InfoText = new Label()
            {
                Size = new Size(500, 120),
                Location = new Point(5, 40),
                Text =
                "In mathematics, iterated function systems (IFSs) are a method of constructing fractals. \n" +
                "one out of several possible algorithms to compute IFS fractals is to transform a shape or image in a itterative way." +
                "It consists of transforming a image with each given function (see IFS) getting a new image, which is the starting " +
                "point for the next itteration.\n" +
                "(Source: Wikipedia)",
                AutoSize = false,
                Font = new Font("Arial", 10, FontStyle.Regular)
            };
            Controls.Add(InfoText);

            LinkText = new LinkLabel()
            {
                Size = new Size(500, 200),
                Location = new Point(5, 160),
                Text = " https://en.wikipedia.org/wiki/Iterated_function_system/ ",
                AutoSize = false,
                Font = new Font("Arial", 10, FontStyle.Regular)
            };
            LinkText.LinkClicked += new LinkLabelLinkClickedEventHandler(linkText_LinkClicked);
            Controls.Add(LinkText);
        } // constructor of NewFrame, second overload
        //
        // -------------------------------------------------------------------------------------------------
        //
        // Definitions of menu + actions 
        private void myMenuEvent(object sender, System.EventArgs e)
        {
            if (sender.Equals(myMItemSafe))
                MM1.SafeImage(Field);
            if (sender.Equals(myMItemOpen))
                MM1.OpenImage(Field);
            if (sender.Equals(myMItemRun))
                RunIFS(Bitmap1, Field, AllData_NewFrame);
        }
        private async void RunIFS(Bitmap Bitmap1, PictureBox Field, string[][] AllData_NewFrame)
        {   
            for (int j = 0; j < Convert.ToInt32(AllData_NewFrame[1][0]); j++)
            {
                await Task.Run(() => LockUnlockBits(Bitmap1, AllData_NewFrame));
                Field.Refresh();
            }
        } // Run fractal construction
         
        private void Work(Bitmap Bitmap1, string[][] AllData_NewFrame, Graphics g2)
        {
            double size = 600.0;
            for (int i = 0; i < Bitmap1.Width; i++)
            {
                for (int k = 0; k < Bitmap1.Height; k++)
                {
                    Color pixelColor0 = Bitmap1.GetPixel(i, k);
                    SolidBrush pixelBrush = new SolidBrush(pixelColor0);
                    for (int l = 3; l < AllData_NewFrame.GetLength(0); l++)
                    {
                        int x = (int)(Convert.ToDouble(AllData_NewFrame[l][1]) * i + Convert.ToDouble(AllData_NewFrame[l][2]) * k
                            + Convert.ToDouble(AllData_NewFrame[l][5]) * size);
                        int y = (int)(Convert.ToDouble(AllData_NewFrame[l][3]) * i + Convert.ToDouble(AllData_NewFrame[l][4]) * k
                            + Convert.ToDouble(AllData_NewFrame[l][6]) * size);
                        g2.FillRectangle(pixelBrush, (float)(x * Convert.ToDouble(AllData_NewFrame[2][2])
                            + Convert.ToDouble(AllData_NewFrame[2][0]) * size),
                            (float)(y * Convert.ToDouble(AllData_NewFrame[2][2])
                            + Convert.ToDouble(AllData_NewFrame[2][1]) * size), 1, 1);
                    }
                }
            }
        }
        // this is the method with the standard way of image processing -> 7 itterations took app. 22 sec !
        // In comparison: method below (LockUnlockBits) w/ processing complete image takes for same fractal (7 itterations, serpinski triangle) app. 8 sec. :-)
        // Additional speed-up by excluding transparent pixels (alpha value != 255) 
        // -> processing time for normal photo (e.g.400x600), 7 itterations, serpinski triangle: 3,5 sec. :-))

        private void LockUnlockBits(Bitmap bmp, string[][] AllData_NewFrame)
        {
            // Lock the bitmap's bits.
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the initial Bitmap bmp.
            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            // Declare an dummy-array to hold the modified bytes
            int bytes_dummy = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues_dummy = new byte[bytes_dummy];

            // Copy the RGB values of Bitmap1 into the array "rgbValues".
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            
            // dummy variables
            byte help_byte_blue_new; // Hilfsvariable
            byte help_byte_green_new; // Hilfsvariable
            byte help_byte_red_new; // Hilfsvariable
            byte help_byte_alpha_new; // Hilfsvariable
            byte help_byte_blue_old = 0; // Hilfsvariable
            byte help_byte_green_old = 0; // Hilfsvariable
            byte help_byte_red_old = 0; // Hilfsvariable
            byte help_byte_alpha_old = 0; // Hilfsvariableint x_old;
            // defintion of coordinates
            int y_old;
            int x_old;
            int x_new;
            int y_new; int x_dummy = 2;
            int Zeile = Math.Abs(bmpData.Stride);

            // Logic of rgb-values depends on used format
            // 24bpp: Blue - Green - Red - Blue - Green - ... and so on (on pixel = 3 following bytes bgr
            // 32bpp: Blue - Green - Red - Alpha - Blue - ... and so on (on pixel = 4 following bytes bgrA
            // 
            // e.g. blue component (bit #0 + mod4)  
            for (int counter = 0; counter < rgbValues.Length; counter += 4)
            {
                // getting rgba data from byte array from initial image
                help_byte_blue_new = rgbValues[counter];       // 
                help_byte_green_new = rgbValues[counter + 1];
                help_byte_red_new = rgbValues[counter + 2];
                help_byte_alpha_new = rgbValues[counter + 3];
                // getting coordiantions of pixel in initial image
                y_old = counter / Zeile;       // separating one-dimensional arry into rows -> getting back image structure
                x_old = (counter) % Zeile / 4; // Here we have to handle specific data structur: 1 pixel = 4 byte in the array
                //
                // --------------------------------------------------------------------------------------
                //
                if (rgbValues[counter + 3] == 255) // alpha = 255 -> pixel is visible, just visible pixel will be processed -> speed up a lot!
                {
                    // Taking given ifs parameters from array AllData_NewFrame and calculating fractal
                    for (int l = 3; l < AllData_NewFrame.GetLength(0); l++)
                    {
                        x_new = (int)(Convert.ToDouble(AllData_NewFrame[l][1]) * x_old + Convert.ToDouble(AllData_NewFrame[l][2]) * y_old
                            + Convert.ToDouble(AllData_NewFrame[l][5]) * bmp.Width);
                        y_new = (int)(Convert.ToDouble(AllData_NewFrame[l][3]) * x_old + Convert.ToDouble(AllData_NewFrame[l][4]) * y_old
                            + Convert.ToDouble(AllData_NewFrame[l][6]) * bmp.Height);
                        //
                        // ---------------------------------------------------------------------------------------------
                        //
                        // if shrinking of image lead to multi-writing in new pixel -> mean value of all rgbaValues
                        // without this part: omly the information of the last pixel written into new pixel cell will be stored (result also ok)
                        if (x_new == x_dummy)
                        {
                            help_byte_blue_new = (byte)((help_byte_blue_new / 2) + (help_byte_blue_old / 2));
                            help_byte_green_new = (byte)((help_byte_green_new / 2) + help_byte_green_old / 2);
                            help_byte_red_new = (byte)(help_byte_red_new / 2 + help_byte_red_old / 2);
                            help_byte_alpha_new = (byte)(help_byte_alpha_new / 2 + help_byte_alpha_old / 2);
                        }
                        // keeping rgb-values for next loop in case new pixel is the same
                        help_byte_blue_old = help_byte_blue_new;
                        help_byte_green_old = help_byte_green_new;
                        help_byte_red_old = help_byte_red_new;
                        help_byte_alpha_old = help_byte_alpha_new;
                        // keeping pixel value for next loop 
                        x_dummy = x_new;
                        //
                        // ------------------------------------------------------------------------------------------------------
                        //
                        // writing of rgba-values into dummy array = new image
                        if (y_new * Zeile + x_new * 4 < bytes) // safeguarding that possible ifs-calculations outside do not lead to interrupt
                        {
                            rgbValues_dummy[y_new * Zeile + x_new * 4] = help_byte_blue_new;
                            rgbValues_dummy[y_new * Zeile + x_new * 4 + 1] = help_byte_green_new;
                            rgbValues_dummy[y_new * Zeile + x_new * 4 + 2] = help_byte_red_new;
                            rgbValues_dummy[y_new * Zeile + x_new * 4 + 3] = help_byte_alpha_new;
                        }
                    }
                }
                
            }
            // Copy the rgba values to the  bitmap -> creating new image
            System.Runtime.InteropServices.Marshal.Copy(rgbValues_dummy, 0, ptr, bytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);
        }

        private void linkText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Change the color of the link text by setting LinkVisited to true
                LinkText.LinkVisited = true;
                //Call the Process.Start method to open the default browser with a URL:
                System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Iterated_function_system");
            }
            catch
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        } // Link in information frame

       
    }
}
