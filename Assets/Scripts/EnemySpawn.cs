using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

[SerializeField]

  private float spawnRadius = 7, time = 1.5f;/* distance de spawn par rapport au point de spawn */

  public GameObject[] enemies;/* sert à placer les enemies qui seront déployé */

    void Start()
    {

      StartCoroutine(SpawnAnEnemy());/* Petite coroutine qu'on aime oui oui */

    }


      /* declaration de ma ptite coroutine*/
    IEnumerator SpawnAnEnemy(){
      Vector2 spawnPos = GameObject.Find("Player").transform.position;
      spawnPos += Random.insideUnitCircle.normalized * spawnRadius;


      Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
      yield return new  WaitForSeconds(time);
      StartCoroutine(SpawnAnEnemy());
    }
}
