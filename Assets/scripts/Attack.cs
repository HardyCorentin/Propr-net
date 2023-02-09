using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexis{
public class Attack : MonoBehaviour
{
    public GameObject player;
    public int countdown = 0;
    public GameObject Ennemy;
    public int defeatcountdown = 0;
    public VictoryorDefeat vd;
    public ComboProgram cp;
    public ParticleSystem particleSystem;
    public ParticleSystem voix;
    public AudioSource soundEffects;
    public AudioClip cri1;
    public AudioClip cri2;
    public AudioClip cri3;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        Debug.DrawRay(player.transform.position, player.transform.right * 5f);
        if (Input.touchCount > 1)
        {
            
            Touch touch1 = Input.GetTouch(1);
            
            // Handle finger movements based on touch phase.
            switch (touch1.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                 if (player.GetComponent<VictoryorDefeat>().side == true)
        {
            var choixCri = Random.Range(1,4);
                        if (choixCri==1){
                            soundEffects.clip = cri1;
                        }
                        if (choixCri==2){
                            soundEffects.clip = cri2;
                        }
                        if (choixCri==3){
                            soundEffects.clip = cri3;
                        }
                        soundEffects.Play(0);

            if (Physics.Raycast(player.transform.position, player.transform.right, out var other, 3f))
            {
                Debug.Log("click");
                countdown = countdown + 1;
                if (countdown >= 2)
                {
                    Debug.Log("AH");
                    if (other.collider.GetComponent<EnnemiScript>().side == true)
                    {
                        other.collider.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    if (other.collider.GetComponent<EnnemiScript>().hostile == false)
                    {
                        var choixCri3 = Random.Range(1,4);
                        if (choixCri3==1){
                            soundEffects.clip = cri1;
                        }
                        if (choixCri3==2){
                            soundEffects.clip = cri2;
                        }
                        if (choixCri3==3){
                            soundEffects.clip = cri3;
                        }
                        soundEffects.Play(0);
                        other.collider.GetComponent<EnnemiScript>().movetopoint = 0;
                        voix.transform.position = player.transform.position + new Vector3(0.044f,1f,0.33f);
                        voix.Play();
                        mortEnnemi(other);
                        cp.comboNumber = 0;
                        vd.hp = vd.hp - 0.335f;
                    }
                    else
                    {
                        var choixCri2 = Random.Range(1,4);
                        if (choixCri2==1){
                            soundEffects.clip = cri1;
                        }
                        if (choixCri2==2){
                            soundEffects.clip = cri2;
                        }
                        if (choixCri2==3){
                            soundEffects.clip = cri3;
                        }
                        soundEffects.Play(0);
                        voix.transform.position = player.transform.position + new Vector3(0.044f,1.206f,0.33f);
                        voix.Play();
                        
                      mortEnnemi(other);
                    }
                }
            }
        }

        if (player.GetComponent<VictoryorDefeat>().side ==false)
        {
            if (Physics.Raycast(player.transform.position, -player.transform.right, out var other, 3f))
            {
                countdown = countdown + 1;
                if (countdown >= 2)
                {
                    Debug.Log("AH");
                    if (other.collider.GetComponent<EnnemiScript>().side == false)
                    {
                        other.collider.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    if (other.collider.GetComponent<EnnemiScript>().hostile == false)
                    {
                        voix.transform.position = player.transform.position + new Vector3(0.044f,1.206f,0.33f);
                        voix.Play();
                        particleSystem.transform.position = other.point;
                        particleSystem.Play();
                        //play anim 
                        cp.comboNumber = 0;
                        vd.hp = vd.hp - 0.335f;
                        Destroy(other.transform.gameObject);
                    }
                    else
                    {
                        voix.transform.position = player.transform.position + new Vector3(0.044f,1.206f,0.33f);
                        voix.Play();
                        particleSystem.transform.position = other.point;
                        particleSystem.Play();
                        cp.comboNumber = cp.comboNumber + 1;
                        //play anim 
                        Destroy(other.transform.gameObject);
                    }

                }
            }
        }
                    break;
            }
    }
   
}
    void mortEnnemi(RaycastHit other){
        particleSystem.transform.position = other.point;
        particleSystem.Play();
        Destroy(other.transform.GetComponent<EnnemiScript>().dechet);
        Destroy(other.transform.gameObject);
        // other.collider.GetComponent<EnnemiScript>().destroyDechet=true;
        // other.collider.GetComponent<EnnemiScript>().Throw();
    }   
}
}
