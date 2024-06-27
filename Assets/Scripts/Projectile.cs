using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 3f;

    private void Start()
    {
        Invoke("DestroyProjectile", lifetime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Target"))
        {
            collision.collider.GetComponent<Renderer>().material.color = Color.red;
            Destroy(collision.collider.gameObject, 1);
            Destroy(this.gameObject);
        }
    }
}
