using System.Diagnostics;

public class Metodos
{

    public void Mensaje(string[] nombres)
    {
        foreach (string nombre in nombres) {
            Console.WriteLine($"hola {nombre} como estas?");
        }
    }
    public void Msj(string name = "noname") 
    {
        Console.WriteLine($"Welcome {name}");
    }

    public void tiradaDados() 
    {
        Random dice = new Random();

        int[] roll = new int[4];

        roll[0] = dice.Next(1, 7);
        roll[1] = dice.Next(1, 7);
        roll[2] = dice.Next(1, 7);
        roll[3] = dice.Next(1, 7);

        Console.Write("La tirada de los dados fue:");
        foreach (int i in roll)
        {
            Console.Write($", {i}");
        }
    }

    public void tiradaMoneda() 
    {
        Random coin = new Random();
        string throwCoin = (coin.Next(0,2))==0 ? "cara":"cruz";
        Console.WriteLine($"la tirada salio {throwCoin}");
    }

    public void securityLevel(String permission, int level) 
    {
        switch (permission.ToLower()) {
            case "admin":
                if (level <= 55)
                {
                    Console.WriteLine("Welcome, Admin User");
                }
                else 
                {
                    Console.WriteLine("Welcome, Super Admin User");
                }
                break;

            case "manager":
                if (level > 20) 
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
                break;

            default: 
                Console.WriteLine("You do not have sufficient privileges"); 
                break;
        }
    }

    public void clothStore(String sku) 
    { 
        string[] product = sku.Split('-');
        string type = "";
        string color = "";
        string size = "";
        switch (product[0])
        {
            case "01":
                type = "Sweat shirt";
                break;
            case "02":
                type = "Tshirt";
                break;
            case "03":
                type = "Sweat pants";
                break;
            default:
                type = "Other";
                break;

        }
        switch (product[1].ToUpper()) 
        {
            case "BL":
                color = "Black";
                break;
            case "MN":
                color = "Maroon";
                break;
            default:
                color = "White";
                break;
        }
        switch (product[2].ToUpper()) 
        {
            case "S":
                size = "Small";
                break;
            case "M":
                size = "Medium";
                break;
            case "L":
                size = "Large";
                break;
            default:
                size = "One Size Fits All";
                break;
        }

        Console.WriteLine($"Product: {size} {color} {type}");

    }
    public void figth() 
    {
        Random damage = new Random();
        int hero = 10;
        int monster = 10;
        int punch = 0;
        do {
            punch=damage.Next(1,11);
            monster -= punch;
            Console.WriteLine($"el mounstro recibe {punch} {(punch > 1 ? "puntos" : "punto")} de daño le {(monster!=1 && monster!=-1 ? $"quedan {monster} puntos":$"queda {monster} punto")} de vida");

            if (monster <= 0) break;

            punch=damage.Next(1,11);
            hero -= punch;
            Console.WriteLine($"el heroe recibe {punch} {(punch > 1 ? "puntos" : "punto")} de daño le {(hero != 1 && hero != -1 ? $"quedan {hero} puntos" : $"queda {hero} punto")} puntos de vida");
        }while(hero>0 && monster>0);

        Console.WriteLine(hero>monster?"Hero WINNS":"Monster WINNS");

    }
}