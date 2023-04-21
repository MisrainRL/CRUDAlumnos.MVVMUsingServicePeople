using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAlumnos.Model
{
    public class Alumnos
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }


        public Alumnos(string name, string email, int age)
        {
            Nombre = name;
            Email = email;
            Edad = age;
        }
    }
}
