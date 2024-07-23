namespace Animal_0723
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog(5, "茶色");
            Animal.count++; //カウントを1増やす
            d1.SetSpecial("GetItemメソッドが使えるぞ！");
            d1.ShowInfo();

            Console.WriteLine(); //改行

            Cat c1 = new Cat(10, "ブチ");
            Animal.count++; //カウントを1増やす
            c1.SetSpecial("Jumpメソッドが使えるぞ！");
            c1.ShowInfo();

            Console.WriteLine(); //改行

            Sparrow s1 = new Sparrow(1, "茶色");
            Animal.count++; //カウントを1増やす
            s1.SetSpecial("Songメソッドが使えるぞ！");
            s1.ShowInfo();

            Console.WriteLine(); //改行

            Animal.ShowCount(); //静的なcountを確認するためのメソッドを呼び出し
        }
    }
}