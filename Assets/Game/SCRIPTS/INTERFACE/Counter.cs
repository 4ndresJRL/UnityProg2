using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    private PlayerDamage lifePlayer;
    [SerializeField] private GameObject player;

    private void Start()
    {
        lifePlayer = player.GetComponent<PlayerDamage>();
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textMesh.text = "Vida " + lifePlayer.life;
    }
}
