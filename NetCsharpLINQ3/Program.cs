// See https://aka.ms/new-console-template for more information
using NetCsharpLINQ3;

Phone[] mass = {new Phone("iPhone 14", "Apple", 999.99m, new DateTime(2023, 9, 14)),
            new Phone("Galaxy S23", "Samsung", 899.99m, new DateTime(2023, 2, 1)),
            new Phone("Pixel 8", "Google", 799.99m, new DateTime(2023, 10, 4)),
            new Phone("Xperia 1 V", "Sony", 1199.99m, new DateTime(2023, 5, 23)),
            new Phone("OnePlus 11", "OnePlus", 699.99m, new DateTime(2023, 1, 11)),
            new Phone("Mi 13", "Xiaomi", 499.99m, new DateTime(2023, 3, 10)),
            new Phone("Moto Edge 40", "Motorola", 599.99m, new DateTime(2023, 8, 15)),
            new Phone("Find X6 Pro", "Oppo", 1099.99m, new DateTime(2023, 6, 18)),
            new Phone("Magic 5 Pro", "Honor", 799.99m, new DateTime(2023, 7, 20)) };

int countPhones = mass.Count();
Console.WriteLine(countPhones);
//int countPriceMoreHundred = (from phone in mass where phone.Price > 100 select phone).Count();
//Console.WriteLine(countPriceMoreHundred);
//int countBetween = (from phone in mass where phone.Price >= 400 & phone.Price<=700 select phone).Count();
//Console.WriteLine(countBetween);
//int manufCount = (from phone in mass where phone.Manufacture == "Samsung" select phone).Count();
//Console.WriteLine(manufCount);
//var MinPricePhone = (from phone in mass where phone.Price == mass.Min(phone => phone.Price) select phone);
//foreach(var phone in MinPricePhone)
//{
//    Console.WriteLine(phone.ToString());
//}
//var MaxPricePhone = from phone in mass where phone.Price == mass.Max(phone => phone.Price) select phone;
//foreach (var phone in MaxPricePhone)
//{
//    Console.WriteLine(phone.ToString());
//}
//var OldestPhone = from phone in mass where phone.startDate == mass.Min(phone => phone.startDate) select phone;
//foreach (var phone in OldestPhone)
//{
//    Console.WriteLine(phone.ToString());
//}
//var NewestPhone = from phone in mass where phone.startDate == mass.Max(phone => phone.startDate) select phone;
//foreach (var phone in NewestPhone)
//{
//    Console.WriteLine(phone.ToString());
//}

//var average = mass.Average(n => n.Price);
//Console.WriteLine(average);

var fiveExpensivePhones = mass.OrderByDescending(phone => phone.Price).Take(5);
foreach (var phone in fiveExpensivePhones)
{
    Console.WriteLine(phone.ToString());
}
Console.WriteLine();
var fiveCheapPhones = mass.OrderBy(phone => phone.Price).Take(5);
foreach (var phone in fiveCheapPhones)
{
    Console.WriteLine(phone.ToString());
}
Console.WriteLine();
var fiveNewPhones = mass.OrderByDescending(phone => phone.startDate).Take(5);
foreach (var phone in fiveNewPhones)
{
    Console.WriteLine(phone.ToString());
}
Console.WriteLine();
var fiveOldPhones = mass.OrderBy(phone => phone.startDate).Take(5);
foreach (var phone in fiveOldPhones)
{
    Console.WriteLine(phone.ToString());
}
Console.WriteLine();



var phoneGroup = mass.GroupBy(p => p.Manufacture)
                      .Select(g => new { Manufacture = g.Key, Count = g.Count() });
foreach (var group in phoneGroup)
    Console.WriteLine("{0} : {1}", group.Manufacture, group.Count);
Console.WriteLine('\n');


Console.WriteLine();

 var phoneGroup2 = mass.GroupBy(p => p.Name)
                      .Select(g => new { Name = g.Key, Count = g.Count() });
foreach (var group in phoneGroup2)
    Console.WriteLine("{0} : {1}", group.Name, group.Count);
Console.WriteLine('\n');


Console.WriteLine();

var phoneGroup3 = mass.GroupBy(p => p.startDate.Year)
                     .Select(g => new { Year = g.Key, Count = g.Count() });
foreach (var group in phoneGroup3)
    Console.WriteLine("{0} : {1}", group.Year, group.Count);
Console.WriteLine('\n');


Console.WriteLine();