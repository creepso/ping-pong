using UnityEngine;

public class player : MonoBehaviour {

public float speed = 20f;
public int score;
public int   power = 600;
private Rigidbody2D rb;

	void Start () {
		rb = GetComponent <Rigidbody2D> ();
	}

	void Update () {
		float moveX = Input.GetAxis ("Horizontal");
		rb.MovePosition (rb.position + Vector2.right * moveX * speed * Time.deltaTime);

		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (new Vector2 (0, power));
		}	
	}

	void OnTriggerEnter2D(Collider2D col) {
		Debug.Log (col.gameObject.name);
		if (col.gameObject.name == "star") {
			Destroy (col.gameObject);
			Debug.Log (score);
			score++;
		}
	}	

		void OnCollisionEnter2D(Collision2D col){
			if (col.gameObject.name == "saw with script") {
				Destroy (gameObject);
			}
			if (col.gameObject.name == "endLevel") {
				Application.LoadLevel ("scene2");
			}
			if (col.gameObject.name == "endLevel2") {
				Application.LoadLevel ("scene5");
			}
			if (col.gameObject.name == "endLevel3") {
				Application.LoadLevel ("scene3");
			}
		}

		void OnGUI(){

	GUI.Box (new Rect(0,0,100,25), "Stars :" +score);

	}

}