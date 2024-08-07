using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour, IInteractable
{
    [SerializeField] private Item _item;
    private Inventory inventory;

    private void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    public void Interact()
    {
        inventory.AddItem(_item);
        Destroy(this.gameObject);
    }

}

