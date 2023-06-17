using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;




public class GoToTarget : MonoBehaviour
{

    public GameObject[] hentaigames;
    private int hentaigamesIndex = 0;

    public GameObject target;
    private NavMeshAgent agent;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(hentaigames[hentaigamesIndex].transform.position);
       if(Vector3.Distance(transform.position, hentaigames[hentaigamesIndex].transform.position) > 1f)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
            hentaigamesIndex++;
            if (hentaigamesIndex >= 4)
            {
                hentaigamesIndex = 0;
            }

        }


    }
}
