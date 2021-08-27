using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigMoney : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == ("Player"))
        {

            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 10);

            Destroy(this.gameObject);
        }
    }
}
