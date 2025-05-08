// Uygulama Hem if Hemde switch karar yapıları kullanılarak yapılmıştır. Benim tercih ettiğim karar yapısı switchtir. Sebebi ise daha okunaklı ve anlaşılır olmasıdır. 
// Genişleme durumunda yeni seçenekler kolayca yazılabilir.
string fruit;
int price;

Console.WriteLine("Rüya Manavına Hoşgeldin ! \n Rüya Manavında Fiyatlar Çok uygun! \n  Fiyat Listesi : "); 
Console.WriteLine("Elma = 2 TL \nArmut = 3 TL \nÇilek = 2 TL \nMuz = 3 TL \nDiğer bütün meyveler = 4 TL "); // Fiyatlar Listelendi.

Console.WriteLine(" Hangi meyveyi almak istersin? (elma, armut, çilek, muz, diğer)");

fruit = Console.ReadLine().ToLower(); // Kullanıcıdan meyve ismi alındı.alının meyve ismini küçük harfe çevirdik.

switch (fruit) // Kullanıcının girdiği meyve ismine göre fiyat belirlendi.
{
    case "elma":
        price = 2;
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı : " + price + " TL");
        break;
    case "armut":
        price = 3;
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı : " + price + " TL");
        break;
    case "çilek":
        price = 2;
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı : " + price + " TL");
        break;
    case "muz":
        price = 3;
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı : " + price + " TL");
        break;
    default:
        Console.WriteLine(fruit + " Fiyatı 4 TL olarak belirlenmiştir.");
        price = 4;
        break;
}
Console.WriteLine("Rüya Manavını tercih ettiğin için teşekkür ederiz.");

// İF KARAR YAPISI İLE YAZILMIŞ HALİ

//string fruit;
//int price;

//Console.WriteLine("Rüya Manavına Hoşgeldin ! \n Rüya Manavında Fiyatlar Çok uygun! \n  Fiyat Listesi : ");
//Console.WriteLine("Elma = 2 TL \nArmut = 3 TL \nÇilek = 2 TL \nMuz = 3 TL \nDiğer bütün meyveler = 4 TL "); // Fiyatlar Listelendi.

//Console.WriteLine(" Hangi meyveyi almak istersin? (elma, armut, çilek, muz, diğer)");

//fruit = Console.ReadLine().ToLower(); // Kullanıcıdan meyve ismi alındı.alının meyve ismini küçük harfe çevirdik.

//if (fruit == "elma") // Kullanıcının girdiği meyve ismine göre fiyat belirlendi.
//{
//    price = 2;
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : " + price + " TL");
//}
//else if (fruit == "armut")
//{
//    price = 3;
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : " + price + " TL");
//}
//else if (fruit == "çilek")
//{
//    price = 2;
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : " + price + " TL");
//}
//else if (fruit == "muz")
//{
//    price = 3;
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : " + price + " TL");
//}
//else
//{
//    Console.WriteLine(fruit + " Fiyatı 4 TL olarak belirlenmiştir.");
//    price = 4;
//}
//Console.WriteLine("Rüya Manavını tercih ettiğin için teşekkür ederiz.");