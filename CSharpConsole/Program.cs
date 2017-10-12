//using System; moramo ga navoditi

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 100; ++i)
                sum += i;
            System.Console.WriteLine(sum);

            System.Console.WriteLine("Zdravo bjac");
            System.Console.ReadKey(true); //da ne prikazuje slovo koje stisnemo zato TRUE
        }
    }
}
