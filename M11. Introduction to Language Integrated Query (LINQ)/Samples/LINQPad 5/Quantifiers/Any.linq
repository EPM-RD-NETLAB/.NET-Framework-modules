<Query Kind="Statements" />

string[] words = { "believe", "relief", "receipt", "field" }; 
words.Any(w => w.Contains("ei")).Dump("There is a word that contains in the list that contains 'ei':"); 