using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ElementsTooltipUI : MonoBehaviour
{
    Image image;

    public Sprite AirSprite;
    public Sprite FireSprite;
    public Sprite EarthSprite;
    public Sprite WaterSprite;

    public PlayerCharacterController.ELEMENTS NeededElement;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        Sprite newSprite = null;
        switch (NeededElement)
        {
            case PlayerCharacterController.ELEMENTS.AIR:
            newSprite = AirSprite;
            break;
            case PlayerCharacterController.ELEMENTS.FIRE:
            newSprite = FireSprite;
            break;
            case PlayerCharacterController.ELEMENTS.EARTH:
            newSprite = EarthSprite;
            break;
            case PlayerCharacterController.ELEMENTS.WATER:
            newSprite = WaterSprite;
            break;
            case PlayerCharacterController.ELEMENTS.NULL:
            newSprite = AirSprite;
            break;
        }

        if (!image.sprite.Equals(newSprite))
            image.sprite = newSprite;
    }
}
