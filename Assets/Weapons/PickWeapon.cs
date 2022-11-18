using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickWeapon : MonoBehaviour
{

    private GameObject player_Rhand;
    private bool follow_player;

    void Start()
    {
        player_Rhand = GameObject.Find("R.hand");
        follow_player = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (follow_player)
        {
            this.gameObject.transform.position = player_Rhand.transform.position;
            this.gameObject.transform.rotation= player_Rhand.transform.rotation;

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            follow_player = true;
        }
    }
}
