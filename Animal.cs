using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_0723
{
    internal class Animal　//親クラス、ベースクラス
    {
        //クラスが持っている変数（フィールド） ※ 自動実装プロパティがあれば不要
        //private string name; //動物の名称
        //private string genre; //分類
        //private int age; //年齢
        //private string color; //見た目の色
        //private string special; //特徴・特技
        //private string cry; //鳴き声

        //フィールドnameに干渉する専用のプロパティ(メソッド)作り
        //public string Name
        //{
        //    set { name = value; } //更新
        //    get { return name; } //参照
        //}

        //自動実装プロパティでもっと簡単にデータを用意する
        public string Name { set; get; } //動物の名称
        public string Genre { private set; get; } //分類
        public int Age { set; get; } //年齢
        public string Color { private set; get; } //見た目の色
        public string Special { private set; get; } //特徴・特技
        public string Cry { private set; get; }//鳴き声

        //コンストラクタ（メソッド）の改造
        public Animal(string name, string genre, int age, string color, string cry)
        {
            Name = name;
            Genre = genre;
            Age = age;
            Color = color;
            Cry = cry;
        }

        public Animal() : this("名無し", "不明", 0, "不明", "不明") { }　//改造した本家のコンストラクタを継承して使っている



        //機能（メソッド（関数））
        //フィールドのデータを変更するメソッド
        public void DataChange(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //フィールドのデータをコンソールに出力するメソッド
        public void ShowInfo()
        {
            Console.WriteLine("名前：" + Name);
            Console.WriteLine("種類：" + Genre);
            Console.WriteLine("年齢：" + Age);
            Console.WriteLine("色：" + Color);
            Console.WriteLine("鳴き声：" + Cry);
            Console.WriteLine("特技：" + Special);
        }

        //特技を設定するメソッド
        public void SetSpecial(string special)
        {
            Special = special; //Specialプロパティに引数の文字列情報が代入される
        }

    }

    class Dog : Animal
    {
        public Dog(int age, string color) : base("犬", "哺乳類", age, color, "ワン！") { } //①実体化の改造 base(Animalクラス)の実体化機能を活用
        public Dog() : this(0, "不明") { } //② ①の機能を使って、引数なしVer.の実体化メソッドも用意しておく

        //犬だけが持っているスキル：宝探しスキルの発動メソッド
        public void GetItem()
        {
            Console.WriteLine("お宝をゲットしてきた！");
        }
    }

    class Cat : Animal
    {
        //①実体化の改造 base(Animalクラス)の実体化機能を活用
        public Cat(int age, string color) : base("ネコ", "哺乳類", age, color, "ニャー") { }

        //② ①の機能を使って、引数なしVer.の実体化メソッドも用意しておく
        public Cat() : this(0, "不明") { }

        //ネコだけが持っているスキル：ハイジャンプスキルの発動メソッド
        public void Jump()
        {
            Console.WriteLine("高くジャンプした！");
        }
    }

    class Sparrow : Animal
    {
        //①実体化の改造 base(Animalクラス)の実体化機能を活用
        public Sparrow(int age, string color) : base("スズメ", "鳥類", age, color, "チュンチュン") { }

        //② ①の機能を使って、引数なしVer.の実体化メソッドも用意しておく
        public Sparrow() : this(0, "不明") { }

        //スズメだけが持っているスキル：さえずるスキルの発動メソッド
        public void Song()
        {
            Console.WriteLine("可愛くさえずった！");
        }
    }

}
