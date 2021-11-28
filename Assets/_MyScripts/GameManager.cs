using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Self { get; private set; }

    private void Awake()
    {
        if (Self != null) return;

        Self = this;
        DontDestroyOnLoad(this);

        mouseInputControl = new MouseInputControl();
    }

    private void OnEnable() => mouseInputControl.Enable();
    private void OnDisable() => mouseInputControl.Disable();

    private MouseInputControl mouseInputControl;
    public InputAction MouseClick { get { return mouseInputControl.MouseActionMap.MouseClick; } }
    public InputAction MousePosition { get { return mouseInputControl.MouseActionMap.MousePosition; } }
    public InputAction MouseWheel { get { return mouseInputControl.MouseActionMap.MouseWheel; } }


    private Map map;
    public bool ValidPositionOnMap(Vector2Int pos)
    {
        return false;
    }
}
