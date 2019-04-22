using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnDestroyPlayer : MonoBehaviour
{
    void OnDestroy()
    {
        MainStore.Store.Stop();
    }
}
