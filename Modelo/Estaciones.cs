using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Estaciones
    {
        private Estacion _primavera;

        public Estacion Primavera
        {
            get
            {
                if(this._primavera == null)
                {
                    _primavera = new Estacion(3, 21, 6, 20);
                }
                return _primavera;
            }
        }

        private Estacion _verano;

        public Estacion Verano
        {
            get
            {
                if (this._verano == null)
                {
                    _verano = new Estacion(6, 21, 9, 20);
                }
                return _verano;
            }
        }

        private Estacion _otoño;

        public Estacion Otoño
        {
            get
            {
                if (this._otoño == null)
                {
                    _otoño = new Estacion(9, 21, 12, 20);
                }
                return _otoño;
            }
        }

        private Estacion _invierno;

        public Estacion Invierno
        {
            get
            {
                if (this._invierno == null)
                {
                    _invierno = new Estacion(12, 21, 3, 20);
                }
                return _invierno;
            }
        }

        public class Estacion
        {
            public Estacion(byte mesInicio, byte diaInicio, byte mesFin, byte diaFin)
            {
                this.MesInicio = mesInicio;
                this.DiaInicio = diaInicio;
                this.MesFin = mesFin;
                this.DiaFin = diaFin;
            }

            public byte MesInicio { get; set; }
            public byte DiaInicio { get; set; }
            public byte MesFin { get; set; }
            public byte DiaFin { get; set; }
        }
    }
}
