using UnityEngine;

public class Bullet : MonoBehaviour {
    [SerializeField] private float speed = 4f;
    [SerializeField] private Rigidbody rb;

    void FixedUpdate() {
         rb.velocity = transform.forward * speed;
    }
  
    void OnCollisionEnter(Collision other) {
          if (other.gameObject.CompareTag("player")) {
            other.health = other.health - 30;
            PhotonNetwork.Destroy(gameObject)
          }
    }
}
