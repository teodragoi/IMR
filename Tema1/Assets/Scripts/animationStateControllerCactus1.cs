using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateControllerCactus1 : MonoBehaviour
{
    private Animator animator;
    private float Distance;

    public GameObject Cactus1;

    public GameObject Cactus2;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Distance =
            Vector3
                .Distance(Cactus1.transform.position,
                Cactus2.transform.position);

        if(Distance < 2) {
            animator.SetBool("IsInRange", true);
        } else {
            animator.SetBool("IsInRange", false);
        }
    }
}
