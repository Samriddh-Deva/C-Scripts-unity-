using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyMovement : MonoBehaviour
{
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.gameObject.transform.position;
        pos = pos - new Vector3(0, 0, 18.5f);
        pos = pos.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = this.gameObject.transform.position + pos * Time.deltaTime*-2.2f;

        if(this.gameObject.transform.position.x<.1&& this.gameObject.transform.position.y < .1)
        {
            
            Destroy(this.gameObject);
        }
    }
}
