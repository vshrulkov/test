using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float force;
    Rigidbody2D BirdRigid;
    // Start is ced before the first frame update

    public GameObject RestartButton;

    void Start()
    {
        Time.timeScale = 1;
        BirdRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BirdRigid.velocity = Vector2.up * force;
         }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            RestartButton.SetActive(true);

        }
    }
}
