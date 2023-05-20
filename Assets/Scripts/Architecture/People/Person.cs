using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Architecture.References;

namespace Architecture
{
    public class Person : MonoBehaviour
    {
        WorldObjects worldObjects;
        PersonRefs personRefs;

        void OnSpawn()
        {
            worldObjects.FindHome();
        }
    }
}
