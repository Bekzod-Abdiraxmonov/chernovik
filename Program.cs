// // System.Console.Write("Birinchi sonni kiriting : ");
// // int firstNumber = Convert.ToInt32(Console.ReadLine());
// // System.Console.Write("Ikkinchi sonni kiriting : ");
// // int secondNumber = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Amalni kiriting : ");
// // string amal = Console.ReadLine();
// // // string password = "";
// // // do
// // // {
// // //     System.Console.WriteLine("Parolni kiriting : ");
// // //     password = Console.ReadLine();
// // // }
// // // while (password != "1234");
// // //  int number;

// // //         do
// // //         {
// // //             Console.Write("Musbat son kiriting: ");
// // //             number = Convert.ToInt32(Console.ReadLine());
// // //         } while (number <= 0);

// // //         Console.WriteLine($"Siz {number} ni kiritdingiz.");
// // int number;
// //         Console.Write("Musbat son kiriting: ");
// //         number = Convert.ToInt32(Console.ReadLine());

// //         while (number <= 0)
// //         {
// //             Console.Write("Xatolik! Musbat son kiriting: ");
// //             number = Convert.ToInt32(Console.ReadLine());
// //         }

// //         Console.WriteLine($"Siz {number} ni kiritdingiz.");
// System.Console.WriteLine("Ismingizni kiriting : ");
// string name = Console.ReadLine();
// System.Console.WriteLine("Yoshingizni kiriting : ");
// int age = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Manzilingizni kiriting : ");
// string address = Console.ReadLine();
// string [] names = new string[3];
// names[0] = "Ali";
// names[1] = "Vali";
// names[2] = name;
// int [] ages = {20, 25, age};
// string [] adres = {"Toshkent", "Samarqand", address};
// for (int i = 2; i < ages.Length; i--)
// {
//     System.Console.WriteLine($"Ism : {names[i]}");
//     System.Console.WriteLine($"Yosh : {ages[i]}");
//     System.Console.WriteLine($"Manzil : {adres[i]}");
//     System.Console.WriteLine();
// }
// for (int i = 1; i < 10; i++)
// {
//     for (int j = 1; j < 10; j++)
//     {
//         System.Console.Write($"{i * j}\t");
//     }
//     System.Console.WriteLine();
// }
int a = 1;
int b = 1000;
 while (a <= b)
 {
     System.Console.WriteLine(a);
        a+=2;
 }