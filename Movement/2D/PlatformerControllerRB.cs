using UnityEngine;

public class PlatformerControllerRB : Monobehaivour
{
	[SerializeField]
	private float movementSpeed;

	private Rigidbody2D body2D;
	
	private float movementInputDirection;
	
	private void Start()
	{
		body2D = GetComponent<Rigidbody2D>();
	}
	
	private void Update()
	{
		CheckInputs();
	}
	
	private void FixedUpdate()
	{
		ApplyMovement();
	}
	
	private void CheckInputs()
	{
		movementInputDirection = Input.GetAxisRaw("Horizontal");
	}
	
	private void ApplyMovement()
	{
		body2D.velocity = new Vector3(movementInputDirection * movementSpeed, rb.velocity.y);
	}
}
