using System.Runtime.InteropServices;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject platform;
    private GameObject myPlatform;

    private void Update()
    {
        if (player.GetComponent<Rigidbody2D>().velocity.y <= -20)
            player.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("platform"))
        {
            Vector2 spawnPos = new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (10 + Random.Range(0.5f, 1f)));
            if (FindCollisions(spawnPos) < 1)
            {
                myPlatform = Instantiate(platform, spawnPos, Quaternion.identity);

            }
            Destroy(collision.gameObject);
        }
    }
    private int FindCollisions(Vector3 pos)
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(pos, 1f);
        return hits.Length;
    }
}
