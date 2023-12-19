var test = new Post();
test.SetPost("Hello world");
test.AddComment("Great");
for (int i = 0; i < 10; i++)
{
    test.AddLike();
}
System.Console.WriteLine(test.GETFULLINFO());


class Post{
    public string _text;
    public int _likes;
    public string _comments;

    public void SetPost(string text)
    {
        _text = text;
    }
   public void AddLike(){
        _likes++;
   }
   public void AddComment(string comment)
   {
        _comments = comment;
   }
   public string GETFULLINFO(){
     return $"Post text: {_text}, Post comment: {_comments}, Likes: {_likes}";
   }
}











// var pub1=new Person();
// pub1.text=Console.ReadLine();
// pub1.Like=Convert.ToInt32(Console.ReadLine());



// System.Console.WriteLine(pub1.GETFULLINFO());



// class Person{

//     public string text;
//     public int Like;
    

//    public void addlike(int Like){
//         System.Console.WriteLine(Like++);

//     }
//     public void newtext(string text){
//        System.Console.WriteLine(text); ;  
//     }
    
//     public string GETFULLINFO(){
//        return $"text:{text}\nLike:{Like}\nnewtext:{newtext}\naddlike:{addlike}+";
//     }
// }
