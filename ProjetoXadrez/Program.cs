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
                Partida partida = new Partida();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e) { Console.WriteLine(e.Message); }
        }
    }
}