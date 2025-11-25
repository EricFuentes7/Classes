using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
//EXTRA:
using System.Windows.Forms;
using System.Drawing;

namespace exercici;

class Program
{
    static List<(int x, int y)> cords = new List<(int x, int y)>();
    static Random r = new Random();

    static void Main(string[] args)
    {
        //https://stackoverflow.com/questions/14792066/change-background-color-on-c-sharp-console-application
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        const int NUM_FINAL = 50;
        ConsoleColor currentBackground = Console.BackgroundColor;
        Console.Clear();
        int puntuacio1 = 0;
        int puntuacio2 = 0;
        //https://www.w3schools.com/cs/cs_arrays_multi.php
        int[,] punts = {
        { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 1, 1, 1, 1, 1, 1, 1, 0 },
        { 0, 1, 2, 2, 2, 2, 2, 1, 0 },
        { 0, 1, 2, 5, 5, 5, 2, 1, 0 },
        { 0, 1, 2, 5, 10, 5, 2, 1, 0 },
        { 0, 1, 2, 5, 5, 5, 2, 1, 0 },
        { 0, 1, 2, 2, 2, 2, 2, 1, 0 },
        { 0, 1, 1, 1, 1, 1, 1, 1, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };


        DibuixarDiana(punts);
        Console.BackgroundColor = currentBackground;
        
        bool turnocompleto = false;

        while (true)
            {
                turnocompleto = false;
                while (!turnocompleto)
                {
                    puntuacio1 += PlayerTurn(1, punts, puntuacio1);
                    
                    DibuixarDiana(punts);
                    cords.Clear();
                    puntuacio2 += PlayerTurn(2, punts, puntuacio2);
                    
                    DibuixarDiana(punts);
                    cords.Clear();
                    turnocompleto = true;
                }  
                if (puntuacio1 >= NUM_FINAL && puntuacio1 == puntuacio2)
                {
                    Console.WriteLine("Han quedat empat, tirada de desempat");
                }
                else if (puntuacio1 >= NUM_FINAL && puntuacio1 > puntuacio2)
                {
                    Console.WriteLine($"\nJugador 1 guanya!! {puntuacio1} a {puntuacio2}");
                    MostrarGif("congrats.gif");
                    break;
                }
                else if (puntuacio2 >= NUM_FINAL && puntuacio2 > puntuacio1)
                {
                    Console.WriteLine($"\nJugador 2 guanya!! {puntuacio2} a {puntuacio1}");
                    MostrarGif("congrats.gif");
                    break;
                }

            }
        Console.ReadKey();
    }
   
   public static void DibuixarDiana(int[,] punts)
    {
        ConsoleColor currentBackground = Console.BackgroundColor;
        for (int i = 0; i < punts.GetLength(0); i++)
        {
            for (int j = 0; j < punts.GetLength(1); j++)
            {
                bool esTiro = false;
                foreach (var shot in cords)
                {
                    if (i == shot.x && j == shot.y)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        esTiro = true;
                        break;
                    }
                }

                if (!esTiro)
                {
                    switch (punts[i, j])
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;
                        case 5:
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;
                        case 10:
                            Console.BackgroundColor = ConsoleColor.White;
                            break;
                    }
                }

                Console.Write("  ");
                Console.BackgroundColor = currentBackground;
            }
            Console.WriteLine();
        }
    }

   static int PlayerTurn(int jugador, int[,] punts, int puntuacioActual)
        {
            Console.WriteLine($"\n-----------\n\nJUGADOR {jugador} LLANÇA:");
            int puntosTurno = 0;

            for (int i = 0; i < 3; i++)
            {
                var (x, y) = PlayerMove();
                cords.Add((x, y));
                int puntos = punts[x, y];
                puntosTurno += puntos;
                Console.WriteLine($"Puntuació: {puntos} ({x}, {y}) (punts act: {puntuacioActual + puntosTurno})");
            }

            Console.WriteLine();
            return puntosTurno;
        }


        public static (int x, int y) PlayerMove()
        {
            return (r.Next(0, 9), r.Next(0, 9));
        }


    // EXTRA, NO FER NI CAS:
public static void MostrarGif(string ruta)
{
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    Form ventana = new Form();
    PictureBox pb = new PictureBox();
    pb.Image = Image.FromFile(ruta);
    pb.SizeMode = PictureBoxSizeMode.AutoSize;

    ventana.Controls.Add(pb);
    ventana.ClientSize = new Size(pb.Image.Width, pb.Image.Height);

    // Especificamos el Timer de Windows Forms
    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
    timer.Interval = 5000; // 5000 ms = 5 segundos
    timer.Tick += (s, e) =>
    {
        timer.Stop();
        ventana.Close();
    };
    timer.Start();

    Application.Run(ventana);
}
}
