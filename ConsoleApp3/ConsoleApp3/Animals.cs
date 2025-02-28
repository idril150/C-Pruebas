public class Animals()
{
    List<object[]> ourAnimals = new List<object[]>();
    int id = 0;

    public void addAnimal()
    {
        int id = 0;
        int age = 0;
        string species = "";
        string description = "";
        string personality = "";
        string alias = "";
        do
        {
            if (id == 0)
            {
                Console.WriteLine("Introduce el ID");
                try
                {
                    id = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\n!!!EL VALOR DEBE SER UN NUMERO ENTERO!!!\n\n");
                }
            }
        } while (id == 0);
        do
        {

            if (age == 0)
            {
                Console.WriteLine("\n\n\nIntroduce la edad");
                try
                {
                    age = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\n!!!EL VALOR DEBE SER UN NUMERO ENTERO!!!\n\n");
                }
            }
        }
        while (age == 0);

        do
        {
            if (species == "")
            {
                Console.WriteLine("\n\n\nINTRODUCE LA ESPECIE");
                species = Console.ReadLine();
            }
        } while (species == "");
        do
        {
            if (description == "")
            {
                Console.WriteLine("\n\n\nINTRODUCE UNA DESCRIPCION");
                description = Console.ReadLine();
            }
        } while (description == "");
        do
        {
            if (personality == "")
            {
                Console.WriteLine("\n\n\nINTRODUCE UNA PERSONALIDAD");
                personality = Console.ReadLine();
            }
        } while (personality == "");
        do
        {
            if (alias == "")
            {
                Console.WriteLine("\n\n\nINTRODUCE UNA ALIAS");
                alias = Console.ReadLine();
            }
        } while (alias == "");

        ourAnimals.Add(new object[] { id, species, alias, age, description, personality });


        species = "";
        age = 0;
        description = "";
        personality = "";
        alias = "";
        species = "";
    }

    public void getAnimals()
    {
        foreach (object[] animal in ourAnimals)
        {
            Console.WriteLine($"ID={animal[0]}\t\tESPECIE={animal[1]}");
            Console.WriteLine($"ALIAS={animal[2]}\t\tEDAD={animal[3]}");
            Console.WriteLine($"DESCRIPCION\n{animal[4]}");
            Console.WriteLine($"PERSONALIDAD\n{animal[5]}");
        }
    }

    public void editAnial()
    {
        int id = int.Parse(Console.ReadLine());
        int find = 0;
        do
        {
            for (int i = 0; i < ourAnimals.Count(); i++)
            {
                if (id == Convert.ToInt32(ourAnimals[i][0]))
                {
                    int option = 0;
                    find++;
                    Console.WriteLine($"ID={ourAnimals[i][0]}\t\tESPECIE={ourAnimals[i][1]}");
                    Console.WriteLine($"ALIAS={ourAnimals[i][2]}\t\tEDAD={ourAnimals[i][3]}");
                    Console.WriteLine($"DESCRIPCION\n{ourAnimals[i][4]}");
                    Console.WriteLine($"PERSONALIDAD\n{ourAnimals[i][5]}");
                    Console.WriteLine("\n\n\n¿SELECCIONE LA OPCION QUE DESEA EDITAR?");
                    Console.WriteLine("1.-ESPECIE");
                    Console.WriteLine("2.-EDAD");
                    Console.WriteLine("3.-DESCRIPCION");
                    Console.WriteLine("4.-PERSONALIDAD");
                    do
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    while (option == 0);

                    switch (option)
                    {                 
                        case 1:
                            string especie = "";
                            do
                            {
                                Console.WriteLine("\n\nINGRESA ACTUALIZACION DE ESPECIE");
                                try
                                {
                                    especie = Console.ReadLine();
                                    if (especie == "")
                                    {
                                        throw new Exception("\n\n\n!!!LA ESPECIE NO PUEDE ESTAR VACIA!!!\n");
                                    }
                                }
                                catch (Exception e) { e.ToString(); }
                            }
                            while (especie =="");
                            ourAnimals[i][1] = especie;
                            especie = "";
                            break;
                        case 2:
                            int edad = 0;
                            do
                            {
                                Console.WriteLine("\n\nINGRESA ACTUALIZACION DE ESPECIE");
                                try
                                {
                                    edad = int.Parse(Console.ReadLine());
                                }
                                catch (Exception e) { Console.WriteLine("\n\n\n!!!DEBE INGRESAR UN NUMERO ENTERO!!!\n"); }
                            }
                            while (edad == 0);
                            ourAnimals[i][3] = edad;
                            break;
                        case 3:
                            string descripcion = "";
                            do
                            {
                                Console.WriteLine("\n\nINGRESA ACTUALIZACION DE ESPECIE");
                                try
                                {
                                    descripcion = Console.ReadLine();
                                    if (descripcion == "")
                                    {
                                        throw new Exception("\n\n\n!!!LA ESPECIE NO PUEDE ESTAR VACIA!!!\n");
                                    }
                                }
                                catch (Exception e) { e.ToString(); }
                            }
                            while (descripcion == "");
                            ourAnimals[i][4] = descripcion;
                            descripcion = "";
                            break;
                        case 4:
                            string personalidad = "";
                            do
                            {
                                Console.WriteLine("\n\nINGRESA ACTUALIZACION DE ESPECIE");
                                try
                                {
                                    personalidad = Console.ReadLine();
                                    if (personalidad == "")
                                    {
                                        throw new Exception("\n\n\n!!!LA ESPECIE NO PUEDE ESTAR VACIA!!!\n");
                                    }
                                }
                                catch (Exception e) { e.ToString(); }
                            }
                            while (personalidad == "");
                            ourAnimals[i][5] = personalidad;
                            personalidad = "";
                            break;
                    }
                }
            }
            if (find == 1) { break; }
            else {
                Console.WriteLine("no encontrado deseas continuar? Y/N");
                string cont = Console.ReadLine();
                find = (cont=="Y")?0:1;
            }
        }
        while (find == 0);
    }

}