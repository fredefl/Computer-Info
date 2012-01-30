#include <Windows.h>
#include <iostream>
#include <sstream>
#include "Helpers.h"
//#include "GetMACAddress.h"
//#include "ScreenInfo.h";
#include "IpAddress.h";

using namespace std;
#pragma comment(lib, "iphlpapi.lib")
#pragma comment(lib, "wsock32.lib")

int main(int argc, char *argv[])
{
	//cout << GetMACAddress();
	//cout << GetScreenHeight();
	cout << GetIpAddress();
	// Make the console stay
	char test;
	cin >> test;
	return 0;
}
