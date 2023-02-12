using System;
using System.Security.Cryptography.X509Certificates;
using static System.Console;
using static System.ConsoleColor;

namespace LaGeneral
{
    class LaGeneral 
    {
        private static int dado1 = 0, dado2 = 0, dado3 = 0, dado4 = 0, dado5 = 0;
        private static int jug1 = 0, jug2 = 0, consl = 0;
        private static int modoJuego = 0;
        public void Dado() 
        {
            Random rnd = new Random();
            
            dado1 = rnd.Next(1, 6);
            dado2 = rnd.Next(1, 6);
            dado3 = rnd.Next(1, 6);
            dado4 = rnd.Next(1, 6);
            dado5 = rnd.Next(1, 6);
        }
        public void Modo1()
        {
            WriteLine($"// Jugador 1, teclea para tirar los dados");
            Console.ReadKey();
            Thread.Sleep(1000);
            Dado();
            ForegroundColor= ConsoleColor.Green;
            WriteLine($"// Jugador 1 tira primeron y saca <{jug1 += dado1 + dado2 + dado3 + dado4 + dado5}>");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"[1]: Dado uno: {dado1}");
            WriteLine($"[2]: Dado dos: {dado2}");
            WriteLine($"[3]: Dado tres: {dado3}");
            WriteLine($"[4]: Dado cuatro: {dado4}");
            WriteLine($"[5]: Dado cinco: {dado5}\n");

            WriteLine($"// Consola esta tirando");
            Thread.Sleep( 2000 );
            Dado();
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"// Consola tira despues y saca <{consl += dado1 + dado2 + dado3 + dado4 + dado5}>");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"[1]: Dado uno: {dado1}");
            WriteLine($"[2]: Dado dos: {dado2}");
            WriteLine($"[3]: Dado tres: {dado3}");
            WriteLine($"[4]: Dado cuatro: {dado4}");
            WriteLine($"[5]: Dado cinco: {dado5}\n");

            if (jug1 > consl)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("// Jugador 1 es el ganador!");
                ForegroundColor = ConsoleColor.White;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("// Consola es el ganador!");
                ForegroundColor = ConsoleColor.White;
            }
            jug1 = 0;
            consl = 0;
        }
        public void Modo2()
        {
            WriteLine($"// Jugador 1, teclea para tirar los dados");
            Console.ReadKey();
            Thread.Sleep(1000);
            Dado();
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"// Jugador 1 tira primeron y saca <{jug1 += dado1 + dado2 + dado3 + dado4 + dado5}>");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"[1]: Dado uno: {dado1}");
            WriteLine($"[2]: Dado dos: {dado2}");
            WriteLine($"[3]: Dado tres: {dado3}");
            WriteLine($"[4]: Dado cuatro: {dado4}");
            WriteLine($"[5]: Dado cinco: {dado5}\n");

            WriteLine($"// Jugador 2, teclea para tirar los dados");
            Console.ReadKey();
            Thread.Sleep(1000);
            Dado();
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"// Jugador 2 tira despues y saca <{jug2 += dado1 + dado2 + dado3 + dado4 + dado5}>");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"[1]: Dado uno: {dado1}");
            WriteLine($"[2]: Dado dos: {dado2}");
            WriteLine($"[3]: Dado tres: {dado3}");
            WriteLine($"[4]: Dado cuatro: {dado4}");
            WriteLine($"[5]: Dado cinco: {dado5}\n");

            if (jug1 > jug2)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("// Jugador 1 es el ganador!");
                ForegroundColor = ConsoleColor.White;
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("// Jugador 2 es el ganador!");
                ForegroundColor = ConsoleColor.White;
            }
            jug1 = 0;
            jug2 = 0;
        }
        public void JuegoDados() 
        {
            int result = 0;

            while (modoJuego == 0)
            {
                ForegroundColor = Yellow;
                WriteLine("Juego de dados <La General>!");
                ForegroundColor = White;
                WriteLine("El juego de dados consiste en sacar la mayor cantidad de puntos posibles para ganar\n");
                WriteLine("// Escoge tu modo de juego");
                WriteLine("[1]: Consola");
                WriteLine("[2]: Dos jugadores");
                WriteLine("[3]: Dos jugadores");
                try
                {
                    modoJuego = Convert.ToInt16(ReadLine());
                }
                catch (Exception e)
                {
                    WriteLine("// Eso no es una respuesta valida!");
                    ReadKey();
                    Clear();
                }
            }
            Clear();
            switch (modoJuego)
            {
                case 1:
                    Modo1();
                    break;
                case 2:
                    Modo2();
                    break;
                case 3:
                    Clear();
                    WriteLine("// Saliendo del juego");
                    Thread.Sleep(2000);
                    break;
            }
        }
        static void Main(string[] args) 
        {
            while (modoJuego < 3) 
            {
                LaGeneral lgn = new LaGeneral();
                lgn.JuegoDados();
            }
        }
    }
}