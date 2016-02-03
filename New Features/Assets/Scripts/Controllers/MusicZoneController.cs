using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class MusicZoneController : MonoBehaviour
{
	public AudioMixer audioMixer;
	public AudioMixerSnapshot snapshot;

	void OnTriggerEnter( Collider col )
	{
		AudioMixerSnapshot[] ams = new AudioMixerSnapshot[1]{snapshot};
		if(audioMixer != null)
		{
			audioMixer.TransitionToSnapshots( ams, new float[1]{1.0f}, 1.0f );
		}
	}
}
