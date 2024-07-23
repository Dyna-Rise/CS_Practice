namespace Animal_0723
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog(5, "茶色");
            d1.SetSpecial("GetItemメソッドが使えるぞ！");
            d1.ShowInfo();

            Console.WriteLine(); //改行

            Cat c1 = new Cat(10, "ブチ");
            c1.SetSpecial("Jumpメソッドが使えるぞ！");
            c1.ShowInfo();

            Console.WriteLine(); //改行

            Sparrow s1 = new Sparrow(1, "茶色");
            s1.SetSpecial("Songメソッドが使えるぞ！");
            s1.ShowInfo();

            Console.WriteLine(); //改行

        }
    }
}