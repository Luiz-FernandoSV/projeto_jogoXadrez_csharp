using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        public static void Main(String[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.WriteLine("Digite a posição de origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.WriteLine("Digite a posição de destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMoviment9(origem, destino);

                }

            }
            catch (TabuleiroException te)
            {
                Console.WriteLine("Erro de tabuleiro: " + te.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
