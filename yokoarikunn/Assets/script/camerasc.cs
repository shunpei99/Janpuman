using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class camerasc : MonoBehaviour
{

    public GameObject player_tr;
    //プレイヤーのトランスフォーム
    //bef＝前の　プレイヤー＋カメラの位置
    private  Vector3 bef_player_tr;
    private Vector3 bef_camerasc_tr;

    //プレイヤー
    public GameObject player;
    //スコアテキスト　最初は０
    public Text scoreText;
    public static  int score = 0;
    //スコア用
    private int scoreUpPos = 3;
    //プレイヤー
    private Transform playerTrans;
    public static int satou_score ()
    {
        return score;
    }
    void Start()
    {
        
     
        bef_player_tr = player_tr.transform.position;
        //前の座標を初期化(スタート時) 
        bef_camerasc_tr = GetComponent<Transform>().position;

        playerTrans = player.GetComponent<Transform>();

        scoreText.text = "score : 0";

        
}

    // Update is called once per frame
    void Update()
    {
        //player_script.

        Vector3 pos = GetComponent<Transform>().position;
        Vector3 pla = player_tr.transform.position;

        float playerHeight = playerTrans.position.y;
        float currentCameraHeight = transform.position.y;
        float newHeight = Mathf.Lerp(currentCameraHeight, playerHeight, 0.5f);

        if(playerHeight > currentCameraHeight)
        {

            transform.position = new Vector3(transform.position.x, newHeight, transform.position.z);

        }

        //　もしも　前の座標より今の座標の方が大きかったらカメラを動かす
        if (pla.y > bef_player_tr.y)
        {
            //もしも前のカメラの座標より今のプレイヤーの座標の方が大きい時
            if(pla.y > bef_camerasc_tr.y){

            pos.y = pla.y;

            GetComponent<Transform>().position = pos;

            }
        } 
        if(playerTrans.position.y >= scoreUpPos)
        {
            scoreUpPos += 3;

            score += 10;

            scoreText.text = "score:  " + score.ToString(); 

        }

        //GetComponent<Transform>().position = pos;
        bef_player_tr = player_tr.transform.position;//前の座標を更新
        bef_camerasc_tr = transform.position;
    }

}
