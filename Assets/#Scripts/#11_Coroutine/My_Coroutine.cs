using System.Collections;
using UnityEngine;



namespace My_Coroutine
{
    public class My_Coroutine : MonoBehaviour
    {
        //Coroutine(코루틴)

        //동기식 방식 Synchronous
        //비동기식 방식 aSynchronous

        //싱글스레드 환경에서 
        //비동기(동시)로 작업을 처리할 수 있게 해주는 문법
        //IEnumerator
        //yield return을 만나기 전까지의 코드를
        //하나의 작업 단위(IEnumerator)로 만들고
        //코루틴을 작업단위를 하나씩 순서대로 실행시켜주는
        //상태 머신 이라고 정의가능


        //StartCoroutine()은 start에서만 사용
        

        //Caching 캐싱
        //
        private WaitForFixedUpdate waitForFixedUpdate = null;
        private void Awake()
        {
           waitForFixedUpdate = new WaitForFixedUpdate();
        }
        private void Start()
        {
            //StartCoroutine(CoSomeCoroutine());
            StartCoroutine(CoCleanWindow());
            StartCoroutine(CoCleanFloor());
            //작업 겹치기 가능



        
        }

        private IEnumerator CoSomeCoroutine()
        {
            //yield return을 만나기 전까지 
            //어떤 코드가 있는데
            //그 코드를 작업 단위로 봄
            //그래서 그 코드는 yield return을 
            //만나기 전까지 작업을 수행함
            while (true)
            {
                Debug.Log("1");
            yield return waitForFixedUpdate;
            }
            //Debug.Log("2");
        }


        private IEnumerator CoCleanWindow()
        {
            for (int i = 0; i < 10; ++i)
            {
                Debug.Log("철수");
            yield return null;
            }
        }
       
        private IEnumerator CoCleanFloor()
        {
            for (int j = 0; j < 10; ++j)
            {
                Debug.Log("영희");
            yield return null;
            }
        }
       

    }
}