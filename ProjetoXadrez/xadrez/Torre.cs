using tabuleiro;
namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            pos.definirValores(posicao.linha - 1, posicao.coluna);//acima
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null & tab.peca(pos).cor != this.cor) { break; }
                pos.linha = pos.linha - 1;
            }
            pos.definirValores(posicao.linha + 1, posicao.coluna);//abaixo
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null & tab.peca(pos).cor != this.cor) { break; }
                pos.linha = pos.linha + 1;
            }
            pos.definirValores(posicao.linha, posicao.coluna + 1);//direita
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null & tab.peca(pos).cor != this.cor) { break; }
                pos.coluna = pos.coluna + 1;
            }
            pos.definirValores(posicao.linha, posicao.coluna - 1);//esquerda
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null & tab.peca(pos).cor != this.cor) { break; }
                pos.coluna = pos.coluna - 1;
            }

            return mat;
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
