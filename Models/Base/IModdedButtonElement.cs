using System;
using Unity.VisualScripting;
using UnityEngine;

namespace ModdedMenu.Models.Base;

public interface IModdedButtonElement
{
    public event Action? OnClick;
}