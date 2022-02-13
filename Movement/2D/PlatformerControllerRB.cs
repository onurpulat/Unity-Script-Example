using UnityEngine;

public class PlatformerControllerRB : Monobehaivour
{
	[SerializeField]
	private float movementSpeed;

	private Rigidbody2D rb;
	
	private float movementInputDirection;
	
	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	private void Update()
	{
		CheckInputs();
	}
	
	private void CheckInputs()
	{
		movementInputDirection = Input.GetAxisRaw("Horizontal");
	}
	
	private void ApplyMovement()
	{
		rb.velocity = new Vector3(movementInputDirection * movementSpeed, rb.velocity.y);
	}
}
