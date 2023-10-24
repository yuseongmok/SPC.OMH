using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public Transform Player;
    public static float Speed = 3;
    public float curSpeed = 3;

    // 순간이동을 실행할 시간 간격을 정의합니다.
    public float teleportInterval = 05.0f;

    // 순간이동 위치의 반경을 정의합니다.
    public float teleportRadius = 20.0f;

    // Use this for initialization
    void Start()
    {
        // 순간이동 프로세스를 시작합니다.
        InvokeRepeating("TeleportToPlayer", teleportInterval, teleportInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.time < 100 && Speed == 3)
        {
            Speed++;
            curSpeed++;
        }
        else if (GameManager.time < 50 && Speed == 4)
        {
            Speed++;
            curSpeed++;
        }
        else if (GameManager.time < 20 && Speed == 5)
        {
            Speed++;
            curSpeed++;
        }
        GetAngle();
    }

    void GetAngle()
    {
        // 플레이어와의 상대 위치를 계산합니다.
        Vector2 move = new Vector2(Player.transform.position.x, Player.transform.position.z) - new Vector2(transform.position.x, transform.position.z);
        move.Normalize();

        // 적의 회전을 설정하여 플레이어를 향하게 합니다.
        transform.eulerAngles = new Vector3(0, Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg, 0);

        // 적을 이동시킵니다.
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    // 충돌이벤트: 트리거를 벗어났을 때 적의 속도를 증가시킵니다.
    private void OnTriggerExit(Collider other)
    {
        Speed += 4;
    }

    // 충돌이벤트: 트리거에 들어갔을 때 적의 속도를 초기 속도로 재설정합니다.
    private void OnTriggerEnter(Collider other)
    {
        Speed = curSpeed;
    }

    // 적을 플레이어 근처로 순간이동시키는 메서드입니다.
    void TeleportToPlayer()
    {
        // 무작위 위치 오프셋을 생성합니다.
        Vector3 randomOffset = Random.insideUnitSphere * teleportRadius;
        randomOffset.y = 0; // 동일한 높이로 유지하도록 합니다.

        // 적을 플레이어 위치 주변에 순간이동시킵니다.
        Vector3 targetPosition = Player.position + randomOffset;
        transform.position = targetPosition;
    }
}
