using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador
{
    public class Dolar
    {
        public static double cotizRespectoDolar;
        public double cantidad;

        public double GetCotizacion()
        {
           return cotizRespectoDolar;
        }
        public double GetCantidad()
        {
           return this.cantidad;
        }

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cant)
        {
            this.cantidad = cant;
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(Peso.GetCotizacion() * d.cantidad);
        }
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(Euro.GetCotizacion() * d.cantidad);
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).cantidad);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }
        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            Dolar aux = d1;
            aux.cantidad += d2.cantidad;
            return aux;
        }
        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            Dolar aux = d1;
            aux.cantidad -= d2.cantidad;
            return aux;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == (Dolar)e;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return d.cantidad == (Dolar)p;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1.cantidad == d2.cantidad);
        }
    }
}
