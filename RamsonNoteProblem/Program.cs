﻿using RamsonNoteProblem;

/*
Harold is a kidnapper who wrote a ransom note, but now he is worried it will 
be traced back to him through his handwriting. 
He found a magazine and wants to know if he can cut out whole words from it 
and use them to create an untraceable replica of his ransom note. 

The words in his note are case-sensitive and he must use only whole words 
available in the magazine. 

He cannot use substrings or concatenation to create the words he needs.

Given the words in the magazine and the words in the ransom note, 
print Yes if he can replicate his ransom note exactly using whole words 
from the magazine; otherwise, print No.
*/

Solution solution = new();
//Example 1
var magazine = new string[] {"attack", "at", "dawn"};
var note = new string[] { "Attack", "at", "dawn" };
var result = solution.CheckMagazineForWordsInNote(magazine, note);
Console.WriteLine(result);

//Example 2
magazine = ["give", "me", "one", "grand", "today", "night"];
note = ["give", "one", "grand", "today"];
result = solution.CheckMagazineForWordsInNote(magazine, note);
Console.WriteLine(result);

//Example 3
magazine = ["two", "times", "three", "is", "not", "four"];
note = [ "two", "times", "two", "is", "four"];
result = solution.CheckMagazineForWordsInNote(magazine, note);
Console.WriteLine(result);

