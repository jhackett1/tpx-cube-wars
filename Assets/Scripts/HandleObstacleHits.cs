using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleObstacleHits : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
