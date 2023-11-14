using UnityEngine;

namespace Attribute
{
    public class DefaultMove : MonoBehaviour, IMove
    {
        public void Move()
        {
            Debug.Log("Interface is work");
        }
    }
}