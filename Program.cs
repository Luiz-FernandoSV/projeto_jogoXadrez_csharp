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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 1));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                Tela.ImprimirTabuleiro(tab);

                PosicaoXadrez px = new PosicaoXadrez('c', 7);
                Console.WriteLine(px);
                Console.WriteLine(px.ToPosicao()) ;

                Console.WriteLine();
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
