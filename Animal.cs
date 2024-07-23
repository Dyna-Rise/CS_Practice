using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_0723
{
    internal class Animal
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
            Console.WriteLine("年齢：" + Age);
        }


    }
}
