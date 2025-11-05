using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnayaRRHH.Model
{
    internal class CandidatoAdministracion : Candidato
    {
        private string nivelInformaticaCalculo, nivelInformaticaInternet, nivelInformaticaTexto;

        public CandidatoAdministracion(
            string nombre, 
            string apellidos, 
            string dni, 
            string direccion, 
            string email, 
            string estudiosFinalizados, 
            byte[] foto, 
            string localidad, 
            string observaciones, 
            string usuariosRegistrador, 
            int cp, 
            int tlfno, 
            DateTime fechaAlta, 
            DateTime fechaNaciemiento,
            string nivelInformaticaCalculo,
            string nivelInformaticaInternet,
            string nivelInformaticaTexto) : 
            base(
                nombre, 
                apellidos, 
                dni, 
                direccion, 
                email, 
                estudiosFinalizados, 
                foto, 
                localidad, 
                observaciones, 
                usuariosRegistrador, 
                cp, 
                tlfno, 
                fechaAlta, 
                fechaNaciemiento)
        {
            this.NivelInformaticaCalculo = nivelInformaticaCalculo;
            this.NivelInformaticaInternet = nivelInformaticaInternet;
            this.NivelInformaticaTexto = nivelInformaticaTexto;
        }

        public string NivelInformaticaCalculo { get => nivelInformaticaCalculo; set => nivelInformaticaCalculo = value; }
        public string NivelInformaticaInternet { get => nivelInformaticaInternet; set => nivelInformaticaInternet = value; }
        public string NivelInformaticaTexto { get => nivelInformaticaTexto; set => nivelInformaticaTexto = value; }
    }
}
