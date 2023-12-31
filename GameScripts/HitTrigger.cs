using UnityEngine;

public class HitTrigger : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag=="Enemy")
        {
            collision.GetComponent<EnemyHealth>().health -= damage;
        }
    }
}
