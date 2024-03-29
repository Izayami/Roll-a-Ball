﻿  using UnityEngine;
 using System.Collections;

 public class ObstacleMove : MonoBehaviour {
     private Vector3 pos1 = new Vector3(16,1,5);
     private Vector3 pos2 = new Vector3(31,1,5);
     public float speed = 1.0f;
 
     void Update() {
         transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
     }
 }
