using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NewController_arisa : MonoBehaviour
{
	public float animSpeed = 1.5f;				
	public float lookSmoother = 3.0f;			
	public bool useCurves = true;						
	public float useCurvesHeight = 0.5f;		
	public float forwardSpeed = 7.0f;
	public float backwardSpeed = 2.0f;
	public float rotateSpeed = 2.0f;
	public float jumpPower = 3.0f;

	private CapsuleCollider col;
	private Rigidbody rb;
	private Vector3 velocity;
	private float orgColHight;
	private Vector3 orgVectColCenter;
	private Animator anim;							
	private AnimatorStateInfo currentBaseState;			

	private GameObject cameraObject;	
	public FixedJoystick moveJoystick;
	public FixedJoystick lookJoystick;
	
	static int idleState = Animator.StringToHash ("Base Layer.Idle");
	static int locoState = Animator.StringToHash ("Base Layer.Locomotion");
	static int jumpState = Animator.StringToHash ("Base Layer.Jump");
	static int restState = Animator.StringToHash ("Base Layer.Rest");

	void Start ()
	{
		anim = GetComponent<Animator> ();
		col = GetComponent<CapsuleCollider> ();
		rb = GetComponent<Rigidbody> ();
		cameraObject = GameObject.FindWithTag ("MainCamera");
		orgColHight = col.height;
		orgVectColCenter = col.center;
	}



	void Update ()
	{
		//float h = Input.GetAxis ("Horizontal");				
		//float v = Input.GetAxis ("Vertical");				
		float h = moveJoystick.Horizontal;
		float v = moveJoystick.Vertical;
		anim.SetFloat ("Speed", v);							
		anim.SetFloat ("Direction", h); 						
		anim.speed = animSpeed;								
		currentBaseState = anim.GetCurrentAnimatorStateInfo (0);	
		rb.useGravity = true;

		velocity = new Vector3 (0, 0, v);		
		velocity = transform.TransformDirection (velocity);
		if (v > 0.1) {
			velocity *= forwardSpeed;		
		} else if (v < -0.1) {
			velocity *= backwardSpeed;	
		}
	
		if (Input.GetButtonDown ("Jump")) {	
			if (currentBaseState.nameHash == locoState) {
				if (!anim.IsInTransition (0)) {
					rb.AddForce (Vector3.up * jumpPower, ForceMode.VelocityChange);
					anim.SetBool ("Jump", true);		
				}
			}
		}
	
		transform.localPosition += velocity * Time.fixedDeltaTime;
		transform.Rotate (0, h * rotateSpeed, 0);	

		if (currentBaseState.nameHash == locoState) {
			if (useCurves) {
				resetCollider ();
			}
		}

		else if (currentBaseState.nameHash == jumpState) {
			if (!anim.IsInTransition (0)) {			
				if (useCurves) {
					float jumpHeight = anim.GetFloat ("JumpHeight");
					float gravityControl = anim.GetFloat ("GravityControl"); 
					if (gravityControl > 0)
						rb.useGravity = false;	
									
					Ray ray = new Ray (transform.position + Vector3.up, -Vector3.up);
					RaycastHit hitInfo = new RaycastHit ();
					if (Physics.Raycast (ray, out hitInfo)) {
						if (hitInfo.distance > useCurvesHeight) {
							col.height = orgColHight - jumpHeight;			
							float adjCenterY = orgVectColCenter.y + jumpHeight;
							col.center = new Vector3 (0, adjCenterY, 0);	
						} else {				
							resetCollider ();
						}
					}
				}			
				anim.SetBool ("Jump", false);
			}
		}

		else if (currentBaseState.nameHash == idleState) {
			if (useCurves) {
				resetCollider ();
			}
			if (Input.GetButtonDown ("Jump")) {
				anim.SetBool ("Rest", true);
			}
		}

		else if (currentBaseState.nameHash == restState) {
			if (!anim.IsInTransition (0)) {
				anim.SetBool ("Rest", false);
			}
		}
		UpdateLookJoystick();
	}

	void resetCollider ()
	{
		col.height = orgColHight;
		col.center = orgVectColCenter;
	}

	void UpdateLookJoystick()
	{
		float hoz = lookJoystick.Horizontal;
		float ver = lookJoystick.Vertical;
		Vector2 convertedXY = ConvertWithCamera(Camera.main.transform.position, hoz, ver);
		Vector3 direction = new Vector3(convertedXY.x, 0, convertedXY.y).normalized;
		Vector3 lookAtPosition = transform.position + direction;
		transform.LookAt(lookAtPosition);
	}


	private Vector2 ConvertWithCamera(Vector3 cameraPos, float hor, float ver)
	{
		Vector2 joyDirection = new Vector2(hor, ver).normalized;
		Vector2 camera2DPos = new Vector2(cameraPos.x, cameraPos.z);
		Vector2 playerPos = new Vector2(transform.position.x, transform.position.z);
		Vector2 cameraToPlayerDirection = (Vector2.zero - camera2DPos).normalized;
		float angle = Vector2.SignedAngle(cameraToPlayerDirection, new Vector2(0, 1));
		Vector2 finalDirection = RotateVector(joyDirection, -angle);
		return finalDirection;
	}

	public Vector2 RotateVector(Vector2 v, float angle)
	{
		float radian = angle * Mathf.Deg2Rad;
		float _x = v.x * Mathf.Cos(radian) - v.y * Mathf.Sin(radian);
		float _y = v.x * Mathf.Sin(radian) + v.y * Mathf.Cos(radian);
		return new Vector2(_x, _y);
	}
}
