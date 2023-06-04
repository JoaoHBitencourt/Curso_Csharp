namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;

            Console.WriteLine("Digite uma senha:");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida! Tente novamente:");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}