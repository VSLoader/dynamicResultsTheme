using System;
using GMSL;
using UndertaleModLib;
using UndertaleModLib.Models;

namespace dynamicresultstheme;

public class Mod : GMSLMod
{
    // Runs when patching the game when changes are detected.
    public override void Patch()
    {
        Console.WriteLine($"[dynamicResultsTheme]: Running Patch!");
        CreateFunctionFromFile("get_results_theme_ver.gml", "get_results_theme_ver", 0);
        var fn = moddingData.Functions.ByName("gml_Script_get_results_theme_ver");
        var call1 = moddingData.Code.ByName("gml_Object_o_2023results_Create_0").Instructions.Find(i => i.Kind == UndertaleInstruction.Opcode.Call && i.Function.Target.Name.Content == "gml_Script_get_ver_num");
        Console.WriteLine(call1);
        call1.Function.Target = fn;
        Console.WriteLine(call1);

        var call2 = moddingData.Code.ByName("gml_Object_o_2023results_Alarm_0").Instructions.Find(i => i.Kind == UndertaleInstruction.Opcode.Call && i.Function.Target.Name.Content == "gml_Script_get_ver_num");
        Console.WriteLine(call2);
        call2.Function.Target = fn;
        Console.WriteLine(call2);
    }

    // Runs before every startup.
    public override void Start()
    {
    }
}
