using UnityEngine;
using System.Collections;

public class enemy_ojama : MonoBehaviour
{

    public GameObject player;//自機を入れる



    // pla = player
    public Vector2 pla_vector2;
    public Rigidbody2D pla_rigidbody2d;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //向きから距離を求める
        



    }
    void OnTriggerEnter2D(Collider2D c)
    {

        //todo　出てきたトランポリンの種類によって飛ばす量を変える。

        pla_rigidbody2d.velocity = new Vector3(0, -10, 0);

        float pla_x = player.transform.position.x;
        float pla_y = player.transform.position.y;

        

        pla_x *= -1;
        pla_y *= -1;
          
        //player


     

    }
}
