using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    [SerializeField] private GameObject columnPrefab;

    private void Start()
    {
        if (GameManager.gameManager.shouldPlay)
        {
            InvokeRepeating(nameof(Spawn), 1, ReturnRandom(1.5f, 3.5f));
        }
    }

    private void Update()
    {
        if (!GameManager.gameManager.shouldPlay)
        {
            CancelInvoke();
        }
    }

    private void Spawn()
    {
        Vector3 pos = new Vector3(3, transform.position.y /*ReturnRandom(0, 2)*/, 0);
        GameObject column = Instantiate(columnPrefab, transform.position + pos, Quaternion.identity);
        SpriteRenderer[] pipes = column.GetComponentsInChildren<SpriteRenderer>();
        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[0].size = new Vector2(pipes[i].size.x, ReturnRandom(3f,5.5f));
            pipes[1].size = new Vector2(pipes[i].size.x, ReturnRandom(-5.5f, -3f));
        }
    }

    private float ReturnRandom(float min, float max)
    {
        float randomNum = Random.Range(min, max);
        return randomNum;
    }
}