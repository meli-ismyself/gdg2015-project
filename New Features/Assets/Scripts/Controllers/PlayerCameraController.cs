//------------------------------------------------------------------------------
//
// PlayerCameraController
//
// - Takes vertical input from the mouse and converts it into pitch for the
//   player camera.
//
//------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

//------------------------------------------------------------------------------
// class definition
//------------------------------------------------------------------------------
public class PlayerCameraController : MonoBehaviour
{
	//public variables
	public bool invertAxis = false;	
	public float minPitch = -60.0f;
	public float maxPitch = 60.0f;
	public float pitchSensitivity = 1.0f;

	//private variables
	private float pitch = 0.0f;
	
	//--------------------------------------------------------------------------
	// protected mono methods
	//--------------------------------------------------------------------------

	protected void Awake()
	{
		pitch = transform.localEulerAngles.x;
	}

	protected void Update()
	{
		// get input
		float mouseYInput = Input.GetAxis ("Mouse Y");
		Vector3 newAngles = transform.localEulerAngles;

		// calculate pitch
		pitch -= (invertAxis ? -1 : 1) * mouseYInput * pitchSensitivity * Time.deltaTime * 60.0f;
		pitch = Mathf.Clamp(pitch, minPitch, maxPitch);
		newAngles.x = pitch;

		// update rotation
		transform.localEulerAngles = newAngles;
	}

}




