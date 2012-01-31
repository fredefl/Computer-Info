#include <Windows.h>
#include <iostream>
#include <sstream>
#include "Helpers.h"
//#include "GetMACAddress.h"
//#include "ScreenInfo.h"
//#include "IpAddress.h"
//#include "ComputerName.h"
//#include "TotalDiskSpace.h"

using namespace std;
#pragma comment(lib, "iphlpapi.lib")
#pragma comment(lib, "wsock32.lib")

int main()
{
	//cout << GetMACAddress();
	//cout << GetScreenHeight();
	//cout << GetIpAddress();
	//cout << GetComputerName();
	cout << GetUnixTimestamp();
	// Make the console stay
	char test;
	cin >> test;
	return 0;
}
