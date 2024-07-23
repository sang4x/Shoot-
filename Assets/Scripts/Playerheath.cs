using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Playerheath : MonoBehaviour
{
    public GameObject Weapon;
    public GameObject enermy;
    public GameObject Player;
    public UnityEvent ondeath;
    [SerializeField] int maxhealth;
    int currenthealth;
    public Healthbar healthbar;
    private void OnEnable()
    {
        ondeath.AddListener(death);
    }
    private void Start()
    {
      
        currenthealth = maxhealth;
        healthbar.Updatebar(currenthealth, maxhealth);
    }
    public void Takedamage(int damage)
    {
     
        
           
            currenthealth -= damage;
            if (currenthealth < 0)
            {
                currenthealth = 0;
                ondeath.Invoke();
                healthbar.Updatebar(currenthealth, maxhealth);
            
        }
    }
    public void death()
    {
        Weapon.SetActive(false);
        Player.SetActive(false);
        enermy.SetActive(false);
    }



    private void Update()
    {
        healthbar.Updatebar(currenthealth, maxhealth);
    }


}


