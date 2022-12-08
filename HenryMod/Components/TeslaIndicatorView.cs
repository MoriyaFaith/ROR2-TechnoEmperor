using System;
using UnityEngine;

public class TeslaIndicatorView : MonoBehaviour {

    public static Sprite[] rangeSprites = new Sprite[] { HenryMod.Modules.Assets.LoadAsset<Sprite>("texIndicator1Close"),
                                                         HenryMod.Modules.Assets.LoadAsset<Sprite>("texIndicator2Med"),
                                                         HenryMod.Modules.Assets.LoadAsset<Sprite>("texIndicator3Far") };
    public static Sprite allySprite = HenryMod.Modules.Assets.LoadAsset<Sprite>("texIndicatorAlly");
    public static Sprite towerSprite = HenryMod.Modules.Assets.LoadAsset<Sprite>("texIndicatorTowerIcon");

    public static Color[] targetColors = new Color[] { Color.cyan,
                                                       Color.red,
                                                       Color.green };

    public SpriteRenderer indicatorRenderer;
    public GameObject towerIndicator;

    public void SetColor(int currentTarget) {

        indicatorRenderer.color = targetColors[currentTarget];
    }

    public void SetSpriteRange(int currentRange) {
        indicatorRenderer.sprite = rangeSprites[currentRange];
    }
    public void SetSpriteAlly() {
        indicatorRenderer.sprite = allySprite;
    }
    public void SetSpriteTower() {
        indicatorRenderer.sprite = towerSprite;
    }

    public void SetTowerSprite(bool hasTower) {
        towerIndicator.SetActive(hasTower);
    }
}
