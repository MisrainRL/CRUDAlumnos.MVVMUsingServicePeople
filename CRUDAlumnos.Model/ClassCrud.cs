using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAlumnos.Model
{
    public class ClassCrud
    {
        public List<Alumnos> LAlumnos = new List<Alumnos>();
        public ClassCrud() { }
        public List<Alumnos> ListarAlumnos()
        {
            return LAlumnos;
        }
        public void AddEstudiante(Alumnos estudiante)
        {
            LAlumnos.Add(estudiante);
        }

      
        public void Actualizar(int index, Alumnos actualizar)
        {
            // Buscar el objeto correspondiente en la lista y actualizar sus propiedades
            Alumnos alumnos = LAlumnos[index];
            alumnos= actualizar;
          
        }
        public void Borrar(int index)
        {
            LAlumnos.Remove(LAlumnos[index]);
        }

    }
}
