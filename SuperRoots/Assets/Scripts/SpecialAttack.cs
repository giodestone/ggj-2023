using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAttack : MonoBehaviour
{
    public ParticleSystem parsnipAttack;
    public GameObject singleParsnip;
    public static Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.F))
        {
            singleParsnip.gameObject.SetActive(true);
          //  singleParsnip.transform.position = transform.position;
           // parsnipAttack.Play();

        }


  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            print("woo");
            target = other.transform;
        }
    }
}
