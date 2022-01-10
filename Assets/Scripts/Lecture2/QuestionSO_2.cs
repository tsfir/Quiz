using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO_2 : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] public string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    






}
