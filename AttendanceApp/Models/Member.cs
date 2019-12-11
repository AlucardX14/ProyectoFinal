using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AttendanceApp.Models
{
    public class Member
    {

        public int ID { get; set; }

        [DisplayName("Nombre")]
        public string FirstName { get; set; }

        [DisplayName("Apellidos")]
        public string LastName { get; set; }

        [DisplayName("Cédula")]
        public string IDCard { get; set; }

        [DisplayName("Foto")]
        public byte[] Photo { get; set; }

        [DisplayName("Dirección")]
        public string Address { get; set; }

        [DisplayName("Teléfono")]
        public string Phone { get; set; }

        [DisplayName("Fec. Nacimiento")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Birthday { get; set; }

        [DisplayName("Afiliados")]
        public string Relatives { get; set; }

        [DisplayName("Tipo membresía")]
        public string Membership { get; set; }

        [DisplayName("Lugar Trabajo")]
        public string Workplace { get; set; }

        [DisplayName("Direc. Trabajo")]
        public string OfficeAddress { get; set; }

        [DisplayName("Tel. Trabajo")]
        public string OfficePhone { get; set; }

        [DisplayName("¿Activo?")]
        [Required]
        public bool IsActiveMember { get; set; }

        [DisplayName("Fec. Ingreso")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> JoinDate { get; set; }

        [DisplayName("Fec. Salida")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> ExitDate { get; set; }

    }
}