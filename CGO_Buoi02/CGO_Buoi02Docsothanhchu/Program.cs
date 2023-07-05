using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi02Docsothanhchu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
     string input = Console.Readline();
    int sonhap = int.Parse(input);
    //29 -> 0 2 9
    int donvi = sonhap % 10;			
    int hangchuc = (sonhap/10) % 10;	
    int hangtram = sonhap % 100;		

    if(input.Length == 3){
       //Xuat gia hangtram;
       switch(hangtram){
           case 0: Console.Write("zero"); break;
           case 1: Console.Write("one hundred"); break;
           //...
       }
    }
    else if(input.Length == 2){
       //Xuat gia hangchuc;
       switch(hangchuc){
           case 0: Console.Write("zero .."); break;
           case 1: Console.Write("one hundred"); break;
           //...
       }
    }
   else  if(input.Length == 1){
       //Xuat gia donvi;
       switch(donvi){
           case 0: Console.Write("zero .."); break;
           case 1: Console.Write("one hundred"); break;
           //...
       }
    }
        
        }









