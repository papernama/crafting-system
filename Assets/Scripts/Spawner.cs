using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour{
    public GameObject[] food;
    public GameObject spawnerPrefab;
    public int foodSpawnPointsCount;

    GameObject[] foodSpawnPointsList;

    // Start is called before the first frame update
    void Start(){
        foodSpawnPointsList = new GameObject[foodSpawnPointsCount];
        InitFoodSpawnPoints();
        SpawnFoodItem();
    }

    // Update is called once per frame
    void Update() {

    }

    void SpawnFoodItem() {
        foreach (var point in foodSpawnPointsList) {
            Instantiate(food[Random.Range(0, food.Length)], point.transform.position, Quaternion.identity);
        }
    }

    void InitFoodSpawnPoints() {
        for (int i = 0; i < foodSpawnPointsCount; i++) {
            Vector3 randomScreenPosition =
                Camera.main.ScreenToWorldPoint(
                    new Vector3(
                        Random.Range(0, Screen.width),
                        Random.Range(0, Screen.height),
                        Camera.main.farClipPlane / 2
                    )
                );

            foodSpawnPointsList[i] = Instantiate(spawnerPrefab, randomScreenPosition, Quaternion.identity);
        }
    }
}
