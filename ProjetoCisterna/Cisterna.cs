using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCisterna
{
    class Cisterna
    {
        public int nivelMaximo;
        private int _nivel;
        public int nivel {
            get { return _nivel; }
            set {
                _nivel = value;

                if (_nivel < 0)
                {
                    _nivel = 0;
                }
                else if (_nivel > nivelMaximo)
                {
                    _nivel = nivelMaximo;
                }

                NivelCisternaEvent(_nivel == nivelMaximo);
            }
        }

        public delegate void NivelCisternaDelegate(Boolean isCheia);
        public event NivelCisternaDelegate NivelCisternaEvent;
    }
}
