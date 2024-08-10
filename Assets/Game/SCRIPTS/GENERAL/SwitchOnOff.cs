using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnOff : MonoBehaviour, IInteractable
{

    public bool on = false;
    private MeshRenderer mesh;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    public void Interact()
    {
        on = !on;
        Debug.Log("Chck");
        mesh.enabled = on;
    }

}
