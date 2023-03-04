using System;
using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }

        public int linha { get; set; }

    
        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }


        //método para converter a posição (char/int para uma posição interna de matriz -> (0,0) ):
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }


        // método para imprimir a letra coluna + número linha
        public override string ToString()
        {
            return "" + coluna + linha;
        }




    }
}
