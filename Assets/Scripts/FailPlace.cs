using System;
using System.Collections;
using System.Collections.Generic;
using Pixeye.Actors;
using UnityEngine;

public class FailPlace : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other) {
		//if (other.tag == "Player") {
		//Destroy(other.gameObject);
		//}
//		Respawn.respawn();
		Transform respTrasform = FindObjectOfType<Respawn>().transform;
//		other.gameObject.transform.position = respTrasform.position;
		Respawn.respawn(other.gameObject.transform, respTrasform);
	}
}
