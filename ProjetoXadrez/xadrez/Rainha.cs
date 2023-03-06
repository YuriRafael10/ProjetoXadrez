﻿using tabuleiro;
namespace xadrez
{
    internal class Rainha : Peca
    {
        public Rainha(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override bool[,] movimentosPossiveis()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
