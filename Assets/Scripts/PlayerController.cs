using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed = 1f;
    public float sidewaysSpeed = 1f;

    Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Time.fixedDeltaTime * -speed, 0, Input.GetAxis("Horizontal") * Time.fixedDeltaTime * sidewaysSpeed);
        rb.AddForce(movement, ForceMode.VelocityChange);
    }

    void Update()
    {
        if (rb.position.y < -1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
