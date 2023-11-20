using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public bool doorOpen = true;
    public float doorAngle =  0.0f;
    public float doorCloseAngle = 95f;
    public float smooth = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        doorOpen = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (doorOpen)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorAngle, 0);
            gameObject.transform.rotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth*Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorCloseAngle, 0);
            gameObject.transform.rotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }

    }

    public void ActivarObjeto()
    {
        doorOpen = !doorOpen;
    }
}
