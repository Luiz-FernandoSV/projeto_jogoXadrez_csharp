using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        public static void Main(String[] args)
        {
            Posicao p;

            p = new Posicao(3, 4);
            Console.WriteLine("Posição: "+p);
            Console.ReadLine();
        }
    }
}
