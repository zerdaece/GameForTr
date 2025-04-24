using UnityEngine;
using System.Collections.Generic;

public class BallDetroyer : MonoBehaviour
{
     void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Çarpışma gerçekleşti: " + collision.gameObject.tag);

        // Eğer çarptığı nesnenin adı "Ground" ise
        if (collision.gameObject.CompareTag("Ground"))
        {
            // 1 saniye sonra yok et
            Invoke("DestroyBall", 1f);
        }
        
    }

    void DestroyBall()
    {
        Score.score -= 1; // Skoru azalt
        Destroy(gameObject);
    }
}
