using UnityEditor.ShaderGraph;
using UnityEditorInternal;
using UnityEngine;

namespace My_Rigidbody
{
    public class RIgidbody_Player : MonoBehaviour
    {
        //Rigidbody(강성물리처리)
        //transform 기반으로 움직임을 처리 -> 프레임 단위로 순간이동의 개념
        // -> 벽뚫문제가 생길 가능성도 있음
        //그래서 rigidbody로 이동을 구현


        private Rigidbody rb = null;
        [SerializeField] private float moveSpeed = 0f;
        [SerializeField] private float jumpPower = 0f;
        //플레이어를 Rigidbodt를 이용해서
        //WASD로 이동시키고
        //Space를 누르면 점프할 수 있게 만들어봄
    
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            Move();
            Jump();
            Debug.DrawRay(transform.position,-transform.up*1.5f,Color.red);//Scene에 Raycast표현
            //              시작위치        ,   방향*길이       , 색
        }

        private void Move()
        {
            //물리처리에서
            //플레이어는 일정한 속도를 가지고 있음
            //3차원에서 속도도 3차원 벡터로 표현할 수 있음
            //키입력에 따라서 어디로, 얼마나 움직여야 하는지
            //Vector를 구해서 Rigidbody의 속력에다가
            //대입해주면 됨
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 dir = transform.forward * vertical + transform.right * horizontal;

            Vector3 nomarlizedDir = dir.normalized;

            Vector3 velocity= new Vector3(
                nomarlizedDir.x*moveSpeed,rb.linearVelocity.y,nomarlizedDir.z*moveSpeed
                );
            rb.linearVelocity = velocity;
        }
        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //바닥에 플레이어가 붙어있는 상태인지를 체크
                //충돌처리 -> bool변수를 활용해서 OnCollisionXXX로 bool값을 변동시켜서
                //RayCast -> 플레이어의 발아래로 RayCast를 쏴서
                // -> 바닥과 레이저가 부딪히는지 체크할것
                // Physics.Raycast(내위치,방향,맞은녀석,레이저길이)
                //내가 , 발아래로, 바닥, 레이저길이
                if (Physics.Raycast(transform.position, -transform.up, out RaycastHit hit, 1.1f))
                {
                    //out이라는 키워드를 통해서 로컬변수를 멤버변수로 반환시켜줌 
             
                    //점프기능 구현
                    //점프하기 직전에 y축의 속도를 순간적으로 0으로 만듬
                    rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
                    rb.AddForce(new Vector3(0f, 1f, 0f) * jumpPower,
                        ForceMode.Impulse);

                }
            }
        }

    }
}