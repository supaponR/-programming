using System;
using System.Collections.Generic;
namespace _3
{

    class Program
    {
        static void Main(string[] args)
        {
            string decide = "y";
            string selectFlower;
            FlowerStore flowerStore = new FlowerStore();
            do{
                ShowInputNumderSelectFlower(flowerStore);
                selectFlower = Console.ReadLine();
                SelectFlower(selectFlower,flowerStore);
                Console.WriteLine("You can stop this progress ?  exit for >>  exit << progress and pressany key for continue");
                decide = Console.ReadLine();
                if (decide == "exit")
                {ShowCurrentMyCart(flowerStore);}
            }while (decide != "exit");
        }

        static void ShowInputNumderSelectFlower(FlowerStore flowerStore){
            Console.WriteLine("Select number for buy flower :");
            foreach (string i in flowerStore.flowerList){
                Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + " ");
                Console.WriteLine(i);
            }
        }

        static void SelectFlower(string selectFlower, FlowerStore flowerStore){
            if(selectFlower == "1")
            {
                flowerStore.addToCart(flowerStore.flowerList[0]);
                Console.WriteLine("Added " + flowerStore.flowerList[0]);
            }
            else if (selectFlower == "2")
            {
                flowerStore.addToCart(flowerStore.flowerList[1]);
                Console.WriteLine("Added " + flowerStore.flowerList[1]);
            }
            else { Console.WriteLine("Not Added to cart. found select number of flower"); }  
        }

        static void ShowCurrentMyCart( FlowerStore flowerStore){

                Console.WriteLine("Current my cart");
                flowerStore.showCart();
        }
        
    }
}
