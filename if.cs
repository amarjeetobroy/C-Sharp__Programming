using System;
class main {
  static void Main(string[]args) {
     Console.Write("Enter your Age: ");
    int Age = Convert.ToInt32(Console.ReadLine());
     
     if(Age>=18){
         Console.WriteLine("You can vaild for vote!");
     }
     else{
         Console.WriteLine("You can not vaild for vote!");
     }
     
  }
}
/* Output
Enter your Age: 19
You can vaild for vote!
*/
