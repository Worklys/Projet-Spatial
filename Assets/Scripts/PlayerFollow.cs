using UnityEngine;
using UnityEngine.AI;
public class PlayerFollow : MonoBehaviour
{
    public GameObject  player;
    public float speed;
    private float distance;
    public GameObject animator;
    public GameObject Vaisseau;

    private Vector3 screenPoint;
    private Vector3 offset;
    void Start(){
    }

    void Update(){
      distance = Vector2.Distance(transform.position, player.transform.position); /* Calcule la distance */
      Vector2 direction = player.transform.position - transform.position; /* Bouge par rapport au vector2 */
      direction.Normalize();
      float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
      transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);/*tranform la position et effectue le
      deplacement par rapport au player et donc permet de se déplacer sur lui */
      transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }



}
