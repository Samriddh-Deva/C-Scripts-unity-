using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementHard : MonoBehaviour
{

    public Transform transform;
    public int speed;
    private Vector3 ScreenSize;
    
    
    void Start()
    {
        Time.timeScale = 0;
        ScreenSize = new Vector3(Screen.width, Screen.height, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
             transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        else
        {
            transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
    }
}
