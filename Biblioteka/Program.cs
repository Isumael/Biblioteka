var book = new Book("Zelta zirgs", "Rainis");

var printer = new BookPrinter();


Console.WriteLine(book.Borrow()); // True

Console.WriteLine(book.Borrow()); // False

printer.Print(book);

Console.WriteLine(book.Return()); // True

printer.Print(book);