using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{

    [SerializeField] private List<Item> inventory;
    [SerializeField] private int itemsInInventory;
    [SerializeField] private int maxCapacity;

    // Get Conseguir
    // Set es configurar, definir, setear
    // Esta variable en si no tiene un valor propio, sino que
    // siempre esta usando el valor al que apunta
    public List<Item> _inventory
    {
        get => inventory;
        private set => inventory = value;
    }

    public void AddItem(Item item)
    {

        _inventory = new List<Item>();

        _inventory.Add(item);
        _inventory.Remove(item);
        _inventory[5] = item;

        if (itemsInInventory < maxCapacity)
        {
            inventory.Add(item);
            itemsInInventory++;
            Debug.Log($"Se ha a�adido el item: {item.name} cuya funcion es {item.description}");
        }
        else
        {
            Debug.Log("No hay espacio en el inventario");
        }
    }

    public void RemoveItem(Item item)
    {
        if (inventory.Contains(item))
        {
            inventory.Remove(item);
            itemsInInventory--;
        }
        else
        {
            Debug.Log("Ese objeto no se encuentra en el inventario");
        }
    }

    public bool ContainsItem(Item item)
    {
        return inventory.Contains(item);
    }


}

