using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnayaRRHH.Model
{
    internal class CandidatoAlmacen : Candidato
    {
        private string carnetCamion, carnetCarretilla, carnetConducir;

        public CandidatoAlmacen(
            string nombre, 
            string apellidos, 
            string dni, 
            string direccion, 
            string email, 
            string estudiosFinalizados, 
            string foto, 
            string localidad, 
            string observaciones, 
            string usuariosRegistrador, 
            int cp, 
            int tlfno, 
            DateTime fechaAlta, 
            DateTime fechaNaciemiento,
            string carnetCamion,
            string carnetCarretilla,
            string carnetConducir) : 
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
            this.CarnetCamion = carnetCamion;
            this.CarnetCarretilla = carnetCarretilla;
            this.CarnetConducir = carnetConducir;
        }

        public string CarnetCamion { get => carnetCamion; set => carnetCamion = value; }
        public string CarnetCarretilla { get => carnetCarretilla; set => carnetCarretilla = value; }
        public string CarnetConducir { get => carnetConducir; set => carnetConducir = value; }
    }
}
