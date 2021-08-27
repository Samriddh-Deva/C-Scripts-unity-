using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceMenu : MonoBehaviour
{

    public Object obj;
    Vector3 pos;
    Vector3 width, height;
    public float delay=0.1f, cp;
    public GameObject hex;
    GameObject[] child;

    // Start is called before the first frame update
    void Start()
    {
        child =new GameObject [hex.transform.childCount];
        width =Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        //height = Screen.height;
        cp = delay;
        for (int i = 0; i < child.Length; i++)
        {
            child[i] = hex.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {

        
        if (delay < 0)
        {
            int i=Random.Range(0,child.Length);
            StartCoroutine(Up(i));

           /* pos.x = Random.Range(-width.y * 2, width.y * 2);
            Instantiate(obj, pos, new Quaternion());*/
            delay = cp;
        }
        else
            delay = delay - Time.deltaTime;
        
    }

    IEnumerator Up(int flag)
    {
        
         for(float i=1;i<2.1f;i+=Time.deltaTime)
         { 

           child[flag].gameObject.transform.Translate(new Vector3(0, 0, -2.0f * Time.deltaTime),Space.World);
            yield return new WaitForSeconds(.01f);
        }

        StartCoroutine(down(flag));
    }
    IEnumerator down(int flag)
    {
        
        for (float i = 1; i < 2.1f; i+=Time.deltaTime)
        {

            child[flag].gameObject.transform.Translate(new Vector3(0, 0, 2.0f * Time.deltaTime), Space.World);
            yield return new WaitForSeconds(.01f);
        }

        child[flag].gameObject.transform.position = new Vector3(child[flag].gameObject.transform.position.x, child[flag].gameObject.transform.position.y, 3.703454f);
    }
}

