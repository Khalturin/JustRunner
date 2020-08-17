using System.Collections.Generic;
using Homebrew;
using UnityEngine;


//TODO синглтон от Pixeye 
public class ColorsManager : Singleton<ColorsManager> {
    
    public enum Ecolor {
        Red,
//        White,
        Blue,
//        Green,
        End
    }
    
    public Dictionary<Ecolor, Color> colors;

    // Метод, выполняемый при старте игры
    void Awake() {
        colors = new Dictionary<Ecolor, Color>();
        colors.Add(Ecolor.Red, Color.red);
//        colors.Add(Ecolor.White, Color.white);
        colors.Add(Ecolor.Blue, Color.blue);
//        colors.Add(Ecolor.Green, Color.green);
    }
}