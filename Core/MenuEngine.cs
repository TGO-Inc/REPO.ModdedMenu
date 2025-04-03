using System;
using System.Linq;
using Shared.Game;
using UnityEngine;

namespace ModdedMenu.Core;

internal class MenuEngine : EarlyMonoBehaviour
{
    private GameObject ButtonPrefab;
    private GameObject MainMenuPrefab;
    
    protected override void Awake()
    {
        MainMenuPrefab = GameObject.Find("/UI/HUD/HUD Canvas/HUD/Menu Holder/Menu Page Main(Clone)");
        ButtonPrefab = GameObject.Find("/UI/HUD/HUD Canvas/HUD/Menu Holder/Menu Page Main(Clone)/Menu Button - Settings");
    }
}
