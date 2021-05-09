using System;

class MainClass {
  
  public static void Main (string[] args) {
    double sum = 0;
    for(int i=1;i<=5;i++){
Console.WriteLine("Enter mark "+i+" :");
sum += Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("average : " +sum/5);
if(sum/5 > 70){
Console.WriteLine("\ngood");
}
else{
Console.WriteLine("\nbad");
}
  }
}