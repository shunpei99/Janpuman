using UnityEngine;
using System.Collections;

public class sky : MonoBehaviour {
    public float speed = 1.0f;
    public ScriptableObject Player_sc; // Player script
    private float han;//pulyerからのja基準
    public GameObject player;// Player object
    
    public GameObject camera_pos;
    public GameObject sky_ob;
    public GameObject chukan;
    int sky_one;
    // Use this for initialization
    void Start () {
        sky_one = 1;
    }

    // Update is called once per frame
    void Update() {
        //Instantiate(yokoari. )
        //han = Player.ja ;// プレイヤスクリプト内の変数の呼び出し
        //transform.Translate(0/*x*/, -0.08f/*y*/, 0/*z*/);
        
        Vector2 play_pos = player.transform.position;
       
        Vector3 sky_pos = transform.position;
        Vector2 cam = camera_pos.transform.position;
        Vector2 chu_pos = chukan.transform.position;
        //プレイヤーとカメラの距離が１０以上あったら

        float kyo;
        kyo = play_pos.y - sky_pos.y;
        float flg = 1;
        if (play_pos.y > 50f)
        {
            flg = 0;
        }
        if (kyo >= 13f)
        {
               
                    sky_pos.y = sky_pos.y + 38f;
            if (flg == 0)
            {               



                if (kyo > 38f) {
                    Destroy(this.gameObject);
                        }
            }
                //transform.position = skf_pos;
                //sky_oneはフラグ
                 
                if (sky_one == 1 && flg == 1 && play_pos.y < chu_pos.y)
                { 
                    sky_one = 0;
                    Instantiate(sky_ob, sky_pos, transform.rotation);

                    if (kyo > 17f)
                    {
                        sky_one = 1;
                        Destroy(this.gameObject);
                    }
                }
            

        }
       
       
	}

  
}
