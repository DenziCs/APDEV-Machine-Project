using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBehavior : MonoBehaviour
{
    [SerializeField] private Camera mainCam;
    [SerializeField] private GameObject boss;
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
            case 1:
                GameObject enemy1 = SpawnEnemy(this.greenBoulder);
                Vector3 position = this.mainCam.ViewportToWorldPoint(new Vector3(0.25f, 1.1f, 10f));
                enemy1.transform.position = position;
                GameObject enemy2 = SpawnEnemy(this.greenBoulder);
                Vector3 position2 = this.mainCam.ViewportToWorldPoint(new Vector3(0.5f, 1.1f, 10f));
                enemy2.transform.position = position2;
                GameObject enemy3 = SpawnEnemy(this.greenBoulder);
                Vector3 position3 = this.mainCam.ViewportToWorldPoint(new Vector3(0.75f, 1.1f, 10f));
                enemy3.transform.position = position3;
                break;
            case 2:
                GameObject enemy4 = SpawnEnemy(this.redPage);
                Vector3 position4 = this.mainCam.ViewportToWorldPoint(new Vector3(0.25f, 1.1f, 10f));
                enemy4.transform.position = position4;
                GameObject enemy5 = SpawnEnemy(this.redPage);
                Vector3 position5 = this.mainCam.ViewportToWorldPoint(new Vector3(0.5f, 1.1f, 10f));
                enemy5.transform.position = position5;
                GameObject enemy6 = SpawnEnemy(this.redPage);
                Vector3 position6 = this.mainCam.ViewportToWorldPoint(new Vector3(0.75f, 1.1f, 10f));
                enemy6.transform.position = position6;
                break;
            case 3:
                GameObject enemy7 = SpawnEnemy(this.blueBlade);
                Vector3 position7 = this.mainCam.ViewportToWorldPoint(new Vector3(0.25f, 1.1f, 10f));
                enemy7.transform.position = position7;
                GameObject enemy8 = SpawnEnemy(this.blueBlade);
                Vector3 position8 = this.mainCam.ViewportToWorldPoint(new Vector3(0.5f, 1.1f, 10f));
                enemy8.transform.position = position8;
                GameObject enemy9 = SpawnEnemy(this.blueBlade);
                Vector3 position9 = this.mainCam.ViewportToWorldPoint(new Vector3(0.75f, 1.1f, 10f));
                enemy9.transform.position = position9;
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
                int spawnIndex = Random.Range(0, 4);
                this.SpawnFleet(spawnIndex);
            }

            if(this.totalTime >= 120f)
            {
                this.boss.SetActive(true);
                this.bossMode = true;
            }
        }
    }
}