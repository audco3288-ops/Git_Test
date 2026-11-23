using UnityEngine;


namespace My_Collision
{
    public class Collision_Enemy : MonoBehaviour, IDamageable
    {
        private float hp = 100f;

      
        public void OnDamage(float damage)
        {
            hp -= damage;
            Debug.Log("Enemy°¡ ÇÇ°Ý:" + hp);
        }
    }
}