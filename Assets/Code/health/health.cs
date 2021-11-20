using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
   [SerializeField] private float startinghealth;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startinghealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startinghealth);

        if(currentHealth==0)
        {
            SceneManager.LoadScene("GameDevSolo 1");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            TakeDamage(1);
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startinghealth);
    }

}
