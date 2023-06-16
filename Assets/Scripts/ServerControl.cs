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
        PhotonNetwork.ConnectUsingSettings();//Servera ba�lanma iste�i
        //PhotonNetwork.JoinLobby();//Lobiye ba�lanma
        //PhotonNetwork.JoinRoom("Oda ismi");//�zel bir odaya ba�lanma
        //PhotonNetwork.JoinRandomRoom();//Rastgele bir odaya ba�lanma
        //PhotonNetwork.CreateRoom("Oda ismi", roomOptions);//Oda yaratma
        //PhotonNetwork.JoinOrCreateRoom("Oda ismi", roomOptions);//Oda olu�tur ve ba�lan
        //PhotonNetwork.LeaveRoom();//Odadan ��k
        //PhotonNetwork.LeaveLobby();//Lobiden ��k
    }
    public override void OnConnectedToMaster()
    {
        //Servera ba�lan�nca �al��an callback fonksiyon
        Debug.Log("Servera ba�land�");
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        //Lobby ba�lan�nca �al��an callback fonksiyon
        Debug.Log("Lobiye ba�land�");
        RoomOptions roomOptions = new RoomOptions() { MaxPlayers = 2, IsOpen = true, IsVisible = true };
        PhotonNetwork.JoinOrCreateRoom("Harun", roomOptions,TypedLobby.Default);
    }
    public override void OnJoinedRoom()
    {
        //Odaya ba�lan�nca �al��an callback fonksiyon
        Debug.Log("Odaya ba�land�");
        GameObject player = PhotonNetwork.Instantiate("Player", Vector3.up, Quaternion.identity, 0, null);
        player.GetComponent<PhotonView>().Owner.NickName = "Harun";
    }
    public override void OnLeftRoom()
    {
        //Odadan ayr�l�nca �al��an callback fonksiyon
        Debug.Log("Odadan ayr�ld�");
    }
    public override void OnLeftLobby()
    {
        //Lobiden ayr�l�nca �al��an callback fonksiyon
        Debug.Log("Lobiden ayr�ld�");
    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        //Bir odaya girmeye �al���nca hata olu�ursa �al��an callback fonksiyon
        Debug.Log("Herhangi bir odaya girilemedi");
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        //Rastgele bir odaya girmeye �al���nca hata olu�ursa �al��an callback fonksiyon
        Debug.Log("Rastgele bir odaya girilemedi");
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        //Bir odaya yaratmaya esnas�nda hata olu�ursa �al��an callback fonksiyon
        Debug.Log("Oda olu�turulurken hata olu�tu");
    }

}
