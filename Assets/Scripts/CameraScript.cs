using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject player;
    private Vector3 viewDistance = new Vector3(0,2, -6);

    void LateUpdate()
    {
       transform.position = player.transform.position + viewDistance; 
    }
}
