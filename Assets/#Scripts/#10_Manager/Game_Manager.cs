using UnityEngine;
using UnityEngine.SceneManagement;


namespace My_Manager
{
    public class Game_Manager : MonoBehaviour
    {
        //Manager
        //점수를 관리하거나, 특정 오브젝트를 관리할때
        //Manager라는 객체를 사용함
        //지금 보면, Scene1 에서 쌓은
        //점수가 Scene2에서 초기화 된걸 확인가능
        //Unity는 씬을 바꿀때, 모든 오브젝트를 파괴하고,
        //새로 만들기 떄문에 그럼

        //static
        //일반 변수들은 게임이 시작하고, 끝날 때,
        //각자 타이밍 맞게 메모리에 올라감
        //static이 붙은 변수는 게임이 시작할떄,
        //메모리 중에 data 영역이 있는데,
        //거기에 생성
        //그리고 게임 끝날떄 메모리에서 해제됨

        //그리고, 점수를 계산하는 매니저가 씬에
        //여러개가 배치되어 있으면, 어떤 점수가
        //진짜인지 모르게됨
        //즉, 씬에는 1개의 매니저만이 존재해야함
        //이러한 문제를 해결하기 위해서
        //Singleton 패턴이라는 것을 사용함
        // 
        private static Game_Manager instance = null;

        private int score = 0;
        //변순데 함수처럼 쓸 수 있는게 있음
        //프로퍼티(Property)
        public static Game_Manager Instance
        {
            get
            {

                //씬에 같은 게임매니저가 
                //여러개 있는 문제
                //만약에 instance가 null인 경우
                if (instance == null)
                {
                    instance =
                    FindAnyObjectByType<Game_Manager>();
                    if (instance == null)
                    {
                        //그래도 없으면 GameManager를 만들어서 등록하면됨
                        GameObject go = new GameObject();
                        instance = go.AddComponent<Game_Manager>();
                        go.name = "[Singleton]GameManager";

                        DontDestroyOnLoad(go);//씬전환중에 절대 파괴하지마라
                    }
                }
                return instance;
            }
        }
            
                                             //준다 뭐름? instance를 

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Addscore();
            }
            SceneChange();
        }
        public void Addscore()
        {
            score++;
            Debug.Log(score);
        }
        private void SceneChange()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //씬전환
                SceneManager.LoadScene("GameScene");
            }

        }
        //만약, 하이어라키에 Gamemanager가 여러개 있으면
        //그 중에 1개만 instance에 들어가긴 하는데
        //어떤놈이 들어가는지를 모름
        //그래서, 게임이 시작할때, Gamemanger를 
        //한놈만 남게 할것

        //싱글턴 
        //지워지지 않는 하나의 객체만 남기고 싶을 때 사용
        //장점 : 게임매니저와 같이 여러씬에서 공용으로 사용되는 형태
        //- 사용성이 좋음/객체가 하나인 걸 보장(싱글 스레드에서만)
        //단점 : static을 이용해서 게임이 시작과끝까지 계속 오브젝트가 살아있음
        //- 불필요한 데이터가 계속하여 살아있을 수 있음, 데이터 오염이 쉬움(접근이 쉽다)-> 충돌이 일어나기 쉽다.
        private void Awake()
        {
            if(instance == null || instance == this)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else Destroy(gameObject);
        }
        public static Game_Manager GetInstance()
        {
            //씬에 같은 게임매니저가 
            //여러개 있는 문제
            //만약에 instance가 null인 경우
            if(instance==null)
            {
                instance = 
                FindAnyObjectByType<Game_Manager>();
                if (instance == null)
                {
                    //그래도 없으면 GameManager를 만들어서 등록하면됨
                    GameObject go = new GameObject();
                    instance = go.AddComponent<Game_Manager>();
                    go.name = "[Singleton]GameManager";

                    DontDestroyOnLoad(go);//씬전환중에 절대 파괴하지마라
                }
            }
            return instance;
        }
        
    }
}
