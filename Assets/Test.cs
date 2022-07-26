using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


//クラスがキャラや敵などの本体の枠組み、メンバ関数がそれらの持つ機能（攻撃・防御・移動など）、メンバ変数が具体的な各種の値


public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //MP

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //魔法攻撃用の関数
    public void Magic(int Consume)
    {

            if (mp >= 5)
            {
                this.mp -= Consume;
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        

    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}
//ここまででボスのデータや攻撃防御についての処理ができる


public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法攻撃用の関数を呼び出す
        for(int i = 0; i <= 10; i++)
        { 
             lastboss.Magic(5);
           
        }


        int[] array = new int[]{ 1, 2, 3, 4, 5 };

        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //逆順表示方法①
        //変数tの初期値をarray.Length-1にしてt=0になるまで繰り返し、５個目のデータから順に取得
        for(int t = array.Length-1;t>=0; t--)
        {
            Debug.Log(array[t]);
        }

        //逆順表示方法②　Array.Reverseを使用するらしい（7/24失敗、存在しないとエラーに…)
        //（7/24解決　Using System; が抜けていた）C#本来は使えるが衝突しがち

        Array.Reverse(array);
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }



   /* // Use this for initialization
    void Start()
    {
        /*
        //コンソールにHello, Worldと入力
        Debug.Log("Hello, World");

        //変数の宣言
        int score;

        //変数の代入
        score = 150;
        //コンソールに変数の中身を表示
        Debug.Log(score);

        //変数を初期化する
        int a=3;
        int b=4;

        //変数aと変数bの合計値を変数cに代入する
        int c=a+b;
        //変数cを表示する
        Debug.Log(c);

        //moneyを200で初期化する
        int money=200;
        int money=50;

        if (money >= 100)
        {
            //moneyの値が100以上の場合、文字列を表示する
            Debug.Log("ポーションを買う");
        }


        //moneyを50で初期化する
        int money=50;
        int money=100;
        if (money >= 100)
        {
            //moneyが100以上だった場合
            Debug.Log("ポーションを買う")
        }
        else
        {
            //moneyが100未満だった場合
            Debug.Log("武器を売る");
        }


        //moneyを100で初期化する
        int money = 100;
        
        if (money <= 50)
        {
            // moneyが50以下だった場合の処理
            Debug.Log("武器を売る");
        }
        else if (money >= 200)
        {
            // moneyが200以上だった場合の処理
            Debug.Log("武器を買う");
        }
        else
        {
            // それ以外の場合の処理
            Debug.Log("ポーションを買う");
        }


        // 三項演算子…値を代入したい変数=(条件式)? 変数1:変数2;
        
         // numを1で初期化する
        int num = 1;
        
        // valに代入する値を条件によって変える(三項演算子)
        int val = (num == 1) ? -100 : 100; 　　num==1ならval=-100になるということ
       
        // valの値を表示する
        Debug.Log(val);

        //【if文使っても書ける】

        int val;
        int num = 1;
        
        if(num == 1)
        {
            val = -100;
        }
        else
        {
            val = 100;
        }
        
        Debug.Log(val);


        //for文について
        
        // 5回処理を繰り返す
                for (int i = 0; i < 5; i++)
                {
                        Debug.Log (i);
                }

        // 4回処理を繰り返す
                for (int i = 0; i < 4; i++)
                {
                        Debug.Log (i);
                }

        //合計値を求める

        // sumを0で初期化する
                int sum = 0;
                // 10回処理を繰り返す
                for (int i = 1; i <= 10; i++)
                {
                        // iの値をsumに足す
                        sum += i;
                }
                // sumの値を表示する
                Debug.Log (sum);

         

        // 要素数5の配列を初期化する
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < points.Length; i++)
        {
            // 配列の要素が50以上の場合
            if (points[i] >= 50)
            {
                // 配列の要素を表示する
                Debug.Log(points[i]);
            }
        }

        
         // 「Hello」に続けて引数の文字列を表示する関数
         void HelloName(string name)
         {
             Debug.Log("Hello, " + name);
         }

         void Start()
         {
             // HelloName関数に「Unity」という引数を渡す
             HelloName("Unity");
         }
        

        
        // 第一引数と第二引数の値を足した値を返す関数
        int Add(int a, int b)
        {
            // 第一引数と第二引数の値を足して、変数cに代入する
            int c = a + b;
            // 変数cを呼び出し元の関数に返す
            return c;
        }

        void Start()
        {
            // Add関数に「3」と「6」の引数を渡し、返り値をnum変数に代入する
            int num = Add(3, 6);
            // numを表示する
            Debug.Log(num);
        }
        

    }*/
    


}
