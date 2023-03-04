using System;
using tabuleiro;
using xadrez;


namespace JogoXadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=================== JOGO DE XADREZ ===================");
                Console.WriteLine();
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Branco, tab), new Posicao(0, 0));
                tab.colocarPeca(new Torre(Cor.Branco, tab), new Posicao(3, 3));
                tab.colocarPeca(new Rei(Cor.Azul, tab), new Posicao(2, 4));
                tab.colocarPeca(new Rei(Cor.Azul, tab), new Posicao(6, 4));
                tab.colocarPeca(new Torre(Cor.Branco, tab), new Posicao(7, 0));
                tab.colocarPeca(new Torre(Cor.Branco, tab), new Posicao(7, 5));
                tab.colocarPeca(new Torre(Cor.Branco, tab), new Posicao(7, 7));
                Tela.ImprimirTabuleiro(tab);

                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());

            }
            catch (TabuleiroExceptions e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();



















        }
    }
}
