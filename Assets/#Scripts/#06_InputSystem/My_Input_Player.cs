using Unity.Hierarchy;
using UnityEngine;

namespace My_InputSystem
{
    public class My_Input_Player : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;
        // Vector3 dir = Vector3.zero; <--- (삭제) 클래스 레벨에 있던 이 줄을 지워주세요.
        [SerializeField] private float currentPitch = 0f;

        private Camera mainCamera = null;

        private void Awake()
        {
            mainCamera = GetComponentInChildren<Camera>();
            
        }


        private void Update()
        {
            if (Input.GetMouseButtonDown(0)) LockCursor();
            if (Input.GetKeyDown(KeyCode.Escape)) LockCursor();

            MoveWithKey();
            MoveWithAxis();
            Rotate();
        }

        private void MoveWithKey()
        {
            // 1. dir 변수를 지역 변수로 선언하여 매 프레임 (0,0,0)으로 초기화되게 만듭니다.
            Vector3 dir = Vector3.zero;

            if (Input.GetKey(KeyCode.UpArrow))
            { dir += transform.forward; }

            if (Input.GetKey(KeyCode.DownArrow))
            { dir -= transform.forward; }

            if (Input.GetKey(KeyCode.RightArrow))
            { dir += transform.right; }

            if (Input.GetKey(KeyCode.LeftArrow))
            { dir -= transform.right; }

            Vector3 nomarlizedDir = dir.normalized;

            // 2. = (대입)이 아닌 += (더하기 대입)을 사용하여 현재 위치에서 더해지도록 수정합니다.
            transform.position += nomarlizedDir * Time.deltaTime * moveSpeed;
        }

        private void MoveWithAxis()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            Vector3 dir = new Vector3(horizontal, 0f, vertical);
            Vector3 nomarlizedir = dir.normalized;

            Vector3 moveDir = transform.TransformDirection(nomarlizedir);
            transform.position += moveDir * Time.deltaTime * moveSpeed;
        }

        
        private void Rotate()
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            // 1. 카메라 상하 회전 (Pitch - X축)
            // 마우스를 위아래(mouseY)로 움직일 때 시점 조절
            currentPitch -= mouseY * 2f;

            // 고개가 완전히 뒤로 꺾이지 않도록 -90도 ~ 90도로 제한
            currentPitch = Mathf.Clamp(currentPitch, -90f, 90f);

            // 카메라의 로컬 X축에 currentPitch 값을 대입하여 위아래로 회전
            mainCamera.transform.localEulerAngles = new Vector3(currentPitch, 0f, 0f);

            // 2. 플레이어 좌우 회전 (Yaw - Y축)
            // 마우스를 좌우(mouseX)로 움직일 때 플레이어의 몸통을 Y축 기준으로 회전
            float playerRotation = mouseX * 2f;
            transform.Rotate(0f, playerRotation, 0f);
        }
        

        private void LockCursor()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        private void UnLockCursor()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}