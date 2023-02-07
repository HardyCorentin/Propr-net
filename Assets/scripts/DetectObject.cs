using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{
    public Vector3 point;
    public GameObject currentTouchedObject;
    public MoveToPoint movetoPoint;

    void Update()
    {
        if (Input.touchCount > 0)
        {

            var tempVector = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, Camera.main.nearClipPlane);//On recupere la position du doigt
            point = tempVector;
            var tempRay = Camera.main.ScreenPointToRay(tempVector); // On Converti la position du doigt en rayon qui va vers l'avant dans le mondedu jeu

            RaycastHit tempHit; //On crée un ensemble d'info de raycast 

            if (Physics.Raycast(tempRay.origin, tempRay.direction, out tempHit))
            {//on lance le raycast et on lui dit de remplire les infos avec ce qu'il touche

                currentTouchedObject = tempHit.collider.gameObject; //On recupere le game object touch� depuis les infos
                Debug.Log(currentTouchedObject);
                Debug.Log(tempHit);
            }

            var componentMoveOfGameObject = currentTouchedObject.GetComponent<Move>(); //On recupere le component move de l'objet
            /*Debug.Log(currentTouchedObject.GetComponent<Transform>());
            Debug.Log(currentTouchedObject.GetComponent<Move>());
            Debug.Log(currentTouchedObject.GetComponent<SpriteRendrer>());*/
            var componentAttackOfGameObject = currentTouchedObject.GetComponent<Attack>();
            var componentGoToSceneOfGameObject = currentTouchedObject.GetComponent<GoToSCENE>();
            var componentActivateReverseModeOfGameObject = currentTouchedObject.GetComponent<ActivateReversemode>();
            var componentLaunchSceneOfGameObject = currentTouchedObject.GetComponent<LaunchScene>();
            if (componentMoveOfGameObject != null) //Si le component move Existe

            {
                Debug.Log("Ca marche");
                //Alors on fait des trucs 
                componentMoveOfGameObject.OnTouch();


            }
            ////////////////////////////////////////////////
            if (componentAttackOfGameObject != null)
            {
                componentAttackOfGameObject.Update();
                Debug.Log("BBBBBBBBBBBBBBBBBBH");
            }
            ///////////////////////////////////////////////
            if (componentGoToSceneOfGameObject != null)
            {
                componentGoToSceneOfGameObject.OnTouch();
            }
            if (componentActivateReverseModeOfGameObject != null)
            {
                componentActivateReverseModeOfGameObject.onTouch();
            }
            if (componentLaunchSceneOfGameObject != null) //Si le component move Existe

            {
                Debug.Log("Ca marche");
                //Alors on fait des trucs 
                componentLaunchSceneOfGameObject.OnTouch();
            }

            movetoPoint.OnTouch(tempHit.point);


            /*
            var componentOfGameObject = gameObject.GetComponent<MonComponent>(); //On recupere le component move de l'objet
            if (componentOfGameObject != null) //Si le component move Existe
            {
                //Alors on fait des trucs 
                componentOfGameObject.MaFonction();
            }
            */

        }

        else

        {
            /// //////////////////////////////
            if (currentTouchedObject != null)
            {
                Debug.Log("BANANAAAAAAAAAAAAAAA8");
                var componentMoveOfGameObject = gameObject.GetComponent<Move>(); //On recupere le component move de l'objet
                Debug.Log("BANANAAAAAAAAAAAAAAA9");
                if (componentMoveOfGameObject != null)

                {
                    Debug.Log("BANANAAAAAAAAAAAAAAA10");
                    componentMoveOfGameObject.TouchUp();
                }
                else
                {
                    Debug.Log("BANANAAAAAAAAAAAAAAA11");
                    currentTouchedObject = null;
                }
            }

        }

    }
}
