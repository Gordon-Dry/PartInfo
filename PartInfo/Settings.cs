﻿#if false

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace PartInfo
{
    // http://forum.kerbalspaceprogram.com/index.php?/topic/147576-modders-notes-for-ksp-12/#comment-2754813
    // search for "Mod integration into Stock Settings
    public class PartInfoSettings : GameParameters.CustomParameterNode
    {
        public override string Title { get { return "Part Info"; } } // column heading
        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override string Section { get { return "Part Info"; } }
        public override string DisplaySection { get { return "Part Info"; } }
        public override int SectionOrder { get { return 1; } }
        public override bool HasPresets { get { return false; } }


        [GameParameters.CustomParameterUI("Show Part Name")]
        public bool showPartName = true;

        [GameParameters.CustomParameterUI("Show Part Path")]
        public bool showPartPath = true;

        

        public override void SetDifficultyPreset(GameParameters.Preset preset)
        {
          
        }

        public override bool Enabled(MemberInfo member, GameParameters parameters)
        {
            return true; //otherwise return true
        }

        public override bool Interactible(MemberInfo member, GameParameters parameters)
        {

            return true;
            //            return true; //otherwise return true
        }

        public override IList ValidValues(MemberInfo member)
        {
            return null;
        }

    }
}
#endif