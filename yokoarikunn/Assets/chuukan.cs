using UnityEngine;
public class chuukan : MonoBehaviour {
    public GameObject nsky;
    public GameObject play;
    private float flg_n;
	// Use this for initialization
	void Start () {
        flg_n = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 n_pos = nsky.transform.position;
        Vector3 pla_pos = play.transform.position;
        float kyo = transform.position.y - pla_pos.y;
        if (flg_n == 0 && kyo < 10)
        {
            n_pos.y = n_pos.y + 38f;
            Instantiate(nsky, n_pos, transform.rotation);
            flg_n = 1;
        }
        
    }
}
