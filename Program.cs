﻿using System;
namespace HelloWorld{
    class Program{
        static void Main (string[] args){
            //  Console.WriteLine("HelloWorld");
            //  Console.WriteLine("What is your name?" );
            //  string str=Console.ReadLine();
            //  Console.WriteLine("Hello there " + str);

            int i=10;
             float f= 2.0f;
            decimal d=10.0m;
             bool b = true;
            char c='c';
            string str ="solomon";
             var x=10;
             var z="Hello World";
            int[] vals=new int[5];
            string[] strs={"one","two","three"};
             Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", i,f,d,b,c,str,x,z);
            // int x =10, y =5;
            // string a ="abcd", b="efgh";
            // Console.WriteLine((x/y)*x);
            // Console.WriteLine(a+b); 
        }
    }
}
