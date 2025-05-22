using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInspector : MonoBehaviour
{
    public float checkDistance = 5f;
    public LayerMask inspectLayer;
    public Text infoText;

    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, checkDistance, inspectLayer))
        {
            Inspectable target = hit.collider.GetComponent<Inspectable>();
            if (target != null)
            {
                infoText.text = $"{target.objectName}\n{target.description}";
            }
        }
        else
        {
            infoText.text = "";
        }
    }
}
