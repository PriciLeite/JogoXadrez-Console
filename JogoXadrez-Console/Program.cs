using System;
using tabuleiro;
using xadrez;


namespace JogoXadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(Cor.Branco, tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Branco, tab), new Posicao(1, 3));
            tab.colocarPeca(new Rei(Cor.Azul, tab), new Posicao(2, 4));
            tab.colocarPeca(new Rei(Cor.Azul, tab), new Posicao(6, 4));
            tab.colocarPeca(new Torre(Cor.Branco, tab), new Posicao(7, 0));
            tab.colocarPeca(new Torre(Cor.Branco, tab), new Posicao(7, 5));
            tab.colocarPeca(new Torre(Cor.Branco, tab), new Posicao(7, 7));






            Tela.ImprimirTabuleiro(tab);
            Console.ReadLine();
            


        }
    }
}
