#pragma once

#include <string>

class CAppUtil
{
public:
	virtual std::string GetName() = 0;
	virtual std::string MyAddString(std::string str1, std::string str2) = 0;
};