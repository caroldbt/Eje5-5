using System;

namespace Eje5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cint A = 4;
            int B = 6;
            int C = 8;
            int D = 3;
            B = C;
            C = A;
            A = D;
            D = B;
            System.Console.WriteLine("A = " + A + "\nB = " + B + "\nC = " + C + "\nD = " + D);
            
        }
    }
}
