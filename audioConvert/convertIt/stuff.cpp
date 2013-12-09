#include "stdafx.h"

#include "stuff.h"
//Jean Peña

void clearIt(){std::cout<<std::string(50, '\n').c_str();} //print 50 lines. like a clear

int safeInt()//people like to enter nonsense
{
     int x;
     do
     {
         if(std::cin.fail())
         {
                       std::cin.clear();//clear cin's flags
                       //ignore any nonsense up to a new line
                       std::cin.ignore(INT_MAX, '\n');
         }
         std::cout<<"user: ";
         std::cin>>x;
     }while(std::cin.fail());//if the user enters a non integer, ask again
     return x;
}

int digitsIn(int x) //returns how many digits an int has
{
    if(x<10) return 1;
    else return 1+ digitsIn(x/10);
}

std::string toUpper(std::string s)
{
	for (int i = 0; i < s.length(); i++) s[i] = toupper(s[i]);
	return s;
}

std::string toLower(std::string s)
{
	for (int i = 0; i < s.length(); i++) s[i] = tolower(s[i]);
	return s;
}

std::string gimmeExt(std::string s)
{
	for (int i = s.length() - 1; i >= 0; i--)
	{
		if (s[i] == '.')
		{
			s = s.substr(i, s.length() - 1);
			break;
		}
		else if (s[i] == '\\') break;
	}
	if (s[0] != '.') s = "";
	return s;
}

std::string gimmePath(std::string s)
{
	for (int i = s.length() - 1; i >= 0; i--)
	{
		if (s[i] == '\\')
		{
			s = s.substr(0, i);
			break;
		}
	}
	if (s[s.length() - 1] != '\\') s = "";
	return s;
}

std::string gimmeFile(std::string s)
{
	for (int i = s.length() - 1; i >= 0; i--)
	{
		if (s[i] == '\\')
		{
			s = s.substr(i, s.length() - 1);
			break;
		}
	}
	return s;
}

template<class T>
void swap(T &a, T &b) //swaps the values of 2 variables
{
     T t = a;
     a=b;
     b=t;
}
