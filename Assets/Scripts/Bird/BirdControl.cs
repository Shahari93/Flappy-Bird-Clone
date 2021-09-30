using UnityEngine;

public class BirdControl : MonoBehaviour
{
    private Rigidbody2D birdRB;
    [SerializeField] private float yVelocity = 2.5f;
    [SerializeField] private UIManager uIManager;
    private const string pipe = "Pipe", ground = "Ground";

    private void Start()
    {
        birdRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdRB.AddForce(transform.up * yVelocity * Time.deltaTime, ForceMode2D.Impulse);
        }
        if (birdRB.velocity.y <= -2f)
        {
            //transform.Rotate(0, 0, -15);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(pipe) || collision.gameObject.CompareTag(ground))
        {
            Debug.Log("hit");
            this.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        uIManager.AddToScore();
    }
}