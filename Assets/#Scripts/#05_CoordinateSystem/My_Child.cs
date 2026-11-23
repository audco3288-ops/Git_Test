using UnityEngine;
namespace My_CoordinateSystem
{
    public class My_Child : MonoBehaviour
    {
        private void Update()
        {
            transform.localPosition += new Vector3(0f,0f,1f*Time.deltaTime);
            
        }
    }
}