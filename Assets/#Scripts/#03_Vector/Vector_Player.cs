using My_LifeCycle;
using Unity.VisualScripting;
using UnityEngine;

namespace My_Vector
{
    public class Vector_Player : MonoBehaviour
    {
        private Transform tr;
        private GameObject player;
        private void Awake()
        {
            player = this.gameObject;
            tr = GetTransform(player);      
        }
        void Start()
        {
            
            tr.position = new Vector3(10f,5f,-1f);

        }
        private Transform GetTransform(GameObject target)
        {
            Transform tr = target.GetComponent<Transform>();
            return tr;
        }

    }
}