namespace ReverseBits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 00000000000000000000000000001011;
            uint res = 0;
            int bits = 32;

            while (n != 0)
            {
                res += (n & 1) << bits;
                bits--;
                n >>= 1;
            }

            Console.WriteLine(res);
        }
    }
}