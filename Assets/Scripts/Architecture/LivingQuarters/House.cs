using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Architecture.References;

namespace Architecture
{
    public class House : MonoBehaviour
    {
        private HouseRefs houseRefs = null;

        public void OnConstruct()
        {
            houseRefs = new HouseRefs();
        }
    }
}