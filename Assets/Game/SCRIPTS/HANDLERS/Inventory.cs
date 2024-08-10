using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Item> inventory = new List<Item>(); // Inicializa la lista
    [SerializeField] private int itemsInInventory;
    [SerializeField] private int maxCapacity;

    // Propiedad para acceder a la lista de inventario
    public List<Item> _inventory
    {
        get => inventory;
        private set => inventory = value;
    }

    public void AddItem(Item item)
    {
        if (_inventory.Count < maxCapacity) // Verifica si hay espacio antes de agregar
        {
            _inventory.Add(item);
            itemsInInventory++;
            Debug.Log($"Se ha añadido el item: {item.name} cuya función es {item.description}");
        }
        else
        {
            Debug.Log("No hay espacio en el inventario");
        }
    }

    public void RemoveItem(Item item)
    {
        if (_inventory.Contains(item))
        {
            _inventory.Remove(item);
            itemsInInventory--;
        }
        else
        {
            Debug.Log("Ese objeto no se encuentra en el inventario");
        }
    }

    public bool ContainsItem(Item item)
    {
        return _inventory.Contains(item);
    }
}

