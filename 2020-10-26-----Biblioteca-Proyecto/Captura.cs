using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_10_26_____Biblioteca_Proyecto
{
    public class Captura
    {
        public float CalcularPrecio(int dias_estadia, float precio_habitacion) {
            if (dias_estadia > 9 && dias_estadia < 20)
            {
                return dias_estadia * precio_habitacion * (float)0.85;
            }
            else if (dias_estadia > 19 && dias_estadia < 40)
            {
                return dias_estadia * precio_habitacion * (float)0.75;
            }
            else {
                return dias_estadia * precio_habitacion;
            }
        }

        public void RegistrarReservacion(Reservacion cliente) { 
            
        }
    }

    public class Reservacion {
        private string nombre_completo;
        private int duracion_estadia;
        private string tipo_habitacion;
        private bool servicio_extra;

        public void SetNombre_Completo(string entrada) {
            this.nombre_completo = entrada;
        }

        public string GetNombre_Completo() {
            return this.nombre_completo;
        }

        public void SetDuracion_estadia(int entrada) {
            this.duracion_estadia = entrada;
        }

        public int GetDuracion_estadia() {
            return this.duracion_estadia;
        }

        public void SetTipo_Habitacion(string entrada) {
            this.tipo_habitacion = entrada;
        }

        public string GetTipo_Habitacion() {
            return this.tipo_habitacion;
        }

        public void SetServicio_Extra(bool entrada) {
            this.servicio_extra = entrada;
        }

        public bool IsServicio_Extra() {
            return this.servicio_extra;
        }

        public Reservacion() { 
            
        }

        public Reservacion(string nombre_completo_entrada,int duracion_estadia_entrada,string tipo_duracion_entrada,bool servicio_extra_entrada) {
            this.nombre_completo = nombre_completo_entrada;
            this.duracion_estadia = duracion_estadia_entrada;
            this.tipo_habitacion = tipo_duracion_entrada;
            this.servicio_extra = servicio_extra_entrada;
        }
    }
}
