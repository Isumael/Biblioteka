// tiek izmantotas atsevišķas klases pēc SOLID, S principa, ka katra klasei ir viens iemesls
public class Book
{
    public string Title;
    //Definē lauku kas tiks izmantots, lai saglabātu grāmatas titulu
    public string Author;
    //Definē lauku kas tiks izmantots, lai saglabātu grāmatas autoru
    public bool IsBorrowed { get; private set; }
    // Ir privāts, lai nevarētu mainīt ārpus klases.
    public Book(string title, string author)
    {

        Title = title;
        //tiek izmantots kods lai saglabātu grāmatas titulu
        Author = author;
        //tiek izmantots kods lai saglabātu grāmatas autoru
    }
    public bool Borrow()
    {
        if (IsBorrowed)
        {
            // Ja grāmata jau ir aizņemta, tad atgriež false
            return false;
        }
        else
        {
            // Ja grāmata nav aizņemta, tad atzīmē to kā aizņemtu un atgriež true
            IsBorrowed = true;
            return true;
        }
    }


    public bool Return()
    {
        if (IsBorrowed)
        {
            // Ja grāmata ir aizņemta, tad atzīmē to kā brīvu un atgriež true
            IsBorrowed = false;
            return true;
        }
        else
        {
            // Ja grāmata nav aizņemta, tad atgriež false
            return false;
        }
    }
}


public class BookPrinter
{
    public void Print(Book book)
    {
        // Izvada grāmatas informāciju konsolē, izmantojot grāmatas nosaukumu, autoru un aizņemšanas statusu
        Console.WriteLine($"{book.Title}({book.Author}) - {(book.IsBorrowed ? "izsniegta" : "brīva")}");
    }
}