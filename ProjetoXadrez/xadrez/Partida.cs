using tabuleiro;

namespace xadrez
{
    internal class Partida
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public Partida()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarMovimentos();
            Peca capturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
        private void colocarPecas()
        {
            tab.colocarPeca(new Rei(Cor.Preta, tab), new PosicaoXadrez('d', 1).toPosicao());
            tab.colocarPeca(new Rei(Cor.Branca, tab), new PosicaoXadrez('d', 8).toPosicao());
            char ch = 'a';
            for (int i = 1; i <= 8; i++)
            {
                tab.colocarPeca(new Peao(Cor.Preta, tab), new PosicaoXadrez(ch, 2).toPosicao());
                tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez(ch, 7).toPosicao());
                ch++;
            }
        }
    }
}
