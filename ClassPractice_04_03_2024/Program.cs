

using ClassPractice_04_03_2024;

//Books book = new();
//book.Name = "asasfaf";

//Console.WriteLine(book.Name);

//int num = 5;


//Class1 class1 = new Class1();

//class1.MyProperty = 100;

//Console.WriteLine(class1.MyProperty);

//string name = null;

////int? num = null;
//Console.WriteLine((Books.null); 

//Console.WriteLine("Book id found");

//Books book1 = new()
//{
//    Id = 1,
//    Name = "Isgendername"
//};

//Books book2 = new()
//{
//    Id = 2,
//    Name  = "Xosrov ve Shirin" 
//};

//Books[] books = { book1, book2 };

//void GetBookById(Books[] books,int? id = null)
//{
//    if (id == null)
//    {
//        Console.WriteLine("Your Id is null");
//        return;
//    }

//    Books result= books.FirstOrDefault(m => m.Id == id);
//}
//Console.WriteLine(books,);

//GetBookById(books);



Level level = new();

void GetLevel(string level)
{
    switch (level)
    {
        case nameof(Level.Low):
            Console.WriteLine("Low");
            break;
        case nameof(Level.Medium):
            Console.WriteLine("Medium");
            break;
        case nameof(Level.Hight):
            Console.WriteLine("High");
            break;
            default:
            break;

    }
}

GetLevel("High");