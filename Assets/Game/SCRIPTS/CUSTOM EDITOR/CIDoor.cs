using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR
// Esta linea indica a que script va a afectar
[CustomEditor(typeof(Door))]
public class CIDoor : Editor // CI = Custom Inspector
{
    private Door _door;

    // Es una funcion que se llama al activar un objeto o seleccionar un objeto
    private void OnEnable() // Al Habilitarse
    {
        _door = (Door)target; // El target es el objeto que tengamos seleccionado en la escena y aparezca en el inspector
    }

    // Este metodo sirve para sobreescribir el inspector
    public override void OnInspectorGUI()
    {
        _door.type = (DoorType)EditorGUILayout.EnumPopup("Door Type", _door.type);
        _door.animator = EditorGUILayout.ObjectField("Door Animator", _door.animator, typeof(Animator), true) as Animator;
        _door.animationName = EditorGUILayout.TextField("Animation to Play", _door.animationName);

        EditorGUILayout.Space();
        EditorGUILayout.Space();


        switch (_door.type)
        {
            case DoorType.Normal:
                break;

            case DoorType.KeyRequired:
                {
                    _door.key = EditorGUILayout.ObjectField("Door's Key", _door.key, typeof(Item), true) as Item;
                    _door.keyUsed = EditorGUILayout.Toggle("Key Used?", _door.keyUsed);
                    break;
                }

            case DoorType.EnergyRequired:
                {
                    GUI.enabled = false;
                    _door.hasEnergy = EditorGUILayout.Toggle("Has Energy", _door.hasEnergy);
                    GUI.enabled = true;
                    break;
                }
        }
    }
}
#endif
