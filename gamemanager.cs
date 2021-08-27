
using UnityEngine;
using UnityEngine.SceneManagement;



public class gamemanager : MonoBehaviour
{
   public float delay = 2f;
   bool end=true;
   public void EndGame()
{
if(end)
{
Debug.Log("Game Over!!!!");
end=false;
Invoke("restart",delay);
}
}


void restart()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
}
