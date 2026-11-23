using UnityEngine;

namespace My_CoordinateSystem
{
    public class My_CoordinateSystem : MonoBehaviour
    {
        //좌표계
        //Global
        //시스템상의 전체적인 기본 좌표계
        //ex. transform.position



        //Local
        //부모의 좌표계를 원점으로 잡음
        //transform이라는 컴포넌트의 1차 parent는 component를 가진 오브젝트
        //-> transform이라는 컴포넌트를 가지고있다 = 본인의 좌표계
        //ex. transform.localposition


        //헬리콥터의 프로펠러와 같이 상위의 존재에 묶여서 그 존재의 transform에 붙어서 기동하는 형태에서 사용
        // -> 본체의 이동이 생기면 같이 이동해서 파츠의 올바른 배치를 가져가야하고, 가져가는 배치에서 구동을 해야한다.
        // 오브젝트의 모델링 파츠를 보게되면 일반적으로 root로 묶게 된다. 그렇기에 디폴트좌표에서 같이 웨이트를 받거나, 행동을 해야하는 부위에 child로 작용시키고, 
        // -> parent에게 움직임에 대한 sc를 붙여주고, 개별로 움직임이나 형태를 local값을 변화시켜 구현


        // 상속관계와 동일하게 자녀가 부모에게 영향을 줄순없음(override/virtual의 개념이 없다는 가정하에)
        // -> parent의 transform이 기준값(zeropoint)으로 작용

    }
}