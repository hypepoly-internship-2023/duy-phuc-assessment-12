using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class HomeController : Controller
{
    public const string HOME_SCENE_NAME = "Home";

    public override string SceneName()
    {
        return HOME_SCENE_NAME;
    }

    public void VoteClick()
    {
        Manager.Add(Popup_VoteController.POPUP_VOTE_SCENE_NAME);
    }

    public void SettingsClick()
    {
        Manager.Add(SettingsController.SETTINGS_SCENE_NAME);
    }

    public void PlayClick()
    {
        Manager.Add(LevelController.LEVEL_SCENE_NAME);
    }
}