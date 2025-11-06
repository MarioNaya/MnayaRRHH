using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnayaRRHH.Model
{
    internal class Candidato
    {
        private string nombre, apellidos, dni, direccion, email, estudiosFinalizados;
        private byte[] foto;
        private string localidad, observaciones, usuariosRegistrador;
        private int cp, tlfno;
        private DateTime fechaAlta, fechaNaciemiento;

        public Candidato(string nombre, string apellidos, string dni, string direccion, string email, string estudiosFinalizados, byte[] foto, string localidad, string observaciones, string usuariosRegistrador, int cp, int tlfno, DateTime fechaAlta, DateTime fechaNaciemiento)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
            this.Direccion = direccion;
            this.Email = email;
            this.EstudiosFinalizados = estudiosFinalizados;
            this.Foto = foto;
            this.Localidad = localidad;
            this.Observaciones = observaciones;
            this.UsuariosRegistrador = usuariosRegistrador;
            this.Cp = cp;
            this.Tlfno = tlfno;
            this.FechaAlta = fechaAlta;
            this.FechaNaciemiento = fechaNaciemiento;
        }

        public Candidato(string nombre, string apellidos, string direccion, string email, byte[] foto, string localidad, int cp, int tlfno, DateTime fechaAlta, DateTime fechaNaciemiento)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.email = email;
            this.foto = foto;
            this.localidad = localidad;
            this.cp = cp;
            this.tlfno = tlfno;
            this.fechaAlta = fechaAlta;
            this.fechaNaciemiento = fechaNaciemiento;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public string EstudiosFinalizados { get => estudiosFinalizados; set => estudiosFinalizados = value; }
        public byte[] Foto { get => foto; set => foto = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string UsuariosRegistrador { get => usuariosRegistrador; set => usuariosRegistrador = value; }
        public int Cp { get => cp; set => cp = value; }
        public int Tlfno { get => tlfno; set => tlfno = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime FechaNaciemiento { get => fechaNaciemiento; set => fechaNaciemiento = value; }
    }
}
