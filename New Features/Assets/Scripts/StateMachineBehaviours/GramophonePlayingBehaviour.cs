using UnityEngine;
using System.Collections;

public class GramophonePlayingBehaviour : StateMachineBehaviour 
{
	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		animator.GetComponent<GramophoneController>().MusicParticleSystem.Play();
		AudioSource audioSource = animator.GetComponent<AudioSource>();
		if( audioSource != null )
		{
			audioSource.loop = true;
			audioSource.Play();
		}
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		animator.GetComponent<GramophoneController>().MusicParticleSystem.Stop();
		AudioSource audioSource = animator.GetComponent<AudioSource>();
		if( audioSource != null )
		{
			audioSource.Stop();
		}
	}
}
