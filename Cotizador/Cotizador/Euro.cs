﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador
{
    public class Euro
    {
        public static double cotizRespectoDolar;
        public double cantidad;

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad; 
        
        }

        static Euro()
        {
           cotizRespectoDolar = 1 / 1.08;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / cotizRespectoDolar);
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);

        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return e == (Euro)p;
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
    }
}
