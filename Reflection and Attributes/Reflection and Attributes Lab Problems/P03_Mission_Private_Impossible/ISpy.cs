﻿namespace Stealer
{
    public interface ISpy
    {
        string StealFieldInfo(string investigate, params string[] arr);

        string AnalyzeAcessModifiers(string className);

        string RevealPrivateMethods(string className);
    }
}
