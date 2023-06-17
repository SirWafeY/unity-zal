using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NeedsSystem : MonoBehaviour
{
    private NavMeshAgent NavMesh;



    [SerializeField] private float hungry = -100.0f;
    [SerializeField] private float funn = -100.0f;
    [SerializeField] private float sleep = -100.0f;
    [SerializeField] private GameObject fridge;
    [SerializeField] private GameObject tv;
    [SerializeField] private GameObject bed;
    [SerializeField] private GameObject currentTarget;





    // Start is called before the first frame update
    void Start()
    {
        NavMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        hungry = hungry - 3.0f * Time.deltaTime;
        funn = funn - 2.0f * Time.deltaTime;
        sleep = sleep - 1.0f * Time.deltaTime;

        Hungry();
        Funn();
        Sleep();
    }


    private void Hungry()
    {
        if (hungry < 25 && (!currentTarget || currentTarget == fridge))
        {
            currentTarget = fridge;
            NavMesh.SetDestination(fridge.transform.position);
            float distance = Vector3.Distance(transform.position, currentTarget.transform.position);

            if (distance < 2f)
            {
                hungry = 100f;
                currentTarget = null;
            }

        }
    }
    private void Funn()
    {
        if (funn < 25 && (!currentTarget || currentTarget == tv))
        {
            currentTarget = tv;
            NavMesh.SetDestination(tv.transform.position);
            float distance = Vector3.Distance(transform.position, currentTarget.transform.position);

            if (distance < 2f)
            {
                funn = 100f;
                currentTarget = null;
            }

        }
    }
    private void Sleep()
    {
        if (sleep < 25 && (!currentTarget || currentTarget == bed))
        {
            currentTarget = bed;
            NavMesh.SetDestination(bed.transform.position);
            float distance = Vector3.Distance(transform.position, currentTarget.transform.position);

            if (distance < 2f)
            {
                sleep = 100f;
                currentTarget = null;
            }
        }
    }
}
