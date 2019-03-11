using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    public class Puntos
    {
        private double puntoX;
        private double puntoY;
        private int label;
        private string color;

        public Puntos(double puntoX, double puntoY, string color)
        {
            this.puntoX = puntoX;
            this.puntoY = puntoY;
            this.color = color;
            if(this.color == "rojo")
            {
                label = 1;
            }
            if(this.color == "morado")
            {
                label = -1;
            }
        }
        public double PuntoX
        {
            get { return puntoX; }
            set { puntoX = value; }
        }
        public double PuntoY
        {
            get { return puntoY; }
            set { puntoY = value; }
        }
        public int Label
        {
            get { return label; }
            set { label = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
       
    }
}
