using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject gfx;

    private void Awake()
    {
        gfx.SetActive(false);
    }
}
