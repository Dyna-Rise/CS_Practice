namespace Animal_0723
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog(5, "���F");
            Animal.count++; //�J�E���g��1���₷
            d1.SetSpecial("GetItem���\�b�h���g���邼�I");
            d1.ShowInfo();

            Console.WriteLine(); //���s

            Cat c1 = new Cat(10, "�u�`");
            Animal.count++; //�J�E���g��1���₷
            c1.SetSpecial("Jump���\�b�h���g���邼�I");
            c1.ShowInfo();

            Console.WriteLine(); //���s

            Sparrow s1 = new Sparrow(1, "���F");
            Animal.count++; //�J�E���g��1���₷
            s1.SetSpecial("Song���\�b�h���g���邼�I");
            s1.ShowInfo();

            Console.WriteLine(); //���s

            Animal.ShowCount(); //�ÓI��count���m�F���邽�߂̃��\�b�h���Ăяo��
        }
    }
}