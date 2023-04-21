using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CRUDAlumnos.Model;
using CRUDAlumnos.Model.PersonServiceReference;

namespace CRUDAlumnos.ViewModel
{

    public class MainViewModel : ViewModelBase
    {/*
        private int index = -1;
        private MainModel model;
        private string nombre;
        private string correo;
        private string edad;
        private List<Alumnos> mydata;
        private Alumnos datosAlumnos;

        public int INDEX
        {
            get { return index; }
            set
            {
                if (index == value)
                {
                    return;
                }
                index = value;
                OnPropertyChanged("index");
            }
        }

        public string Nombre
        {
            get { return nombre; }

            set
            {
                if (nombre == value)
                    return;

                nombre = value;
                OnPropertyChanged("nombre");
            }
        }

        public string Correo
        {
            get { return correo; }

            set
            {
                if (correo == value)
                    return;

                correo = value;
                OnPropertyChanged("Correo");
            }
        }

        public string Edad
        {
            get { return edad; }

            set
            {
                if (edad == value)
                    return;

                edad = value;
                OnPropertyChanged("Edad");
            }
        }

        public List<Alumnos> MyData
        {
            get
            {
                return mydata;
            }

            set
            {
                if (mydata == value)
                    return;

                mydata = value;
                OnPropertyChanged("MyData");
            }
        }

        private ICommand addCommand;
        private ICommand removeCommand;
      
      
        
     public Alumnos DatosAlumnos
        {
            get { return datosAlumnos; }
            set
            {
                if (datosAlumnos == value)
                {
                    return;
                }
                datosAlumnos = value;
                formato((Alumnos)datosAlumnos);
                OnPropertyChanged("DatosAlumnos");
            }
        }
        private void formato(Alumnos alumnos)
        {
            if(alumnos != null)
            {
                Nombre = alumnos.Nombre;
                Correo = alumnos.Email;
                Edad=Convert.ToString(alumnos.Edad);
            }
            else {
                LimpiarEntradas();
            }
        }

        private void LimpiarEntradas()
        {
            Nombre = null;
            Correo = null;
            Edad = null;
            index = -1;
            MyData = null;
            MyData = model.Listar();
        }

        private Alumnos empacar()
        {
            return model.EmpacarDatos(Nombre, Correo, Edad);
        }

        private Boolean ValidarDatos()
        {
            if (!string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Correo) && !string.IsNullOrEmpty(Edad))
            {
                return true;
            }
            else { return false; }
        }
        public ICommand RemoveCommand
        {
            get
            {
                if (removeCommand == null)
                {
                    removeCommand = new RelayCommand(param => this.removeCommandExecute(), null);
                }
                return removeCommand;
            }

        }

        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand(param => this.addCommandExecute(), null);
                }
                return addCommand;
            }
        }

        private void addCommandExecute()
        {
            //model.AddAl(INDEX,empacar(),ValidarDatos());
            model.AddAl(empacar());
            LimpiarEntradas();

        }
     
        private void removeCommandExecute()
        {
            model.Delete(INDEX);
            LimpiarEntradas();
        }

        public MainViewModel()
        {
            model = new MainModel();
            model.AddAl(new Alumnos("Misrain", "correo@gmail.com", 25));
            MyData = model.Listar();

        }*/
        private MainModel model;

        private List<Person> alumnosGet;

        public List<Person> AlumnosGet
        {
            get { return alumnosGet; }
            set
            {
                if (alumnosGet == value) { return; }
                alumnosGet = value;
                OnPropertyChanged("AlumnosGet");
            }
        }

        public MainViewModel()
        {
            model = new MainModel();
           
            AlumnosGet = model.getPersonList();

        }
    }
}
