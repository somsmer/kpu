// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the EXERCISE1_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// EXERCISE1_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef EXERCISE1_EXPORTS
#define EXERCISE1_API __declspec(dllexport)
#else
#define EXERCISE1_API __declspec(dllimport)
#endif
#include <string>

// This class is exported from the exercise1.dll
class EXERCISE1_API exercise1 {
public:
	exercise1(void);
	static int addNumbers(int i, int j);
	static std::string addString(std::string i, std::string j);
	static char* addChar(char*i, char*j);
	// TODO: add your methods here.
};

EXERCISE1_API int return42(void);
