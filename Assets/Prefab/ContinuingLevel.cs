using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuingLevel : MonoBehaviour

{ private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 1000f;
    [SerializeField] private Transform LevelStart;
    //[SerializeField] private Transform List<Transform> ContinuingLevel;
    [SerializeField] private Transform Transform ContinuingLevel;
    [SerializeField] private Player player;

    private Vector3 lastEndPosition;

    private void Awake()
    {
        lastEndPosition = LevelStart.Find("EndPosition").position;


    }

    private void Update()
    {
        if(Vector3.Distance(player.GetPosition(), lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform lastLevelPartTransform = SpawnLevelPart(lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }

    private Transform SpawnLevelPart(Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(ContinuingLevel, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
