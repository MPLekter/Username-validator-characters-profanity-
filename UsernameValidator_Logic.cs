using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UsernameValidator_Logic : MonoBehaviour
{

    public bool IsSuitable(string word)
    {

        foreach (string badWord in UsernameValidator_ProfanityList.profanityArray)
        {
            if (word.ToLower().Contains(badWord) == true)
            {
                Debug.Log("Profanity Detected - Username Denied");
                return false;

            }
        }
        char[] charWord = word.ToCharArray();
        char[] allowedLetters = UsernameValidator_AllowedLetters.allowedChars;
        foreach (char letter in charWord)
        {
            if (allowedLetters.Contains(letter) == false)
            {
                Debug.Log("Disallowed Letter Detected - Username Denied");
                return false;
            }

        }
        if (word.Contains(" ") == true)
        {
            Debug.Log("Whitespace Detected - Username Denied");
            return false;
        }
        else if (word.Length < 3 || word.Length > 10)
        {
            Debug.Log("Incorrect Length Detected - Username Denied");
            return false;
        }
        else { return true; }
    }
}
