using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAlter : MonoBehaviour
{

    public Transform trans;
    public Vector3 substract;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, Random.Range(0, 360)));
    }

    // Update is called once per frame
    void Update()
    {
        trans.localScale = trans.localScale - substract*Time.deltaTime;
        if (trans.localScale.x<0)
        {
            Destroy(this.gameObject);
            
        }
    }
}
