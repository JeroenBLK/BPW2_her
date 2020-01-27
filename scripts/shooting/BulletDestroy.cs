using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            gameObject.SetActive(false);
        }
    }
}
