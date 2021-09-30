using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameManager.shouldPlay)
        {
            MovePipesLeft(); 
        }
    }

    private void MovePipesLeft()
    {
        Vector3 move = new Vector3(-.3f * Time.deltaTime * speed, 0, 0);
        transform.position += move;
        if (transform.position.x <= -4.5f)
        {
            Destroy(gameObject);
        }
    }
}