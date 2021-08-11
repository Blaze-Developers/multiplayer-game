using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;

public class audioDestroy : MonoBehaviour
{
    PhotonView PV;
    AudioListener aL;
    // Start is called before the first frame update
    void Start()
    {
        aL = GetComponent<AudioListener>();
        PV = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!PV.IsMine)
        {
            aL.enabled = false;
        }
    }
}
