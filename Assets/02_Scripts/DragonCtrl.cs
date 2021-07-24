using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonCtrl : MonoBehaviour
{
    private float DragonHit = 100.0f;
    private Animator anim;

    private readonly int hashHit = Animator.StringToHash("GetHit");

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("BULLET"))
        {


            anim.SetTrigger(hashHit);
            Destroy(collision.gameObject);

            DragonHit -= 10;
            if(DragonHit <= 0)
            {
                //Dragon Die
            }
            Debug.Log($"DragonHit = {DragonHit}");

        }
    }
}
