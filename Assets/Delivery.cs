using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log($"[Frame {Time.frameCount}] {gameObject.name} collided with {collision.gameObject.name}, contacts: {collision.contactCount}");
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        //the below two comparisons are same
        if(other.tag == "Package"){
            Debug.Log("Packgae picked up!");
            hasPackage = true;
        }
        if(other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Packgae delivered!");
            hasPackage = false;
        }
    }

}
