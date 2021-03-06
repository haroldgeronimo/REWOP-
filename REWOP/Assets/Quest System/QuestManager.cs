﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour {
    public QuestObject[] quests;
    public bool[] questCompleted;
    private DialogueManager DM;
   public int activeQuest;

    // Use this for initialization
    void Start () {
        DM = FindObjectOfType<DialogueManager>();
        questCompleted = new bool[quests.Length];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowStartDialogue(Dialogue dialogue) {
        DM.StartDialogue(dialogue);
    }

    public void ShowEndDialogue(Dialogue dialogue)
    {
        DM.StartDialogue(dialogue);
    }


}
