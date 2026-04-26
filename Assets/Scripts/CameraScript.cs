using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject player;
    private Vector3 viewDistance = new Vector3(0,0.33f, -1.1f);

    void LateUpdate()
    {
       Vector3 newPos = player.transform.TransformPoint(viewDistance);
       newPos.y = 2;
       transform.position = newPos;
       Vector3 playerPosWithoutY = player.transform.position;
       playerPosWithoutY.y = 0;
       transform.LookAt(playerPosWithoutY + Vector3.up * 1.5f);
    }
}
