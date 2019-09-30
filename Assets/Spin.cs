 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 public class Spin : MonoBehaviour
 {
     public float spinValue = 90;
         // Use this for initialization
         void Start ()
         {

         }
     
         void Update ()
         {
           transform.Rotate(Vector3.up*spinValue*Time.deltaTime);
         }
 }