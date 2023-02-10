using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alexis
{

    public class DetectObject : MonoBehaviour
    {
        public float i = 0f;
        private GameObject currentTouchedObject;

        private bool paolo = true;
        void Update()
        {
            if (Input.touchCount > 0)
            {

                var tempVector = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, Camera.main.nearClipPlane);//On recupere la position du doigt

                var tempRay = Camera.main.ScreenPointToRay(tempVector); // On Converti la position du doigt en rayon qui va vers l'avant dans le mondedu jeu

                RaycastHit tempHit; //On cr�e un ensemble d'info de raycast 

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
                var componentGoToSceneOfGameObject = currentTouchedObject.GetComponent<GoToScene>();
                var componentActivateReverseModeOfGameObject = currentTouchedObject.GetComponent<ActivateReversemode>();
                var componentLaunchSceneOfGameObject = currentTouchedObject.GetComponent<LaunchScene>();
                var componentJoyStickOfGameObject = currentTouchedObject.GetComponent<JoystickDef>();
                if (componentMoveOfGameObject != null) //Si le component move Existe

                {
                    Debug.Log("Ca marche");
                    //Alors on fait des trucs 
                    //componentMoveOfGameObject.OnTouch();


                }
                ////////////////////////////////////////////////
                if (componentAttackOfGameObject != null)
                {
                    componentAttackOfGameObject.Update();
                    Debug.Log("BBBBBBBBBBBBBBBBBBH");
                }
                ///////////////////////////////////////////////

                if (componentJoyStickOfGameObject != null)
                {
                    componentJoyStickOfGameObject.Update();
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

               

            }

            else

            {
                

            }
        }
    }
}
