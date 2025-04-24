using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;



    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("abuzer kadayif çaliş " + collision.gameObject.tag);
        
        if (collision.gameObject.CompareTag("Object"))
        {
            // Eğer çarptığı nesne "Sepet" ise, skoru artır
            score += 1;
            Destroy(collision.gameObject); // Çarpışan nesneyi yok et
            Debug.Log("Skor: " + score);
        }
        
    }
    
  
    }
    
