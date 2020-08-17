using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    private GameObject player;

    public float cameraShift;

    public float min_X = -0.7f;
    public float max_X = -0.7f;
    
    public float min_Y = -15.0f;
    public float max_Y =  55.5f;
    private Vector3 camPos = Vector3.zero;
    
    private void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
//        Vector3 camPos = new Vector3(player.transform.position.x, player.transform.position.y + cameraShift, cameraShift);
        
        if(player != null)
            camPos = new Vector3(player.transform.position.x, player.transform.position.y, cameraShift);
        else {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        
//        if (camPos.x <= min_X) camPos.x = min_X; // перемещение в рамках одного экрана по ширине
//        if (camPos.y <= min_Y) camPos.y = min_Y;
//
//        if (camPos.x >= max_X) camPos.x = max_X;// перемещение в рамках одного экрана по ширине
//        if (camPos.y >= max_Y) camPos.y = max_Y;
        
        transform.position = camPos;
    }
}
