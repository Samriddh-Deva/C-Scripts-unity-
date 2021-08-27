using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Monetization;

public class PlayerMovementMid : MonoBehaviour
{
    
    public Transform transform;
    public int speed;
    private Vector3 ScreenSize;


    public string gameId = "3912641";
    public string placementId = "BannerDuringgame";
    public bool testMode = false;

    private void Start()
    {
      Advertisement.Initialize(gameId, testMode);
       // Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_LEFT);
        Time.timeScale = 0;
      StartCoroutine(ShowBannerWhenReady());

    }
    // Start is called before the first frame update

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
                transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
           
        }
       Advertisement.Banner.Show(placementId);

    }
    
    
    
   
  IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(placementId))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(placementId);
    }
}
