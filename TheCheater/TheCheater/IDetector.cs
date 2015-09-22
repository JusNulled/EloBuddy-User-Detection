using System;
using System.Collections.Generic;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using SharpDX;

namespace TheCheater
{
    public enum DetectorSetting { Preferred, Safe, AntiHumanizer} // Just Menu settings
    interface IDetector
    {
        void Initialize(Obj_AI_Hero hero, DetectorSetting setting = DetectorSetting.Safe);
        void ApplySetting(DetectorSetting setting);
        void FeedData(Vector3 targetPos);
        int GetScriptDetections();
        string GetName();
    }
}
