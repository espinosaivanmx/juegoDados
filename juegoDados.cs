using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoDados
{
    internal class juegoDados
    {
        private List<Apuesta> _apuesta;
        private List<Jugador> _jugador;


        public void menuPrincipal()
        {
            int opcionSelecionada = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("...BIENVENIDO...");
                Console.WriteLine("1.-Modo de Juego");
                Console.WriteLine("2.-Menu Jugar");
                Console.WriteLine("3.-Menu Jugador");
                Console.WriteLine("4.-Menu Apostar");
                Console.WriteLine("5.-salir del juego");
            } while (!validaMenu(5, ref opcionSelecionada));
            Console.Clear();
            switch (opcionSelecionada)
            {
                case 1:
                    Console.WriteLine("Modo de Juego:");
                    Console.WriteLine("Enter para continuar");
                    modoJuego();
                    break;
                case 2:
                    Console.WriteLine("Menu jugar:");
                    Console.WriteLine("Enter para continuar");
                    Console.ReadLine();
                    Menujugar();
                    break;
                case 3:
                    Console.WriteLine("Menu Jugador:");
                    Console.WriteLine("Enter para continuar");
                    Console.ReadLine();
                    Menujugador();
                    break;
                case 4:
                    Console.WriteLine("Menu Apuesta");
                    Console.WriteLine("Enter para continuar");
                    Console.ReadLine();
                    MenuApuesta();
                    break;
                case 5:
                    Console.WriteLine("Gracias por jugar");
                    Console.WriteLine("Enter para salir...");
                    Console.ReadLine();
                    break;
            }

        }
        public void modoJuego()
        {
            int opcionSelecionada = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione modo de juego");
                Console.WriteLine("1.-Numero Cualquiera:");
                Console.WriteLine("2.-Numero Par o Impar");
                Console.WriteLine("3.-Salir.....");
            } while (!validaMenu(3, ref opcionSelecionada));
            Console.Clear();
            switch (opcionSelecionada)
            {
                case 1:
                    Console.WriteLine("1.-Numero Cualquiera");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("2.-Numero Par o Impar");
                    break;
                case 3:
                    Console.WriteLine("Salir.....");
                    break;

            }
        }
        public void MenuApuesta()
        {
            int opcionSelecionada = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu del jugador");
                Console.WriteLine("1.-apostar");
                Console.WriteLine("2.-Inicio apuesta");
                Console.WriteLine("3.-Saldo");
                Console.WriteLine("4.-salir");
            } while (!validaMenu(4, ref opcionSelecionada));
            Console.Clear();
            switch (opcionSelecionada)
            {
                case 1:
                    Console.WriteLine("apostar");
                    Console.ReadLine();
                    Inicio();
                    break;
                case 2:
                    Console.WriteLine("inicio apuesta");
                    Console.ReadLine();
                    tirarDados();
                    break;
                case 3:
                    Console.WriteLine("Saldo");
                    Console.ReadLine();
                    Saldo();
                    break;
                case 4:
                    break;

            }
        }
        public void Menujugar()
        {
            int opcionSelecionada = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu del jugador");
                Console.WriteLine("1.-Jugar");
                Console.WriteLine("2.-tirar dados");
                Console.WriteLine("3.-salir");
            } while (!validaMenu(3, ref opcionSelecionada));
            Console.Clear();
            switch (opcionSelecionada)
            {
                case 1:
                    Console.WriteLine("jugar");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("tirar dados");
                    Console.ReadLine();
                    tirarDados();
                    break;
                case 3:
                    break;

            }
        }
        public void Menujugador()
        {
            int opcionSelecionada = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu del jugador");
                Console.WriteLine("1.-Score juego");
                Console.WriteLine("2.-Score numeros pares");
                Console.WriteLine("3.-Score numeros impares");
                Console.WriteLine("4.-salir....");
            } while (!validaMenu(4, ref opcionSelecionada));
            Console.Clear();
            switch (opcionSelecionada)
            {
                case 1:
                    Console.WriteLine("Score Juego");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Score numeros pares");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Score numeros Impares");
                    Console.ReadLine();
                    break;
                case 4:
                    break;
            }
        }
        static void numeroCualquiera()
        {
            int num = 0;
            Console.WriteLine("Ingrese cualquier numero");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero:" + num);
        }
        
        static void numeroParImpar()
        {
            int num = 0;
            Console.WriteLine("Ingrese el numero");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero:" + num);
        }
        static void Inicio()
        {
            int dineroInicial = 300;
            int montoApuesta = 0;
            Console.Clear();
            Console.WriteLine("Dinero Inicial: " + dineroInicial);
            Console.WriteLine("Dinero a apostar: ");
            montoApuesta = int.Parse(Console.ReadLine());
            if (montoApuesta != dineroInicial)
            {
                Console.WriteLine("Dinero de apuesta: " + montoApuesta);
            }
            else
            {
                Console.WriteLine("Solo multiplos de 10");
            }
        }
        void scoreJuego()
        {
            Console.WriteLine("Score del juego: ");
        }
        void Saldo()
        {
            if (_apuesta.Count() > 0)
            {
                foreach (Apuesta item in _apuesta)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("no se encontraron resultados");
                Console.ReadLine();
            }
        }
        void tirarDados()
        {
            Random rnd = new Random();
            int numero = rnd.Next(1, 12);
            Console.WriteLine("Entrer para tirar: ");
            Console.WriteLine("Numero:" + numero);
        }
        private bool validaMenu(int rango, ref int opcionSeleccionada)
        {
            int numero;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero <= rango && numero != 0)
                {
                    opcionSeleccionada = numero;
                    return true;
                }
                else
                {
                    Console.WriteLine("Opción Inválida.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido, debes ingresar un número.");
                return false;
            }
        }
    }
}