namespace Animal_0723
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animalクラスであるa1を用意し、実体化（インスタンス化）
            Animal a1 = new Animal();

            a1.DataChange("犬", 5);
            a1.ShowInfo();

            Animal a2 = new Animal();

            a2.Name = "ネコ";
            Console.WriteLine(a2.Name);

            Animal a3 = new Animal("スズメ", "鳥類", 1, "茶色", "チュンチュン");
            a3.ShowInfo();

            Animal a4 = new Animal();
            a4.ShowInfo();

            Dog d1 = new Dog();
            d1.SetSpecial("GetItemメソッドでお宝ゲット！"); //親クラス
            d1.ShowInfo();　//親クラス
            d1.GetItem(); //Dogクラスの専用メソッド

        }
    }
}