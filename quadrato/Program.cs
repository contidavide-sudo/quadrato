namespace quadrato
{
    internal class Program
    {

        static bool Quadrato(int[] v)
        {
            for(int i=1; i<v.Length; i++)
            {
                if ((v[i-1] * v[i-1]) < v[i])
                {
                    return false;
                }
               
            }

            return true;
            
        }
        static void Main(string[] args)
        {
            int[] vet = { 1, 2};

           Console.WriteLine(Quadrato(vet));
           
        }
    }
}
