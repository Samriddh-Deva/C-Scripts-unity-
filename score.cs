using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class score : MonoBehaviour
{

    RaycastHit hit;
    public Text text,GameOverScore,HighGame;
    public int s=0;
    //public  ParticleSystem explosion;
    public Canvas OverMenu,scoreAndPause;
    private int Life = 0;
    bool testMode = false;

    void Start()
    { 
        Advertisement.Initialize("3912641", testMode);
        HighGame.text = "Highscore:" + PlayerPrefs.GetInt("highscore"); 
        
    }

    
    void FixedUpdate()
    {
        
        text.text = Mathf.RoundToInt(s/9).ToString();

        if(Physics.Raycast(transform.position,transform.up,out hit,.5f))
        {


            if (hit.collider.tag == "Over")
            {
                s = Mathf.RoundToInt(s / 9);
                GameOverScore.text = "YOUR SCORE: " + text.text;
                Time.timeScale = 0;
                scoreAndPause.enabled = false;
                OverMenu.enabled = true;



                //Save    
                if (s > PlayerPrefs.GetInt("highscore"))
                {
                    PlayerPrefs.SetInt("highscore", s);
                }

            }
            //increment Score

            else
            if (hit.collider.tag == "Score")
                s++;
        }

    }

    /*private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Over")
        {
            GameOverScore.text = GameOverScore.text + text.text;
            Time.timeScale = 0;
            scoreAndPause.enabled = false;
            OverMenu.enabled = true;
            


           //Save    
                if (s > PlayerPrefs.GetInt("highscore"))
                {
                    PlayerPrefs.SetInt("highscore", s);
                }
            
        }        
            //increment Score
        
        else
            if (collision.collider.tag == "Score")
            s++;
    }*/

    IEnumerator extra_Life()
    {
        
        Advertisement.Load("3912641");
        Life++;
        

        if(!Advertisement.IsReady())
        {

           yield return null;
        }
        Advertisement.Show("rewardedVideo");
        Advertisement.Initialize("3912641", testMode);
    }
   
    public void click_button()
    {
        //Advertisement.Initialize("3912640", true);
        StartCoroutine("extra_Life");
    }
}
