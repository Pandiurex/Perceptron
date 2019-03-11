using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : MaterialForm
    {
        Random rnd = new Random();
        double x0 = -1;
        double[] weight = new double[3];
        double[] pesosLinea = new double[3];
        List<Point> puntosGrafic = new List<Point>();
        List<Puntos> listaP = new List<Puntos>();
        Pen lapiz = new Pen(Color.Black, 3);
        Pen penGraphic = new Pen(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);

        public Form1()
        {
            weight[0] = 0;
            weight[1] = 0;
            weight[2] = 0;
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE
            );
        }

        private void validateNum(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void learningBox_Click(object sender, System.EventArgs e)
        {
            if (learningBox.Text == "Learning Rate ( η )")
            {
                learningBox.Text = "";
            }
        }

        private void iterationBox_Click(object sender, System.EventArgs e)
        {
            if (iterationBox.Text == "Num Epocas")
            {
                iterationBox.Text = "";
            }
        }

        private void iterationBox_Leave(object sender, System.EventArgs e)
        {
            if (iterationBox.Text == "")
            {
                iterationBox.Text = "Num Iteraciones";
            }
        }

        private void learningBox_Leave(object sender, System.EventArgs e)
        {
            if (learningBox.Text == "")
            {
                learningBox.Text = "Learning Rate ( η )";
            }
        }

        private void iterationBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateNum(e);
        }

        private void learningBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validateNum(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pintarPlano();

        }

        private void pintarPlano()
        {
            Graphics g = panel1.CreateGraphics();

            Pen pincel = new Pen(Color.Black, 2);
            g.DrawLine(pincel, new Point(0, panel1.Width / 2),
                new Point(panel1.Width, panel1.Height / 2));

            g.DrawLine(pincel, new Point(panel1.Width / 2, 0),
                new Point(panel1.Width / 2, panel1.Height));

            g.DrawLine(pincel, 1, 0, 0, 399);
            g.DrawLine(pincel, 0, 399, 399, 399);
            g.DrawLine(pincel, 0, 1, 399, 0);
            g.DrawLine(pincel, 399, 0, 399, 399);
        }

        private void pintarPuntos()
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen2;



            for (int i = 0; i < puntosGrafic.Count; i++)
            {
                pen2 = (listaP[i].Label == 1) ? new Pen(Color.Red) : new Pen(Color.Purple);
                g.DrawEllipse(pen2, new Rectangle(puntosGrafic[i].X, puntosGrafic[i].Y, 3, 3));
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point puntito = new Point();

            puntito.X = e.X;
            puntito.Y = e.Y;

            puntosGrafic.Add(puntito);

            double x1 = (double)(e.X - panel1.Width / 2) / 40;
            double y1 = (double)(panel1.Height / 2 - e.Y) / 40;


            DibujarPunto(x1, y1, puntito);
        }
        private void DibujarPunto(double x1, double y1, Point punto)
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen2;
            pen2 = new Pen(Color.Red);


            if (positiveRadBtn.Checked)
            {
                string color = "rojo";
                Puntos puntos = new Puntos(x1, y1, color);
                listaP.Add(puntos);
                g.DrawEllipse(pen2, new Rectangle(punto.X, punto.Y, 3, 3));

            }
            else if (negativeRadBtn.Checked)
            {
                string color = "morado";
                pen2 = new Pen(Color.Purple);
                Puntos puntos = new Puntos(x1, y1, color);
                listaP.Add(puntos);
                g.DrawEllipse(pen2, new Rectangle(punto.X, punto.Y, 3, 3));

            }
        }
        private void Perceptron()
        {
            int ciclo = Convert.ToInt32(iterationBox.Text);
            Graphics g = panel1.CreateGraphics();
            Graphics evaluated = valuatedPanel.CreateGraphics();
            bool exit = false;
            int errores = 0, erroresMax = 0;
            int guess;
            double lr = Convert.ToDouble(learningBox.Text);
            float rangoX = (ciclo > valuatedPanel.Width) ? 1 : valuatedPanel.Width / ciclo;
            float rangoY = valuatedPanel.Height / (listaP.Count / 1.9f);
            int error;
            int contador = 0;

            positiveRadBtn.Checked = true;
            evaluated.Clear(Color.White);

            while (!exit && contador < ciclo)
            {
                contador++;
                errores = 0;
                exit = true;

                for (int i = 0; i < listaP.Count; i++)
                {
                    guess = ((weight[1] * listaP[i].PuntoX) + (weight[2] * listaP[i].PuntoY) - weight[0] < 0) ? -1 : 1;
                    error = listaP[i].Label - guess;
                    if (error != 0)
                    {
                        errores += 1;
                        exit = false;
                        weight[0] += lr * error * x0;
                        weight[1] += lr * error * listaP[i].PuntoX;
                        weight[2] += lr * error * listaP[i].PuntoY;

                    }

                }

                g.Clear(Color.White);
                pintarPlano();
                pintarPuntos();
                dibujarLinea(weight, Color.Red);
                dibujarLinea(pesosLinea, Color.Yellow);

                if (contador > 1)
                {
                    evaluated.DrawLine(penGraphic, (rangoX * (contador - 1)), valuatedPanel.Height - (erroresMax * rangoY),
                        (rangoX * contador), valuatedPanel.Height - (errores * rangoY));
                }

                erroresMax = errores;
                Thread.Sleep(100);

            }
            //colorearPanel();
            pintarPlano();
            pintarPuntos();
            dibujarLinea(weight, Color.Red);
            dibujarLinea(pesosLinea, Color.Yellow);
            MessageBox.Show("Listo en " + contador + " iteraciones");

        }

        private void dibujarLinea(double[] weigths, Color color)
        {
            Pen linea = new Pen(color, 1);
            double x1 = -5;
            double x2 = 5;

            double y = -(x1 * weigths[1] / weigths[2]) - ((x0 * weigths[0]) / weigths[2]);
            double y2 = -(x2 * weigths[1] / weigths[2]) + ((weigths[0]) / weigths[2]);

            double panelHeigth = panel1.Height / 2;

            Point puntos = new Point();
            puntos.X = 0;
            puntos.Y = (int)(panelHeigth - y * 40);


            Point punto2 = new Point();
            punto2.X = panel1.Width;
            punto2.Y = (int)(panelHeigth - y2 * 40);

            Graphics g = panel1.CreateGraphics();
            g.DrawLine(linea, puntos, punto2);


        }

        private void perceptronBtn_Click(object sender, EventArgs e)
        {
            if (learningBox.Text == "Learning Rate ( η )" || learningBox.Text == "")
            {
                MessageBox.Show("No hay ingresado un valor numerico en el Learning Rate");
            }
            else if (iterationBox.Text == "Num Epocas" || iterationBox.Text == "")
            {
                MessageBox.Show("No hay ingresado un valor numerico en las Epocas");
            }
            else if (weight[0].ToString() == "0" || weight[1].ToString() == "0" || weight[2].ToString() == "0")
            {
                MessageBox.Show("No has iniciado los Pesos");
            }
            else
            {
                
                Perceptron();

            }
        }

        private void colorearPanel()
        {
            Graphics g = panel1.CreateGraphics();
            SolidBrush brocha;
            Color finalColor = new Color();
            finalColor = Color.FromArgb(204, 255, 204);

            for (int x = 0; x < panel1.Width; x += 4)
            {
                for (int y = 0; y < panel1.Height; y += 4)
                {
                    double x1 = (double)(x - panel1.Width / 2) / 40;
                    double x2 = (double)(panel1.Height / 2 - y) / 40;

                    brocha = new SolidBrush(finalColor);

                    g.FillEllipse(brocha, x, y, 5, 5);
                }
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Graphics evaluated = valuatedPanel.CreateGraphics();
            Graphics g = panel1.CreateGraphics();

            listaP.Clear();
            puntosGrafic.Clear();

            evaluated.Clear(Color.White);

            g.Clear(Color.White);
            pintarPlano();

        }

        private void weightBtn_Click(object sender, EventArgs e)
        {
            weight[0] = rnd.NextDouble();
            weight[1] = rnd.NextDouble();
            weight[2] = rnd.NextDouble();

            pesosLinea[0] = weight[0];
            pesosLinea[1] = weight[1];
            pesosLinea[2] = weight[2];

            dibujarLinea(pesosLinea, Color.Yellow);

        }
    }
}
