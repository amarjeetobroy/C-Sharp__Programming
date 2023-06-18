using System;
class main {
  static void Main(string[]args) {
      int a=10,b=20;
      int c=a+b;
    Console.WriteLine(c);
  }
}

/* Output
30
*/

using System;
class main {
  static void Main(string[]args) {
      int a,b,c;
    Console.WriteLine("Enter any two numbers: ");
    a=Convert.ToInt32(Console.ReadLine());
    b=Convert.ToInt32(Console.ReadLine());
    c=a+b;
    Console.WriteLine("Sum of two numbers: "+c);
  }
}

/* Output
Enter any two numbers: 
20 
69
Sum of two numbers: 89
*/
