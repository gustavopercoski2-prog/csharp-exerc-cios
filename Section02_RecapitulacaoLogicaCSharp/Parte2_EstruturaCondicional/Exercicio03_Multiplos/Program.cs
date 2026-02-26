namespace MultipleNumbers {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine()!.Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            if (x % y == 0 || y % x == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}