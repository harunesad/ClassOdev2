using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class ServerControl : MonoBehaviourPunCallbacks
{
    //Server-Lobby-Room
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();//Servera baðlanma isteði
        //PhotonNetwork.JoinLobby();//Lobiye baðlanma
        //PhotonNetwork.JoinRoom("Oda ismi");//Özel bir odaya baðlanma
        //PhotonNetwork.JoinRandomRoom();//Rastgele bir odaya baðlanma
        //PhotonNetwork.CreateRoom("Oda ismi", roomOptions);//Oda yaratma
        //PhotonNetwork.JoinOrCreateRoom("Oda ismi", roomOptions);//Oda oluþtur ve baðlan
        //PhotonNetwork.LeaveRoom();//Odadan çýk
        //PhotonNetwork.LeaveLobby();//Lobiden çýk
    }
    public override void OnConnectedToMaster()
    {
        //Servera baðlanýnca çalýþan callback fonksiyon
        Debug.Log("Servera baðlandý");
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        //Lobby baðlanýnca çalýþan callback fonksiyon
        Debug.Log("Lobiye baðlandý");
        RoomOptions roomOptions = new RoomOptions() { MaxPlayers = 2, IsOpen = true, IsVisible = true };
        PhotonNetwork.JoinOrCreateRoom("Harun", roomOptions,TypedLobby.Default);
    }
    public override void OnJoinedRoom()
    {
        //Odaya baðlanýnca çalýþan callback fonksiyon
        Debug.Log("Odaya baðlandý");
        GameObject player = PhotonNetwork.Instantiate("Player", Vector3.up, Quaternion.identity, 0, null);
        player.GetComponent<PhotonView>().Owner.NickName = "Harun";
    }
    public override void OnLeftRoom()
    {
        //Odadan ayrýlýnca çalýþan callback fonksiyon
        Debug.Log("Odadan ayrýldý");
    }
    public override void OnLeftLobby()
    {
        //Lobiden ayrýlýnca çalýþan callback fonksiyon
        Debug.Log("Lobiden ayrýldý");
    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        //Bir odaya girmeye çalýþýnca hata oluþursa çalýþan callback fonksiyon
        Debug.Log("Herhangi bir odaya girilemedi");
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        //Rastgele bir odaya girmeye çalýþýnca hata oluþursa çalýþan callback fonksiyon
        Debug.Log("Rastgele bir odaya girilemedi");
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        //Bir odaya yaratmaya esnasýnda hata oluþursa çalýþan callback fonksiyon
        Debug.Log("Oda oluþturulurken hata oluþtu");
    }

}
