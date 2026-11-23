using UnityEngine;


namespace My_Quaternion
{
    public class My_Item : MonoBehaviour
    {
        // 얼마나 빠르게 회전할건가?
        // ->
        [SerializeField]
        private float rotationSpeed = 0f;


        private void Update()
        {
            // 무슨 축을 기준으로 회전할 것인가?
            // -> Y축으로 
            Quaternion rotation =
                Quaternion.Euler(new Vector3(0f,rotationSpeed, 0f)); 
            
            //Quaternion의 Vector3형태로 값변화 -> eulerAngles
            transform.rotation = Quaternion.Euler(new Vector3(0f,rotationSpeed,0f)*Time.deltaTime);
            transform.rotation = Quaternion.Euler(rotation.eulerAngles*Time.deltaTime);
            

            
        }
    }
}