using System;
using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; } //alterada somente pelas subclasses e ela mesma.
        public Tabuleiro Tabuleiro { get; protected set; } //alterada somente pelas subclasses e ela mesma.

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro) 
        {
            this.Posicao = posicao;
            this.Cor = cor;
            this.Tabuleiro = tabuleiro;
            this.qteMovimentos = 0;
        
        }
    
    
    
    
    }
}
