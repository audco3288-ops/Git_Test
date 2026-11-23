using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using My_LifeCycle;

namespace My_ComponentScan
{
    public class My_ComponentScan : MonoBehaviour
    {
        [Header("오브젝트")]
        //변수를 만들어서 어떤 큐브인지 저장해야함
        [SerializeField]/*직렬화*/private GameObject cubeObject123 = null;
        //컴포넌트 가져오기

        //월드에, cube가 하나 있음
        //이 큐브를 z축 방향으로 서서히 움직이게 하고싶음

        //1. Cube를 찾기
        //2. Cube의 transform(컴포넌트).position의 z의 값을 변경
        //3. GetComponent<타입>()

        private void Awake()
        {
            //Transform이라는 타입을 가진 tr이라는 변수를 생성
            //cubeObject의 Transform컴포넌트를 가져와서 대입시킨다.
            Transform tr = cubeObject123.GetComponent<Transform>();

            Transform tr1 = this.GetComponent<Transform>();
            Debug.Log(tr1.name);
            


            //나의 자식으로 있는
            //player의 Transform 가져오기
            //Transform player_tr = GetComponentInChildren<Transform>();

            //문제점 : 본인도 자식으로 가지게됨 -> 본인의 정보를 가져옴
            
            //-> 자식한테만 있는 컴포넌트를 만들어서 기준점을 찾음
            //-> 즉, Player Object에 Player컴포넌ㅌ를 만들어서 달아주고, 그것을 기준으로 찾아옴
            My_Player player_Component = GetComponentInChildren<My_Player>();
            Transform player_tr = player_Component.GetComponent<Transform>();

            //player 오브젝트가 6개가 됐고, 각각 transform값을 가져오고 싶음
            // -> GetComponent"s"InChildren
            // Array 배열 []
            // idx를 기준으로 나열해서 0~순으로 할당되게

            Transform[] transformArray = GetComponentsInChildren<Transform>();
            for (int i = 0; i < transformArray.Length; ++i)
            {
                print(transformArray[i].name);
            }
            print("---------------------------------------------------------------");
            My_Player[] PlayerArray = GetComponentsInChildren<My_Player>();
            for (int i = 0;i < PlayerArray.Length; ++i)
            {
                print(PlayerArray[i].GetComponent<Transform>().name);
                print(PlayerArray[i].GetComponent<Transform>().position.x);
                print(PlayerArray[i].GetComponent<Transform>().position.y);
                print(PlayerArray[i].GetComponent<Transform>().position.z);
            }
        }
    }
    //FindFirstObjectByType<T>()    ->하이어라키상의 idx를 기준으로 첫번쨰 1개 type을기준으로    \
    //FindAnyObjectByType<T>()      ->하이어라키상의 해당되는 타입의 오브젝트 랜덤1개            | -> 효율이 별로임
    //Find(name)                    -> 이름을 기준으로 찾기(전체를 기준으로 나열하고, 찾게됨)     /
    //FindGameObjectWithTag(오브젝트태그명) -> 태그를 기준으로 서치
    //GetComponentInParent() -> 부모의 컴퍼넌트를 서치
    //
}