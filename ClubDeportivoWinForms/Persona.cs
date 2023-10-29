using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoWinForms
{


    internal class Persona
    {
        private string _name;
        private long num_Telefono;
        private int dni;

        public Persona(string name, long num_Telefono, int dni)
        {
            _name = name;
            this.num_Telefono = num_Telefono;
            this.dni = dni;
        }
        public string Name { get =>  _name; set => _name = value; }
        public long Num_Telefono { get => num_Telefono; set => num_Telefono = value; }
        public int Dni { get => dni; set => dni = value; }

        public override string ToString()
        {
            return "Nombre: " + Name + " Dni: " + Dni + " Numero de telefono: " + Num_Telefono;
        }
    }

}
