using UnityEngine;
using System.Collections;

public class DistanceCalc : MonoBehaviour {
	public GameObject sphere1;
	public GameObject sphere2;
	public GameObject L;
	public GameObject LF1;
	public GameObject LF2;
	public GameObject LS1;
	public GameObject LS2;
	public GameObject LS3;
	public GameObject LS4;
	public GameObject LS5;
	public GameObject GC;

	//public GameObject atomicbomb;
	// Use this for initialization
	void Start () {
		L.SetActive(false);
		LF1.SetActive(false);
		LF2.SetActive(false);
		LS1.SetActive(false);
		LS2.SetActive(false);
		LS3.SetActive(false);
		LS4.SetActive(false);
		LS5.SetActive(false);
		GC.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (sphere1.transform.position, sphere2.transform.position);

		if (distance > 3f) {
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
		if (distance > 4.5f) {
			Debug.Log ("Level 6");
			L.SetActive(false);
			LF1.SetActive(false);
			LF2.SetActive(false);
			LS1.SetActive(false);
			LS2.SetActive(false);
			LS3.SetActive(false);
			LS4.SetActive(false);
			LS5.SetActive(false);
			GC.SetActive(false);
		}
		if (3.5f <= distance && distance < 4f) {
			Debug.Log ("Level 5");
			L.SetActive(true);
			LF1.SetActive(false);
			LF2.SetActive(false);
			LS1.SetActive(false);
			LS2.SetActive(false);
			LS3.SetActive(false);
			LS4.SetActive(false);
			LS5.SetActive(false);
			GC.SetActive(false);
		}
		if (3f <= distance && distance < 3.5f) {
			Debug.Log ("Level 4");
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(false);
			LS1.SetActive(false);
			LS2.SetActive(false);
			LS3.SetActive(false);
			LS4.SetActive(false);
			LS5.SetActive(false);
			GC.SetActive(false);
		}
		if (2.5f <= distance && distance < 3f) {
			Debug.Log ("Level 3");
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(true);
			LS1.SetActive(false);
			LS2.SetActive(false);
			LS3.SetActive(false);
			LS4.SetActive(false);
			LS5.SetActive(false);
			GC.SetActive(false);
		}
		if (2f <= distance && distance < 2.5f) {
			Debug.Log ("Level 2");
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(true);
			LS1.SetActive(true);
			LS2.SetActive(false);
			LS3.SetActive(false);
			LS4.SetActive(false);
			LS5.SetActive(false);
			GC.SetActive(false);
		}
		if ( 1.5f <= distance && distance < 2f) {
			Debug.Log ("Level 1");
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(true);
			LS1.SetActive(true);
			LS2.SetActive(true);
			LS3.SetActive(false);
			LS4.SetActive(false);
			LS5.SetActive(false);
			GC.SetActive(false);
		}
		if (1f < distance && distance < 1.5f) {
			Debug.Log ("Level 0");
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(true);
			LS1.SetActive(true);
			LS2.SetActive(true);
			LS3.SetActive(true);
			LS4.SetActive(true);
			LS5.SetActive(true);
			GC.SetActive(false);

		} 
		if (0.1f > distance) {
			Debug.Log ("Bomb goes off");
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(true);
			LS1.SetActive(true);
			LS2.SetActive(true);
			LS3.SetActive(true);
			LS4.SetActive(true);
			LS5.SetActive(true);
			GC.SetActive(true);
			//GC.transform.position = Vector3.MoveTowards(GC.transform.position, new Vector3(-10,75,0), 5*Time.deltaTime); // Vector3.zero
		} 
		Debug.Log (distance);
	}
}
