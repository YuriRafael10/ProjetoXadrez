using tabuleiro;
using xadrez;
namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(1, 0));
                tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicao(3, 0));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) { Console.WriteLine(e.Message); }
        }
    }
}