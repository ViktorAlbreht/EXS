﻿Console.Clear(); 
int n = new Random().Next(100, 1000); // [100, 999] 
Console.WriteLine(n);
 int n1 = n % 100;
  int n3 = n / 10;
  int n2 = n % 10;
   Console.WriteLine((n1 % 100 - n3 % 10)/10);
   

