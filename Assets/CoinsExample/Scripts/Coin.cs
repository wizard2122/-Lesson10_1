using UnityEngine;

public abstract class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out ICoinPicker coinPicker))
        {
            Debug.Log("������������� ������ ������� �������");
            Debug.Log("������������� vfx");

            AddCoins(coinPicker);

            Destroy(gameObject);
        }
    }

    protected abstract void AddCoins(ICoinPicker coinPicker);
}
