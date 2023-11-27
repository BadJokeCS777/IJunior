using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    [SerializeField] private EnemySpawner[] _spawners;

    [ContextMenu(nameof(Spawn))]
    private void Spawn()
    {
        foreach (EnemySpawner spawner in _spawners)
            spawner.Spawn();
    }

    [ContextMenu(nameof(FindSpawners))]
    private void FindSpawners()
    {
        _spawners = GetComponentsInChildren<EnemySpawner>();
    }
}