namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nro01 = Convert.ToInt32(args[0]);
            var nro02 = Convert.ToInt32(args[1]);
            Console.WriteLine($"A soma dos números {nro01} e {nro02} é igual a {Soma(nro01, nro02)}");
        }

        public static int Soma(int a, int b)
        {
            return a + b;
        }
    }
}
