using UnityEngine;

public class PlatformerControllerRB : Monobehaivour
{
  private Rigidbody2D rb;
  
  private float movementSpeed = 5;
  
  private void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }
  
  private void FixedUpdate()
  {
    rb.velocity = new Vector2(movementSpeed, rb.velocity.y);
  }
}
