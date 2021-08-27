using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rota : MonoBehaviour
{
    public Transform tran;
    public float sp=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        tran.Rotate ( new Vector3(0, 0, sp * Time.deltaTime), Space.World);
    }
}
