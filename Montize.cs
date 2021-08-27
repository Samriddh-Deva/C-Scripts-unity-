using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Montize : MonoBehaviour
{

    public string gameId = "3912641";
    public string placementId = "BannerDuringgame";
    public bool testMode = false;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the SDK if you haven't already done so:
        Advertisement.Initialize(gameId, testMode);
        StartCoroutine(ShowBannerWhenReady());
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(placementId))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(placementId);
    }
    private void Update()
    {
        Advertisement.Banner.Show(placementId);
    }
}
