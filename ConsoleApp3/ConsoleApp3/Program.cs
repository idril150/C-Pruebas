Animals animales = new Animals();
do
{
    Console.WriteLine("introduce tu opcion");
    int opcion = int.Parse(Console.ReadLine());
    switch (opcion) { 
        case 1:animales.addAnimal();break;
        case 2:animales.getAnimals();break;
        case 3:animales.editAnial();break;
            
    }
}
while (true);