namespace Animal_0723
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal�N���X�ł���a1��p�ӂ��A���̉��i�C���X�^���X���j
            Animal a1 = new Animal();

            a1.DataChange("��", 5);
            a1.ShowInfo();

            Animal a2 = new Animal();

            a2.Name = "�l�R";
            Console.WriteLine(a2.Name);

            Animal a3 = new Animal("�X�Y��", "����", 1, "���F", "�`�����`����");
            a3.ShowInfo();

            Animal a4 = new Animal();
            a4.ShowInfo();

            Dog d1 = new Dog();
            d1.SetSpecial("GetItem���\�b�h�ł���Q�b�g�I"); //�e�N���X
            d1.ShowInfo();�@//�e�N���X
            d1.GetItem(); //Dog�N���X�̐�p���\�b�h

        }
    }
}