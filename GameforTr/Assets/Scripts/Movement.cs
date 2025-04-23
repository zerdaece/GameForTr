using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float minX;
    public float maxX;

    void Update()
    {
        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 newPosition = transform.position;
            newPosition.x += speed * Time.deltaTime;
            transform.position = newPosition;
        }
      
    }
}
