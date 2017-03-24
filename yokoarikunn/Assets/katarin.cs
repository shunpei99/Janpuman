using UnityEngine;
using System.Collections;

public class katarin : MonoBehaviour
{

   
    public GameObject katarin2;
    public Rigidbody2D pla_rigidbody2d;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D c)
    {

        katarin2.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
         pla_rigidbody2d.velocity = new Vector2(0, -1.0f);

    }
}
