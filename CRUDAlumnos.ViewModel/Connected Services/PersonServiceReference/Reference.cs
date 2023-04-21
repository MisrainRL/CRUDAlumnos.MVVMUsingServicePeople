﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDAlumnos.ViewModel.PersonServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonServiceReference.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        void AddPerson(CRUDAlumnos.Model.PersonServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        System.Threading.Tasks.Task AddPersonAsync(CRUDAlumnos.Model.PersonServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersonById", ReplyAction="http://tempuri.org/IPersonService/GetPersonByIdResponse")]
        CRUDAlumnos.Model.PersonServiceReference.Person GetPersonById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersonById", ReplyAction="http://tempuri.org/IPersonService/GetPersonByIdResponse")]
        System.Threading.Tasks.Task<CRUDAlumnos.Model.PersonServiceReference.Person> GetPersonByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        void UpdatePerson(CRUDAlumnos.Model.PersonServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(CRUDAlumnos.Model.PersonServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        void DeletePerson(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetAllPersons", ReplyAction="http://tempuri.org/IPersonService/GetAllPersonsResponse")]
        CRUDAlumnos.Model.PersonServiceReference.Person[] GetAllPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetAllPersons", ReplyAction="http://tempuri.org/IPersonService/GetAllPersonsResponse")]
        System.Threading.Tasks.Task<CRUDAlumnos.Model.PersonServiceReference.Person[]> GetAllPersonsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : CRUDAlumnos.ViewModel.PersonServiceReference.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<CRUDAlumnos.ViewModel.PersonServiceReference.IPersonService>, CRUDAlumnos.ViewModel.PersonServiceReference.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddPerson(CRUDAlumnos.Model.PersonServiceReference.Person person) {
            base.Channel.AddPerson(person);
        }
        
        public System.Threading.Tasks.Task AddPersonAsync(CRUDAlumnos.Model.PersonServiceReference.Person person) {
            return base.Channel.AddPersonAsync(person);
        }
        
        public CRUDAlumnos.Model.PersonServiceReference.Person GetPersonById(int id) {
            return base.Channel.GetPersonById(id);
        }
        
        public System.Threading.Tasks.Task<CRUDAlumnos.Model.PersonServiceReference.Person> GetPersonByIdAsync(int id) {
            return base.Channel.GetPersonByIdAsync(id);
        }
        
        public void UpdatePerson(CRUDAlumnos.Model.PersonServiceReference.Person person) {
            base.Channel.UpdatePerson(person);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(CRUDAlumnos.Model.PersonServiceReference.Person person) {
            return base.Channel.UpdatePersonAsync(person);
        }
        
        public void DeletePerson(int id) {
            base.Channel.DeletePerson(id);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(int id) {
            return base.Channel.DeletePersonAsync(id);
        }
        
        public CRUDAlumnos.Model.PersonServiceReference.Person[] GetAllPersons() {
            return base.Channel.GetAllPersons();
        }
        
        public System.Threading.Tasks.Task<CRUDAlumnos.Model.PersonServiceReference.Person[]> GetAllPersonsAsync() {
            return base.Channel.GetAllPersonsAsync();
        }
    }
}