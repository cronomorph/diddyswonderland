using UnityEngine;
using Photon.Pun;

public class gun : MonoBehaviourPunCallbacks 
  [SerializeField] private GameObject bullet;

    void Update() {
      if (OnMouseDown(0)) {
        PhotonNetwork.Instintiate(bullet.name, base.position, base.rotation);
      }
    }
  
}
