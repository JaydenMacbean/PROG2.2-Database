using System;

namespace WhatCouldThisBe
{
    class Pouch
    {
        string answer1;
        string answer2;
        static int bombsInPossession = 0;
        static int poisonJarsInPossession = 0;
        static int donutsInPossession = 0;
        FaustItem inFaustory = new FaustItem("shop", 69);
        public void Start()
        {
            Console.WriteLine("Welcome to Faust's Item Shop! How can I help you?");
            Console.WriteLine("Here you can either buy items or participate in the item roulette form free!");
            Console.WriteLine("Write either BUY or ROULETTE or CHECK INVENTORY or LEAVE\n");
            answer1 = Console.ReadLine();

            if(answer1.ToLower() == "buy" || answer1.ToLower() == "buy ")
            {
                Buy();
            }

            if (answer1.ToLower() == "roulette" || answer1.ToLower() == "roulette ")
            {
                Roulette();
            }

            if (answer1.ToLower() == "check inventory" || answer1.ToLower() == "check inventory ")
            {
                CheckInFaustory();
            }

            if (answer1.ToLower() == "leave" || answer1.ToLower() == "leave ")
            {
                Console.Clear();
            }





        }

        public void Buy()
        {
            Console.WriteLine("Here's our current selection of items:\n - BOMB \n - POISON \n - DONUT");
            Console.WriteLine("Type out the item name to buy it."); 
            Console.WriteLine("You can also check your current amount of money by typing MONEY or head back to start through typing BACK.\n");
            answer1 = Console.ReadLine();

            switch(answer1)
            {
                case "BOMB":

                    Bomb aBomb = new Bomb("Bomb", 0);
                    inFaustory.AddItems(aBomb);
                    bombsInPossession++;
                    Console.WriteLine("Would you like to buy anything else? y/n");
                    Console.WriteLine("Type out y to head back to the buying section, or n to leave\n");
                    answer2 = Console.ReadLine();
                    if(answer2.ToLower() == "y")
                    {
                        Buy();
                    }

                    else
                    {
                        Start();
                    }
                    break;

                case "POISON":

                    Poison poisonJar = new Poison("Poison", 1);
                    inFaustory.AddItems(poisonJar);
                    poisonJarsInPossession++;
                    Console.WriteLine("Would you like to buy anything else? y/n");
                    Console.WriteLine("Type out y to head back to the buying section, or n to leave\n");
                    answer2 = Console.ReadLine();
                    if (answer2.ToLower() == "y")
                    {
                        Buy();
                    }

                    else
                    {
                        Start();
                    }
                    break;

                case "DONUT":

                    Donut aDonut = new Donut("Donut", 2);
                    inFaustory.AddItems(aDonut);
                    donutsInPossession++;
                    Console.WriteLine("Would you like to buy anything else? y/n");
                    Console.WriteLine("Type out y to head back to the buying section, or n to leave\n");
                    answer2 = Console.ReadLine();
                    if (answer2.ToLower() == "y")
                    {
                        Buy();
                    }

                    else
                    {
                        Start();
                    }
                    break;





            }


        }

        public void Roulette()
        {

        }

        public void CheckInFaustory()
        {
            Console.WriteLine("Here's what items you can check: \n - BOMBS \n - POISON \n - DONUTS");
            Console.WriteLine("Type out the item name to check it out.");
            answer1 = Console.ReadLine();
            
            switch(answer1)
            {
                case "BOMBS":

                    if(bombsInPossession == 0)
                    {
                        Console.WriteLine("Current bomb amount: " + bombsInPossession);
                        Start();
                    }
                    else
                    {
                        foreach (Bomb aBomb in inFaustory.faustItems)
                        {
                            
                            Console.WriteLine("Current bomb amount: " + bombsInPossession);
                            Start();
                        }
                    }               
                    break;

                case "POISON":

                    if (poisonJarsInPossession == 0)
                    {
                        Console.WriteLine("Current poison jar amount: " + poisonJarsInPossession);
                        Start();
                    }
                    else
                    {
                        foreach (Poison poisonJar in inFaustory.faustItems)
                        {

                            Console.WriteLine("Current poison jar amount: " + poisonJarsInPossession);
                            Start();
                        }
                    }
                    break;

                case "DONUTS":

                    if (donutsInPossession == 0)
                    {
                        Console.WriteLine("Current donut amount: " + donutsInPossession);
                        Start();
                    }
                    else
                    {
                        foreach (Donut aDonut in inFaustory.faustItems)
                        {

                            Console.WriteLine("Current donut amout: " + donutsInPossession);
                            Start();
                        }
                    }
                    break;

            }

        }

        

         
    }
}
