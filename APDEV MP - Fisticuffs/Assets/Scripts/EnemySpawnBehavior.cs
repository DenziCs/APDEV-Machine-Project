using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBehavior : MonoBehaviour
{
    [SerializeField] private GameObject greenBoulder;
    [SerializeField] private GameObject redPage;
    [SerializeField] private GameObject blueBlade;
    [SerializeField] private float spawnInterval;

    public List<GameObject> enemyList;
    private float totalTime = 0f;
    private float timer = 0f;
    private bool bossMode = false;

    private GameObject SpawnEnemy(GameObject templateObject)
    {
        GameObject enemy = GameObject.Instantiate(templateObject, null);
        enemy.SetActive(true);
        this.enemyList.Add(enemy);
        return enemy;
    }

    public void DespawnEnemy(GameObject enemy)
    {
        for (int i = 0; i < this.enemyList.Count; i++)
        {
            if(this.enemyList[i] == enemy)
            {
                this.enemyList.RemoveAt(i);
                break;
            }
        }
        GameObject.Destroy(enemy);
    }

    private void DespawnFleet()
    {
        for(int i = 0; i < this.enemyList.Count; i++)
        {
            GameObject.Destroy(this.enemyList[i]);
        }
        this.enemyList.Clear();
    }

    private void SpawnFleet(int spawnIndex)
    {
        switch (spawnIndex)
        {
            case 0:
                GameObject enemy1 = SpawnEnemy(this.greenBoulder);
                GameObject enemy2 = SpawnEnemy(this.greenBoulder);
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!bossMode)
        {
            this.totalTime += Time.deltaTime;
            this.timer += Time.deltaTime;
            if (this.timer >= this.spawnInterval)
            {
                this.timer = 0f;
                this.DespawnFleet();
                this.SpawnFleet(Random.Range(0, 10));
            }
        }
    }
}