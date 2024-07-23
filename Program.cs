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

        }
    }
}