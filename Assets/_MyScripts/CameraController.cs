using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private int minZoom = 5;
    [SerializeField] private int maxZoom = 150;
    private Camera mainCam;
    private Vector3 mousePressedInitialPosition;

    private void Awake() => mainCam = Camera.main;

    private void Start()
    {
        // InputAction x = GameManager.Self.mouseInputControl.MouseActionMap.MousePo000sition;
        GameManager.Self.MouseClick.started += _ =>
        {
            mousePressedInitialPosition = mainCam.ScreenToWorldPoint(GameManager.Self.MousePosition.ReadValue<Vector2>());
            // GameManager.Self.MouseCell = new Vector2Int((int)mousePressedInitialPosition.x, (int)mousePressedInitialPosition.y);
        };
        GameManager.Self.MousePosition.performed += Ctx => CameraMotion(Ctx.ReadValue<Vector2>());
        GameManager.Self.MouseClick.canceled += _ => { mousePressedInitialPosition = Vector3.zero; };
        GameManager.Self.MouseWheel.performed += Ctx => CameraZoom(Ctx.ReadValue<float>());
    }

    private void CameraMotion(Vector2 mousePos)
    {
        if (mousePressedInitialPosition != Vector3.zero)
        {
            transform.position += mousePressedInitialPosition - mainCam.ScreenToWorldPoint(mousePos);
        }
    }

    private void CameraZoom(float value) => mainCam.orthographicSize = Mathf.Clamp(value + mainCam.orthographicSize, minZoom, maxZoom);

    // private void OnDrawGizmos()
    // {
    // Gizmos.DrawSphere(mousePressedInitialPosition, 10F);
    // }

}
