using UnityEngine;

public class CheckColor : MonoBehaviour {
//	private Color color = Color.red;
	public ColorsManager.Ecolor color;

	private void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Player") {
			SpriteRenderer sr = other.gameObject.GetComponent<SpriteRenderer>();
			if (sr.color != ColorsManager.Instance.colors[color]) {
				Transform respTrasform = FindObjectOfType<Respawn>().transform;
				Respawn.respawn(other.gameObject.transform, respTrasform);
				//Debug.Log(color + " " + sr.color);
			}
		}
	}
}
