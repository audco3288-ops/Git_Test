using My_ComponentScan;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

namespace My_Vector
{
    public class My_Vector : MonoBehaviour
    {
        private Vector_Player player = null;
        private Vector_Enemy enemy = null;
        // Vector
        // 힘과 방햐을 가진 수
        // 수의 집합


        // Vector의 연산
        // Vector의 더하기
        // x의 좌표값 하나만으로 위치를 규정가능  -> 1차원 Vector(단일축)
        // x/y의 좌표값으로 위치를 규정가능      -> 2차원 Vector(2D)
        // x/y/z의 좌표값으로 위치를 규정가능    -> 3차원 Vector(3D)

        //구조체(struct)
        Vector3 vector1 = new Vector3(2f, 2f, 0f);
        Vector3 vector2 = new Vector3(2f, 0f, 0f);
        private void Awake()
        {
            enemy = GetComponentInChildren<Vector_Enemy>();
            player = GetComponentInChildren<Vector_Player>();
            
        }
        void Start()
        {
            enemy.Init(player,5f);
            Vector3 vector3 = vector1 + vector2;

            print(vector3);

            // Vector의 뺄셈
            // 같은 타입끼리의 연산
            // 만약, A라는 Vector, B라는 Vector값이 있을때
            // A-B를 하면, 같은 성분끼리 뺀값이 나오고,
            // Vector의 방향을 B가 A를 바라보는 방향으로 설정됨 -로 인한 역방향성이 부여
            Vector3 vector4 = new Vector3(5f, 3f, 0f);
            Vector3 vector5 = new Vector3(1f, 2f, 1f);
            Vector3 vector6 = vector4 - vector5;
            print(vector6);


            //Vector의 힘(Scalar) -> localposition의 단일 진행방향의 값
            //(3f,4f,0f) => 이동한 거리 5 => 피타고라스 법칙 
            //플레이어의 이동방향에 따라 5이동 -> 
            Vector3 vector7 = new Vector3(3f, 4f, 0f);
            float scalar = vector7.magnitude;
            //magnitude제곱근 -> Scalar로 값변환
            //프로퍼티(Property)
            //변수를 함수처럼 사용하는 문법 
            print(scalar);


            //단위Vector 
            Vector3 vector8 = new Vector3(1f,0f,0f);
            Vector3 vector9 = new Vector3(0f,1f,0f);
            Vector3 vector10 = vector8 + vector9;
            float scalar2 = vector10.magnitude;
            print(scalar2);
            //어떤 Vector를 방향은 유지하고,
            //힘은 1로 만드는 과정을 정규화라고 한다.
            // 왜 1로 만드나? 이동하는 각도에 상관없이 같은 이동을 위해서
            Vector3 normarlizedVector = vector10.normalized;
            print(normarlizedVector);

            print(normarlizedVector.magnitude);
        }
    }
    
}
