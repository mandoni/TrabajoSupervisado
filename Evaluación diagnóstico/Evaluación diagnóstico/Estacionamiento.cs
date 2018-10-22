using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_diagnóstico
{
    class Estacionamiento
    {
        public bool estado;
        private string marca;
        private string color;
        private string placa;
        private DateTime horaIngreso;

        public Estacionamiento()
        {
            estado = false;
        }

        public void NuevoCarro(string color, string marca, string placa)
        {
            this.estado = true;
            this.marca = marca;
            this.color = color;
            this.placa = placa;
            horaIngreso = DateTime.Now;
        }

        public void SalidaCarro()
        {
            this.marca = null;
            this.color = null;
            this.placa = null;
            estado = false;
        }

        public void getCarro(int x, int y)
        {
            string[] array = { marca, color, placa, horaIngreso.ToString()};
            Console.WriteLine(String.Format("Estacionamiento {0}, {1}\n" +
                                        "Marca: \t{2}\n" +
                                        "Color: \t{3}\n" +
                                        "Placa: \t{4}\n" +
                                        "Hora y fehca: {5}", x, y, marca, color, placa, horaIngreso.ToString()));
        }
    }
}
