
using UnityEngine;
public class CameraFollow : MonoBehaviour
{

    public Transform Sam;

    // Update is called once per frame
    void Update()
    {
        transform.position = Sam.transform.position + new Vector3(0, 1, -5);
    }
}

