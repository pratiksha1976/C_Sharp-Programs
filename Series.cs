using  System;

class program{

    static void printSeries(int n,int a,int b,int c)
    {
        int d;

        if(n==1)
        {
            Console.Write(a+" ");
            return;
        }
        if(n==2)
        {
            Console.Write(a+" "+b+" ");
            return;
        }

        Console.Write(a+" "+b+" "+c+" ");

        for(int i=4;i<=n;i++)
        {
            d=a+b+c;
            Console.Write(d+" ");

            a=b;
            b=c;
            c=d;

        }
    }

    public static void Main()
    {
        int num=int.Parse(Console.ReadLine());

        int a=1,b=3;
        int c=4;

        printSeries(num,a,b,c);
    }
}   