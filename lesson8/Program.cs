// See https://aka.ms/new-console-template for more information
using lesson8;

try
{
    Book b = new Book("hi", 1234, 0, "chaya");
}
catch(NumPagesExeptions ex)
{
    Console.WriteLine( ex.Message);
}

    /*try
    {
        Book b = new Book("hi", 1234, 100, "chaya");
    }*/
    catch (CodeExeption c)
    {
        Console.WriteLine(c.Message);
    }



