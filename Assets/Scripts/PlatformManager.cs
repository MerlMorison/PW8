using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] private GameObject newPlatformPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            Instantiate(newPlatformPrefab, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
        }
    }
}
