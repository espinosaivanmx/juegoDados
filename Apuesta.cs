using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoDados
{
    internal class Apuesta
    {

        private string _inicial;
        private string _tirar;
        private string _apuesta;
        private string _score;

        public Apuesta(string _Apuesta, string _Tirar, string _Iniciar, string _Score)
        {
            _inicial = _Iniciar;
            _score = _Score;
            _tirar = _Tirar;
            _apuesta = _Apuesta;
        }

        public string Score
        {
            get { return _score; }
            set { _score = value; }
        }
        public string Apostar
        {
            get { return _apuesta; }
            set { _apuesta = value; }
        }
        public string Tirar
        {
            get { return _tirar; }
            set { _tirar = value; }
        }
        public string Iniciar
        {
            get { return _inicial; }
            set { _inicial = value; }
        }
        public override string ToString()
        {
            return $"Monto a Apostar: {_apuesta}, Numero: {_tirar}, Monto Inicial: {_inicial},Score: {_score}";
        }
    }
}
