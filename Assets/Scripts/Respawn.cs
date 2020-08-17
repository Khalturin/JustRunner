using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    static public void respawn(Transform objPos, Transform startPos) {
        //Debug.Log("respawn");
        objPos.position = startPos.position;
    }
}
