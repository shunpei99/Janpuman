using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    float ja = 0;
    public float aaaaa;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 pos = transform.position;
        

       
	}

	//衝突したときに呼ばれる（IsTriggerにチェックが入っているとき）
	void OnTriggerEnter2D(Collider2D c){


        ja = 1;
		jump ();
		Destroy (c.gameObject); 	//トランポリンを削除
		GetComponent<Rigidbody2D> ().velocity //ヨコアリ君を上にとばす
		= new Vector2(0, 8.0f);

        Vector2 pos2 = transform.position;


	}

	public void jump()
	{
        //ヨコアリ君を上に
	}
}

