using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorscript : MonoBehaviour
{
    [SerializeField]
    GameObject DoorType;

    Manager gm;

    public int nexLevel;

    private void OnTriggerEnter(Collider col)
    {
        gm.LoadNextLevel(nexLevel);
    }
}
