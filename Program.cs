namespace Animal_0723
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog(5, "���F");
            d1.SetSpecial("GetItem���\�b�h���g���邼�I");
            d1.ShowInfo();

            Console.WriteLine(); //���s

            Cat c1 = new Cat(10, "�u�`");
            c1.SetSpecial("Jump���\�b�h���g���邼�I");
            c1.ShowInfo();

            Console.WriteLine(); //���s

            Sparrow s1 = new Sparrow(1, "���F");
            s1.SetSpecial("Song���\�b�h���g���邼�I");
            s1.ShowInfo();

            Console.WriteLine(); //���s

        }
    }
}