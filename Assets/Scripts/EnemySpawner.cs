using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    public void Spawn()
    {
        Instantiate(_enemyPrefab, transform.position, Quaternion.identity, transform);
    }
}