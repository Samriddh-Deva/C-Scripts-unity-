using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.Networking;

public class ScoreMultiplayer : NetworkBehaviour
{
    RaycastHit hit;
    public Text text, GameOverScore, HighGame;
    //public int s = 0;
    //public  ParticleSystem explosion;
    public Canvas OverMenu, scoreAndPause;
    private int Life = 0;
    bool testMode = false;
    [SyncVar(hook = "UpdateScore2")]
    private int s = 0;
    int s2=0;
   
    
    [Command]
    private void UpdateScore2(int newscore)
    {
        s = newscore;
        
            }
    void Start()
    {
        Advertisement.Initialize("3912641", testMode);
        HighGame.text = "Highscore:" + PlayerPrefs.GetInt("highscore");

    }


    void FixedUpdate()
    {
        text.text = Mathf.RoundToInt(s / 9).ToString();

        // text.text = Mathf.RoundToInt(s / 9).ToString();

        if (Physics.Raycast(transform.position, transform.up, out hit, .5f))
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

    

    IEnumerator extra_Life()
    {

        Advertisement.Load("3912641");
        Life++;


        if (!Advertisement.IsReady())
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
