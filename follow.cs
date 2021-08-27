using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
   public Transform player;
public Vector3 diviation,diviationa,diviationd;
    // Update is called once per frame
    void Update()
    {
        {transform.position = player.position + diviation;}
    }
}
