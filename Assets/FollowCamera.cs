using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    //this thing position (car) should be same as the car's position
    [SerializeField] GameObject thingToFollow;
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
    }
}
