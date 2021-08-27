using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyControl : MonoBehaviour
{
    public GameObject []Money = new GameObject[2];
    float []SpawnTime = { 3,30};
    Vector3 ScreenSize;
    //Vector2 constraints,ZVector;
    void Start()
    {
        
        /*constraints = new Vector2(Screen.width, Screen.height);
        Debug.Log(constraints);
        constraints = Camera.main.ScreenToWorldPoint(constraints);
        ZVector = Camera.main.ScreenToWorldPoint(ZVector);
        Debug.Log(constraints);*/

    }

    // Update is called once per frame
    void Update()
    {
        var size = new Vector3(Screen.width, Screen.height, 18.47f);
        size = Camera.main.ScreenToWorldPoint(size);
        ScreenSize = new Vector3(Random.Range(-size.x,size.x),
                                 Random.Range(-size.y,size.y),
                                 18.479f);


        if (SpawnTime[0]<.1)
        {
            Instantiate(Money[0], ScreenSize, new Quaternion(0, 0, 0, 0));
            SpawnTime[0] = 3;
        }
        if(SpawnTime[1]<1)
        {
            Instantiate(Money[1], ScreenSize, new Quaternion(0, 0, 0, 0));
            SpawnTime[1] = 30;

        }
        SpawnTime[0] -= Time.deltaTime;
        SpawnTime[1] -= Time.deltaTime;
    }

}
