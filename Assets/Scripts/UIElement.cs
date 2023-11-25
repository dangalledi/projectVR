using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class UIElement : MonoBehaviour
{
    public UnityEvent OnXrPointerEnter;
    public UnityEvent OnXrPointerExit;
    private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = CameraPointerManager.Instance.gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick()
    {
        PointerEventData pointeEvent = PlacePointer();
        OnXrPointerEnter?.Invoke();
        ExecuteEvents.Execute(this.gameObject, pointeEvent, ExecuteEvents.pointerClickHandler);
    }
    public void OnPointerEnter()
    {
        PointerEventData pointeEvent = PlacePointer();
        OnXrPointerEnter?.Invoke();
        ExecuteEvents.Execute(this.gameObject, pointeEvent, ExecuteEvents.pointerDownHandler);
    }
    public void OnPointerExit()
    {
        PointerEventData pointeEvent = PlacePointer();
        OnXrPointerEnter?.Invoke();
        ExecuteEvents.Execute(this.gameObject, pointeEvent, ExecuteEvents.pointerUpHandler);
    }

    public PointerEventData PlacePointer()
    {
        Vector3 screePointer = _camera.WorldToScreenPoint(CameraPointerManager.Instance.hitPoint);
        var pointer = new PointerEventData(EventSystem.current);
        pointer.position = new Vector2(screePointer.x, screePointer.y);
        return pointer;
    }

}
