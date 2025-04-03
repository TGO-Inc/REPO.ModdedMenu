using Shared.Game;
using UnityEngine;

namespace ModdedMenu.Models.Base;

public abstract class ModdedUIElement : EarlyMonoBehaviour
{
    internal abstract GameObject Create();
    
    protected override void Awake()
    {
        
    }
}