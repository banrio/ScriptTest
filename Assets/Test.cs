using UnityEngine;
using System.Collections;


public class Boss {
	int mp = 53; //変数mp

	public void Magic() {
		//魔法攻撃をする関数
		if (this.mp > 4){
			//残りmpを5減らす
			this.mp -= 5;
			//テキスト表示
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");

		} else {
			Debug.Log ("mpが足らないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 要素数5の配列を初期化する
		int[] array = new int[5];

		// 配列の各要素に値を代入する
		array [0] = 0;
		array [1] = 1;
		array [2] = 2;
		array [3] = 3;
		array [4] = 4;

		//配列の要素を順に表示する
		for (int a = 0; a < array.Length; a++){
			Debug.Log (array [a]);
		}
	

		// 配列の要素を逆順ですべて表示する
		for (int i = 4; i > -1; i--) {
			Debug.Log (array [i]);
		}


		//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		//魔法攻撃を11回呼び出す。
		for (int k = 1; k < 12; k++){
			lastboss.Magic();
				}
	}
	// Update is called once per frame
	void Update () {
	}
}




