﻿using UnityEngine;
using Verse;

// ReSharper disable All

namespace RedistHeat
{
    public static class ResourceBank
    {
        public static string StringTargetTemperature    = "TargetTemperature".Translate();
        public static string StringState                = "RedistHeat_State".Translate();

        public static string StringWorking              = "RedistHeat_Working".Translate();
        public static string StringNotWorking           = "RedistHeat_NotWorking".Translate();

        public static string StringWorkingDucts         = "RedistHeat_WorkingDucts".Translate();
        
        public static string StringLowerNetTemperature  = "RedistHeat_LowerNetTemperature".Translate();
        public static string StringUpperNetTemperature  = "RedistHeat_UpperNetTemperature".Translate();

        public static string StringExposeDuct           = "RedistHeat_MustExposeDuct".Translate();
        public static string StringExposeBoth           = "MustPlaceVentWithFreeSpaces".Translate();
        public static string StringExposeHot            = "RedistHeat_MustExposeHotSide".Translate();
        public static string StringExposeCold           = "RedistHeat_MustExposeColdSide".Translate();
        public static string StringAttachToCooler       = "RedistHeat_MustPlaceBackSideOnCooler".Translate();

        public static string StringUIRefreshIDLabel     = "RedistHeat_CommandRefreshID".Translate();
        public static string StringUIRefreshIDDesc      = "RedistHeat_CommandRefreshIDDesc".Translate();
        public static string StringUILockLabel          = "RedistHeat_CommandToggleLock".Translate();
        public static string StringUILockDesc           = "RedistHeat_CommandToggleLockDesc".Translate();

        public static readonly Texture2D UITempRaise    = ContentFinder< Texture2D >.Get( "UI/Commands/TempRaise", true );
        public static readonly Texture2D UITempReset    = ContentFinder< Texture2D >.Get( "UI/Commands/TempReset", true );
        public static readonly Texture2D UITempLower    = ContentFinder< Texture2D >.Get( "UI/Commands/TempLower", true );

        public static readonly Texture2D UIRefreshID    = ContentFinder< Texture2D >.Get( "UI/Commands/TryReconnect", true );

        public static readonly Texture2D UILock         = ContentFinder< Texture2D >.Get( "UI/Commands/Forbidden", true );
    }
}