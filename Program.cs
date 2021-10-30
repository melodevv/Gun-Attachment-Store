using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programmer: T Direko
//Student Number: 220030521
//Date:17 June 2020
//Programming Challenge

namespace ProgrammingChallenge
{   
    class Program
    {
        //Global Variables:
        const int dollarPrice = 15;
        static string userOption, equiptedItems, muzzleEquipped, barrelEquipped, laserEquipped, opticEquipped, stockEquipped, underBarrelEquipped, ammunitionEquipped, rearGripEquipped;
        static double numEquipped = 0, totalPrice = 700, priceRand;
        static int attachmentSelection;

        static void Main()
        {
            //Calling Method:
            HouseKeeping();
        }
        static void HouseKeeping()
        {
            //Welcome Message:
            Console.WriteLine("==============================");
            Console.WriteLine("Welcome to the loadout creator");
            Console.WriteLine(" where you can create your    ");
            Console.WriteLine("own weapon with attachments   ");
            Console.WriteLine("==============================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You will be starting of with a");
            Console.WriteLine("default M4A1 Assault Rifle with");
            Console.WriteLine("no attachments.");
            Console.WriteLine("The max attachments a weapon can have is 5.");
            Console.WriteLine();
            Console.WriteLine("Default M4A1 price = ${0}", totalPrice);
            Console.WriteLine();
            Console.WriteLine("Do you want to continue upgrading the M4A1 with attachments or");
            Console.WriteLine("are you happy with the default M4A1? (Y to upgrade or X to use default)");
            userOption = Console.ReadLine();
            Console.WriteLine();

            //Calling Method:
            Validation();

        }
        static void Validation()
        {
            //Dollars to rands calculation:
            priceRand = totalPrice * dollarPrice;

            //Validating user entry:
            if (userOption == "x" || userOption =="X")
            {
                Console.WriteLine("The default M4A1 will be used");
                Console.WriteLine("Total Price: R{0}", priceRand);
                Console.WriteLine("The program will now end. Press any key");
                Console.ReadKey();
            }
            else if(userOption == "y" || userOption == "Y")
            {
                Console.Clear();
                AttachmentsMenu();   //Calling Method:
            }
        }
        static void AttachmentsMenu()
        {
            //Menu display:
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("These are the available attachment categories to select from");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();

            //Equipped attachments:
            Console.WriteLine("{0} out of 5 equipped", numEquipped);
            Console.WriteLine();

            //User options:
            Console.WriteLine("1. Muzzle");
            Console.WriteLine("2. Barrel");
            Console.WriteLine("3. Laser");
            Console.WriteLine("4. Optic");
            Console.WriteLine("5. Stock");
            Console.WriteLine("6. Under-barrel");
            Console.WriteLine("7. Ammunition");
            Console.WriteLine("8. Rear Grip");

            //Request and save user input:
            Console.WriteLine("Please select any attachment that you want to equip:");
            attachmentSelection = Convert.ToInt16(Console.ReadLine());

            //Calling Method:
            UserOptions();
        }
        static void UserOptions()
        {
            //Validating user entry:
            switch (attachmentSelection)
            {
                case 1:
                    if(muzzleEquipped == "Equipped")
                    {
                        Console.WriteLine("A muzzle is already attached!! Please try again");
                        AttachmentsMenu();
                    }
                    else
                    {
                        Console.Clear();
                        MuzzleMenu();
                    }
                    break;

                case 2:
                    if(barrelEquipped == "Equipped")
                    {
                        Console.WriteLine("A barrel is already attached!! Please try again");
                        AttachmentsMenu();
                    }
                    else
                    {
                        Console.Clear();
                        BarrelMenu();
                    }                    
                    break;

                case 3:
                    if(laserEquipped == "Equipped")
                    {
                        Console.WriteLine("A laser is already attached!! Please try again");
                        AttachmentsMenu();
                    }
                    else
                    {
                        Console.Clear();
                        LaserMenu();
                    }
                    break;

                case 4:
                    if(opticEquipped == "Equipped")
                    {
                        Console.WriteLine("A optic is already attached!! Please try again");
                        AttachmentsMenu();
                    }
                    else
                    {
                        Console.Clear();
                        OpticMenu();
                    }
                    break;

                case 5:
                    if(stockEquipped == "Equipped")
                    {
                        Console.WriteLine("A stock is already attached!! Please try again");
                        AttachmentsMenu();
                    }
                    else
                    {
                        Console.Clear();
                        StockMenu();
                    }                    
                    break;

                case 6:
                    if(underBarrelEquipped == "Equipped")
                    {
                        Console.WriteLine("A under-barrel is already attached!! Please try again");
                        AttachmentsMenu();
                    }
                    else
                    {
                        Console.Clear();
                        UnderBarrelMenu();
                    }                    
                    break;

                case 7:
                    if(ammunitionEquipped == "Equipped")
                    {
                        Console.WriteLine("A ammunition is already attached!! Please try again");
                        AttachmentsMenu();
                    }
                    else
                    {
                        Console.Clear();
                        AmmunitionMenu();
                    }                    
                    break;

                case 8:
                    if(rearGripEquipped == "Equipped")
                    {
                        Console.WriteLine("A rear grip is already attached!! Please try again");
                        AttachmentsMenu();
                    }
                    else
                    {
                        Console.Clear();
                        RearGripMenu();
                    }                    
                    break;
                    
                default:
                    //Validating user entry:
                    if (attachmentSelection < 1 || attachmentSelection > 8)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid selection try again!!");
                        AttachmentsMenu();
                    }
                    else
                    {
                        Console.WriteLine("Critical error has occurred. System shutting down. Press any key.");
                        Console.ReadKey();
                    }
                    break;                    
            }
        }
        //This method is linked to the 8 attachment sub menus:
        static void AddMoreAttachment()
        {            
            Console.WriteLine("Do you want to add more attachments? (Y or N)");
            userOption = Console.ReadLine();
            Console.WriteLine();
            
            //Check the if limit has been reached
            if (numEquipped == 5)
            {
                Console.WriteLine("You already have 5 attachments");
                Console.WriteLine();
                priceRand = totalPrice * dollarPrice;
                Console.WriteLine("M4A1 equipped with: {0}", equiptedItems);
                Console.WriteLine("******************************");
                Console.WriteLine("Total Price: R{0}", priceRand);
                Console.WriteLine("******************************");
                Console.WriteLine("The program will now end. Press any key");
                Console.ReadKey();
            }
            //Validate user input:
            else if (userOption == "y" || userOption == "Y")
            {
                Console.Clear();
                AttachmentsMenu();
            }
            else if (userOption == "n" || userOption == "N")
            {
                priceRand = totalPrice * dollarPrice;

                Console.WriteLine("M4A1 equipped with: {0}", equiptedItems);
                Console.WriteLine("******************************");
                Console.WriteLine("Total Price: R{0}", priceRand);
                Console.WriteLine("******************************");
                Console.WriteLine("The program will now end.");
                Console.ReadKey();
            }
        }
        //Sub menus:
        static void MuzzleMenu()
        {
            //Print menu to user
            Console.WriteLine("Available muzzle's");
            Console.WriteLine("''''''''''''''''''''''");
            Console.WriteLine("1. Flash Guard = $7.50");
            Console.WriteLine("2. Breacher Device = $35");
            Console.WriteLine("3. Tactical Suppressor = $495");
            Console.WriteLine("4. Muzzle Break = $70");
            Console.WriteLine("5. Lightweight Suppressor = $350");
            Console.WriteLine("6. Compensator = $30");
            Console.WriteLine("7. Monolithic = $800");
            attachmentSelection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            //Validate user entry:
            switch (attachmentSelection)
            {
                case 1:
                    totalPrice = totalPrice + 7.50;
                    equiptedItems = "Flash Guard, ";
                    muzzleEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Flash Guard equipped");                    
                    Console.WriteLine("Price is now: ${0}", totalPrice);                    
                    break;
                case 2:
                    totalPrice = totalPrice + 35;
                    equiptedItems = "Breacher Device, ";
                    muzzleEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Breacher Device equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);                    
                    break;
                case 3:
                    totalPrice = totalPrice + 495;
                    equiptedItems = "Tactical Suppressor, ";
                    muzzleEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Tactical Suppressor equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);                    
                    break;
                case 4:
                    totalPrice = totalPrice + 70;
                    equiptedItems = "Muzzle Break, ";
                    muzzleEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Muzzle Break equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);                    
                    break;
                case 5:
                    totalPrice = totalPrice + 350;
                    equiptedItems = "Lightweight Suppressor, ";
                    muzzleEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Lightweight Suppressor equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);                    
                    break;
                case 6:
                    totalPrice = totalPrice + 30;
                    equiptedItems = "Compensator, ";
                    muzzleEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Compensator equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);                    
                    break;
                case 7:
                    totalPrice = totalPrice + 800;
                    equiptedItems = "Monolithic Suppressor, ";
                    muzzleEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Monolithic Suppressor equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);                    
                    break;
                default:
                    //Validate user entry:
                    if(attachmentSelection < 1 || attachmentSelection > 7)
                    {
                        Console.Clear();
                        Console.WriteLine("You have entered an invalid option!! Try again");
                        MuzzleMenu();
                    }
                    else
                    {
                        Console.WriteLine("Critical error has occurred. System shutting down. Press any key.");
                        Console.ReadKey();
                    }
                    break;
            }
            //Calling Method
            AddMoreAttachment();
        }
        static void BarrelMenu()
        {
            //Print menu to screen:
            Console.WriteLine("Available barrel's");
            Console.WriteLine("''''''''''''''''''''''");
            Console.WriteLine("1. FFS 11.5 Commando = $250");
            Console.WriteLine("2. Stock M16 Grenadier = $350");
            Console.WriteLine("3. FFS 14.5 Tac Lite = $200");
            Console.WriteLine("4. Corvus Custom Marksman = $575");
            Console.WriteLine("5. FFS 12.4 Predator = $300");
            attachmentSelection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            //Validate user entry:
            switch (attachmentSelection)
            {
                case 1:
                    totalPrice = totalPrice + 250;
                    equiptedItems = equiptedItems + "FFS 11.5 Commando, ";
                    barrelEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("FFS 11.5 Commando equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);                    
                    break;

                case 2:
                    totalPrice = totalPrice + 350;
                    equiptedItems = equiptedItems + "Stock M16 Grenadier, ";
                    barrelEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Stock M16 Grenadier equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);                    
                    break;

                case 3:
                    totalPrice = totalPrice + 200;
                    equiptedItems = equiptedItems + "FFS 14.5 Tac Lite, ";
                    barrelEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("FFS 14.5 Tac Lite equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);                   
                    break;

                case 4:
                    totalPrice = totalPrice + 575;
                    equiptedItems = equiptedItems + "Corvus Custom Marksman, ";
                    barrelEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Corvus Custom Marksman equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);                    
                    break;

                case 5:
                    totalPrice = totalPrice + 350;
                    equiptedItems = equiptedItems + "FFS 12.4 Predator, ";
                    barrelEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("FFS 12.4 Predator equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);                    
                    break;
                default:
                    if (attachmentSelection < 1 || attachmentSelection > 5)
                    {
                        Console.Clear();
                        Console.WriteLine("You have entered an invalid option!! Try again");
                        BarrelMenu();
                    }
                    else
                    {
                        Console.WriteLine("Critical error has occurred. System shutting down. Press any key.");
                        Console.ReadKey();
                    }
                    break;
            }

            //Calling Method
            AddMoreAttachment();
        }
        static void LaserMenu()
        {
            //Print menu to screen:
            Console.WriteLine("Available laser's");
            Console.WriteLine("''''''''''''''''''''''");
            Console.WriteLine("1. 1mw Laser = $885.50");
            Console.WriteLine("2. 5mw Laser = $1360.90");
            Console.WriteLine("3. Tactical Laser = $2950");
            attachmentSelection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            //Validate user entry:
            switch (attachmentSelection)
            {
                case 1:
                    totalPrice = totalPrice + 885.50;
                    equiptedItems = equiptedItems + "1mw Laser, ";
                    laserEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("1mw Laser equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 2:
                    totalPrice = totalPrice + 1360.90;
                    equiptedItems = equiptedItems + "5mw Laser, ";
                    laserEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("5mw Laser equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 3:
                    totalPrice = totalPrice + 2950;
                    equiptedItems = equiptedItems + "Tactical Laser, ";
                    laserEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Tactical Laser equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                default:
                    if (attachmentSelection < 1 || attachmentSelection > 3)
                    {
                        Console.Clear();
                        Console.WriteLine("You have entered an invalid option!! Try again");
                        LaserMenu();
                    }
                    else
                    {
                        Console.WriteLine("Critical error has occurred. System shutting down. Press any key.");
                        Console.ReadKey();
                    }
                    break;
            }

            //Calling Method
            AddMoreAttachment();
        }
        static void OpticMenu()
        {
            //Print menu to screen:
            Console.WriteLine("Available optic sights");
            Console.WriteLine("''''''''''''''''''''''");
            Console.WriteLine("1. Operator Reflex Sight = $469");
            Console.WriteLine("2. G.I. Mini Reflex = $875");
            Console.WriteLine("3. VLK 3.0x Optic = $450");
            Console.WriteLine("4. Merc Thermal Optic = $6999");
            Console.WriteLine("5. PBX Holo 7 Sight = $1500");
            attachmentSelection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            //Validate user entry: 
            switch (attachmentSelection)
            {
                case 1:
                    totalPrice = totalPrice + 469;
                    equiptedItems = equiptedItems + "Operator Reflex Sight, ";
                    opticEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Operator Reflex Sight equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 2:
                    totalPrice = totalPrice + 875;
                    equiptedItems = equiptedItems + "G.I. Mini Reflex, ";
                    opticEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("G.I. Mini Reflex equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 3:
                    totalPrice = totalPrice + 450;
                    equiptedItems = equiptedItems + "VLK 3.0 Optic, ";
                    opticEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("VLK 3.0 Optic equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 4:
                    totalPrice = totalPrice + 6999;
                    equiptedItems = equiptedItems + "Merc Thermal Optic, ";
                    opticEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Merc Thermal Optic equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 5:
                    totalPrice = totalPrice + 1500;
                    equiptedItems = equiptedItems + "PBX Holo 7 Sight, ";
                    opticEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("PBX Holo 7 Sight equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                default:
                    //Validate user entry: 
                    if (attachmentSelection < 1 || attachmentSelection > 5)
                    {
                        Console.Clear();
                        Console.WriteLine("You have entered an invalid option!! Try again");
                        OpticMenu();
                    }
                    else
                    {
                        Console.WriteLine("Critical error has occurred. System shutting down. Press any key.");
                        Console.ReadKey();
                    }
                    break;
            }

            //Calling Method
            AddMoreAttachment();
        }
        static void StockMenu()
        {
            //Print menu to screen:
            Console.WriteLine("Available stocks");
            Console.WriteLine("''''''''''''''''''''''");
            Console.WriteLine("1. M16 stock = $200");
            Console.WriteLine("2. Singuard arms invander = $175");
            Console.WriteLine("3. No stock = $500");
            Console.WriteLine("4. Forge tac CQS = $955");
            attachmentSelection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            //Validate user entry: 
            switch (attachmentSelection)
            {
                case 1:
                    totalPrice = totalPrice + 200;
                    equiptedItems = equiptedItems + "M16 stock, ";
                    stockEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("M16 stock equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 2:
                    totalPrice = totalPrice + 175;
                    equiptedItems = equiptedItems + "Singuard arms invander, ";
                    stockEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Singuard arms invander equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 3:
                    totalPrice = totalPrice + 500;
                    equiptedItems = equiptedItems + "No stock, ";
                    stockEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("No stock equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 4:
                    totalPrice = totalPrice + 469;
                    equiptedItems = equiptedItems + "Forge tac CQS, ";
                    stockEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Forge tac CQS equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                default:
                    //Validate user entry: 
                    if (attachmentSelection < 1 || attachmentSelection > 4)
                    {
                        Console.Clear();
                        Console.WriteLine("You have entered an invalid option!! Try again");
                        StockMenu();
                    }
                    else
                    {
                        Console.WriteLine("Critical error has occurred. System shutting down. Press any key.");
                        Console.ReadKey();
                    }
                    break;
            }

            //Calling Method
            AddMoreAttachment();
        }
        static void UnderBarrelMenu()
        {
            //Print menu to screen:
            Console.WriteLine("Available under-barrel's");
            Console.WriteLine("'''''''''''''''''''''''''''''");
            Console.WriteLine("1. Commando Foregrip = $75.90");
            Console.WriteLine("2. Bipod = $100");
            Console.WriteLine("3. M203 40mm High-explosive = $5400.99");
            Console.WriteLine("4. M203 40mm Smokescreen = $6700.40");
            attachmentSelection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            //Validate user entry: 
            switch (attachmentSelection)
            {
                case 1:
                    totalPrice = totalPrice + 75.90;
                    equiptedItems = equiptedItems + "Commando Forgegrip, ";
                    underBarrelEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Commando Forgegrip equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 2:
                    totalPrice = totalPrice + 100;
                    equiptedItems = equiptedItems + "Bipod, ";
                    underBarrelEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Bipod equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 3:
                    totalPrice = totalPrice + 5400.99;
                    equiptedItems = equiptedItems + "M203 40mm High-explosive, ";
                    underBarrelEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("M203 40mm High-explosive equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 4:
                    totalPrice = totalPrice + 6700.40;
                    equiptedItems = equiptedItems + "M203 40mm Smoke screen, ";
                    underBarrelEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("M203 40mm Smoke screen equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                default:
                    //Validate user entry: 
                    if (attachmentSelection < 1 || attachmentSelection > 4)
                    {
                        Console.Clear();
                        Console.WriteLine("You have entered an invalid option!! Try again");
                        UnderBarrelMenu();
                    }
                    else
                    {
                        Console.WriteLine("Critical error has occurred. System shutting down. Press any key.");
                        Console.ReadKey();
                    }
                    break;
            }

            //Calling Method
            AddMoreAttachment();
        }
        static void AmmunitionMenu()
        {
            //Print menu to screen:
            Console.WriteLine("Available ammunitions");
            Console.WriteLine("''''''''''''''''''''''");
            Console.WriteLine("1. 50 Rounds Mags = $350.45");
            Console.WriteLine("2. 60 Round Mags = $600");
            Console.WriteLine("3. 9mm Para 32-Round Mags = $120");
            Console.WriteLine("4. .458 SOCOM 10-Round Mags = $850.30");
            attachmentSelection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            //Validate user entry: 
            switch (attachmentSelection)
            {
                case 1:
                    totalPrice = totalPrice + 350.45;
                    equiptedItems = equiptedItems + "50 Rounds Mags, ";
                    ammunitionEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("50 Rounds Mags equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 2:
                    totalPrice = totalPrice + 600;
                    equiptedItems = equiptedItems + "60 Round Mags, ";
                    ammunitionEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("60 Round Mags equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 3:
                    totalPrice = totalPrice + 120;
                    equiptedItems = equiptedItems + "9mm Para 32-Round Mags, ";
                    ammunitionEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("9mm Para 32-Round Mags equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 4:
                    totalPrice = totalPrice + 850.30;
                    equiptedItems = equiptedItems + ".458 SOCOM 10-Round Mags, ";
                    ammunitionEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine(".458 SOCOM 10-Round Mags equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                default:
                    if (attachmentSelection < 1 || attachmentSelection > 4)
                    {
                        Console.Clear();
                        Console.WriteLine("You have entered an invalid option!! Try again");
                        AmmunitionMenu();
                    }
                    else
                    {
                        Console.WriteLine("Critical error has occurred. System shutting down. Press any key.");
                        Console.ReadKey();
                    }
                    break;
            }

            //Calling Method
            AddMoreAttachment();
        }
        static void RearGripMenu()
        {
            //Print menu to screen:
            Console.WriteLine("Available rear grip's");
            Console.WriteLine("''''''''''''''''''''''");
            Console.WriteLine("1. Granulated Grip Tape = $30.50");
            Console.WriteLine("2. Rubberized Grip Tape = $15");
            Console.WriteLine("3. Stippled Grip Tape = $80.90");
            attachmentSelection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            //Validate user entry: 
            switch (attachmentSelection)
            {
                case 1:
                    totalPrice = totalPrice + 30.50;
                    equiptedItems = equiptedItems + "Granulated Grip Tape, ";
                    rearGripEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Granulated Grip Tape equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 2:
                    totalPrice = totalPrice + 15;
                    equiptedItems = equiptedItems + "Rubberized Grip Tape, ";
                    rearGripEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Rubberized Grip Tape equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                case 3:
                    totalPrice = totalPrice + 80.90;
                    equiptedItems = equiptedItems + "Stippled Grip Tape, ";
                    rearGripEquipped = "Equipped";
                    numEquipped = numEquipped + 1;
                    Console.WriteLine("Stippled Grip Tape equipped");
                    Console.WriteLine("Price is now: ${0}", totalPrice);
                    break;
                default:
                    //Validate user entry: 
                    if (attachmentSelection < 1 || attachmentSelection > 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid selection try again!!");
                        AttachmentsMenu();
                    }
                    else
                    {
                        Console.WriteLine("Critical error has occurred. System shutting down. Press any key.");
                        Console.ReadKey();
                    }
                    break;
            }

            //Calling Method
            AddMoreAttachment();
        }
    }
}