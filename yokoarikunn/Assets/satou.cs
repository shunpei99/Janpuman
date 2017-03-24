using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class satou : MonoBehaviour {

   
    public Text scoreText;
    
    // Use this for initialization
    void Start () {
    

    }

    // Update is called once per frame
    void Update() {
       
    }
 
    void OnTriggerEnter2D(Collider2D c)
    {

        camerasc.score += 100;
       
        scoreText.text = "score:  " + camerasc.score.ToString();


    }



}
