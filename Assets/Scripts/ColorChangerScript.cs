using UnityEngine;

public class ColorChangerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Player>().SetRandomColor();
            Destroy(gameObject);
        }
    }
}
