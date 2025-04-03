using System;
using ModdedMenu.Models.Base;
using UnityEngine;

namespace ModdedMenu.Models.Buttons;

public class MenuButtonElementTypeA : ModdedUIElement, IModdedButtonElement
{
    internal override GameObject Create()
    {
        throw new System.NotImplementedException();
    }

    public event Action? OnClick;
}