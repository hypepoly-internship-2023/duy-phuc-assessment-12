using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.View;

public class ResultController : Controller
{
    public const string RESULT_SCENE_NAME = "Result";

    public override string SceneName()
    {
        return RESULT_SCENE_NAME;
    }

    public void HomeClick()
    {
        Manager.Load(HomeController.HOME_SCENE_NAME);
    }

    public void VoteClick()
    {
        Manager.Load(Popup_VoteController.POPUP_VOTE_SCENE_NAME);
    }
}