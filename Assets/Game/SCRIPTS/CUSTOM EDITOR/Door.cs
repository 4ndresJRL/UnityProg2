using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public DoorType type;

    public Animator animator;
    public string animationName;

    public Item key;
    public bool keyUsed;

    public bool hasEnergy;

    public Inventory inventory;
    public SwitchOnOff switchOnOff;

    private void Start()
    {

        switch (type)
        {
            case DoorType.Normal:
                {
                    Debug.Log("Puerta normal");
                    break;
                }

            case DoorType.KeyRequired:
                {
                    Debug.Log("Requiere llave");
                    break;
                }

            case DoorType.EnergyRequired:
                {
                    Debug.Log("Requiere energia");
                    break;
                }
        }

        animator = GetComponent<Animator>();
        inventory = FindObjectOfType<Inventory>();
        if (type == DoorType.EnergyRequired)
        {
            switchOnOff = FindObjectOfType<SwitchOnOff>(); // Encuentra el interruptor en la escena
        }
    }

    public void Interact()
    {
        switch (type)
        {
            case DoorType.Normal:
                animator.Play(animationName);
                break;

            case DoorType.KeyRequired:
                if (inventory.ContainsItem(key))
                {
                    animator.Play(animationName);
                    keyUsed = true; // Marca la llave como usada, si lo necesitas
                }
                else
                {
                    Debug.Log("No tienes la llave");
                }
                break;

            case DoorType.EnergyRequired:
                if (switchOnOff != null && switchOnOff.on == true)
                {
                    animator.Play(animationName);
                }
                else
                {
                    Debug.Log("No hay energia para abrir la puerta");
                }
                break;
        }
    }

    [ContextMenu("Toggle Energy")]
    public void ToggleEnergy()
    {
        hasEnergy = !hasEnergy;
    }
}

