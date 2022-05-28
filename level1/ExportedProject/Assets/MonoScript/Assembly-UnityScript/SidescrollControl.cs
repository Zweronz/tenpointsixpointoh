using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(CharacterController))]
public class SidescrollControl : MonoBehaviour
{
	public Joystick moveTouchPad;

	public Joystick jumpTouchPad;

	public float forwardSpeed;

	public float backwardSpeed;

	public float jumpSpeed;

	public float inAirMultiplier;

	private Transform thisTransform;

	private CharacterController character;

	private Vector3 velocity;

	private bool canJump;

	public SidescrollControl()
	{
		forwardSpeed = 4f;
		backwardSpeed = 4f;
		jumpSpeed = 16f;
		inAirMultiplier = 0.25f;
		canJump = true;
	}

	public override void Start()
	{
		thisTransform = (Transform)GetComponent(typeof(Transform));
		character = (CharacterController)GetComponent(typeof(CharacterController));
		GameObject gameObject = GameObject.Find("PlayerSpawn");
		if ((bool)gameObject)
		{
			thisTransform.position = gameObject.transform.position;
		}
	}

	public override void OnEndGame()
	{
		moveTouchPad.Disable();
		jumpTouchPad.Disable();
		enabled = false;
	}

	public override void Update()
	{
		Vector3 zero = Vector3.zero;
		zero = ((moveTouchPad.position.x <= 0f) ? (Vector3.right * backwardSpeed * moveTouchPad.position.x) : (Vector3.right * forwardSpeed * moveTouchPad.position.x));
		if (character.isGrounded)
		{
			bool flag = false;
			Joystick joystick = jumpTouchPad;
			if (!joystick.IsFingerDown())
			{
				canJump = true;
			}
			if (canJump && joystick.IsFingerDown())
			{
				flag = true;
				canJump = false;
			}
			if (flag)
			{
				velocity = character.velocity;
				velocity.y = jumpSpeed;
			}
		}
		else
		{
			velocity.y += Physics.gravity.y * Time.deltaTime;
			zero.x *= inAirMultiplier;
		}
		zero += velocity;
		zero += Physics.gravity;
		zero *= Time.deltaTime;
		character.Move(zero);
		if (character.isGrounded)
		{
			velocity = Vector3.zero;
		}
	}

	public override void Main()
	{
	}
}
