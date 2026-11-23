using UnityEngine;


namespace My_LifeCycle
{
    public class My_LifeCycle : MonoBehaviour
    {
        private Player player = null;
        private float lastFixedUpdateTime = 0f;
        private float lastUpdateTime = 0f;
        //생명주기 - LifeCycle
        //private void Reset()//초기값으로 되돌리기 -> 초기값에 대한 매서드가 있다면 그것이 초기값으로 
        //{
        //    // 컴퍼넌트를 만들다 보면,
        //    // 컴퍼넌트의 초기값을 설정해야 할 때가 있음
        //    // Reset함수에서 초기값을 설정하고,
        //    // 컴퍼넌트를 게임오브젝트에 붙이거나,
        //    // 컴퍼넌트의 메뉴에서 Reset을 누르면
        //    // 이 함수가 실행되게 됨
        //    print("Reset");
        //}
        ////여기서부터
        ////게임이 시작될 때, 관여하는 생명주기 함수
        //private void Awake()
        //{
        //    // play와 동시에 
        //    // 1회성으로 호출되는 형태
        //    // 변수의 초기화 담당 초기설계를 생성 --> 생성자
        //    player = new Player();   
            
        //    print("Awake");
        //}
        //private void OnEnable()
        //{
        //    // play의 형태 -> 모든 오브젝트를 껏다가 켜지는 형태
        //    // 컴퍼넌트의 bool값이 true가 되면 기능
        //    print("OnEnable");
        //}
        private void Start()
        {
            // 컴퍼넌트가 활성화 된 이후 기능을 시작할떄
            // 초기화된 변수를 조작하여 값을 입력
            print("Start");
            player.SetAge(10);
            
        }
        private void FixedUpdate() 
        {
            // 고정된 프레임 단위로 연산이 시작되는 지점
            // 프레임 단위 연산의 시작지점 
            // 연산루프의 갱신점
            // 
            print("연산루프시작/갱신");
            //float current = Time.time;
            //float interval = lastFixedUpdateTime - current;
            //lastUpdateTime = current;
            //print("FixedUpdateInterval"+interval.ToString("F4"));
            

        }
        private void OnTriggerEnter(Collider other)
        {
            
        }
        private void OnCollisionEnter(Collision collision)
        {
            
        }
        private void Update()
        {
            //프레임이 갱신되는 주기로
            //연산이 갱신되었다. 루프로 판단이 완료되었다. 프레임단위연산
            //Time.deltetime이 프레임사이에 걸린 시간이라는 값 
            // time += Time.deltatime; 를 통해 time의 조건부를 걸어 몇초가 지나면 실행 -> time 값 0으로 초기화를 진행하는 식으로 시간에 따른 업데이트주기를 조절
            print("update");
            //float current = Time.time;
            //float interval = lastFixedUpdateTime - current;
            //lastFixedUpdateTime = current;
            //print("updateinterval" + interval.ToString("F4"));
        }
        private void LateUpdate()
        {
            //Update매서드가 실행된 1Frame 이후에
            //이동에 대한 연산이 끝난 이후에 적용되어야 하므로 루프상 마지막에 해당하는 LateUpdate에 카메라의 snap을 담는다
        }
        private void OnDisable()
        {
            //오브젝트의 bool값이 false가 될때
            //SetActive
        }
        private void OnDestroy()
        {
            //오브젝트가 파괴되었을때
            
        }
        
        private void OnApplicationQuit()
        {
            //play가 종료되었을 때 실행
            //save해야하는 데이터를 기록할때
        }

    }
    public class Player
    {
        private int age = 0;
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}