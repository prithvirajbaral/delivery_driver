using UnityEngine;


public class Driver : MonoBehaviour {

    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;
    void Start() {
        // transform.Rotate(0,0,45);
        Debug.Log("Hello World!");
    }
    void  Update() {
        transform.Rotate(0,0,steerSpeed);
        transform.Translate(0,moveSpeed,0);
    }
}

    

