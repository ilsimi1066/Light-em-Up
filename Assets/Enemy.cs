using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int hp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void decrease_hp()
    {
        hp--;
        if (hp <= 0 )
        {
            GameObject.Destroy(gameObject);
        }
    }
}
