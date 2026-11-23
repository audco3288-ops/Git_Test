using UnityEngine;


namespace My_Collision
{
    public class Collision_Player : MonoBehaviour
    {

        float damage = 10f;
        private void OnCollisionEnter(Collision collision)
        {

        

            //Collision
            //충돌한 물체의 정보를 가지는 클래스
            
            //Debug.Log("물체충돌됨"+collision.gameObject.name);
        
            //if(collision.gameObject.CompareTag("Enemy"))
            //{
            ////Tag기준으로 구분
            //    Debug.Log("Enemy에게 데미지를 줌");

            //}
            //Collision_Enemy enemy = collision.gameObject.GetComponent<Collision_Enemy>();
            //if (enemy != null)
            //{
            //    Debug.Log("Enemy에게 데미지를 줌");
            //    enemy.GetDamage(damage);
            //}
            //인터페이스
            //클래스랑 똑같은데,
            //정의가 없음
            // 그냥 그 자식클래스의 틀을 정의 하는 문법 
            //
            IDamageable idamageable = collision.gameObject.GetComponent<IDamageable>();
            //Null conditional 연산자 
            //? 
            if (idamageable != null) {idamageable.OnDamage(damage); }
            //-> idamageable?.OnDamage(damage);
            //와 같은 코드 
        }
        private void OnCollisionExit(Collision collision) 
        { 
            IDamageable idamageable = collision.gameObject.GetComponent<IDamageable>();
            
            if (idamageable != null)  Debug.Log("OnCollisionExit");
        }






        
        //Trigger 체크는
        // 충돌하는 2개의 물체 중에서 
        // 하나만 isTrigger 체크가 되어있으면
        // Trigger 체크를 할 수 있음
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("OnTriggerEnter");
        }
        
    }
}