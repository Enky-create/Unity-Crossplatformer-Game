using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { private set; get; }
    [SerializeField] private Transform controllable;
    public IControllable iControllable;
    private void Awake()
    {
        if (controllable.TryGetComponent(out IControllable controllableObject))
        {
            iControllable = controllableObject;
        }
        Instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iControllable.Move(GameInput.Instance.GetInputVectorNormalized());
    }
}
