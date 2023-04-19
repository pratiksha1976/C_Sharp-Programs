using System;

class Program {
    static bool IsPrime(int n) {
        if (n < 2) {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++) {
            if (n % i == 0) {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        for (int i = 2; count < n; i++) {
            if (IsPrime(i)) {
                Console.Write(i + " ");
                count++;
            }
        }
    }
}