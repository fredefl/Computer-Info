#include <Windows.h>
#include <iostream>
#include <sstream>
#include "Helpers.h"
#include "GetMACAddress.h"
#include "ScreenInfo.h";

using namespace std;
#pragma comment(lib, "iphlpapi.lib")

int main(int argc, char *argv[])
{
	//cout << GetMACAddress();
	cout << GetScreenHeight();
	// Make the console stay
	char test;
	cin >> test;
	return 0;
}
