using System;  
public class NumberTriangle  
{  
    public static void Main(string[] args)  
    {  
        //char ch='A';      
        int num = 1;
        int i, j, k, m, times;
        Console.WriteLine("Enter the range");
        times = int.Parse(Console.ReadLine());
        for(i=1; i<=times; i++)      
        {      
            for(j=5; j>=i; j--)      
                Console.Write(" ");      

            for(k=1;k<=i;k++)      
                Console.Write(num++);      
            num--;      
            
            for(m=1;m<i;m++)      
                Console.Write(--num);      
            
            Console.Write("\n");      
            num = 1;
        }      
    }  
}  