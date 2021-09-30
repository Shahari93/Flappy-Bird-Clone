using UnityEngine;

public class BirdControl : MonoBehaviour
{
    private Rigidbody2D birdRB;
    [SerializeField] private float yVelocity = 2.5f;

    private void Start()
    {
        birdRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdRB.AddForce(transform.up * yVelocity * Time.deltaTime, ForceMode2D.Impulse);
        }
        if(birdRB.velocity.y <= -2f)
        {
            //transform.Rotate(0, 0, -15);
        }
    }
}