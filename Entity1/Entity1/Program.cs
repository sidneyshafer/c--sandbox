using Entity1.Data;
using Entity1.Models;

using EntityContext context = new EntityContext();

/*
Product veggieSpecial = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 9.99M
};
context.Products.Add(veggieSpecial);

Product deluxeMeat = new Product()
{
    Name = "Deluxe Meat Pizza",
    Price = 12.99M
};
context.Add(deluxeMeat);

context.SaveChanges();
*/

var veggieSpecial = context.Products.Where(p => p.Name == "Veggie Special Pizza")
    .FirstOrDefault(); //returns veggie pizza or default which is null

//change price of pizza
if (veggieSpecial is Product)
{
    veggieSpecial.Price = 10.99M;
}
context.SaveChanges();

//REMOVE ENTITY
/*
if (veggieSpecial is Product)
{
    context.Remove(veggieSpecial);
}
*/


//Fluent API Syntax
var products = context.Products.Where(p => p.Price > 10.00M).OrderBy(p => p.Name);

// LINQ Syntax
/*
var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;
*/

foreach (Product p in products)
{
    Console.WriteLine($"Id:     {p.Id}");
    Console.WriteLine($"Name:   {p.Name}");
    Console.WriteLine($"Price:  {p.Price}");
    Console.WriteLine(new string('-', 20));
}