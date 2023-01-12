using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuncilinVirus : MonoBehaviour
{

    public GameObject virus;
    public float waktuMinimal, waktuMaximal;
    public float posisiMinimal, posisiMaximal;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MunculVirus()
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(posisiMinimal,posisiMaximal)
        , Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMinimal,waktuMaximal));
        StartCoroutine(MunculVirus());
    }
}
