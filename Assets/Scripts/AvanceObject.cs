using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvanceObject : MonoBehaviour
{

    /// <summary>
    /// The material to use when this object is inactive (not being gazed at).
    /// </summary>
    public Material InactiveMaterial;

    /// <summary>
    /// The material to use when this object is active (gazed at).
    /// </summary>
    public Material GazedAtMaterial;


    public CharacterController characterController;
    private Renderer _myRenderer;


    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        SetMaterial(false);

    }

    private void Update()
    {
        characterController.Move(new Vector3(5.0f, 0, 0));
        SetMaterial(false);

    }
    public void OnPointerClick()
    {
        characterController.Move(new Vector3 (5.0f, 0, 0));

    }
    public void OnPointerEnter()
    {
        SetMaterial(true);
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        SetMaterial(false);
    }

    private void SetMaterial(bool gazedAt)
    {
        if (InactiveMaterial != null && GazedAtMaterial != null)
        {
            _myRenderer.material = gazedAt ? GazedAtMaterial : InactiveMaterial;
        }
    }
}
