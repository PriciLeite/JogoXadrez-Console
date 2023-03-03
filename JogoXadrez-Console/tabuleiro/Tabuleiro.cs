using System;


namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] pecas;  //Matriz de linhas x colunas
 

        public Tabuleiro(int linhas, int colunas) 
        {
            Linhas = linhas;
            Colunas = colunas;      
            pecas = new Peca[linhas, colunas];
        }
                

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha,coluna];
        }
    }

}
