﻿
int firstNum = int.Parse(Console.ReadLine());
int secondNum=int.Parse(Console.ReadLine()); 
int thirdNum = int.Parse(Console.ReadLine());
int fourNum =int.Parse(Console.ReadLine());
int addOperator = firstNum + secondNum;
int divideOperator = addOperator / thirdNum;
int multiplyOperator = divideOperator * fourNum;

Console.WriteLine(multiplyOperator);