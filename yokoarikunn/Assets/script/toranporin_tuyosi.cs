using UnityEngine;
using System.Collections;

public class toranporin_ : MonoBehaviour {
	public GameObject img;
    GameObject prefab;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            prefab = (GameObject)Instantiate(prefab, Camera.main.ScreenToWorldPoint( Input.mousePosition), Quaternion.identity);
            prefab.transform.position = new Vector3(prefab.transform.position.x, prefab.transform.position.y, 0);
            prefab.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

            //Destroy(prefab);	//自分自身を消去する
            //prefab.transform.position += new Vector3(0, 0.1f, 0);
        }
	}
}
