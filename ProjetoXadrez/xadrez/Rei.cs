using tabuleiro;
namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            pos.definirValores(posicao.linha - 1, posicao.coluna);//cima
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);//ne
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            pos.definirValores(posicao.linha, posicao.coluna + 1);//dir
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);//se
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            pos.definirValores(posicao.linha + 1, posicao.coluna);//abaixo
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);//so
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            pos.definirValores(posicao.linha, posicao.coluna - 1);//esq
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);//no
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            return mat;
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
