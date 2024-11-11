using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCollectibleScript : MonoBehaviour
{


	[SerializeField] private IntEvent OnScoreGained;
	
	[SerializeField] private bool rotate; // do you want it to rotate?

	[SerializeField] private float rotationSpeed;

	[SerializeField] private AudioClip collectSound;

	[SerializeField] private GameObject collectEffect;

	[SerializeField] private int defaultScore = 10;
	
	
	void Update () {

		if (rotate)
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			Collect ();
		}
	}

	public void Collect()
	{
		if(collectSound)
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
		if(collectEffect)
			Instantiate(collectEffect, transform.position, Quaternion.identity);
		
		//GameManager.Instance.IncreaseScore(defaultScore);
		OnScoreGained.Raise(defaultScore);
		

		Destroy (gameObject);
	}
}
