using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameController gameController;


    [SerializeField] private GameObject pipePairPrefab;
    [SerializeField] private float spawnInterval = 1.6f;
    [SerializeField] private float spawnX = 3f;
    [SerializeField] private float minY = -1.5f;
    [SerializeField] private float maxY = 1.5f;

    private float timer;

    void Update()
    {
        if (!gameController.IsPlaying())
            return;

        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            float y = Random.Range(minY, maxY);

            var pipe = Instantiate(pipePairPrefab, new Vector3(spawnX, y, 0f), Quaternion.identity);

            var scoreTrigger = pipe.GetComponentInChildren<ScoreTrigger>();
            if (scoreTrigger != null)
            {
                scoreTrigger.SetGameController(gameController);
            }
        }

        
    }
}

