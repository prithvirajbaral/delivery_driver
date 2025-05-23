using UnityEngine;


public class Driver : MonoBehaviour {

    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    void Start() {
        // transform.Rotate(0,0,45);
        Debug.Log("Hello World!");
    }
    void  Update() {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "SppedUp") {
            moveSpeed = boostSpeed;
            Debug.Log("Touch speed!");
        }
    }
}

    

