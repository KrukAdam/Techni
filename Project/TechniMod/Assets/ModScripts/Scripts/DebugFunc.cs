using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModScripts
{
    public class DebugFunc : MonoBehaviour
    {
        public Rigidbody rb;

        [SerializeField] private float gizmoRange = 3f;

        private int debugInt;

        void Start()
        {
            Debug.Log("LOG " + debugInt);

            Debug.LogWarning($"[Inventory] WARNING {debugInt}");

            Debug.LogError($"[TEMP] ERROR {debugInt * debugInt}");
        }

        private void OnDrawGizmos()
        {
            //Rysuje ko³o wizualnie.
            //Przydaje siê np. do zobrazowania zasiêgu broni bia³ej
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(transform.position, gizmoRange);
        }

        private void OnDrawGizmosSelected()
        {
            //Rysuje ko³o wy³¹cznie wtedy gdy obiekt jest
            //zaznaczony na scenie
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, gizmoRange * 2);
        }

    }

}
