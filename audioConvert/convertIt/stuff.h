#ifndef STUFF__H
#define STUFF__H

#include<iostream>

//Jean Peña

void clearIt(); //creates 50 new lines. simulates a clear screen

int safeInt(); //for safe integer input
int digitsIn(int); //returns the number of digits in an integer

template<class T>void swap(T&, T&); //swap 2 values

std::string toUpper(std::string);
std::string toLower(std::string);

#endif
