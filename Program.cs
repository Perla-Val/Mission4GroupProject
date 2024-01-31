internal class Program
{
    private static void Main(string[] args) //nothin should be calling the main class
                                            //(that is why it is private, you can also have public and protected
                                            //STATIC means it can stick you can have it unstick
                                            //VOID explains what is going to be returned in this case nothing but it could say string
                                            //(Inside the Parenthesis it has what is being passed in this case you have a
                                            //string array names args) 
    {
        System.Console.WriteLine("Hello, World!");
    }
}