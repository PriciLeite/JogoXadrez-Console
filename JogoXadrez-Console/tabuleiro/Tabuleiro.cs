﻿using System;


namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        private Peca[,] pecas;  //Matriz de linhas x colunas
 
        public Tabuleiro(int linhas, int coluna) 
        {
            Linha = linhas;
            Coluna = coluna;        
        }
    
    
    
    
    
    
    }
}