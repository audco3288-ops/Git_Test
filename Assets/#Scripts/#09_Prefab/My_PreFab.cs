using UnityEngine;


namespace My_Prefab
{
    public class My_PreFab : MonoBehaviour
    {
        //Prefab
        //Item을 소환 -> 
        //A라는 item을 2개 소환 ->


        //1. 어떤 오브젝트를 소환할것인가?
        [SerializeField]private GameObject item = null;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                //아이템을 하나 소환할거임
                //Instantiate(소환할 오브젝트, 위치(transform.position값), 회전값)
                //GameObject go = Instantiate(item, 
                //    new Vector3(0f,3f,-1f),
                //    Quaternion.identity);

                //Random.Range(최솟값,최대값)
                //space를 눌렀을 때, 랜덤한 위치에 소환할거고,
                //아이템의 색상이 변하게
                float randomX = Random.Range(-5f, 5f);
                float randomY = Random.Range(-5f, 5f);
                float randomZ = Random.Range(-5f, 5f);

                GameObject go = Instantiate(item,
                   new Vector3(randomX, randomY, randomZ),
                   Quaternion.identity);
                MeshRenderer renderer = go.GetComponent<MeshRenderer>();
                if(renderer != null)
                {
                    renderer.material.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
                }

            }
        }
    }
}