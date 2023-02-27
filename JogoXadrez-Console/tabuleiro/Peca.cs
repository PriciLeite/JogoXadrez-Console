using System;
using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; set; }
    
        public Peca(Posicao posicao, Cor cor, int qteMovimento, Tabuleiro tabuleiro) 
        {
        
        
        }
    
    
    
    
    }
}
