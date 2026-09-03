namespace ConsoleApp2
{

    internal class MethodOver
    {
        public static int DoubleScale(int val)
        {
            return val * 2;
        }
        public static float DoubleScale(float val)
        {
            return val * 2;
        }
    }

    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("정수형" + MethodOver.DoubleScale(3));
            Console.WriteLine("실수형" + MethodOver.DoubleScale(3.14f));
        }
    }
}
