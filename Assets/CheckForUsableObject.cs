using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForUsableObject : MonoBehaviour
{

    private Camera cam;
    private Transform camTransform;
    private RectTransform currentText;
    private string groupedName;

    public AnimationManager manager;

    public Canvas canvas;

    private void Start()
    {
        cam = GetComponentInChildren<Camera>();
        camTransform = GetComponentInChildren<Transform>();
    }

    void Update()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1f))
        {
            if (hit.transform.tag == "UsableObject") 
            {
                canvas.GetComponent<ToggleCursorText>().UpdateText(hit.transform.name);
                groupedName = canvas.GetComponent<ToggleCursorText>().objectName;
            }
            else
            {
                canvas.GetComponent<ToggleCursorText>().TurnTextOff();
            }

            if (Input.GetButtonDown("Fire1"))
            {
                manager.TriggerAnimation(groupedName);
                //hit.transform.GetComponent<Animator>().SetTrigger(canvas.GetComponent<ToggleCursorText>().objectName);
            }
        }
        else
        {
            canvas.GetComponent<ToggleCursorText>().TurnTextOff();
        }

    }
}
