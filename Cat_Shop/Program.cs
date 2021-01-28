using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace Cat_Shop
{

    class Cat
    {
        public string Nickname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Energy { get; set; } = 100;
        public int Price { get; set; } = 0;
        public int MealQuantity { get; set; } = 1000;

        public void Eat()
        {
            Energy += 5;
            Price += 5;
            MealQuantity -= Energy;



        }
        public int Sleep()
        {
            Energy += 10;
            return Energy;
        }
        public void Play()
        {

            Energy -= 20;



        }



        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n ==== Cat ======================================================= ");
            Console.WriteLine($" Nickname: \t\t {Nickname}");
            Console.WriteLine($" Age: \t\t\t {Age}");
            Console.WriteLine($" Nickname: \t\t {Gender}");
            Console.WriteLine($" Energy: \t\t {Energy} ");
            Console.WriteLine($" Price: \t\t {Price} USD");
            Console.WriteLine($" Meal Quantity: \t {MealQuantity} ");
            Console.WriteLine(" =============================================================== \n");



        }
    }

    class CatHouse
    {
        public double Housearea { get; set; }
        public string Housecolor { get; set; }
        public Cat[] Cats { get; set; }

        public int CatCount { get; set; } = default;

        public void AddCat(ref Cat cats)
        {
            Cat[] temp = new Cat[++CatCount];
            if (Cats != null)
            {
                Cats.CopyTo(temp, 0);

            }
            temp[temp.Length - 1] = cats;
            Cats = temp;
        }

        public bool RemoveCat()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter nickname for delete: ");
            string nick = Console.ReadLine();


            bool found = false;
            for (int i = 0; i < Cats.Length; ++i)
            {
                if (found)
                {
                    Cats[i - 1] = Cats[i];
                }
                else if (Cats[i].Nickname == nick)
                {
                    found = true;
                }
            }
            return found;



        }

        public void CatHouseshow()
        {
            foreach (var item in Cats)
            {
                item.Show();
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Cat House ================================================= ");
            Console.WriteLine($" House area: \t\t {Housearea} m2");
            Console.WriteLine($" House color: \t\t {Housecolor}");
            Console.WriteLine(" ================================================================ \n");



        }
    }


    class PetShop
    {
        public CatHouse[] CatHouses { get; set; }
        public int CatHouseCount { get; set; } = default;
        public void AddCatHouse(ref CatHouse catHouses)
        {
            CatHouse[] temp = new CatHouse[++CatHouseCount];
            if (CatHouses != null)
            {
                CatHouses.CopyTo(temp, 0);

            }
            temp[temp.Length - 1] = catHouses;
            CatHouses = temp;
        }

        public void PetShopshow()
        {
            foreach (var item in CatHouses)
            {
                item.Show();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:\\Users\\Lenovo\\source\\repos\\Cat Shop\\Cat_Shop\\Cat_Shop\\SpaceCatsMagicFly.wav";
            player.Play();

            DateTime catbirth1 = new DateTime(2020, 1, 1);
            DateTime dateTime1 = DateTime.Now;
            TimeSpan catyear1 = dateTime1 - catbirth1;

            DateTime catbirth2 = new DateTime(2019, 1, 1);
            DateTime dateTime2 = DateTime.Now;
            TimeSpan catyear2 = dateTime2 - catbirth2;

            Cat c1 = new Cat()
            {
                Nickname = "Muncuq",
                Age = (int)catyear1.TotalDays / 360,
                Gender = "Male"
            };

            Cat c2 = new Cat()
            {
                Nickname = "Mestan",
                Age = (int)catyear2.TotalDays / 360,
                Gender = "Female"
            };



            CatHouse ch1 = new CatHouse()
            {
                Housearea = 15.36,
                Housecolor = "Red"
            };

            CatHouse ch2 = new CatHouse()
            {
                Housearea = 20.50,
                Housecolor = "Green"
            };

            PetShop petshopPlace = new PetShop();

            petshopPlace.AddCatHouse(ref ch1);
            petshopPlace.PetShopshow();
            ch1.AddCat(ref c1);
            ch1.CatHouseshow();



            PetShop petshopPlace2 = new PetShop();

            petshopPlace2.AddCatHouse(ref ch2);
            petshopPlace2.PetShopshow();
            ch2.AddCat(ref c2);
            ch2.CatHouseshow();

            Thread.Sleep(10000);
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" \n Play: ");

                c1.Play();
                c1.Show();
                Thread.Sleep(600);

                Console.Clear();
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" \n Sleep: ");

                c1.Sleep();
                c1.Show();
                Thread.Sleep(600);

                Console.Clear();
            }


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(" \n Play: ");

                c1.Play();
                c1.Show();
                Thread.Sleep(600);

                Console.Clear();
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(" \n Eat: ");

                c1.Eat();
                c1.Show();
                Thread.Sleep(600);

                Console.Clear();
            }


            ch1.CatHouseshow();


            Thread.Sleep(5000);
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" \n Play: ");

                c2.Play();
                c2.Show();
                Thread.Sleep(600);

                Console.Clear();
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" \n Sleep: ");

                c2.Sleep();
                c2.Show();
                Thread.Sleep(600);

                Console.Clear();
            }


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(" \n Play: ");

                c2.Play();
                c2.Show();
                Thread.Sleep(600);

                Console.Clear();
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(" \n Eat: ");

                c2.Eat();
                c2.Show();
                Thread.Sleep(600);

                Console.Clear();
            }


            ch2.CatHouseshow();

            Console.Clear();
            ch1.CatHouseshow();
            ch2.CatHouseshow();

            ch1.RemoveCat();
            ch1.CatHouseshow();


            Console.ReadKey();
        }
    }
}
