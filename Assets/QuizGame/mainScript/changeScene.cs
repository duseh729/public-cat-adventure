using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public static void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        // ���� ���� ���� �ʱ�ȭ�� ���� �ڵ�
        QuestionAndAnswerTextChanger.trigger = 0;
        NextBtnEvent.nextFlag = false;
    }
}