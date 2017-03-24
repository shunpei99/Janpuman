using UnityEngine;
using System.Collections;

public class janpu_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D c)
    {
        
        
        Destroy(c.gameObject);  //トランポリンを削除
        GetComponent<Rigidbody2D>().velocity //ヨコアリ君を上にとばす
        = new Vector2(0, 8.0f);


    }
}
