using UnityEngine;
using System.Collections;

public class GramophoneController : MonoBehaviour 
{
	public ParticleSystem MusicParticleSystem;
	private GameObject player;
	private Animator animator;
	private int isPlaying;

	// Use this for initialization
	void Awake () 
	{
		player = GameObject.Find( "Player" );
		animator = gameObject.GetComponent<Animator>();
		isPlaying = Animator.StringToHash( "isPlaying" );
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if player exists
		if( player != null)
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				//if we are less than 4 units from the gramophone
				if( Vector3.Distance( this.transform.position, player.transform.position ) < 4.0f )
				{
					Debug.Log("Toggle Play on Gramophone");
					animator.SetBool( isPlaying, !(animator.GetBool( isPlaying )));
				}
			}
		}
	}
}
