using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
   void OnTriggerEnter2D()
   {
    Debug.Log("You Won!");
    Scores.CurrentScore += 100;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
