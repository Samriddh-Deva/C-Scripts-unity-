using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Opening : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("wait");
    }

    // Update is called once per frame
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
    
}
