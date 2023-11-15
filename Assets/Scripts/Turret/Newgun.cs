using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newgun : MonoBehaviour
{
    public Transform bulletspawnpoint;
    public GameObject bulletprefab;
    public GameObject gunParticle;

    public AudioSource fireAudio;
    private float timer=0;
    void Start()
    {
        
        //audiosource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    
    void Update()
    {
        timer += Time.deltaTime;
        //float randomnum=Random.Range(0.1f,0.6f);
        //Debug.Log(randomnum);
        if(timer > 1.5f)
        {
            //audiosource.Play(explosion);
            timer = 0; 
            var bullet = Instantiate(bulletprefab, bulletspawnpoint.position, bulletspawnpoint.rotation);
            Instantiate(gunParticle, bulletspawnpoint.position, Quaternion.identity);
            fireAudio.Play();
            bullet.GetComponent<Rigidbody>().velocity = bulletspawnpoint.forward * 30.0f;
        }
        
    }
}
