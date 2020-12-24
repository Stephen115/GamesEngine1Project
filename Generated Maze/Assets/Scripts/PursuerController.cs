using UnityEngine;

[RequireComponent(typeof(Pursuer))]
public class PursuerController : MonoBehaviour
{
    public Transform target;
    //TheGrapIsReady() will be executed when the gameObject receives the "TheGraphIsReady" message
    public void TheGraphIsReady()
    {
        gameObject.GetComponent<Pursuer>().MoveTo(target);
    }

    void Start()
    {
        Invoke("TheGraphIsReady", 30.0f);
    }

}