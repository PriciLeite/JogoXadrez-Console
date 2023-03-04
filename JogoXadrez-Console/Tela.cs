using System;
using tabuleiro;

namespace JogoXadrez_Console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)                  
            {
                
                Console.Write("                  " + (8 - i) + "  ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {                                            // percorrendo a matriz
                    if (tabuleiro.peca(i,j) == null)
                    {                        
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tabuleiro.peca(i, j));
                        Console.Write(" ");
                    }                   
                    
                }
                Console.WriteLine();
            }            
            Console.WriteLine("                  " + "   a b c d e f g h");        
        
        }   
    
        
        public static void imprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branco)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        
        
        
        }   








    
    }
    
    
}
