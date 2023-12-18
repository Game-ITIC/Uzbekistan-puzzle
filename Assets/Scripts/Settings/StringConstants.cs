﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// If you ever have to hard-code strings in any script, you can instead
/// define them here which should keep refactoring them less of a headache.
/// And hopefully this class doesn't get out of control lol.
/// </summary>
public class StringConstants
{
    public class SceneNames
    {
        public const string RootSceneName = "Root";
        public const string MainMenuScene = "MainMenu";

        public const string TutorialSceneName = "Tutorial";
        public const string Level1 = "Level1";

        public const string ThankYou = "Thanks";
    }

    public class Input
    {
        public const string ActivateButton = "Controller_B";
        public const string DeactivateButton = "Controller_X";
        public const string JumpButton = "Controller_A";
        public const string SkipButton = "Controller_A";
        public const string HorizontalMovement = "Horizontal";
        public const string VerticalMovement = "Vertical";
        public const string Start = "Start";
        public const string Back = "Back";
        public const string ResetOne = "LeftBumper";
        public const string ResetTwo = "RightBumper";
        public const string CameraView = "CameraView";
        public const string PauseConfirm = "Controller_A";
        public const string PauseBack = "Controller_B";
    }

    public class Tags
    {
        public const string CrystalTag = "Crystal";
        public const string Player = "Player";
        public const string Water = "Water";
        public const string Platform = "Platform";
        public const string ActivatableWire = "ActivatableWire";
        public const string FireComponent = "FireComponent";
        public const string SlidingDoor = "SlidingDoor";
        public const string StoneBridge = "StoneBridge";
        public const string TutorialTotem = "TutorialTotem";
    }

    public class PrefabPaths
    {
        public const string ManagerPath = "Prefabs/Manager/FlameKeeperManager";
    }
}
