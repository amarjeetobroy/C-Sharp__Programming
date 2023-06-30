using System;
class logical {
  static void Main() {
    int a=100,b=50;
    Console.WriteLine(a<b && a>b);
    Console.WriteLine(a>b || a<b);
    Console.WriteLine(!(a<b));
    
  }
}
/* Output
False
True
True
*/
