public class Game
{
    private Character player;
    private List<Monster> monsters;
    private List<Item> items;
    private int roomNumber;
    private Random rand;

    public Game(string playerName, int playerHealth, int playerAttack)
    {
        player = new Character(playerName, playerHealth, playerAttack);
        monsters = new List<Monster>();
        items = new List<Item>();
        roomNumber = 0;
        rand = new Random();
    }

    public void GenerateRoom()
    {
        roomNumber++;
        monsters.Clear();
        items.Clear();

        Console.WriteLine($"\n-------------------------Wchodzisz do pokoju {roomNumber}-----------------------------------");


        int numberOfMonsters = rand.Next(1, 3); 
        for (int i = 0; i < numberOfMonsters; i++)
        {
            string monsterName = $"Potwór {i + 1}";
            int monsterHealth = rand.Next(15 * roomNumber, 30 * roomNumber);
            int monsterAttack = rand.Next(7 * roomNumber, 15 * roomNumber);
            Monster monster = new Monster(monsterName, monsterHealth, monsterAttack);
            monsters.Add(monster);
        }

        
        int numberOfItems = rand.Next(1, 4); 
        for (int i = 0; i < numberOfItems; i++)
        {
            Item newItem;
            int itemType = rand.Next(1, 116); 

            if (itemType == 1)
            {
                newItem = new Item("Mikstura Zdrowia", rand.Next(10, 21), 0); // staty po lewo dodaja hp a po prawo atak
            }
            else if (itemType == 2)
            {
                newItem = new Item("Miecz", 0, rand.Next(5, 11));
            }
            else if (itemType == 3)
            {
                newItem = new Item("Magiczny Zwój", rand.Next(5, 11), rand.Next(5, 11));
            }
            else if (itemType == 4)
            {
                newItem = new Item("Zbroja", rand.Next(10, 21), 0);
            }
            else if (itemType == 5)
            {
                newItem = new Item("Amulet", 0, rand.Next(10, 21));
            }
            else if (itemType == 6)
            {
                newItem = new Item("Eliksir", rand.Next(30, 510), 0);
            }
            else if (itemType == 7)
            {
                newItem = new Item("Sztylet", 0, rand.Next(8, 16));
            }
            else if (itemType == 8)
            {
                newItem = new Item("Magiczny Pergamin", rand.Next(10, 21), rand.Next(10, 21));
            }
            else if (itemType == 9)
            {
                newItem = new Item("Pancerz", rand.Next(15, 310), 0);
            }
            else if (itemType == 10)
            {
                newItem = new Item("Obrączka Siły", 0, rand.Next(15, 31));
            }
            else if (itemType == 11)
            {
                newItem = new Item("Laska Maga", 0, rand.Next(15, 31));
            }
            else if (itemType == 12)
            {
                newItem = new Item("Hełm Rycerski", rand.Next(15, 31), 0);
            }
            else if (itemType == 13)
            {
                newItem = new Item("Tarcza", rand.Next(15, 310), 0);
            }
            else if (itemType == 14)
            {
                newItem = new Item("Księga Zaklęć", 0, rand.Next(15, 31));
            }
            else if (itemType == 15)
            {
                newItem = new Item("Naszyjnik przeznaczenia", rand.Next(5, 110), 0);
            }
            else if (itemType == 16)
            {
                newItem = new Item("Brylantowa Broń", 0, rand.Next(15, 31));
            }
            else if (itemType == 17)
            {
                newItem = new Item("Smocza Łuska", rand.Next(15, 31), 0);
            }
            else if (itemType == 18)
            {
                newItem = new Item("Kamień Mądrości", 0, rand.Next(15, 31));
            }
            else if (itemType == 19)
            {
                newItem = new Item("Miecz boskiej potęgi", 0, rand.Next(15, 31));
            }
            else if (itemType == 19)
            {
                newItem = new Item("Różdżka Uzdrowienia", rand.Next(20, 31), 0);
            }
            else if (itemType == 20)
            {
                newItem = new Item("Zbroja nieśmiertelnego herosa", 0, rand.Next(30, 41));
            }
            else if (itemType == 21)
            {
                newItem = new Item("Amulet nieskończonego chaosu", rand.Next(15, 26), 0);
            }
            else if (itemType == 22)
            {
                newItem = new Item("Kapelusz Czarodzieja", 0, rand.Next(25, 36));
            }
            else if (itemType == 23)
            {
                newItem = new Item("Klinga Niewidzialności", rand.Next(25, 36), 0);
            }
            else if (itemType == 24)
            {
                newItem = new Item("Amulet Życia", rand.Next(30, 41), 0);
            }
            else if (itemType == 25)
            {
                newItem = new Item("Kostur Ognistego Płomienia", 0, rand.Next(30, 41));
            }
            else if (itemType == 26)
            {
                newItem = new Item("Złota Zbroja", rand.Next(25, 36), 0);
            }
            else if (itemType == 27)
            {
                newItem = new Item("Pierścień Mocy", 0, rand.Next(30, 41));
            }
            else if (itemType == 28)
            {
                newItem = new Item("Naszyjnik przeznaczenia", rand.Next(15, 260), 0);
            }
            else if (itemType == 29)
            {
                newItem = new Item("Zbroja boskiego stróża", 0, rand.Next(35, 46));
            }
            else if (itemType == 30)
            {
                newItem = new Item("Amulet Mądrości", 0, rand.Next(1, 5));
            }
            else if (itemType == 31)
            {
                newItem = new Item("Tarcza Blokująca", rand.Next(1, 5), 0);
            }
            else if (itemType == 32)
            {
                newItem = new Item("Hełm Ochronny", 0, rand.Next(1, 5));
            }
            else if (itemType == 33)
            {
                newItem = new Item("Kostium Infiltratora", rand.Next(1, 5), rand.Next(1, 5));
            }
            else if (itemType == 34)
            {
                newItem = new Item("Oprawione oko smoka", rand.Next(3, 8), 0);
            }
            else if (itemType == 35)
            {
                newItem = new Item("Czarne ostrze Gauldura", 0, rand.Next(3, 8));
            }
            else if (itemType == 36)
            {
                newItem = new Item("Kamień Zdrowia", rand.Next(5, 100), 0);
            }
            else if (itemType == 37)
            {
                newItem = new Item("Rękawice Bojowe", 0, rand.Next(2, 70));
            }
            else if (itemType == 38)
            {
                newItem = new Item("Amulet Mocy", rand.Next(2, 7), 0);
            }
            else if (itemType == 39)
            {
                newItem = new Item("Mikstura Odporności", 0, rand.Next(5, 10));
            }
            else if (itemType == 40)
            {
                newItem = new Item("Laska Czarodzieja", rand.Next(2, 70), rand.Next(2, 7));
            }
            else if (itemType == 41)
            {
                newItem = new Item("Tarcza Energii", 0, rand.Next(3, 80));
            }
            else if (itemType == 42)
            {
                newItem = new Item("Napój Regeneracji", rand.Next(4, 900), 0);
            }
            else if (itemType == 43)
            {
                newItem = new Item("Kapelusz Skradacza", 0, rand.Next(2, 70));
            }
            else if (itemType == 44)
            {
                newItem = new Item("Różdżka Ognia", rand.Next(2, 70), 0);
            }
            else if (itemType == 45)
            {
                newItem = new Item("Szklany miecz", 0, rand.Next(2, 70));
            }
            else if (itemType == 46)
            {
                newItem = new Item("Mikstura Przeznaczenia", rand.Next(2, 7), rand.Next(2, 70));
            }
            else if (itemType == 47)
            {
                newItem = new Item("Naszyjnik Życia", rand.Next(2, 70), 0);
            }
            else if (itemType == 48)
            {
                newItem = new Item("Kij bojowy", 0, rand.Next(2, 70));
            }
            else if (itemType == 49)
            {
                newItem = new Item("Srebrna Korona", rand.Next(2, 70), rand.Next(2, 70));
            }
            else if (itemType == 50)
            {
                newItem = new Item("Księga Zaklęć", rand.Next(2, 7), rand.Next(2, 70));
            }
            else if (itemType == 51)
            {
                newItem = new Item("Złoty Medalion", rand.Next(2, 70), rand.Next(2, 70));
            }
            else if (itemType == 52)
            {
                newItem = new Item("Srebrny Medalion", rand.Next(2, 70), rand.Next(2, 70));
            }
            else if (itemType == 53)
            {
                newItem = new Item("Diamentowy Naszyjnik", rand.Next(2, 70), rand.Next(2, 70));
            }
            else if (itemType == 54)
            {
                newItem = new Item("Nieskończona Mikstura", rand.Next(2, 70), rand.Next(2, 70));
            }
            else if (itemType == 55)
            {
                newItem = new Item("Błyszczący Kamień", rand.Next(2, 70), rand.Next(2, 70));
            }
            else if (itemType == 56)
            {
                newItem = new Item("Długi łuk", rand.Next(2, 70), rand.Next(2, 70));
            }
            else if (itemType == 57)
            {
                newItem = new Item("Kamień synergii", rand.Next(2, 7), rand.Next(2, 70));
            }
            else if (itemType == 58)
            {
                newItem = new Item("Srebrna Tarcza", rand.Next(2, 7), rand.Next(2, 70));
            }
            else if (itemType == 59)
            {
                newItem = new Item("Mikstura Przenikania", rand.Next(2, 7), rand.Next(2, 7));
            }
            else if (itemType == 60)
            {
                newItem = new Item("Kapelusz Magii Ciemności", rand.Next(2, 7), rand.Next(2, 7));
            }
            else if (itemType == 62)
            {
                newItem = new Item("Miecz Władcy Ciemności", rand.Next(15, 21), rand.Next(10, 16));
            }
            else if (itemType == 63)
            {
                newItem = new Item("Zbroja Niezniszczalności", rand.Next(20, 26), rand.Next(5, 11));
            }
            else if (itemType == 64)
            {
                newItem = new Item("Wielki miecz ciemnego księżyca", rand.Next(100, 200), rand.Next(150, 210));
            }
            else if (itemType == 65)
            {
                newItem = new Item("Kusza Ostateczności", rand.Next(118, 124), rand.Next(112, 118));
            }
            else if (itemType == 66)
            {
                newItem = new Item("Tarcza Boga Wojny", rand.Next(25, 31), rand.Next(80, 111));
            }
            else if (itemType == 67)
            {
                newItem = new Item("Miecz nocy i ognia", rand.Next(300, 360), rand.Next(300, 360));
            }
            else if (itemType == 68)
            {
                newItem = new Item("### ŚWIĘTY MIECZ ŚWIĘTEGO JERZEGO ### (UNIKATOWY MIECZ Z ASSASINS CREED WALHALLA, pozdro whait102 za kozacki pomysl", rand.Next(3000, 3600), rand.Next(3000, 3600));
            }
            else if (itemType == 69)
            {
                newItem = new Item("Zbroja Odporności", rand.Next(20, 260), rand.Next(5, 11));
            }
            else if (itemType == 70)
            {
                newItem = new Item("Klucz do Bramy Nieśmiertelności", rand.Next(10, 16), rand.Next(15, 21));
            }
            else if (itemType == 71)
            {
                newItem = new Item("Łuk Szybkosci", rand.Next(18, 24), rand.Next(12, 18));
            }
            else if (itemType == 72)
            {
                newItem = new Item("Tarcza Ocalenia", rand.Next(25, 31), rand.Next(5, 11));
            }
            else if (itemType == 73)
            {
                newItem = new Item("Mikstura Nadziei", rand.Next(30, 36), rand.Next(30, 36));
            }
            else if (itemType == 74)
            {
                newItem = new Item("Amulet Mocy Absolutnej", rand.Next(25, 31), rand.Next(25, 31));
            }
            else if (itemType == 75)
            {
                newItem = new Item("Hełm Niezwyciężony", rand.Next(30, 360), rand.Next(10, 16));
            }
            else if (itemType == 76)
            {
                newItem = new Item("Sztylet Celnosci", rand.Next(12, 18), rand.Next(18, 24));
            }
            else if (itemType == 77)
            {
                newItem = new Item("Różdżka Chaosu", rand.Next(20, 26), rand.Next(20, 26));
            }
            else if (itemType == 78)
            {
                newItem = new Item("Złoty Amulet", rand.Next(12, 18), 0);
            }
            else if (itemType == 79)
            {
                newItem = new Item("Miecz Królów", 0, rand.Next(15, 21));
            }
            else if (itemType == 80)
            {
                newItem = new Item("Nieskończony Hełm", rand.Next(18, 240), rand.Next(12, 18));
            }
            else if (itemType == 81)
            {
                newItem = new Item("Klucz do Sekretnej Skrytki", rand.Next(10, 16), rand.Next(20, 26));
            }
            else if (itemType == 82)
            {
                newItem = new Item("Mikstura Wielkiej Mocy", rand.Next(25, 31), rand.Next(25, 31));
            }
            else if (itemType == 83)
            {
                newItem = new Item("Skrzydła Anioła", rand.Next(30, 36), 0);
            }
            else if (itemType == 84)
            {
                newItem = new Item("Pierścień Nieśmiertelności", rand.Next(40, 46), rand.Next(40, 46));
            }
            else if (itemType == 85)
            {
                newItem = new Item("Laska Czarów", rand.Next(35, 41), rand.Next(25, 31));
            }
            else if (itemType == 86)
            {
                newItem = new Item("Zbroja Potężnego Wojownika", rand.Next(35, 41), rand.Next(30, 36));
            }
            else if (itemType == 87)
            {
                newItem = new Item("Kamień Mądrości", 0, rand.Next(40, 46));
            }
            else if (itemType == 88)
            {
                newItem = new Item("Elfi Łuk", rand.Next(15, 21), rand.Next(8, 14));
            }
            else if (itemType == 89)
            {
                newItem = new Item("### Jadowy Cierń ### (LEGENDARNY JEDNORĘCZNY MIECZ)", rand.Next(877, 900), rand.Next(1100, 2367));
            }
            else if (itemType == 90)
            {
                newItem = new Item("Zbroja Wampira", rand.Next(20, 26), rand.Next(10, 16));
            }
            else if (itemType == 91)
            {
                newItem = new Item("Kamień Witalności", rand.Next(30, 36), 0);
            }
            else if (itemType == 92)
            {
                newItem = new Item("Miecz Zagłady", rand.Next(25, 31), rand.Next(15, 21));
            }
            else if (itemType == 93)
            {
                newItem = new Item("Rękawice Zręczności", rand.Next(18, 24), rand.Next(18, 24));
            }
            else if (itemType == 94)
            {
                newItem = new Item("Złoty Medalion", rand.Next(22, 28), 0);
            }
            else if (itemType == 95)
            {
                newItem = new Item("Mikstura Przeznaczenia", rand.Next(35, 41), rand.Next(35, 41));
            }
            else if (itemType == 96)
            {
                newItem = new Item("Korona Króla", rand.Next(40, 46), rand.Next(30, 36));
            }
            else if (itemType == 97)
            {
                newItem = new Item("Szept Lasu", rand.Next(15, 21), rand.Next(25, 31));
            }
            else if (itemType == 98)
            {
                newItem = new Item("Diamentowy Miecz", rand.Next(30, 36), rand.Next(20, 26));
            }
            else if (itemType == 99)
            {
                newItem = new Item("Róg Obfitości", rand.Next(35, 41), 0);
            }
            else if (itemType == 100)
            {
                newItem = new Item("### Zły uczynek ### (LEGENDARNY DWURĘCZNY MIECZ", rand.Next(400, 460), rand.Next(410, 416));
            }
            else if (itemType == 101)
            {
                newItem = new Item("Kryształowa Korona", rand.Next(45, 51), rand.Next(35, 41));
            }
            else if (itemType == 102)
            {
                newItem = new Item("Sierp Mroku", rand.Next(35, 41), rand.Next(30, 36));
            }
            else if (itemType == 103)
            {
                newItem = new Item(" ### INKLINATOR ŚMIERCI ### (LEGENDARNY JEDNORĘCZNY MIECZ)", rand.Next(1300, 2370), rand.Next(540, 646));
            }
            else if (itemType == 104)
            {
                newItem = new Item("Mikstura Boskiej Mocy", rand.Next(50, 56), rand.Next(50, 56));
            }
            else if (itemType == 105)
            {
                newItem = new Item("Szmaragdowy Amulet", rand.Next(40, 46), rand.Next(20, 26));
            }
            else if (itemType == 106)
            {
                newItem = new Item("Kusza Elfów", rand.Next(28, 34), rand.Next(28, 34));
            }
            else if (itemType == 107)
            {
                newItem = new Item("Peleryna Niewidzialności", rand.Next(25, 31), 0);
            }
            else if (itemType == 108)
            {
                newItem = new Item(" ### GŁOWOŁOMCA ### (LEGENDARNY TOPÓR)", 0, rand.Next(1577, 2146));
            }
            else if (itemType == 109)
            {
                newItem = new Item("Pergamin Mądrości", 0, rand.Next(50, 56));
            }
            else if (itemType == 110)
            {
                newItem = new Item("Nieskończony Łuk", rand.Next(40, 46), rand.Next(30, 36));
            }
            else if (itemType == 111)
            {
                newItem = new Item("Runiczny Medalion", rand.Next(35, 41), rand.Next(35, 41));
            }
            else if (itemType == 112)
            {
                newItem = new Item("Złoty Hełm", rand.Next(45, 51), rand.Next(15, 21));
            }
            else if (itemType == 113)
            {
                newItem = new Item("Miecz Księżyca", 0, rand.Next(45, 51));
            }
            else if (itemType == 114)
            {
                newItem = new Item("Płaszcz Niewidzialności", rand.Next(35, 41), 0);
            }
            else if (itemType == 115)
            {
                newItem = new Item("Korona Czarodzieja", rand.Next(48, 54), rand.Next(38, 44));
            }

            else
            {
                newItem = new Item("### RIVERS OF BLOOD ### (LEGENDARNY MIECZ Z ELDEN RING, pozdrawiam zioma whait102 i jego pomysl)", rand.Next(2000, 4000), rand.Next(3500, 4000));
            }


            items.Add(newItem);
        }
    }

