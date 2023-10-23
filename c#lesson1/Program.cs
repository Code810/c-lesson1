#region task1 metod1

//int number=int.Parse(Console.ReadLine());
//while(number>0)
//if (number > 999 && number < 10000) 
//{
//    Console.Write("7");
//    Console.Write(number);
//    Console.WriteLine("8");
//        break;
//}
//else 
//{
//        Console.WriteLine("Yalniz 4 reqemli eded daxil ede bilersiniz");
//        number = int.Parse(Console.ReadLine());

//}

#endregion

#region task1 metod2


//int number = int.Parse(Console.ReadLine());

//string result = number switch
//{
//        _ when number > 999 && number < 10000 => "7" + number + "8",
//        _ => "4 reqemli eded daxil edilmelidir"
//};
//Console.WriteLine(result);
#endregion

#region task2

//int number = int.Parse(Console.ReadLine());

//string result = number switch
//{
//    _ when number > 99 && number < 1000 => ""+number + number,
//    _ => "3 reqemli eded daxil edilmelidir"
//};
//Console.WriteLine(result);
#endregion

#region task3
//int number = int.Parse(Console.ReadLine());
//int result = number switch
//{
//    _ when number>9999&&number<100000 => (number*18)/100,
//    _=>0
//};
//if (result==0)
//{
//    Console.WriteLine("5 reqemli eded daxil edin");
//}
//else
//{
//    Console.WriteLine(result);
//    result = (result * 3) / 100;
//    Console.WriteLine(result);
//}
#endregion

#region task4
using System.Diagnostics.CodeAnalysis;

int number=int.Parse(Console.ReadLine());
string result = number switch
{ 
  _ when number>99&&number<1000 => number+"7",
  _=>"3 reqemli eded daxil edin"
};
float count = int.Parse(result);
count = (count * 7) / 100;
Console.Write("cavab:");
Console.WriteLine(count);
#endregion