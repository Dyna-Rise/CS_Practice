using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_0723
{
    internal class Animal
    {
        //クラスが持っている変数（フィールド）
        private string name; //動物の名称
        private string genre; //分類
        private int age; //年齢
        private string color; //見た目の色
        private string special; //特徴・特技
        private string cry; //鳴き声

        //機能（メソッド（関数））
        //フィールドのデータを変更するメソッド
        public void DataChange(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