    public void Start()
    {
        Console.WriteLine("Witaj w Nieskończonym Lochu!");

        while (player.IsAlive())
        {
            Console.WriteLine("\nAktualne statystyki postaci:");
            player.PrintStats();

            Console.WriteLine("\nPotwory w pokoju:");
            foreach (var monster in monsters)
            {
                monster.PrintInfo();
            }

            Console.WriteLine("\nPrzedmioty w pokoju:");
            foreach (var item in items)
            {
                item.PrintInfo();
            }

            Console.WriteLine("Co chcesz zrobić? (Wpisz 'atakuj' lub 'użyj' lub 'wyjdź'");
            string input = Console.ReadLine();

            if (input.ToLower() == "atakuj")
            {
                foreach (var monster in monsters.ToList())
                {
                    player.TakeDamage(monster.Attack);
                    monster.TakeDamage(player.Attack);

                    if (!monster.IsAlive())
                    {
                        monsters.Remove(monster);
                        Console.WriteLine($"Pokonales potwora {monster.Name}!");
                    }
                }
            }
            else if (input.ToLower() == "użyj")
            {
                Console.WriteLine("Wybierz przedmiot do użycia:");
                int itemNumber = 1;
                foreach (var item in items)
                {
                    Console.WriteLine($"{itemNumber}. {item.Name}");
                    itemNumber++;
                }

                int selectedItemIndex;
                if (int.TryParse(Console.ReadLine(), out selectedItemIndex) && selectedItemIndex >= 1 && selectedItemIndex <= items.Count)
                {
                    Item selectedItem = items[selectedItemIndex - 1];
                    player.UseItem(selectedItem);
                    Console.WriteLine($"Użyłeś przedmiotu {selectedItem.Name}.Twoje statystyki zostały zaktualizowane");
                    items.Remove(selectedItem);
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór");
                }
            }
            else if (input.ToLower() == "wyjdź")
            {
                Console.WriteLine("Opuściłeś grę");
                break;
            }
    
                if (monsters.Count == 0)
            {
                Console.WriteLine("Przeszedłes pokój");
                Random rand = new Random();
                if (rand.Next(0, 2) == 0)
                {
                    Item newItem = new Item("Mikstura zdrowia", rand.Next(10, 21), 0);
                    items.Add(newItem);
                }
                else
                {
                    Item newItem = new Item("Miecz", 0, rand.Next(5, 11));
                    items.Add(newItem);
                }

                GenerateRoom();
            }
        }

        Console.WriteLine("Koniec gry! Twoja postać zginęła");
    }
}