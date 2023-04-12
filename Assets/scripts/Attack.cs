using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace Alexis
{
    public class Attack : MonoBehaviour
    {
        public GameObject player;
        public int countdown = 0;
        public GameObject Ennemy;
        public int defeatcountdown = 0;
        public VictoryorDefeat vd;
        public ComboProgram cp;
        public ParticleSystem fxDispa;
        public ParticleSystem voix;
        public AudioSource soundEffects;
        public AudioClip cri1;
        public AudioClip cri2;
        public AudioClip cri3;



 public void OnPointerDown(PointerEventData eventData)
        {
            Validate();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            //Unvalidate(true);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (eventData.pointerPress != null)
            {
                Validate();
            }
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (eventData.pointerPress != null)
            {
                //Unvalidate(false);
            }
        }

         public void Validate()
                {
                    // Record initial touch position.
                        var choixCri = Random.Range(1, 4);
                        if (choixCri == 1)
                        {
                            soundEffects.clip = cri1;
                        }
                        if (choixCri == 2)
                        {
                            soundEffects.clip = cri2;
                        }
                        if (choixCri == 3)
                        {
                            soundEffects.clip = cri3;
                        }
                        soundEffects.Play(0);
                        ParticleSystem aaaaa = Instantiate(voix, player.transform.position + new Vector3(1f, 0.7f, 0.33f), player.transform.rotation);
                        aaaaa.Play();
                        if (aaaaa.isPlaying == false)
                        {
                            Destroy(aaaaa);
                        }

                        if (player.GetComponent<VictoryorDefeat>().side == true)
                        {
                        
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
                                        ParticleSystem fxSmoke = Instantiate(fxDispa, other.point, other.transform.rotation);
                                        fxSmoke.Play();
                                        if (fxSmoke.isPlaying==false)
                                        {
                                            Destroy(fxSmoke);
                                        }
                                        cp.comboNumber = 0;
                                        //play anim 
                                        vd.hp = vd.hp - 0.335f;
                                        Destroy(other.transform.gameObject);
                                    }
                                    else
                                    {
                                        ParticleSystem fxSmoke = Instantiate(fxDispa, other.point, other.transform.rotation);
                                        fxSmoke.Play();
                                        if (fxSmoke.isPlaying == false)
                                        {
                                            Destroy(fxSmoke);
                                        }
                                        cp.comboNumber = cp.comboNumber + 1;
                                        //play anim 
                                        Destroy(other.transform.gameObject);
                                    }
                                }
                            }
                        }

                        if (player.GetComponent<VictoryorDefeat>().side == false)
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
                                        
                                        ParticleSystem fxSmoke = Instantiate(fxDispa, other.point, other.transform.rotation);
                                        fxSmoke.Play();
                                        if (fxSmoke.isPlaying == false)
                                        {
                                            Destroy(fxSmoke);
                                        }
                                       
                                        cp.comboNumber = 0;
                                        vd.hp = vd.hp - 0.335f;
                                        Destroy(other.transform.gameObject);
                                    }
                                    else
                                    {
                                        
                                        ParticleSystem fxSmoke = Instantiate(fxDispa, other.point, other.transform.rotation);
                                        fxSmoke.Play();
                                        if (fxSmoke.isPlaying == false)
                                        {
                                            Destroy(fxSmoke);
                                        }
                                        cp.comboNumber = cp.comboNumber + 1;
                                        
                                        Destroy(other.transform.gameObject);
                                    }

                                }
                            }
                        }
                        
                }
            }
    }
        // Update is called once per frame
      

                // Handle finger movements based on touch phase.
       


