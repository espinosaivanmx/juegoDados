using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoDados
{
    internal class Jugador
    {
        private string _scoreJuego;
        private string _resultadoPares;
        private string _resultadoImpares;
        private string _jugador;

        public Jugador(string _Jugador, string _ScoreJuego, string _ResultadoPares, string ResultadoImpares)
        {
            _scoreJuego = _ScoreJuego;
            _resultadoImpares = ResultadoImpares;
            _resultadoPares = _ResultadoPares;
            _jugador = _Jugador;
        }
        public string Score
        {
            get { return _scoreJuego; }
            set { _scoreJuego = value; }
        }
        public string ResultadoImpares
        {
            get { return _resultadoImpares; }
            set { _resultadoImpares = value; }
        }
        public string ResPares
        {
            get { return _resultadoPares; }
            set { _resultadoPares = value; }
        }
        

        public string jugadorr
        {
            get { return _jugador; }
            set { _jugador = value; }
        }
        public override string ToString()
        {
            return $"Jugador: {_jugador}, Score: {_scoreJuego}, resultados impares{_resultadoImpares}, resultados pares: {_resultadoPares}";
        }
    }
}