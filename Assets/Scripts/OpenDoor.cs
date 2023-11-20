using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public bool doorOpen = true;
    public float doorAngle =  0.0f;
    public float doorCloseAngle = 95f;
    public float smooth = 3.0f;
    public Inventario inventario;
    public GameObject player;

    public GameObject LLave;
    // Start is called before the first frame update
    void Start()
    {
        doorOpen = true;
        inventario = inventario.GetComponent<Inventario>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!doorOpen)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorCloseAngle, 0);
            gameObject.transform.rotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
            LLave.SetActive(false);
            inventario.RemoveItem(LLave.GetComponent<Item>().ID);
        }

    }

    public void ActivarObjeto()
    {
        if (LLave.activeSelf) doorOpen = false;
    }
}
