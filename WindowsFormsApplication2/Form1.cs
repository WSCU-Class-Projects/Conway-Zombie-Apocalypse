using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{


    public partial class universe : Form
    {

        public Cell[,] world1 = new Cell[43, 32];
        public Cell[,] world2 = new Cell[43, 32];
        public bool on = false;
        public int countGens = 0;
        public int countPop;
        public static int uSizeX;
        public static int uSizeY;
        public bool mdown = false;
        public bool mmoved = false;
        public int x = 0;
        public int y = 0;
        public float z = 1;
        public float panx = 0;
        public float pany = 0;
        public int vx;
        public int vy;
        public int birth = 0;
        public int death = 0;
        public bool wrapBool = false;
        public float boxSizeX;
        public float boxSizeY;
        private Bitmap pic;
        // Bitmap myBitmap = new Bitmap(640, 480);
        //  Bitmap myBitmap = Bitmap.FromFile(openFileDialog2.Filename);
        Bitmap myBitmap = new Bitmap(@"E:\CS310\Colorado.jpg");
        Color color = new Color();
        public int height = 32;
        public int width = 43;
        public int r;
        public int g;
        public int b;
        public int red = 0;
        public int green = 0;
        public int blue = 0;
        public int darkness = 15;
        public double prob = 0;
        public int maybe = 0;
        public Random rand = new Random();




        public universe()
        {
            InitializeComponent();
            //world1[1, 2] = 1;
            world.Refresh();
            boxSizeX = world.Width / (int)(width);
            boxSizeY = world.Height / (int)(height);
            uSizeX = world.Height;
            uSizeY = world.Width;





        }
        


        /*    for (int i = 0; i < 64; i++)
             {
                 for (int j = 0; j < 48; j++)
                 {
                     bool clicked = false;
                     trackBar1.Scroll += (s,
                                             e) =>
                     {
                         if (clicked)
                             return;
                        // Console.WriteLine(trackBar1.Value);
                     };
                     trackBar1.MouseDown += (s,
                                             e) =>
                     {
                         clicked = true;
                     };
                     trackBar1.MouseUp += (s,
                                             e) =>
                     {
                         if (!clicked)
                             return;

                         clicked = false;
                       //  Console.WriteLine(darkness);
                     }; 
                     Color c = myBitmap.GetPixel(i * 10, j * 10);
                     //need to use formuala to convert pixels to grid
                     r = c.R;
                     g = c.G;
                     b = c.B;
                     int x = c.A;
                       Console.WriteLine(r);
                       Console.WriteLine(g);
                       Console.WriteLine(b);
                       Console.WriteLine(x);
                     if ((r + g + b) < darkness)
                        
                     {
                       
                         //cell is alive
                         // Console.WriteLine("Alive cell");
                         world1[i, j] = new Cell(r, g, b);

                     }
                
                
                     else
                     {
                        // world1[i, j] = null; 
                        // Console.WriteLine("This one's dead, jim.");
                     }

                 }


             }
      
            
         }*/



        public int wrap2(int i)
        {
            return (i + 20 * height) % 20;
        }

        public int wrap(int i)
        {
            return (i + 20 ) % 20;
        }

        public int popCount(int[,] life, int x, int y)
        {
            if (life[x, y] == 1)
            {
                return 1;
            }
            else return 0;
        }


        /* public void dropMove()
         {
             for (int i = 0; i < uSize; i++)
             {
                 for (int j = 0; j < uSize; j++)
                 {
                     int count = 0;
                     for (int k = Math.Max(i - 1, 0); k < Math.Min(i + 1, uSize); k++)
                     {
                         for (int l = Math.Max(j - 1, 0); l < Math.Min(j + 1, uSize); l++)
                         {
                             if(world1[k, l]!= null)
                             count = count + world1[k, l];
                             //  Console.WriteLine("Cell detected");
                         }
                     }
                     
                     {
                         if (count == 3 || count == 4)
                         {
                             world2[i, j] = new Cell();

                         }
                         else
                         {
                             world2[i, j] = null;

                         }
                     }
                     else
                     {
                         if (count == 3)
                         {
                             world2[i, j] = 1;

                         }
                         else
                         {
                             world2[i, j] = null;

                         }
                     }
                 }

             }
             int[,] temp = world1;
             world1 = world2;
             world2 = temp;

             world.Refresh();
             countGens++;
         }*/


        public void move()
        {
          
            //int high = 0;
            //int xg = 0;
            //int yg = 0;
            //int h1 = 0, h2 = 0, h3 = 0, h4 = 0;
            //int x = 0, y = 0;


            for (int i = 0; i < 43; i++)
            {
                for (int j = 0; j < 32; j++)
                {

                    Cell u = world1[i, j];
                    Color c = myBitmap.GetPixel(i, j);

                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            Color c2 = myBitmap.GetPixel(wrap(k), wrap2(l));
                            //if ((u = world1[wrap(k), wrap2(l)]) != null)
                            //{
                                red = red + c2.R;
                                green = green + c2.G;
                                blue = blue + c2.B;


                              

                                // count = count + m;
                                //  Console.WriteLine(count); 
                                //(world1[wrap(k), wrap2(l)];

                            //}
                        
                           // Console.WriteLine("i " + i + " j " + j);
                           // Console.WriteLine("c " + c);
                           // Console.WriteLine("c2 " + c2);

                                if (world1[wrap(k), wrap2(l)].blue == 0 && world1[wrap(k), wrap2(l)].red == 0 && world1[wrap(k), wrap2(l)].green == 0)
                            {
                                world1[i, j] = new Cell(0, 0, 0);
                                world2[i, j] = new Cell(0, 0, 0);

                                /* if (c2.R > high)
                                 {
                                     high = c2.R;
                                     Console.WriteLine(c2.R);
                                     xg = i;
                                     yg = j;
                                     //    Console.WriteLine("High " + high + "xg " + xg + "yg " + yg);

                                 }
                                 if (high > 0)
                                 {
                                     world2[xg, yg] = new Cell(0, 0, 0);
                                 }

                                 else
                                 {
                                     world2[xg, yg] = new Cell(c.R, c.G, c.B);
                                 }
                             }
                         }*/
                            }
                        }
                    }
                }
            }
                

                //else
                //{
                //    if (c2.R > h1)
                //    {
                //        h1 = c2.R;
                //        x = i;
                //        y = j;

                //    }
                //    else if (c2.R > h2)
                //    {
                //        h2 = c2.R;
                //        x = i;
                //        y = j;

                //    }
                //    else if (c2.R > h3)
                //    {
                //        h3 = c2.R;
                //        x = i;
                //        y = j;

                //    }
                //    else if (c2.R > h4)
                //    {
                //        h4 = c2.R;
                //        x = i;
                //        y = j;

                //    }
                //    world1[wrap(x), wrap(y)] = 1;
                //    //Console.WriteLine("g " + c.G + "r " + c.R);
                //}



                Cell[,] temp = world1;
                world1 = world2;
                world2 = temp;
                countGens++;
                gen.Text = "Generation: " + countGens;

                world.Refresh();
            
        }

        public void move2()
        {
            countPop = 0;
            birth = 0;
            death = 0;


            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int count = 0;
                    red = 0;
                    green = 0;
                    blue = 0;
                    Cell u;
                    Color c = myBitmap.GetPixel(i * 10, j * 10);


                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            if ((u = world1[wrap(k), wrap2(l)]) != null)
                            {
                                red = red + c.R;
                                green = green + c.G;
                                blue = blue + c.B;


                                count++;

                                // count = count + m;
                                //  Console.WriteLine(count); 
                                //(world1[wrap(k), wrap2(l)];

                            }
                        }
                    }
                    if (world1[i, j] != null)
                    {
                        if (count == 3 || count == 4)
                        {
                            // world2[i, j] = 1;
                            world2[i, j] = new Cell(c.R, c.G, c.B);

                            countPop++;
                            /*  Console.WriteLine(r);
                              Console.WriteLine(g);
                              Console.WriteLine(b);*/

                        }
                        else
                        {
                            // world2[i, j] = 0;
                            world2[i, j] = null;
                            death++;


                        }
                    }
                    else
                    {
                        if (count == 3)
                        {
                            // world2[i, j] = 1;
                            world2[i, j] = new Cell(red / 3, green / 3, blue / 3);
                            countPop++;
                            birth++;



                        }
                        else
                        {
                            world2[i, j] = null;



                        }

                    }
                    //countPop += popCount(world1, i, j);
                }
            }

            // Color[,] temp = new Color[,] world1;
            Cell[,] temp = world1;
            world1 = world2;
            world2 = temp;

            world.Refresh();
            countGens++;
            gen.Text = "Generation = " + countGens;
            pop.Text = "Population =" + countPop;
            // label3.Text = "Universe Size = " + uSize;
        }
                

       /*     public void makeProb()
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {

                        Color c = myBitmap.GetPixel(i, j);
                        if (c.R >= 220)
                        {
                            prob = .9;
                            if (prob == .9)
                            {
                                maybe = rand.Next(10);
                                if (maybe > 0)
                                {
                                    warMove1();
                                }
                            }
                        }

                        if (c.R <= 219 && c.R >= 200)
                        {
                            prob = .7;
                            if (prob == .7)
                            {
                                maybe = rand.Next(10);
                                if (maybe > 3)
                                {
                                    warMove1();
                                }
                            }
                        }

                        else
                        {
                            prob = .5;
                            if (prob == .5)
                            {
                                maybe = rand.Next(10);
                                if (maybe > 6)
                                {
                                    warMove1();
                                }
                            }
                        }

                    }
                }
            }*/






            private void universe_Load(object sender, EventArgs e)
            {

            }

            private void world_Click(object sender, EventArgs e)
            {

            }

            private void world_Paint(object sender, PaintEventArgs e)
            {

                //https://msdn.microsoft.com/en-us/library/cce5h557%28v=vs.110%29.aspx

                // Color yes = Color.FromArgb(red, green, blue);
                // Graphics g = Graphics.FromImage(myBitmap);
                Graphics g = e.Graphics;
                e.Graphics.DrawImage(myBitmap, 0, 0);

                Brush br2 = new SolidBrush(Color.Black);

                for (int i = 0; i < width; i++)

                    for (int j = 0; j < height; j++)
                    {
                       
                         if (world1[i, j] !=null)
                          {
                            
                              Color c = world1[i, j].colored();
                              Brush br = new SolidBrush(c);
                              g.FillRectangle(br, i * 10, j * 10, 10, 10);

                          }
                          else if(world2[i,j]==null)
                          {
                              g.FillRectangle(br2, i * 10, j * 10, 10, 10);
                          }

                      }
                    }

            


            private void timer1_Tick(object sender, EventArgs e)
            {
                // dropMove();

                move();
                
                //makeProb();

                pop.Text = "Population = " + countPop; // +"   Generation# = " + countGens + "   Univere Size = " + size.Text;
            }


    /*        public void warMove1()
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        int count = 0;
                        int count1 = 0;
                        int defense = 0;
                        for (int k = i - 1; k <= i + 1; k++)
                        {
                            for (int l = j - 1; l <= j + 1; l++)
                            {
                                // if (world1[i, j] == 1)
                                if (world1[i, j] == 1)
                                { count = count + world1[wrap(k), wrap(l)] ; }
                                else if (world1[i, j] == 2)
                                {
                                    count = count + world1[wrap(k), wrap(l)] ;
                                }
                                // else if (world1[i, j] == 2)
                                if (world1[i, j] != 2)
                                { defense = 1 - 8; }
                                if (world1[i, j] == 2)
                                {
                                    count = 2 - 8;
                                }

                            }
                        }
                        if (world1[i, j] == 1 || world1[i, j] == 2)
                        {
                            if (count > defense)
                            {
                                world2[i, j] = 2;

                            }
                            else if (defense > count)
                            {
                                world2[i, j] = 1;
                            }



                        }

                    }
                }



                int[,] temp = world1;
                world1 = world2;
                world2 = temp;
                countGens++;
                //genCount.Text = "Generation: " + countGens;

                world.Refresh();
            }*/

            private void world_MouseClick(object sender, MouseEventArgs e)
            {
                world1[e.X/10, e.Y/10] = new Cell(0,0,0);
                world2[e.X / 10, e.Y / 10] = new Cell(0, 0, 0);
                world.Refresh();

                //if (world1[e.X / 10, e.Y / 10] == 1)
                //    pop.Text = "Population: " + countPop++;
                //else if (world1[e.X / 10, e.Y / 10] == 0)
                //    pop.Text = "Population: " + countPop--;


                //world.Refresh();
            }

           private void reset_MouseClick(object sender, MouseEventArgs e)
          {

                 for (int i = 0; i < width; i++)
                  {
                      for (int j = 0; j < height; j++)
                      {
                                
                          Color c = myBitmap.GetPixel(i * 10, j *10);
                          //need to use formuala to convert pixels to grid
                          r = c.R;
                          g = c.G;
                          b = c.B;
                          int x = c.A;
                          /*  Console.WriteLine(r);
                            Console.WriteLine(g);
                            Console.WriteLine(b);
                            Console.WriteLine(x);*/
                          //if ((r + g + b) > trackBar1.Value)

                          // {

                          //    Console.WriteLine(darkness);

                              //cell is alive
                              // Console.WriteLine("Alive cell");
                              world1[i, j] = new Cell(r, g, b);
                              world2[i, j] = new Cell(r, g, b);

                          //}


                          //else
                          //{
                          //    // world1[i, j] = null; 
                          //    // Console.WriteLine("This one's dead, jim.");
                          //}

                      }
                           world.Refresh();


                  }




        //    countGens = 0;

        //    pop.Text = "Population = " + (countPop = 5); //"   Generation# = " + countGens + "   Univere Size = " + size.Text;
        //    for (int i = 0; i < width; i++)
        //    {
        //        for (int j = 0; j < height; j++)
        //        {
        //            world1[i, j] = 0;
        //        }
        //    }
        //    for (int i = 0; i < width; i++)
        //    {
        //        for (int j = 0; j < height; j++)
        //        {
        //            world1[25, 25] = 1;
        //            world1[26, 25] = 1;
        //            world1[24, 26] = 1;
        //            world1[25, 26] = 1;
        //            world1[25, 27] = 1;
        //            world.Refresh();


        //        }
        //    }

        //    world.Refresh();
        //    countGens++;
        //    gen.Text = "Generation = " + countGens;*/

        }

        private void jump_MouseClick(object sender, MouseEventArgs e)
        {



        }

        private void play_MouseClick(object sender, MouseEventArgs e)
        {

            if (on == false)
            {
                clock.Start();
                play.Text = "Pause";
                on = true;
            }
            else if (on == true)
            {
                clock.Stop();
                play.Text = "Play";
                on = false;
            }

        }

        private void speed_Scroll(object sender, ScrollEventArgs e)
        {
            clock.Interval = speed.Value;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void size_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void size_Enter(object sender, EventArgs e)
        {
            /* uSize = 50;
             // if (size.Text == null)
             //   world1 = new int[50, 50];
             //else
             int.TryParse(size.Text, out uSize);
             world1 = new int[uSize, uSize];*/
        }

        private void pop_Click(object sender, EventArgs e)
        {

        }

        private void world_MouseDown(object sender, MouseEventArgs e)
        {
            mdown = true;
            mmoved = false;
            vx = e.X;
            vy = e.Y;


        }

        private void world_MouseMove(object sender, MouseEventArgs e)
        {
            /* if (mdown)
             {
                 panx = panx + (e.X - vx) / z;
                 pany = pany + (e.Y - vy) / z;
                 mmoved = true;
                 x = e.X;
                 y = e.Y;

             }
             world.Refresh();*/
        }

        private void world_MouseUp(object sender, MouseEventArgs e)
        {
            /* mdown = false;
             if (!mmoved)
             {
                 x = e.X;
                 y = e.Y;

             }
             world.Refresh();*/
        }

        private void Save_Click(object sender, EventArgs e)
        {
            /* int linecount = 0;
             SaveFileDialog saveFile1 = new SaveFileDialog();
             saveFile1.Filter = "Test files (*.txt)| *txt|All files(*.*)|*.*";
             saveFile1.FilterIndex = 2;
             saveFile1.RestoreDirectory = true;
             if (saveFile1.ShowDialog() == DialogResult.OK)
             {
                 using (StreamWriter writer = new StreamWriter(saveFile1.FileName))
                     for (int i = 0; i < world1.GetLength(0); i++)
                     {
                         String str = "";
                         for (int j = 0; j < world1.GetLength(1); j++)
                         {
                             if (world1[j, i] == 1)
                             {
                                 str += "*";

                             }
                             else
                                 str += "";
                         }
                         writer.WriteLine(str);
                     }
             }*/
        }

        private void Zoom_Scroll(object sender, EventArgs e)
        {
            z = Zoom.Value;
            world.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            /* string str = openFileDialog1.FileName;

             Console.WriteLine(str);

             string[] input = System.IO.File.ReadAllLines(str);

             uSize = input[0].Length;

             world1 = new int[uSize, uSize];

             boxSizeX = world.Width / (float)uSize;

             boxSizeY = world.Height / (float)uSize;




             for (int i = 0; i < uSize; i++)
             {

                 for (int j = 0; j < uSize; j++)
                 {

                     world1[i, j] = 0;

                 }

             }




             for (int i = 0; i < (Math.Min(uSize, input.Length)); i++)
             {

                 for (int j = 0; j < (Math.Min(uSize, input[i].Length)); j++)
                 {

                     if (input[i].Substring(j, 1).Equals("*"))
                     {

                         world1[i, j] = 1;

                     }

                 }

             }

             world.Refresh();*/
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            //Bitmap myBitmap = (System.Drawing.Bitmap)Bitmap.FromFile(openFileDialog2.FileName);

        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            //  r = trackBarR.Value;

        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            //  g = trackBarG.Value;

        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            //   b = trackBarB.Value;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Chosen_File = "";
            openFileDialog2.ShowDialog();
            openFileDialog2.Filter = "Bitmap | *.bmp | JPG | *.jpg | GIF | *.gif | All Files | *.*";
            openFileDialog2.FileName = "";

            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Cancelled");

            }
            else
            {
                Chosen_File = openFileDialog2.FileName;
                world.Image = Image.FromFile(Chosen_File);
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //darkness = trackBar1.Value;

            //label4.Text = "The intensity is: " + darkness;
            //world.Refresh();
        }
    }
}