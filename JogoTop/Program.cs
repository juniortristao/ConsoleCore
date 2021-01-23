using JogoTop.Lib;

namespace JogoTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoTop(
                new Jogador1(),
                new Jogador2()
            );

            jogo.Iniciarjogo();
        }
    }
}
