






#region task1 metod1
//Console.Write("Ededi daxil edin:");
//int number = int.Parse(Console.ReadLine());
//while (true)
//    if (number > 999 && number < 10000)
//    {
//        Console.Write("7");
//        Console.Write(number);
//        Console.WriteLine("8");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Yalniz 4 reqemli eded daxil ede bilersiniz");
//        number = int.Parse(Console.ReadLine());

//    }

#endregion

#region task1 metod2

//using System.Reflection.Metadata.Ecma335;

//Console.Write("ededi daxil edin:");
//int number = int.Parse(Console.ReadLine());
//while (number < 999 || number > 10000)
//{
//    Console.WriteLine("4 reqemli eded daxil edin");
//    number=int.Parse(Console.ReadLine());
//}
//string result = number switch
//{
//    _ when number > 999 && number < 10000 => "7" + number + "8"

//}; 


//Console.WriteLine(result);
#endregion

#region task2

//Console.WriteLine("ededi daxil edin:");
//int number = int.Parse(Console.ReadLine());
//while (number < 99 || number > 1000)
//{
//    Console.WriteLine("3 reqemli eded daxil edin:");
//    number=int.Parse(Console.ReadLine());
//}
//string result = number switch
//{
//    _ when number > 99 && number < 1000 => "" + number + number

//};
//Console.WriteLine(result);
#endregion

#region task3
double number = int.Parse(Console.ReadLine());

while (number < 9999 || number > 100000)
    {
    Console.WriteLine("5 reqemli eded daxil edin");
    number=int.Parse(Console.ReadLine());
}
double result = number switch
{
    _ when number > 9999 && number < 100000 => (number * 18) / 100,
    
};
Console.Write("ededin 18 faizi:");
Console.WriteLine(result);
    result = (result * 3) / 100;
Console.Write("alinan ededin 3 faizi:");
Console.WriteLine(result);

#endregion

#region task4
//using System.Diagnostics.CodeAnalysis;

//int number=int.Parse(Console.ReadLine());
//string result = number switch
//{ 
//  _ when number>99&&number<1000 => number+"7",
//  _=>"3 reqemli eded daxil edin"
//};
//float count = int.Parse(result);
//count = (count * 7) / 100;
//Console.Write("cavab:");
//Console.WriteLine(count);
#endregion

#region task5
//int number=int.Parse(Console.ReadLine());
//string result = number switch
//{ 
//    _ when number>999 && number<10000 =>"4"+number+"44",
//    _=>"4 reqemli eded daxil edin "
//};
//float count = int.Parse(result);
//count=(count*44)/ 100;
//Console.WriteLine(count);
#endregion

#region task6
//Console.Write("ededi daxil edin: ");
//int number = int.Parse(Console.ReadLine());
//float result = number switch
//{
//    _ when number > 999 && number < 10000 => (number*20)/100,
//    _ => 0
//};
//if (result == 0 )
//{
//    Console.WriteLine("4 reqemli eded daxil edin");
//}
//else
//{
//     result = (result * 10 )/ 100;
//   float count = result * result;
//    Console.Write("cavab:");
//    Console.WriteLine(count);
//}

#endregion

#region task7
//Console.WriteLine("Ededleri daxil edin:");
//int num1=int.Parse(Console.ReadLine());
//int num2=int.Parse(Console.ReadLine());

//int sum=num1 + num2;

//int result = int.Parse("5" + sum + "5");

//result = result * 5 / 100;

//Console.WriteLine(result);
#endregion

#region task3 new


#endregion