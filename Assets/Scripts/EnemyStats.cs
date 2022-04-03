using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class EnemyStats : MonoBehaviour
    {
        public int healthLevel = 10;
        public int maxHealth;
        public int currentHealth;

        Animator animator;

        private void Awake()
        {
            animator = GetComponentInChildren<Animator>();
        }

        void Start()
        {
            maxHealth = SetMaxHealthFromHealthLevel();
            currentHealth = maxHealth;
        }

        public int SetMaxHealthFromHealthLevel()
        {
            maxHealth = healthLevel * 10;
            return maxHealth;
        }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;

            animator.Play("Damage");

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                animator.Play("Dying");
                //Handle Enemy Death
            }
        }
    }
}
