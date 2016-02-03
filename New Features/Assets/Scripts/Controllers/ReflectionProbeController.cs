using UnityEngine;
using System.Collections;

public class ReflectionProbeController : MonoBehaviour 
{
	private ReflectionProbe rp;
	private float lastRenderTime;
	[SerializeField] private float renderRate = 25.0f;

	void Awake () 
	{
		rp = gameObject.GetComponent<ReflectionProbe>();
		lastRenderTime = Time.time - 1.0f/renderRate;
	}

	void Update ()
	{
		if( Time.time - lastRenderTime > 1.0f/renderRate )
		{
			rp.RenderProbe();
			lastRenderTime = Time.time;
		}
	}
}
