using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 1, ReturnRandom(1.5f, 2f));
    }

    private void Spawn()
    {
        Vector3 pos = new Vector3(3, ReturnRandom(-2, 2), 0);
        GameObject pipe = Instantiate(pipePrefab, transform.position + pos, Quaternion.identity);
        pipe.transform.localScale = new Vector3(1, ReturnRandom(1, 1.3f), 1);
    }

    private float ReturnRandom(float min, float max)
    {
        float randomNum = Random.Range(min, max);
        return randomNum;
    }
}