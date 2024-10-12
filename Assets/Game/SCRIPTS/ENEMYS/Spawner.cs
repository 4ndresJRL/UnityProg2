using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab;
    [SerializeField] private int cantidadDeZombiesTotal;
    [SerializeField] private int zombieToSpawn;
    [SerializeField] private int spawnedZomnbies;
    [SerializeField] private int maxZombiesInScene;
    [SerializeField] private int zombiesInScene;
    [SerializeField] private float spawnRate;

    [SerializeField] private Queue<GameObject> zombieQueue;

    private void Start()
    {
        StartCoroutine(ObjectPoolingStart());
    }

    IEnumerator ObjectPoolingStart()
    {
        zombieQueue = new Queue<GameObject>();

        for (int i = 0; i < cantidadDeZombiesTotal; i++)
        {
            yield return new WaitForSeconds(0.1f);
            GameObject objeto = Instantiate(zombiePrefab);
            objeto.name = objeto.name = "Zombie" + (i + 1);
            objeto.transform.position = RandomPos();
            zombieQueue.Enqueue(objeto);
            objeto.SetActive(false);
        }
        StartCoroutine(SpawnZombies());


    }

    IEnumerator SpawnZombies()
    {
       
        for (int i = 0; i < zombieToSpawn; i++)
        {
             if (zombiesInScene >= maxZombiesInScene)
            {
                yield return new WaitUntil(() => zombiesInScene < maxZombiesInScene);
            }
            CalledZombie();
            spawnedZomnbies++;
            zombiesInScene++;
            yield return new WaitForSeconds(spawnRate);
        }


    }

    IEnumerator ReturnZombie(GameObject zombie)
    {
        Debug.Log("Que onda");
        yield return new WaitForSeconds(2f);
        zombieQueue.Enqueue(zombie);
        zombie.SetActive(false);
    }

    private GameObject CalledZombie()
    {
        GameObject zombieToSpawn = zombieQueue.Dequeue();
        zombieToSpawn.SetActive(true);
        zombieToSpawn.transform.position = RandomPos();
        return zombieToSpawn;
    }

    [ContextMenu("Matar Zombie Random")]
    public void zombieKilled(GameObject zombie)
    {
        ReturnZombie(zombie);
        zombiesInScene--;
    }

    private Vector3 RandomPos()
    {
        int x = Random.Range(0, 5);
        int y = Random.Range(0, 5);
        int z = Random.Range(0, 5);

        return new Vector3(x, y, z);
    }
}