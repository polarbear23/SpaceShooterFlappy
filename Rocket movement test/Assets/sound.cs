using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {
	public AudioClip bgm;
	private AudioSource source;

	void Awake(){
		source = GetComponent<AudioSource>();
		source.PlayOneShot (bgm);
	}
}
