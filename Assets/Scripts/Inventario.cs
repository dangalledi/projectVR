using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{

    public List<GameObject> objetosInventario = new List<GameObject>();
    // Start is called before the first frame update

    public void AddObject(GameObject objInv)
    {
        objetosInventario.Add(objInv);
    }

    public void RemoveObject(GameObject objInv)
    {
        objetosInventario[objInv.GetInstanceID()] = null;
    }

}
