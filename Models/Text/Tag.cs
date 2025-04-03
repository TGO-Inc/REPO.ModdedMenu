using ModdedMenu.Models.Base;
using UnityEngine;

namespace ModdedMenu.Models.Text;

public class Tag : ModdedUIElement, IModdedTextElement
{
    internal override GameObject Create()
    {
        throw new System.NotImplementedException();
    }

    public string Text { get; set; }
}