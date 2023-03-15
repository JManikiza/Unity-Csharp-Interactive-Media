using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Unity.MovingLogic
{

    public class KeyMove : MonoBehaviour
    {
        public CharacterController Character;
        public float speed = 20.0f;
        void Update()
        {
            Vector3 pos = transform.position;

            if (Input.GetKey("w"))
            {
                pos.z += speed * Time.deltaTime;
            }
            if (Input.GetKey("s"))
            {
                pos.z -= speed * Time.deltaTime;
            }
            if (Input.GetKey("d"))
            {
                pos.x += speed * Time.deltaTime;
            }
            if (Input.GetKey("a"))
            {
                pos.x -= speed * Time.deltaTime;
            }
            transform.position = pos;
        }
    }
}
