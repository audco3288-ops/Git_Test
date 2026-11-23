using JetBrains.Annotations;
using My_InputSystem;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

namespace My_Inputsystem
{
    public class My_InputSystem : MonoBehaviour
    {
        private Camera mainCamera;
        
        private float mouseX;
        private float mouseY;
        private float mouseScroll;
        private void Awake()
        {
        }
        private void Update()
        {
            mouseX = Input.GetAxis("Mouse X");//마우스 변동 X좌표값
            mouseY = Input.GetAxis("Mouse Y");//마우스 변동 Y좌표값
            mouseScroll = Input.GetAxis("Mouse ScrollWheel");//마우스 변동 휠값


            //print($"X:{mouseX},Y:{mouseY},wheel:{mouseScroll}");
            float mouseXRaw = Input.GetAxisRaw("Mouse X");//마우스 변동 X좌표값
            float mouseYRaw = Input.GetAxisRaw("Mouse Y");//마우스 변동 Y좌표값
            float mouseScrollRaw = Input.GetAxisRaw("Mouse ScrollWheel");//마우스 변동 휠값


            //print($"X:{mouseXRaw},Y:{mouseYRaw},wheel:{mouseScrollRaw}");

            //마우스는 keycode =X 
            //0: 좌 / 1:우 / 2:휠
            if (Input.GetMouseButtonDown(0))
            { print("좌클릭"); }
            if (Input.GetMouseButton(2))
            { print("휠을누르는중"); }
            if (Input.GetMouseButtonUp(1))
            { print("우클릭이 해제"); }
            //Axis
            //마우스의 움직임에 따라서 
            //값을 받을 수 있는 기능
            //마우스의 X 좌표 Mouse X라는 유니티자체의 내장된 변수를 사용 
            //마우스의 Y 좌표 Mouse Y라는 유니티자체의 내장된 변수를 사용




            //키보드의 입력상태를 받기
            //W,S를 눌렀을 때, 플레이어가 얼마만큼 빠르게 
            //A,D를 눌렀을 때, 플레이어가 얼마만큼 빠르게 
            //이동해야 하는지
            // -> 이값을 정의할 때 사용

            //-1~1까지의 값을 가짐

            float keyboardX = Input.GetAxis("Horizontal");
            float keyboarY = Input.GetAxis("Vertical");
            //print($"Horizontal:{keyboardX},Vertical:{keyboarY}");

            //}

            float keyboardXRaw = Input.GetAxisRaw("Horizontal");
            float keyboarYRaw = Input.GetAxisRaw("Vertical");
            //print($"Horizontal:{keyboardXRaw},Vertical:{keyboarYRaw}");

            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Z키 눌러짐");
            }
            if (Input.GetKey(KeyCode.Z))
            {
                Debug.Log("Z키 눌러지는중");
            }
            if (Input.GetKeyUp(KeyCode.Z))
            {
                Debug.Log("Z키 떼짐");
            }


        }

    }
}