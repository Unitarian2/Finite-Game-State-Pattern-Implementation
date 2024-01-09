using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private List<IconSwappable> iconElementsList;
    [SerializeField] private List<IconSwappableSO> iconElementsSoList;

    public GameStateManager gameStateManager;

    private void Start()
    {
        gameStateManager = GetComponent<GameStateManager>();
        gameStateManager.SwitchState(gameStateManager.BoardSetupState);
    }

    public void SetupBoard()
    {
        Init();
        FillElementData();
        InitializeElements();
        StartGameValidationProcess();
    }

    private void InitializeElements()
    {
        foreach (var iconElement in iconElementsList)
        {
            iconElement.InitializeIconElement();
        }
    }

    private void FillElementData()
    {
        GameBoardSetupManager gameBoardSetupManager = new GameBoardSetupManager(iconElementsList, iconElementsSoList);
        List<IconSwappable> generatedIconElementsList = gameBoardSetupManager.SetupGameBoardData();
        for (int i = 0; i < iconElementsList.Count; i++)
        {
            iconElementsList[i].SetupIconElement(generatedIconElementsList[i].IconIndex, generatedIconElementsList[i].UnselectedImage, generatedIconElementsList[i].SelectedImage);
        }
    }

    

    private void Init()
    {
        foreach (var iconElement in iconElementsList)
        {
            iconElement.InitIconElement();
        }
    }

    public void StartGameValidationProcess()
    {
        gameStateManager.SwitchState(gameStateManager.TransitionState);

        //Find Successful Icons
        SuccessValidationHandler successValidationHandler = new(GetIconElementsList());
        List<IconSwappable> successfulIcons = successValidationHandler.FindSuccessfulElements();

        //Patlayacak icon'lar var mý kontrol ediyoruz.
        if(successfulIcons.Count > 0)
        {
            //Successful olanlarý patlatýp yeni iconlar spawn ediyoruz
            GetComponent<IconRespawnHandler>().RespawnProcess(successfulIcons, OnRespawnCompleted);
        }
        else
        {
            ValidationCompleted();
        }
        
    }
    private void OnRespawnCompleted()
    {
        //Respawn Complete olunca tekrar patlayabilecek icon var mý kontrol ediyoruz ta ki patlayacak icon kalmayana kadar.
        StartGameValidationProcess();
        //Debug.LogWarning("OnRespawnCompleted");
    }

    private void ValidationCompleted()
    {
        Debug.LogWarning("Validation Completed");
        gameStateManager.SwitchState(gameStateManager.PlayerTurnState);
    }

    
    public List<IconSwappable> GetIconElementsList()
    {
        return iconElementsList;
    }

    public List<IconSwappableSO> GetIconElementsSoList()
    {
        return iconElementsSoList;
    }


}
