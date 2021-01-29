using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientTier1_1 : MonoBehaviour
{
    WorkshopMenager workshopMenager;
    ShopMenager shopMenager;
    UnityEngine.AI.NavMeshAgent agent;

    public float lookRadious = 8f;

    public Transform target;
    public Transform goAwayTarget;

    public string dialogue;
    public string goodByeDialogue;
    public Text dialogueText;
    public Image dialogueBG;


    public int timeForOrder;
    public int orderValue = 12;
    public bool orderComplete;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Hoof")
        {
            workshopMenager.AddOrderValue(orderValue);
            Destroy(other.gameObject);
            orderComplete = true;
        }
    }
    void Start()
    {
        workshopMenager = WorkshopMenager.instance;
        target = ShopMenager.instance.shopTransform.transform; //wywołanie pozycji gracza    
        goAwayTarget = ShopMenager.instance.goAwayTransform.transform;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>(); // wywołanie agenta nawigacji
        agent.SetDestination(target.position);  // ustawienie kierunku dla agenta
        shopMenager = ShopMenager.instance;

        dialogueText.text = dialogue;
    }

    void Update() //sprawdzanie warunków co klatkę
    {
        float distance = Vector3.Distance(target.position, transform.position); // obliczanie dystansu między klientem a sklepem
        if (distance <= agent.stoppingDistance) // jeśli odległość agenta jest mniejsza/równa stoppingDistance
        {
            Invoke("Ordering",1f);   
        }
        if (orderComplete == true)
        {
            GoAway();
        }
    }
    public void Ordering()
    {
        //Debug.Log("Client has arrived!");
        //dialogueBG.enabled = true;
        Invoke("GoAway", timeForOrder);
    }
    public void GoAway()
    {
        //dialogueText.text = goodByeDialogue;
        agent.SetDestination(goAwayTarget.position);
        Invoke("Destroy", 3f);
    }
    public void Destroy()
    {
        shopMenager.ClientIsSpawned = false;
        Destroy(gameObject);
    }
}
