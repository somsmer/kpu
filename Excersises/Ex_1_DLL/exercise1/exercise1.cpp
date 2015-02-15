// exercise1.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "exercise1.h"

 //This is an example of an exported function.
EXERCISE1_API int return42(void)
{
	return 42;
}

int exercise1::addNumbers(int i, int j)
{
	return i + j;
}

std::string exercise1::addString(std::string i, std::string j)
{
	return i + j;
}

char* exercise1::addChar(char*i, char*j)
{
	char dest[30];
	strcpy_s(dest, i);
	strcat_s(dest, j);
	return dest;
}