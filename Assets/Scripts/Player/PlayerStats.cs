using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private float defaultSpeed = 5f;
    private float currentSpeed;

    private void Start()
    {
        currentSpeed = defaultSpeed;
    }

    public void ApplySpeedBoost(ItemData itemData)
    {
        StopAllCoroutines();
        StartCoroutine(SpeedBoostCoroutine(itemData));
    }

    private IEnumerator SpeedBoostCoroutine(ItemData itemData)
    {
        currentSpeed = defaultSpeed * itemData.speedMultiplier;
        Debug.Log("���ǵ� �ν�Ʈ ����");

        yield return new WaitForSeconds(itemData.effectDuration);

        currentSpeed = defaultSpeed;
        Debug.Log("���ǵ� �ν�Ʈ ����");
    }

    public float GetCurrentSpeed()
    {
        return currentSpeed;
    }
}