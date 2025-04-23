using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log($"[Frame {Time.frameCount}] {gameObject.name} collided with {collision.gameObject.name}, contacts: {collision.contactCount}");
        Debug.Log("Oouh!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        //the below two comparisons are same
        if(other.tag == "Package" && !hasPackage){
            Debug.Log("Packgae picked up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if(other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Packgae delivered!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }

}
