using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServices.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int IdCliente { get; set; }

        [DataMember]
        public string Nombre {get; set;}
           
        [DataMember]
        public string ApellidoPaterno { get; set; }

        [DataMember]
        public string ApellidoMaterno { get; set; }

        [DataMember]
        public string Sexo { get; set; }

        [DataMember]
        public int Dni { get; set; }

        [DataMember]
        public string CorreoElectronico { get; set; }

        [DataMember]
        public string Contraseña { get; set; }

        [DataMember]
        public int Celular { get; set; }

        [DataMember]
        public string Direccion { get; set; }
    
    }
}