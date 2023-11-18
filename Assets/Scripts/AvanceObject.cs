using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvanceObject : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    public void OnTriggerEnter(Collider other)
    {
        float x = teleportTarget.transform.position.x;
        float z = teleportTarget.transform.position.z;
        thePlayer.transform.position = new Vector3(x, thePlayer.transform.position.y, z);

    }
    public void OnPointerClick()
    {
        float x = teleportTarget.transform.position.x;
        float z = teleportTarget.transform.position.z;
        thePlayer.transform.position = new Vector3(x, thePlayer.transform.position.y, z);
    }


}
