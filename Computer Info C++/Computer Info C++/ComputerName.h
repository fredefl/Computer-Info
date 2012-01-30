#include <iostream>
#include <windows.h>
#include <sstream>
using namespace std;

string GetComputerName (){
	char ComputerName[100];
	DWORD Length=100;
	GetComputerName(ComputerName, &Length);
	return ComputerName;
}