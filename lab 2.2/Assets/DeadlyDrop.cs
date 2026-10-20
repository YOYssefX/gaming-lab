using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyDrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function that executes upon trigger (when something collides
    void OnTriggerEnter2D(Collider2D ichigo)
    {

        if (ichigo.tag == "Player")
        //if the collider of the object whose name is Sonic GameOb

        FindObjectOfType<LevelManager>().RespawnPlayer();
    }
}
