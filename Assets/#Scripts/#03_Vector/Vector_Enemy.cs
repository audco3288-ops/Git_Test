using UnityEngine;
using UnityEngine.Rendering;

namespace My_Vector
{
    public class Vector_Enemy : MonoBehaviour
    {
        //Enemy가 Player를 따라다니게 할것
        //필요한 정보
        // 1. 플레이어의 위치 && Enemy의 위치 
        private Vector_Player player;
        private float moveSpeed = 5f;
        private Vector3 destination;
        private Vector3 normalizedVector;
        private float distance;
        
        // 2. 이동하는 속도

        //게으른 초기화라는 기법(Lazy Inittialize)
        //의존성 주입(Dependency Incjection) DI
        public void Init(Vector_Player player,float moveSpeed)
        {
            this.player = player;
            this.moveSpeed = moveSpeed;
        }
        public void SetPlayer(Vector_Player player)
        {
            this .player = player;
        }
        

        private void Update()
        {
            if (this.player != null) return;
            //Update에서 작업할것
            //1. player를 바라보는 Vector를 구해야함
            destination =
                player.transform.position 
                - transform.position;
            distance = destination.magnitude;

            if (distance >= 3)
            {
                normalizedVector = destination.normalized;
                transform.position += normalizedVector * moveSpeed * Time.deltaTime;
            }
        }


        

    }

}