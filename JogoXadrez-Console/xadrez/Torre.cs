﻿using System;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }


        public override string ToString()
        {
            return "T";
        }



    }
}
