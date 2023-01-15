using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Laser : MonoBehaviour {


	public GameObject explosion;
	public float speed;
	private Rigidbody2D rigidBody;

	void Start() {
		rigidBody = GetComponent<Rigidbody2D>();
		rigidBody.AddForce(transform.up * speed, ForceMode2D.Impulse);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		GameObject gameExplosion = Instantiate(explosion, transform.position, Quaternion.identity);
		Destroy(gameExplosion, 0.25f);

        if (collision.gameObject.tag == "Enemy"){

			Destroy(gameObject);
        }else if(collision.gameObject.tag == "Player")
        {
			explosion.SetActive(false);

        }

    }
}