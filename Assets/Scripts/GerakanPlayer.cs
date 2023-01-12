using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerakanPlayer : MonoBehaviour
{
    public float kecepatan;
    Rigidbody rb;
    public Text scoreUI;
    public Text textgameover;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Bergerak();
    }

    void Bergerak()
    {
        float gerak = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * gerak * kecepatan;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus"))
        {
            Time.timeScale = 0;
            Destroy(gameObject);
            textgameover.gameObject.SetActive(true);
        }
    }
}
