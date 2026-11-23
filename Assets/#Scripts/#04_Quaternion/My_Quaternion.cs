using UnityEngine;

namespace My_Quaternion
{
    //Quaternion(회전값)
    //Ratation/Eular의 상위형태
    // 
    
    public class My_Quaternion : MonoBehaviour
    {

        private void Start()
        {
           //transform.rotation = new Vector3 (90,90,0);
           //-> X 
           // why? 짐벌락
           // Vector3의 형태에서
           // 그 축마다 회전을 시키다보면
           // 축이 하나로 겹치는 현상이 생김
           // Vector3 -> Vector2가 됨
           // 이러한 현상을 짐벌락이라고 한다.
           // 연산과정이 X축 -> Y축 -> Z축순으로 연산이 되는 과정에서 축의 방향이 겹쳐지는 현상이 생길 수 있음
           // Quaternion이란? 3축의 짐벌현상을 방지하는 w라는 가상의 축을 parent로 xzy를 개별로 조절하는 형태
           //Quaternion rotation1 = Quaternion.Euler(new Vector3 (0f, 90f, 0f));
           // //Quaternion이란? 그럼 [x,y,z]이런식으로 값을 받는 형태가 되는것이고, 그 값을 기반으로 총괄 회전값을 계산하는 형태인가?
           // transform.rotation = rotation1;

           // //Quaternion의 더하기/빼기
           // // *(연산자 오버로딩)
           // // + 연산자를 사용하면 + 즉, 값이 더해지는 형태이고, 각도를 기준으로 전체적인 rotation값에 적용되어서 회전이 들어가야함 -> *를 통해서 값을 재 배열한다.
           // Quaternion rotation2 = Quaternion.Euler(new Vector3 (90f,0f, 0f));
           // Quaternion rotation3 = Quaternion.Euler(new Vector3 (0f,0f, 90f));
           // Quaternion rotation4 = rotation2 * rotation3;
           // transform.rotation=rotation4;
           // print(rotation4);

        }
    }
}