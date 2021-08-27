using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartExit : MonoBehaviour
{
    public int Half_Speed = 5;
    public Canvas canvas;
    public Canvas Tutorial;
    
    // Start is called before the first frame update
    public void play()
    {
        
        SceneManager.LoadScene(2);
    }
    public void exit()
    {
        Application.Quit();
    }

    public void Pause()
    {
        Time.timeScale = 0;
        canvas.enabled = true;


    }
    public void mainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
   public void playagain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void resume()
    {
        Time.timeScale = 1;
        canvas.enabled = false;
    }
    public void HalfTime()
    {
        Time.timeScale = 0.5f;
        canvas.enabled = false;
        StartCoroutine("normal");
        

    }
    IEnumerator normal()
    {
        yield return new WaitForSeconds(Half_Speed);
        Time.timeScale = 1.0f;
    }

    public void ExitTutorial()
    {
        Time.timeScale = 1;
        Tutorial.enabled = false;
    }

    public void easy()
    {
        SceneManager.LoadScene(3);
    }
    public void Mid()
    {
        SceneManager.LoadScene(4);
    }
    public void Hard()
    {
        SceneManager.LoadScene(5);
    }
    public void Multi()
    {
        SceneManager.LoadScene(6);
    }
}
