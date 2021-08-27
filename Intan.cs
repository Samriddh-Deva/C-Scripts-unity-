using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intan : MonoBehaviour
{
    public float delay, cp;
    public Object obj;
    private Quaternion ob;


    // Start is called before the first frame update
    void Start()
    {
        delay = 1;
        cp = 4;
        //cp = delay;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (delay < 0.1)
        { ob = new Quaternion(0, 0, Random.Range(30, 360),0);
                    delay = cp;
                    Instantiate(obj, new Vector3(0, 0, 18.479f), ob);
            if(cp>1.2)
            cp -=0.1f;
        }
        else
            delay -= Time.deltaTime;
        
    }
}
