
var sabriddin=new Person();
    System.Console.Write("Enter Your FIRST NAME: ");
     sabriddin.firstname=Console.ReadLine();
     System.Console.Write("Enter Your age:");
     sabriddin.age=Convert.ToInt32(Console.ReadLine());
      System.Console.Write("Enter Your SECOND NAME:");
      sabriddin.lastname=Console.ReadLine();;





System.Console.Write($"{sabriddin.GETFULLINFO()}");

class Person{
    public string firstname;
    public string lastname;
    public int age;
    public string GETFULLINFO(){
       return $"Firstname:{firstname}\nLastname:{lastname}\nAge:{age}";
    }

}
