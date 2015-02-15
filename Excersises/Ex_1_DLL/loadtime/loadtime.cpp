// loadtime.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include <iostream>
#include "exercise1.h"
using namespace std;

int main()
{
	int i = exercise1::addNumbers(5, 3);
	cout << i << endl;
	int j = return42();
	cout << j << endl;
	return 0;
}

//int _tmain(int argc, _TCHAR* argv[])
//{
	//return 0;
//}

