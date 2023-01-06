using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreen : MonoBehaviour
{
    public GameObject fX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {

            var tempVector = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, Camera.main.nearClipPlane);//On recupere la position du doigt

            var tempRay = Camera.main.ScreenPointToRay(tempVector); // On Converti la position du doigt en rayon qui va vers l'avant dans le mondedu jeu

            RaycastHit tempHit; //On cr�e un ensemble d'info de raycast 

            fX clone = Instantiate(fX, tempHit.position, tempHit.rotation);
        }
}
