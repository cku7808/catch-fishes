using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] public RectTransform rect_Background;
    [SerializeField] public RectTransform rect_Joystick;

    private float radius;

    [SerializeField] public GameObject go_player;
    [SerializeField] private float moveSpeed = 200.0f;

    private bool isTouch = false;
    private Vector3 movePosition;

    // Start is called before the first frame update
    void Start()
    {
        radius = rect_Background.rect.width * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouch == true && go_player != null)
        {
            go_player.transform.position += movePosition;
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 value = eventData.position - (Vector2)rect_Background.position;

        value = Vector2.ClampMagnitude(value, radius);
        rect_Joystick.localPosition = value;

        float distance = Vector2.Distance(rect_Background.position, rect_Joystick.position) / radius;
        value = value.normalized;
        movePosition = new Vector3(value.x * moveSpeed * distance * Time.deltaTime, value.y * moveSpeed * distance * Time.deltaTime, 0f);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isTouch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isTouch = false;
        rect_Joystick.localPosition = Vector3.zero;
    }
}
