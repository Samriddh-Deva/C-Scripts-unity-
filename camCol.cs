using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camCol : MonoBehaviour
{
        public Camera camera;
        public Color []color;
    private float i=0;
    
    Color c;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("colorChange");
    }

    // Update is called once per frame
    void Update()
    {
        /* if (i >= color.Length-1)
             i = 0;
         i = i + Time.deltaTime;
         if(i<color.Length)
         camera.backgroundColor = color[Mathf.RoundToInt(i)];*/
        //  camera.backgroundColor = c;

        camera.backgroundColor = Color.Lerp(camera.backgroundColor, color[(int)(i + 1)], .03f);
    }

    IEnumerator colorChange()
    {
        yield return new WaitForSeconds(.7f);
        i++;
        if (i > color.Length-2)
            i = 0;
       restart();
    }
    void restart()
    {
        StartCoroutine("colorChange");
    }
}
