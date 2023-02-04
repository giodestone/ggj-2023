using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private int enemyHealth = 5;
    bool enemyVulnerableToBreath = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnParticleCollision(GameObject TargetedParticle)
    {
        if (enemyVulnerableToBreath)
            StartCoroutine(damageEnemy());
        print("particle col");
        
    }

    IEnumerator damageEnemy()
    {
        enemyHealth -= 1;
        enemyVulnerableToBreath = false;
        yield return new WaitForSeconds(1);
        enemyVulnerableToBreath = true;

    }

    }
