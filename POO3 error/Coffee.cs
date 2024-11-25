using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    internal class Cafetera
    {
        private int _capacidadMaxima;
        private int _cantidadActual;

        public int CapacidadMaxima
        {
            get => _capacidadMaxima;
            set => _capacidadMaxima = value;
        }
        public int CapacidadActual
        { 
            get => _cantidadActual;
        }
        public Cafetera ()
        {
            _capacidadMaxima = 1000;
            _cantidadActual = 0;
        }

        public Cafetera (int capacidadMaxima)
        {
            _capacidadMaxima = capacidadMaxima;
            _cantidadActual = capacidadMaxima;
        }
        public Cafetera (int capacidadMaxima, int capacidadActual)
        {
            _capacidadMaxima = capacidadMaxima;

            if (capacidadActual <= capacidadMaxima) { _cantidadActual = capacidadActual; }
            else { _cantidadActual = capacidadMaxima; }
        }

        public void LlenarCafetera()
        {
            _cantidadActual = _capacidadMaxima;
        }

        public int ServirTaza(int tamanoTaza)
        {
            int cantidadServida = tamanoTaza;
            
            if (tamanoTaza <= _cantidadActual)
            {
                _cantidadActual -= tamanoTaza;
                return cantidadServida;
            }

            else
            {
                cantidadServida = _cantidadActual;
                _cantidadActual = 0;
                return cantidadServida;
            }
        }

        public void VaciarCafetera()
        {
            _cantidadActual = 0;
        }

        public bool AgregarCafe(int agregarCafe)
        {
            if ((agregarCafe + _cantidadActual) <= _capacidadMaxima)
            {
                _cantidadActual += agregarCafe;
                return true;
            }

            else
            {
                _cantidadActual = _capacidadMaxima;
                return false;
            }
        }

        public bool NumeroPositivo(int numero)
        {
            if (numero >= 0) return true;
            else return false;
        }
    }
}
