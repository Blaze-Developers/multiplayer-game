using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MultiLauncher : MonoBehaviourPunCallbacks
{
    void Start()
	{
		Debug.Log("Connecting to Master");
		PhotonNetwork.ConnectUsingSettings();
	}
    public override void OnConnectedToMaster()
	{
		Debug.Log("Connected to Master");
		PhotonNetwork.JoinLobby();
		
	}
    public override void OnJoinedLobby()
	{
		
		Debug.Log("Joined Lobby");		
	}
	public override void OnJoinedRoom()
	{
		MenuManager.Instance.OpenMenu("room");
		

	}
	public override void OnCreateRoomFailed(short returnCode, string message)
	{
		
		MenuManager.Instance.OpenMenu("error");
	}
	
    
    
}
