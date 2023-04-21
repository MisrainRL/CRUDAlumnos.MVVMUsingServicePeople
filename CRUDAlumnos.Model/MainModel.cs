using CRUDAlumnos.Model.PersonServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAlumnos.Model
{
    public class MainModel
    {/*
        ClassCrud crud = new ClassCrud();

        public void AddAl(Alumnos alumnos)
        {
            crud.AddEstudiante(alumnos);
        }
        public void AddAl(int index, Alumnos registro,Boolean bandera)
        { if (index > -1 && bandera)
            {
                crud.Actualizar(index, registro);
            }else if (bandera)
            {
                crud.AddEstudiante(registro);
            }
        }
        public List<Alumnos> Listar() {
            return crud.ListarAlumnos();
        }

        public void Delete(int index)
        {
            crud.Borrar(index);
        }
        public  Alumnos EmpacarDatos(string Nombre, string Correo, string Edad)
        {
            return new Alumnos(Nombre, Correo, Int32.Parse(Edad));
        }
      Mio  
      */

        PersonServiceClient cliente;

        public MainModel() 
        { 
            cliente = new PersonServiceClient();
        }

        public List<Person> getPersonList()
        {
            using(cliente)
            {
                return cliente.GetAllPersons().ToList();
            }
        }

    }
}
