int n = int.Parse(Console.ReadLine()); //броят на продуктите

List<string> products = new List<string>(); //продукти

for (int i = 1; i <= n; i++)
{
    string product = Console.ReadLine();
    products.Add(product);
}

//пълен списък с продуктите
// {"Potatoes", "Tomatoes", "Onions", "Apples"}
//Трябва да се сортират по азбучен ред (ascendind order -> A - Z)

products.Sort();

int number = 1; //поредния номер на продукта
foreach (string product in products)
{
    Console.WriteLine(number + "." + product);
    number++;
}