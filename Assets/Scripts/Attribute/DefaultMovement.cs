using UnityEngine;

namespace Attribute
{
    public class DefaultMovement : MonoBehaviour, IMovement
    {
        public void Move()
        {
            Debug.Log("Interface is work");
        }
    }
}