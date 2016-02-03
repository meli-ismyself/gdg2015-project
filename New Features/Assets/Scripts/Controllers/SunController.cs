using UnityEngine;
using System.Collections;

public class SunController : MonoBehaviour 
{
	Light sunlight;

	// Use this for initialization
	void Awake () 
	{
		sunlight = gameObject.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey( KeyCode.Alpha1 ))
		{
			transform.Rotate( Vector3.up, -60.0f * Time.deltaTime, Space.World );
		}
		if(Input.GetKey( KeyCode.Alpha2 ))
		{
			transform.Rotate( Vector3.up, 60.0f * Time.deltaTime, Space.World );
		}
		if(Input.GetKey( KeyCode.Alpha3 ))
		{
			sunlight.bounceIntensity -= 8.0f * Time.deltaTime;
			sunlight.bounceIntensity = Mathf.Clamp( sunlight.bounceIntensity, 0.0f, 8.0f );
		}
		if(Input.GetKey( KeyCode.Alpha4 ))
		{
			sunlight.bounceIntensity += 8.0f * Time.deltaTime;
			sunlight.bounceIntensity = Mathf.Clamp( sunlight.bounceIntensity, 0.0f, 8.0f );
		}
	}
}
