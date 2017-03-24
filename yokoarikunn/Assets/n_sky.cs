using UnityEngine;
using System.Collections;

public class n_sky : MonoBehaviour
{
    public GameObject player;
    public GameObject camera_pos;
    public GameObject nsky_ob;
    private float nsky_flg;
    // Use this for initialization
    void Start()
    {
        nsky_flg = 1;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 play_pos = player.transform.position;

        Vector3 sky_pos = transform.position;
        Vector3 cam = camera_pos.transform.position;

        float kyo;
        kyo = play_pos.y - sky_pos.y;

        if (sky_pos.y < cam.y)
        {

            sky_pos.y = sky_pos.y + 38f;
           

            if (nsky_flg == 1)
            {
                nsky_flg = 0;
                Instantiate(nsky_ob, sky_pos, transform.rotation);

                
            }
            
        }
    }
}
